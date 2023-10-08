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

namespace club_sport_app
{
    public partial class Reglement : MetroForm
    { SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\BOUTAIBNETFRAM\club_sport_app\club_sport_app\Database1.mdf;Integrated Security = True");
        public Reglement()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Restant = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.chercher = new MetroFramework.Controls.MetroTextBox();
            this.cherche = new MetroFramework.Controls.MetroButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TEST = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(169, 48);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(160, 12);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(173, 55);
            this.htmlLabel1.TabIndex = 1;
            this.htmlLabel1.Text = "Reglement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "A PAYER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DH";
            // 
            // Restant
            // 
            this.Restant.AutoSize = true;
            this.Restant.Location = new System.Drawing.Point(100, 329);
            this.Restant.Name = "Restant";
            this.Restant.Size = new System.Drawing.Size(44, 13);
            this.Restant.TabIndex = 7;
            this.Restant.Text = "Restant";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "DH";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(198, 383);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(115, 31);
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Text = "REGLER";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(319, 383);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(117, 31);
            this.metroButton2.TabIndex = 11;
            this.metroButton2.Text = "ANNULER";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // chercher
            // 
            // 
            // 
            // 
            this.chercher.CustomButton.Image = null;
            this.chercher.CustomButton.Location = new System.Drawing.Point(210, 2);
            this.chercher.CustomButton.Name = "";
            this.chercher.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.chercher.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.chercher.CustomButton.TabIndex = 1;
            this.chercher.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.chercher.CustomButton.UseSelectable = true;
            this.chercher.CustomButton.Visible = false;
            this.chercher.Lines = new string[0];
            this.chercher.Location = new System.Drawing.Point(103, 198);
            this.chercher.MaxLength = 32767;
            this.chercher.Name = "chercher";
            this.chercher.PasswordChar = '\0';
            this.chercher.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.chercher.SelectedText = "";
            this.chercher.SelectionLength = 0;
            this.chercher.SelectionStart = 0;
            this.chercher.ShortcutsEnabled = true;
            this.chercher.Size = new System.Drawing.Size(250, 42);
            this.chercher.TabIndex = 12;
            this.chercher.UseSelectable = true;
            this.chercher.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.chercher.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cherche
            // 
            this.cherche.Location = new System.Drawing.Point(75, 383);
            this.cherche.Name = "cherche";
            this.cherche.Size = new System.Drawing.Size(117, 31);
            this.cherche.TabIndex = 13;
            this.cherche.Text = "CHERCHER";
            this.cherche.UseSelectable = true;
            this.cherche.Click += new System.EventHandler(this.cherche_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Location = new System.Drawing.Point(290, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 13);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(290, 326);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(34, 13);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox3.Location = new System.Drawing.Point(210, 169);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(60, 13);
            this.textBox3.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(186, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // TEST
            // 
            // 
            // 
            // 
            this.TEST.CustomButton.Image = null;
            this.TEST.CustomButton.Location = new System.Drawing.Point(210, 2);
            this.TEST.CustomButton.Name = "";
            this.TEST.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.TEST.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TEST.CustomButton.TabIndex = 1;
            this.TEST.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TEST.CustomButton.UseSelectable = true;
            this.TEST.CustomButton.Visible = false;
            this.TEST.Lines = new string[0];
            this.TEST.Location = new System.Drawing.Point(103, 278);
            this.TEST.MaxLength = 32767;
            this.TEST.Name = "TEST";
            this.TEST.PasswordChar = '\0';
            this.TEST.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TEST.SelectedText = "";
            this.TEST.SelectionLength = 0;
            this.TEST.SelectionStart = 0;
            this.TEST.ShortcutsEnabled = true;
            this.TEST.Size = new System.Drawing.Size(250, 42);
            this.TEST.TabIndex = 18;
            this.TEST.UseSelectable = true;
            this.TEST.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TEST.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Reglement
            // 
            this.ClientSize = new System.Drawing.Size(459, 425);
            this.Controls.Add(this.TEST);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cherche);
            this.Controls.Add(this.chercher);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Restant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.htmlLabel1);
            this.Name = "Reglement";
            this.TransparencyKey = System.Drawing.Color.Navy;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
           Register register = new Register();
            register.Show();

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            FormMembers formMembers = new FormMembers();
            formMembers.Show();
        }

        private void cherche_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT a.Nom, a.Prenom, sp.nom_Sport, sp.date_Debut, sp.date_Fin, sp.Payer, sp.Restant, ph.PhotoData FROM [dbo].[Adherents] a INNER JOIN [dbo].[SportsPratiques] sp ON a.Id = sp.AdherentID LEFT JOIN [dbo].[Photos] ph ON ph.AdherentId = a.Id WHERE sp.AdherentID = '" + chercher.Text + "'";
            cmd.ExecuteNonQuery();

           

            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection);
            dataadp.Fill(dta);
            object result = cmd.ExecuteScalar();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox3.Text = reader.GetString(0);
                textBox2.Text = reader.GetDecimal(5).ToString();
                textBox1.Text = reader.GetDecimal(6).ToString();
                byte[] imageData = (byte[])dta.Rows[0]["PhotoData"]; // retrieve the photo data from the DataTable
                MemoryStream ms = new MemoryStream(imageData); // create a MemoryStream from the photo data
                pictureBox2.Image = Image.FromStream(ms); // set the Image property of the PictureBox to the photo
                

            }
            reader.Close();
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void metroButton1_Click(object sender, EventArgs e)
        {
            

            decimal val1, val2, result;
            if (decimal.TryParse(TEST.Text, out val1) && decimal.TryParse(textBox1.Text, out val2))
            {
                connection.Open();
                result = val1 - val2;
                TEST.Text = result.ToString();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE SportsPratiques SET Payer = @payer, Restant = @restant WHERE AdherentID = @adherentID";
                cmd.Parameters.AddWithValue("@payer", TEST.Text);
                cmd.Parameters.AddWithValue("@restant", textBox1.Text);
                cmd.Parameters.AddWithValue("@adherentID", chercher.Text);


                cmd.ExecuteNonQuery();
                // Assuming the connection to the database is already establish
                // Add parameters to the command

                MessageBox.Show("Payer updated successfully!");
                connection.Close();
            }
            else
            {
                MessageBox.Show("Veuillez entrer des valeurs numériques valides dans les deux premières zones de texte.");
            }
          

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

    
}
