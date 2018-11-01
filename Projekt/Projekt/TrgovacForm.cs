using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class TrgovacForm : Form
    {
        private int id;
        private double ukupno;

        public TrgovacForm(int _id)
        {
            InitializeComponent();
            id = _id;

            ukupno = 0;
            label4.Text = ukupno.ToString();
            comboBox1.SelectedIndex = 0;
            SizeLastColumn(listView1);
            dataGridSize(dataGridView3);
            // radioButton4.Checked = true;
            this.Resize += _Resize;
        }

        protected void _Resize(object sender, System.EventArgs e)
        {
            SizeLastColumn(listView1);
            dataGridSize(dataGridView3);
        }



        private void SizeLastColumn(ListView lv)
        {
            int x = lv.Width / 6 == 0 ? 1 : lv.Width / 6;
            lv.Columns[0].Width = x ;
            lv.Columns[1].Width = x ;
            lv.Columns[2].Width = x ;
            lv.Columns[3].Width = x ;
            lv.Columns[4].Width = x ;
            lv.Columns[5].Width = x ;
        }

        private void dataGridSize(DataGridView dgv)
        {
            int x = dgv.Size.Width / 15 == 0 ? 1 : dgv.Size.Width / 15;
            dgv.Columns[0].Width = x;
            dgv.Columns[1].Width = x*5;
            dgv.Columns[2].Width = x*2;
            dgv.Columns[3].Width = x*2;
            dgv.Columns[4].Width = x*3;
            dgv.Columns[5].Width = x;
            // dgv.Columns[6].Width = x;
        }

        private void TrgovacForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataSet.Artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter.Fill(this.shopDataSet.Artikl);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.artiklTableAdapter.FillBy1(this.shopDataSet.Artikl, KodTextBox.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // koji je red selektiran
            int selectedCell = dataGridView1.CurrentCell.RowIndex;
            // vraca id artikal 
            int artikl_id = Convert.ToInt32(dataGridView1.Rows[selectedCell].Cells[0].Value);

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\shop.mdf;Integrated Security=True");
            // upit u bazu za dobivanje informacija o artiklu
            SqlDataAdapter sda = new SqlDataAdapter("Select Naziv,Cijena,Kategorija,Porez,Kod,Količina from Artikl where Artikl_Id=" + artikl_id.ToString() + " ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            // provjera dali ima dovoljno trazenog artikla u bazi
            if (Convert.ToInt32(numericUpDown1.Value) <= Convert.ToInt32(dt.Rows[0][5]))
            {
                // provjera dali ima popust na sebi preko koda
                SqlDataAdapter sda_popust1 = new SqlDataAdapter("Select Iznos,Datum_isteka from Popust where Kod_Kat='" + dt.Rows[0][4] + "' ", con);
                DataTable dt_popust1 = new DataTable();
                sda_popust1.Fill(dt_popust1);

                // provjera dali ima popust na sebi preko kategorije
                SqlDataAdapter sda_popust2 = new SqlDataAdapter("Select Iznos,Datum_isteka from Popust where Kod_Kat='" + dt.Rows[0][2] + "' ", con);
                DataTable dt_popust2 = new DataTable();
                sda_popust2.Fill(dt_popust2);

                // izracunavanje popusta
                int popust = 0;
                if (dt_popust1.Rows.Count > 0)
                    for(int i = 0; i < dt_popust1.Rows.Count; ++i)
                        if (Convert.ToDateTime(dt_popust1.Rows[i][1]) < DateTime.Now)
                            popust = popust + Convert.ToInt32(dt_popust1.Rows[i][0]);
                if (dt_popust2.Rows.Count > 0)
                    for (int i = 0; i < dt_popust2.Rows.Count; ++i)
                        if (Convert.ToDateTime(dt_popust2.Rows[i][1]) < DateTime.Now)
                            popust = popust + Convert.ToInt32(dt_popust2.Rows[i][0]);

                // izracunavanje cijene
                double cijena = Convert.ToInt32(dt.Rows[0][1]);
                cijena = cijena - cijena * popust / 100 + cijena * Convert.ToInt32(dt.Rows[0][3]) / 100;
                cijena = cijena * Convert.ToDouble(numericUpDown1.Value);

                // dodavanje artikla u ListView
                string[] arr = new string[6];
                ListViewItem lvi;
                arr[0] = dt.Rows[0][0].ToString(); // naziv artikla
                arr[1] = dt.Rows[0][4].ToString(); // kod artikla
                arr[2] = popust.ToString(); // ukupni popust 
                arr[3] = dt.Rows[0][3].ToString(); // porez
                arr[4] = numericUpDown1.Value.ToString(); // kolicina
                arr[5] = cijena.ToString(); // cijena
                lvi = new ListViewItem(arr);
                listView1.Items.Add(lvi);

                // oduzimannje artikla iz baze 
                con.Open();
                using (SqlCommand cmd =
                    new SqlCommand("UPDATE Artikl SET Količina=@Količina WHERE Artikl_Id=@Artikl_Id", con))
                {
                    int nova_količina = Convert.ToInt32(dt.Rows[0][5]) - Convert.ToInt32(numericUpDown1.Value);
                    cmd.Parameters.AddWithValue("@Artikl_Id", artikl_id);
                    // cmd.parameter.add(@, sqlDbtype.TYPE).value = artikl_id;
                    cmd.Parameters.AddWithValue("@Količina", nova_količina);
                    int rows = cmd.ExecuteNonQuery();
                }
                con.Close();

                // dodavanje za cijelu vrijednost racuna
                ukupno = ukupno + cijena;
                label4.Text = ukupno.ToString();
            }
            else
            {
                MessageBox.Show("Nedovoljno proizvoda!");
            }
            // postavaljanje numericupdown na pocetnu vrijednost
            numericUpDown1.Value = 1;

            // praznjenje textbox-a za kod 
            KodTextBox.Clear();
        }

        private void izdajRacun_Click(object sender, EventArgs e)
        {
            string nacin_placanja = comboBox1.Text;

            if (ukupno != 0)
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\shop.mdf;Integrated Security=True");
                // upit u bazu za dobivanje maximalnog broja racuna
                SqlDataAdapter sda = new SqlDataAdapter("Select MAX(Broj_Racuna) from Racun", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // odredivanje maximalnog broja racuna
                int max;
                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                    max = Convert.ToInt32(dt.Rows[0][0]);
                else
                    max = 1;
                max = max + 1;

                // prolazak kroz sve artikle u listView-u te dodavanje njiih u tablicu racuni
                foreach (ListViewItem lvi in listView1.Items)
                {
                    // MessageBox.Show(lvi.SubItems[0].Text);
                    string stmt = "INSERT INTO dbo.Racun(Broj_Racuna, Zaposlenik_Id, Artikl_Id, Popust, Nacin_Placanja, Količina) VALUES(@BrojRacuna, @ZaposlenikId, @ArtiklId, @Popust_ , @NacinPlacanja, @Količina)";
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(stmt, con);
                    cmd.Parameters.Add("@BrojRacuna", SqlDbType.Int);
                    cmd.Parameters.Add("@ZaposlenikId", SqlDbType.Int);
                    cmd.Parameters.Add("@ArtiklId", SqlDbType.Int);
                    cmd.Parameters.Add("@Popust_", SqlDbType.Float);
                    cmd.Parameters.Add("@NacinPlacanja", SqlDbType.VarChar, 50);
                    cmd.Parameters.Add("@Količina", SqlDbType.Int);

                    SqlDataAdapter sda_id = new SqlDataAdapter("Select Artikl_Id from Artikl where Kod='" + lvi.SubItems[1].Text + "' ", con);
                    DataTable dt_id = new DataTable();
                    sda_id.Fill(dt_id);

                    cmd.Parameters["@BrojRacuna"].Value = max;
                    cmd.Parameters["@ZaposlenikId"].Value = id;
                    if (dt_id.Rows.Count > 0)
                        cmd.Parameters["@ArtiklId"].Value = dt_id.Rows[0][0];
                    cmd.Parameters["@Popust_"].Value = Convert.ToInt32(lvi.SubItems[2].Text);
                    cmd.Parameters["@NacinPlacanja"].Value = nacin_placanja;
                    cmd.Parameters["@Količina"].Value = Convert.ToInt32(lvi.SubItems[4].Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                // brisanje elemenata iz litView-a
                listView1.Items.Clear();

                // resetiranje koliko ima na racunu
                ukupno = 0;
                label4.Text = ukupno.ToString();

                /*  Provjera: */
                /*
                SqlDataAdapter sda_ = new SqlDataAdapter("Select * from Racun", con);
                DataTable dt_ = new DataTable();
                sda_.Fill(dt_);
                if (dt_.Rows.Count > 0)
                    for (int i = 0; i < dt_.Rows.Count; ++i)
                        MessageBox.Show(dt_.Rows[i][0].ToString() + "\n" + dt_.Rows[i][1].ToString() + "\n" + dt_.Rows[i][2].ToString()
                            + "\n" + dt_.Rows[i][3].ToString() + "\n" + dt_.Rows[i][4].ToString() + "\n" + dt_.Rows[i][5].ToString());
                */
            }
            else
                MessageBox.Show("Unesite proizvode na račun!");
            
        }

        private void tabControl1_SelectedIndexChanged(Object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            KodTextBox.Clear();
            TextBox1.Clear();
            this.artiklTableAdapter.Fill(this.shopDataSet.Artikl);
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                this.artiklTableAdapter.FillBy2(this.shopDataSet.Artikl, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DateTime.Today.AddDays(7), typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                this.artiklTableAdapter.FillBy3(this.shopDataSet.Artikl);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    this.artiklTableAdapter.FillBy1(this.shopDataSet.Artikl, TextBox1.Text + "%");
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }

            if (radioButton2.Checked == true)
            {
                try
                {
                    this.artiklTableAdapter.FillBy(this.shopDataSet.Artikl, TextBox1.Text + "%", "% " + TextBox1.Text + "%");
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }
    }
}