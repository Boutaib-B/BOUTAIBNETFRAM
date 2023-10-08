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
using Bunifu.Framework.UI;
using club_sport_app.Database1DataSetTableAdapters;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace club_sport_app
{

    public partial class Payment : MetroForm
        
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\BOUTAIBNETFRAM\club_sport_app\club_sport_app\Database1.mdf;Integrated Security = True");

        private object metroGrid;

        public Payment()
        {
            InitializeComponent();
        }

        public Payment(object metroGrid, SelectedRow selectedRow, Panel panel2, PictureBox pictureBox1, Label label2, Label label1, BunifuTileButton bunifuTileButton1, BunifuTileButton bunifuTileButton2, BunifuTileButton bunifuTileButton3, BunifuTileButton bunifuTileButton4, Panel panel1, MetroGrid metroGrid1, Database1DataSet database1DataSet, BindingSource adherentsBindingSource, IContainer components, AdherentsTableAdapter adherentsTableAdapter, DataGridViewTextBoxColumn idDataGridViewTextBoxColumn, DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn, DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn, DataGridViewTextBoxColumn cNEDataGridViewTextBoxColumn, DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn, DataGridViewImageColumn adresseDataGridViewImageColumn, DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn, DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn, DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn, BunifuTextbox cherche)
        {
            this.metroGrid = metroGrid;
            this.selectedRow = selectedRow;
            this.panel2 = panel2;
            this.pictureBox1 = pictureBox1;
            this.label2 = label2;
            this.label1 = label1;
            this.bunifuTileButton1 = bunifuTileButton1;
            this.bunifuTileButton2 = bunifuTileButton2;
            this.bunifuTileButton3 = bunifuTileButton3;
            this.bunifuTileButton4 = bunifuTileButton4;
            this.panel1 = panel1;
           
            this.database1DataSet = database1DataSet;
            this.adherentsBindingSource = adherentsBindingSource;
            this.components = components;
            this.adherentsTableAdapter = adherentsTableAdapter;
       
            
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.adherentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new club_sport_app.Database1DataSet();
            this.adherentsTableAdapter = new club_sport_app.Database1DataSetTableAdapters.AdherentsTableAdapter();
            this.cherche1 = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.com = new MetroFramework.Controls.MetroComboBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adherentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(1, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 69);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(114, 51);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(82, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "User";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(113, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(82, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::club_sport_app.Properties.Resources.user__2_;
            this.pictureBox1.InitialImage = global::club_sport_app.Properties.Resources.user__2_;
            this.pictureBox1.Location = new System.Drawing.Point(43, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.bunifuTileButton4);
            this.panel1.Controls.Add(this.bunifuTileButton3);
            this.panel1.Controls.Add(this.bunifuTileButton2);
            this.panel1.Controls.Add(this.bunifuTileButton1);
            this.panel1.Location = new System.Drawing.Point(1, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 733);
            this.panel1.TabIndex = 0;
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.bunifuTileButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTileButton4.color = System.Drawing.Color.DarkTurquoise;
            this.bunifuTileButton4.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton4.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton4.Image = global::club_sport_app.Properties.Resources.home;
            this.bunifuTileButton4.ImagePosition = 20;
            this.bunifuTileButton4.ImageZoom = 20;
            this.bunifuTileButton4.LabelPosition = 41;
            this.bunifuTileButton4.LabelText = "Acceuil";
            this.bunifuTileButton4.Location = new System.Drawing.Point(25, 115);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(128, 90);
            this.bunifuTileButton4.TabIndex = 4;
            this.bunifuTileButton4.Click += new System.EventHandler(this.bunifuTileButton4_Click);
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.bunifuTileButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTileButton3.color = System.Drawing.Color.DarkTurquoise;
            this.bunifuTileButton3.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = global::club_sport_app.Properties.Resources.euro;
            this.bunifuTileButton3.ImagePosition = 20;
            this.bunifuTileButton3.ImageZoom = 20;
            this.bunifuTileButton3.LabelPosition = 41;
            this.bunifuTileButton3.LabelText = "Regler";
            this.bunifuTileButton3.Location = new System.Drawing.Point(25, 457);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(128, 90);
            this.bunifuTileButton3.TabIndex = 3;
            this.bunifuTileButton3.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.bunifuTileButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTileButton2.color = System.Drawing.Color.DarkTurquoise;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = global::club_sport_app.Properties.Resources.paid_search;
            this.bunifuTileButton2.ImagePosition = 20;
            this.bunifuTileButton2.ImageZoom = 20;
            this.bunifuTileButton2.LabelPosition = 41;
            this.bunifuTileButton2.LabelText = "Payés";
            this.bunifuTileButton2.Location = new System.Drawing.Point(25, 342);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(128, 90);
            this.bunifuTileButton2.TabIndex = 2;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.bunifuTileButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTileButton1.color = System.Drawing.Color.DarkTurquoise;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = global::club_sport_app.Properties.Resources.history;
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 20;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Historique";
            this.bunifuTileButton1.Location = new System.Drawing.Point(25, 228);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(128, 90);
            this.bunifuTileButton1.TabIndex = 1;
            // 
            // adherentsBindingSource
            // 
            this.adherentsBindingSource.DataMember = "Adherents";
            this.adherentsBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adherentsTableAdapter
            // 
            this.adherentsTableAdapter.ClearBeforeFill = true;
            // 
            // cherche1
            // 
            // 
            // 
            // 
            this.cherche1.CustomButton.Image = null;
            this.cherche1.CustomButton.Location = new System.Drawing.Point(402, 2);
            this.cherche1.CustomButton.Name = "";
            this.cherche1.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.cherche1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cherche1.CustomButton.TabIndex = 1;
            this.cherche1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cherche1.CustomButton.UseSelectable = true;
            this.cherche1.CustomButton.Visible = false;
            this.cherche1.Lines = new string[0];
            this.cherche1.Location = new System.Drawing.Point(190, 28);
            this.cherche1.MaxLength = 32767;
            this.cherche1.Name = "cherche1";
            this.cherche1.PasswordChar = '\0';
            this.cherche1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cherche1.SelectedText = "";
            this.cherche1.SelectionLength = 0;
            this.cherche1.SelectionStart = 0;
            this.cherche1.ShortcutsEnabled = true;
            this.cherche1.Size = new System.Drawing.Size(442, 42);
            this.cherche1.TabIndex = 6;
            this.cherche1.UseSelectable = true;
            this.cherche1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cherche1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::club_sport_app.Properties.Resources.search1;
            this.pictureBox2.Location = new System.Drawing.Point(638, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // com
            // 
            this.com.FormattingEnabled = true;
            this.com.ItemHeight = 23;
            this.com.Items.AddRange(new object[] {
            "PAYES",
            "IMPAYES"});
            this.com.Location = new System.Drawing.Point(190, 76);
            this.com.Name = "com";
            this.com.Size = new System.Drawing.Size(207, 29);
            this.com.TabIndex = 8;
            this.com.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(558, 692);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(102, 23);
            this.metroButton2.TabIndex = 10;
            this.metroButton2.Text = "Annuler";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(425, 76);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(207, 29);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "ok";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(195, 150);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(477, 300);
            this.metroGrid1.TabIndex = 12;
            // 
            // Payment
            // 
            this.ClientSize = new System.Drawing.Size(695, 738);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.com);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cherche1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adherentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private SelectedRow selectedRow = new SelectedRow();
        private void Payment_Load(object sender, EventArgs e)
        {
            Display_data();



        }
        private void display_data()
        {
            

        }
        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                
         }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {

        Form1  fromm = new Form1();
            fromm.Show();
            this.Hide();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            Reglement reglement = new Reglement();
            reglement.Show();
            this.Hide();
        }


        private void Display_data()

        {
           
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT a.Nom, a.Prenom, a.Genre, a.Email, a.Telephone, sp.nom_Sport, sp.date_Debut, sp.date_Fin, sp.Payer, sp.Restant, s.prix\r\nFROM [dbo].[Adherents] a\r\nINNER JOIN [dbo].[SportsPratiques] sp\r\nON a.Id = sp.AdherentID\r\nINNER JOIN [dbo].[Sport] s\r\nON sp.nom_Sport = s.lib_sport  ";
                cmd.ExecuteNonQuery();
                connection.Close();

                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd.CommandText, connection);
                dataAdapter.Fill(dataTable);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                string chercher = cherche1.Text;
                // Appliquer un filtre à la source de données en fonction de la chaîne de recherche
                bindingSource.Filter = string.Format(" CONVERT(nom_Sport, 'System.String') LIKE '%{0}%' OR CONVERT(nom, 'System.String') LIKE '%{0}%'", cherche1.Text);

                // Affecter la source de données filtrée à la grille existante
                
                metroGrid1.DataSource = dataTable;

                metroGrid1.DataSource = bindingSource;

                // Rafraîchir la grille
                bindingSource.ResetBindings(false);

            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (com.SelectedItem != null && com.SelectedItem.ToString() == "IMPAYES")

            {
                connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT a.Nom, a.Prenom, a.Genre, a.Email, a.Telephone, sp.nom_Sport, sp.date_Debut, sp.date_Fin, sp.Payer, sp.Restant, s.prix\r\nFROM [dbo].[Adherents] a\r\nINNER JOIN [dbo].[SportsPratiques] sp\r\nON a.Id = sp.AdherentID\r\nINNER JOIN [dbo].[Sport] s\r\nON sp.nom_Sport = s.lib_sport where  sp.Payer IS  NULL  ";
                cmd.ExecuteNonQuery();
            connection.Close();

            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd.CommandText, connection);
            dataAdapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            string chercher = cherche1.Text;
            // Appliquer un filtre à la source de données en fonction de la chaîne de recherche
            bindingSource.Filter = string.Format(" CONVERT(nom_Sport, 'System.String') LIKE '%{0}%' OR CONVERT(nom, 'System.String') LIKE '%{0}%'", cherche1.Text);

            // Affecter la source de données filtrée à la grille existante
        
            metroGrid1.DataSource = dataTable;

            metroGrid1.DataSource = bindingSource;

            // Rafraîchir la grille
            bindingSource.ResetBindings(false);
            
        }
            
            else if (com.SelectedItem != null && com.SelectedItem.ToString() == "PAYES")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT a.Nom, a.Prenom, a.Genre, a.Email, a.Telephone, sp.nom_Sport, sp.date_Debut, sp.date_Fin, sp.Payer, sp.Restant, s.prix\r\nFROM [dbo].[Adherents] a\r\nINNER JOIN [dbo].[SportsPratiques] sp\r\nON a.Id = sp.AdherentID\r\nINNER JOIN [dbo].[Sport] s\r\nON sp.nom_Sport = s.lib_sport where  sp.Payer IS NOT NULL  ";
                cmd.ExecuteNonQuery();
                connection.Close();

                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd.CommandText, connection);
                dataAdapter.Fill(dataTable);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                string chercher = cherche1.Text;
                // Appliquer un filtre à la source de données en fonction de la chaîne de recherche
                bindingSource.Filter = string.Format(" CONVERT(nom_Sport, 'System.String') LIKE '%{0}%' OR CONVERT(nom, 'System.String') LIKE '%{0}%'", cherche1.Text);

                // Affecter la source de données filtrée à la grille existante

                metroGrid1.DataSource = dataTable;

                metroGrid1.DataSource = bindingSource;

                // Rafraîchir la grille
                bindingSource.ResetBindings(false);

            }
        }

        private void metroGrid8_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Récupérez la valeur de la cellule sélectionnée
                DataGridViewCell cell = metroGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string cellValue = cell.Value.ToString();

                // Faites quelque chose avec la valeur de la cellule (par exemple, affichez-la dans un MessageBox)
                MessageBox.Show("La cellule sélectionnée contient la valeur : " + cellValue);
            }
        }
    } 

    
}
