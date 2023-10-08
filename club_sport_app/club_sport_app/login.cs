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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace club_sport_app
{
    public partial class login : MetroForm
    {

        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\BOUTAIBNETFRAM\club_sport_app\club_sport_app\Database1.mdf;Integrated Security = True");
        int i;

       

        public login()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton2
            // 
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton2.Location = new System.Drawing.Point(166, 304);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(250, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.TabIndex = 18;
            this.metroButton2.Text = "Register";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(163, 241);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Password oublié ?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::club_sport_app.Properties.Resources.user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(204, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(166, 274);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(250, 24);
            this.metroButton1.TabIndex = 20;
            this.metroButton1.Text = "login";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(166, 167);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(250, 20);
            this.Username.TabIndex = 21;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(166, 212);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(250, 20);
            this.Password.TabIndex = 22;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(166, 145);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Username";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(164, 190);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Password";
            // 
            // login
            // 
            this.ClientSize = new System.Drawing.Size(579, 381);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
        public class Session
        {
            public static string Username { get; set; }
            public static int UserId { get; set; }
            public static Image ProfilePicture { get; set; }
        }
        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e, string v)
        {
        }
    

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           resetpassword reset = new resetpassword();
            reset.Show();
            this.Hide();
        }
       

        private void Username_OnTextChange(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
            i = 0;
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Users where username='" + Username.Text + "' and password ='" + Password.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection);
            dataadp.Fill(dta);
            i = Convert.ToInt32(dta.Rows.Count.ToString());

            if (i == 0)
            {

                MessageBox.Show("Wrong username or password.");

            }
            else


            { 
                
                this.Hide();
                Form1 fm = new Form1();
                fm.Show();

            }
            connection.Close();


        }
    }
 }
    

