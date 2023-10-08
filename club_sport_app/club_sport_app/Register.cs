using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace club_sport_app
{
    public partial class Register : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\BOUTAIBNETFRAM\club_sport_app\club_sport_app\Database1.mdf;Integrated Security = True");


        public Register()
        {
            InitializeComponent();
        }



        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
        }



        private void metroButton1_Click(object sender, EventArgs e)

        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Users] (username,password,email) values ('" + Usernamee.Text + "','" + Passwordd.Text + "','" + Emaill.Text + "')";
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("ok");
            if (MessageBox.Show("ok") == DialogResult.OK)
            {
                Usernamee.Text = "";
                Emaill.Text = "";
                Passwordd.Text = "";
                login ogg = new login();
                ogg.Show();
                this.Hide();
            }


        }

        private void Usernamee_OnTextChange(object sender, EventArgs e)
        {

        }

        private void Passwordd_OnTextChange(object sender, EventArgs e)
        {

        }

        private void Emaill_OnTextChange(object sender, EventArgs e)
        {

        }

        private void Image_Click(object sender, EventArgs e)
        {
          
                            
                        
            
         }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
  }

