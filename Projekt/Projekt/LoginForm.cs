using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projekt
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            putInMiddle();
            this.Resize += _Resize;
        }

        protected void _Resize(object sender, System.EventArgs e)
        {
            putInMiddle();
        }

        private void putInMiddle()
        {
            int centarX, centarY;
            centarX = ClientRectangle.Width / 2;
            centarY = ClientRectangle.Height / 2;
            label1.Location = new Point(centarX - label1.Size.Width -10, centarY - 50 );
            label2.Location = new Point(centarX - label2.Size.Width - 10,centarY -Pass_Textbox.Size.Height/2 );
            User_Textbox.Location = new Point(centarX , centarY - 50);
            Pass_Textbox.Location = new Point(centarX ,centarY - Pass_Textbox.Size.Height / 2);
            Login_Button.Location = new Point(centarX -Login_Button.Size.Width/2,centarY + 50);
        }

        private void Pass_Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Login_Button_Click(sender, e);
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\shop.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Zaposlenik_ID,Direktor from Zaposlenici where Username='" + User_Textbox.Text.ToString() + "' and Password='" + Pass_Textbox.Text.ToString() + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][1].ToString() == "0")
                {
                    TrgovacForm TrgForm = new TrgovacForm(Convert.ToInt32(dt.Rows[0][0]));
                    TrgForm.ShowDialog();
                }
                else if (dt.Rows[0][1].ToString() == "1")
                {
                    DirektorForm DirForm = new DirektorForm();
                    DirForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }

            Pass_Textbox.Clear();
            User_Textbox.Clear();
        }
    }
}
