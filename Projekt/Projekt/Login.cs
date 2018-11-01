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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LgnButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Shop.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Category from Employee where Username='"+textBox1.Text.ToString()+"' and Password='"+textBox2.Text.ToString()+"' ",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][0].ToString() == "1")
                {
                    TrgovacForm TrgForm = new TrgovacForm();
                    TrgForm.ShowDialog();
                }
                else if (dt.Rows[0][0].ToString() == "2")
                {
                    DirektorForm DirForm = new DirektorForm();
                    DirForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }



        }
    }
}
