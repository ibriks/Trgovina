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
    public partial class DirektorForm : Form
    {
        public DirektorForm()
        {
            InitializeComponent();

            dataGridSize(dataGridView1);
            dataGridSize_racun(dataGridView2);
            dataGridSize(dataGridView3);
            dataGridSize2(dataGridView4);
            dataGridSize(dataGridView5);

            popunjavanje_combo();


            lock_ele();
            this.Resize += _Resize;
        }

        private void popunjavanje_combo()
        {
            // popunjavanje combobox-a
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\shop.mdf;Integrated Security=True");
            // upit u bazu za dobivanje svih kategorija
            SqlDataAdapter sda = new SqlDataAdapter("Select Distinct Kategorija from Artikl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            Dictionary<string, string> combo_values = new Dictionary<string, string>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; ++i)
                    combo_values.Add(i.ToString(), dt.Rows[i][0].ToString());
                comboBox1.DataSource = new BindingSource(combo_values, null);
                comboBox1.DisplayMember = "Value";
                comboBox1.ValueMember = "Key";
            }

        }

        private void lock_ele()
        {
            if (radioButton5.Checked == true)
            {
                comboBox1.Enabled = false;
                dataGridView5.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = true;
                dataGridView5.Enabled = false;
            }
        }

        protected void _Resize(object sender, System.EventArgs e)
        {
            dataGridSize(dataGridView1);
            dataGridSize_racun(dataGridView2);
            dataGridSize(dataGridView3);
            dataGridSize2(dataGridView4);
            dataGridSize(dataGridView5);
        }

        private void dataGridSize(DataGridView dgv)
        {
            int x = dgv.Size.Width / 15 == 0 ? 1 : dgv.Size.Width / 15;
            dgv.Columns[0].Width = x;
            dgv.Columns[1].Width = x * 5;
            dgv.Columns[2].Width = x * 2;
            dgv.Columns[3].Width = x * 2;
            dgv.Columns[4].Width = x * 3;
            dgv.Columns[5].Width = x;
            // dgv.Columns[6].Width = x;
        }

        private void dataGridSize2(DataGridView dgv)
        {
            int x = dgv.Size.Width / 17 == 0 ? 1 : dgv.Size.Width / 17;
            dgv.Columns[0].Width = x;
            dgv.Columns[1].Width = x * 3;
            dgv.Columns[2].Width = x * 2;
            dgv.Columns[3].Width = x * 2;
            dgv.Columns[4].Width = x * 2;
            dgv.Columns[5].Width = x;
            dgv.Columns[6].Width = x * 2;
            dgv.Columns[7].Width = x * 2;
        }

        private void dataGridSize_racun(DataGridView dgv)
        {
            int x = dgv.Size.Width / 8 == 0 ? 1 : dgv.Size.Width / 8;
            dgv.Columns[0].Width = x;
            dgv.Columns[1].Width = x;
            dgv.Columns[2].Width = x;
            dgv.Columns[3].Width = x;
            dgv.Columns[4].Width = x;
            dgv.Columns[5].Width = x;
            // dgv.Columns[6].Width = x;
        }

        private void DirektorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataSet3.Artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter1.Fill(this.shopDataSet3.Artikl);
            // TODO: This line of code loads data into the 'shopDataSet2.Racun' table. You can move, or remove it, as needed.
            this.racunTableAdapter.Fill(this.shopDataSet2.Racun);
            this.artiklTableAdapter.Fill(this.shopDataSet.Artikl);

        }

        private void tabControl1_SelectedIndexChanged(Object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            TextBox1.Clear();
            this.artiklTableAdapter.Fill(this.shopDataSet.Artikl);
            this.artiklTableAdapter1.Fill(this.shopDataSet3.Artikl);
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

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new row.
            shopDataSet3.ArtiklRow newArtiklRow;
            newArtiklRow = shopDataSet3.Artikl.NewArtiklRow();

            // Save the new row to the database
            this.artiklTableAdapter1.Update(this.shopDataSet3.Artikl);

            // redefiniranje comboboxa
            popunjavanje_combo();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            dataGridView5.Enabled = false;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            dataGridView5.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // dohvacanje iznosa popusta
            int iznos=Convert.ToInt32(numericUpDown1.Value);
            // provjera dali je artikl ili kategorija
            int kategorija = radioButton5.Checked ? 0 : 1;
            // dohvacanje koda ili kategorije
            string kod_kat;
            if(kategorija == 0)
            {
                int selectedCell = dataGridView1.CurrentCell.RowIndex;
                kod_kat = dataGridView1.Rows[selectedCell].Cells[2].Value.ToString();
            }
            else
            {
                kod_kat = ((KeyValuePair<string, string>)comboBox1.SelectedItem).Value;
            }

            // dohvacanje datuma
            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            // dodavanje u bazu
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\shop.mdf;Integrated Security=True");
            string stmt = "INSERT INTO dbo.Popust(Kod_Kat, Kategorija, Iznos, Datum_isteka) VALUES(@Kod_Kat, @Kategorija, @Iznos, @Datum_isteka)";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(stmt, con);
            cmd.Parameters.Add("@Kod_Kat", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Kategorija", SqlDbType.Int);
            cmd.Parameters.Add("@Iznos", SqlDbType.Int);
            cmd.Parameters.Add("@Datum_isteka", SqlDbType.DateTime);

            cmd.Parameters["@Kod_Kat"].Value = kod_kat;
            cmd.Parameters["@Kategorija"].Value = kategorija;
            cmd.Parameters["@Iznos"].Value = iznos;
            cmd.Parameters["@Datum_isteka"].Value = theDate;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
