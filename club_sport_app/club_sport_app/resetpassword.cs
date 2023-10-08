using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;

namespace club_sport_app
{
    public partial class resetpassword : MetroForm
    {
        public resetpassword()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resetpassword));
            this.Email = new Bunifu.Framework.UI.BunifuTextbox();
            this.Password1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.Password2 = new Bunifu.Framework.UI.BunifuTextbox();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.Silver;
            this.Email.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Email.BackgroundImage")));
            this.Email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Email.ForeColor = System.Drawing.Color.SeaGreen;
            this.Email.Icon = ((System.Drawing.Image)(resources.GetObject("Email.Icon")));
            this.Email.Location = new System.Drawing.Point(166, 110);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(250, 42);
            this.Email.TabIndex = 15;
            this.Email.text = "user@gmail.com";
            // 
            // Password1
            // 
            this.Password1.BackColor = System.Drawing.Color.Silver;
            this.Password1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Password1.BackgroundImage")));
            this.Password1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Password1.ForeColor = System.Drawing.Color.SeaGreen;
            this.Password1.Icon = ((System.Drawing.Image)(resources.GetObject("Password1.Icon")));
            this.Password1.Location = new System.Drawing.Point(166, 167);
            this.Password1.Name = "Password1";
            this.Password1.Size = new System.Drawing.Size(250, 42);
            this.Password1.TabIndex = 14;
            this.Password1.text = "Password new";
            this.Password1.OnTextChange += new System.EventHandler(this.Password1_OnTextChange);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.White;
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(166, 288);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(250, 32);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 17;
            this.metroButton1.Text = "Confirmer";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton2.Location = new System.Drawing.Point(166, 326);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(250, 32);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.TabIndex = 18;
            this.metroButton2.Text = "login";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(250, 48);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(155, 24);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(277, 58);
            this.htmlLabel1.TabIndex = 19;
            this.htmlLabel1.Text = "Reset Password";
            this.htmlLabel1.Click += new System.EventHandler(this.htmlLabel1_Click);
            // 
            // Password2
            // 
            this.Password2.BackColor = System.Drawing.Color.Silver;
            this.Password2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Password2.BackgroundImage")));
            this.Password2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Password2.ForeColor = System.Drawing.Color.SeaGreen;
            this.Password2.Icon = ((System.Drawing.Image)(resources.GetObject("Password2.Icon")));
            this.Password2.Location = new System.Drawing.Point(166, 226);
            this.Password2.Name = "Password2";
            this.Password2.Size = new System.Drawing.Size(250, 42);
            this.Password2.TabIndex = 20;
            this.Password2.text = "Password new";
            // 
            // resetpassword
            // 
            this.ClientSize = new System.Drawing.Size(579, 381);
            this.Controls.Add(this.Password2);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Password1);
            this.Name = "resetpassword";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();

            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Password1_OnTextChange(object sender, EventArgs e)
        {

        }
    }
    
}
