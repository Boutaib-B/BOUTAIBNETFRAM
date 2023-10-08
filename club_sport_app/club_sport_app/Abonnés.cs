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
    public partial class Abonnés : MetroForm

    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\BOUTAIBNETFRAM\club_sport_app\club_sport_app\Database1.mdf;Integrated Security = True");
      
      

        public Abonnés()
        {
            InitializeComponent();
        }

        public Abonnés(object metroGrid, SelectedRow selectedRow, Panel panel2, PictureBox pictureBox1, Label label2, Label label1, BunifuTileButton bunifuTileButton1, BunifuTileButton bunifuTileButton2, BunifuTileButton bunifuTileButton3, BunifuTileButton bunifuTileButton4, Panel panel1, MetroGrid metroGrid1, Database1DataSet database1DataSet, BindingSource adherentsBindingSource, IContainer components, AdherentsTableAdapter adherentsTableAdapter, DataGridViewTextBoxColumn idDataGridViewTextBoxColumn, DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn, DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn, DataGridViewTextBoxColumn cNEDataGridViewTextBoxColumn, DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn, DataGridViewImageColumn adresseDataGridViewImageColumn, DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn, DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn, DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn, BunifuTextbox cherche)
        {
           
            this.selectedRow = selectedRow;
            this.panel2 = panel2;
            this.pictureBox1 = pictureBox1;
            this.label2 = label2;
            this.label1 = label1;
            this.bunifuTileButton1 = bunifuTileButton1;
            this.bunifuTileButton2 = bunifuTileButton2;

            this.bunifuTileButton4 = bunifuTileButton4;
            this.panel1 = panel1;
            this.metroGrid8 = metroGrid1;


           
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
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.DateFin = new MetroFramework.Controls.MetroDateTime();
            this.TextBoxSportChoisi = new System.Windows.Forms.TextBox();
            this.DateDebut = new Bunifu.Framework.UI.BunifuCalendar();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownYears = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownMonths = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Montant = new System.Windows.Forms.TextBox();
            this.RESTANT = new System.Windows.Forms.TextBox();
            this.database1DataSet = new club_sport_app.Database1DataSet();
            this.sportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportTableAdapter = new club_sport_app.Database1DataSetTableAdapters.SportTableAdapter();
            this.tableAdapterManager = new club_sport_app.Database1DataSetTableAdapters.TableAdapterManager();
            this.listBoxSports = new System.Windows.Forms.ListBox();
            this.listBoxPrices = new System.Windows.Forms.ListBox();
            this.listBoxSportsPratiques = new System.Windows.Forms.ListBox();
            this.metroGrid8 = new MetroFramework.Controls.MetroGrid();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.cherche1 = new MetroFramework.Controls.MetroTextBox();
            this.ADHR = new System.Windows.Forms.TextBox();
            this.Num_ = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.metroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(1, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 69);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(108, 51);
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
            this.label1.Location = new System.Drawing.Point(107, 16);
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
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.bunifuTileButton4);
            this.panel1.Controls.Add(this.bunifuTileButton2);
            this.panel1.Controls.Add(this.bunifuTileButton1);
            this.panel1.Location = new System.Drawing.Point(1, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 733);
            this.panel1.TabIndex = 0;
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.bunifuTileButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTileButton4.color = System.Drawing.Color.DarkTurquoise;
            this.bunifuTileButton4.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton4.Image = global::club_sport_app.Properties.Resources.home;
            this.bunifuTileButton4.ImagePosition = 13;
            this.bunifuTileButton4.ImageZoom = 20;
            this.bunifuTileButton4.LabelPosition = 27;
            this.bunifuTileButton4.LabelText = "Acceuil";
            this.bunifuTileButton4.Location = new System.Drawing.Point(6, 160);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(142, 82);
            this.bunifuTileButton4.TabIndex = 4;
            this.bunifuTileButton4.Click += new System.EventHandler(this.bunifuTileButton4_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.bunifuTileButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTileButton2.color = System.Drawing.Color.DarkTurquoise;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = global::club_sport_app.Properties.Resources.settings2;
            this.bunifuTileButton2.ImagePosition = 13;
            this.bunifuTileButton2.ImageZoom = 20;
            this.bunifuTileButton2.LabelPosition = 28;
            this.bunifuTileButton2.LabelText = "MODIFIER  ABONNEMENT";
            this.bunifuTileButton2.Location = new System.Drawing.Point(6, 418);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(142, 82);
            this.bunifuTileButton2.TabIndex = 2;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.bunifuTileButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTileButton1.color = System.Drawing.Color.DarkTurquoise;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = global::club_sport_app.Properties.Resources.renewable;
            this.bunifuTileButton1.ImagePosition = 13;
            this.bunifuTileButton1.ImageZoom = 20;
            this.bunifuTileButton1.LabelPosition = 27;
            this.bunifuTileButton1.LabelText = "RENOUVELER";
            this.bunifuTileButton1.Location = new System.Drawing.Point(6, 280);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(142, 82);
            this.bunifuTileButton1.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(190, 374);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(0, 0);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "A PAYER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 545);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "RESTANT A PAYER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "DH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "DH";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Crimson;
            this.metroButton1.Location = new System.Drawing.Point(382, 660);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(184, 41);
            this.metroButton1.TabIndex = 20;
            this.metroButton1.Text = "CONFIRMER";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Crimson;
            this.metroButton2.Location = new System.Drawing.Point(571, 660);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(149, 41);
            this.metroButton2.TabIndex = 21;
            this.metroButton2.Text = "ANNULER";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroPanel
            // 
            this.metroPanel.Controls.Add(this.label9);
            this.metroPanel.Controls.Add(this.DateFin);
            this.metroPanel.Controls.Add(this.TextBoxSportChoisi);
            this.metroPanel.Controls.Add(this.DateDebut);
            this.metroPanel.Controls.Add(this.label10);
            this.metroPanel.Controls.Add(this.numericUpDownYears);
            this.metroPanel.Controls.Add(this.label11);
            this.metroPanel.Controls.Add(this.numericUpDownMonths);
            this.metroPanel.Controls.Add(this.label12);
            this.metroPanel.Controls.Add(this.label13);
            this.metroPanel.Controls.Add(this.label14);
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            this.metroPanel.Location = new System.Drawing.Point(171, 285);
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Size = new System.Drawing.Size(571, 173);
            this.metroPanel.TabIndex = 35;
            this.metroPanel.VerticalScrollbarBarColor = true;
            this.metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel.VerticalScrollbarSize = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(310, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Sport choisi :";
            // 
            // DateFin
            // 
            this.DateFin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFin.Location = new System.Drawing.Point(30, 124);
            this.DateFin.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateFin.Name = "DateFin";
            this.DateFin.Size = new System.Drawing.Size(217, 29);
            this.DateFin.TabIndex = 34;
            // 
            // TextBoxSportChoisi
            // 
            this.TextBoxSportChoisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSportChoisi.Location = new System.Drawing.Point(314, 124);
            this.TextBoxSportChoisi.Multiline = true;
            this.TextBoxSportChoisi.Name = "TextBoxSportChoisi";
            this.TextBoxSportChoisi.Size = new System.Drawing.Size(125, 29);
            this.TextBoxSportChoisi.TabIndex = 33;
            // 
            // DateDebut
            // 
            this.DateDebut.BackColor = System.Drawing.Color.SeaGreen;
            this.DateDebut.BorderRadius = 0;
            this.DateDebut.ForeColor = System.Drawing.Color.White;
            this.DateDebut.Location = new System.Drawing.Point(30, 38);
            this.DateDebut.Name = "DateDebut";
            this.DateDebut.Size = new System.Drawing.Size(217, 36);
            this.DateDebut.TabIndex = 28;
            this.DateDebut.Value = new System.DateTime(2023, 5, 7, 2, 27, 44, 300);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(524, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Ans";
            // 
            // numericUpDownYears
            // 
            this.numericUpDownYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownYears.Location = new System.Drawing.Point(444, 43);
            this.numericUpDownYears.Name = "numericUpDownYears";
            this.numericUpDownYears.Size = new System.Drawing.Size(45, 26);
            this.numericUpDownYears.TabIndex = 16;
            this.numericUpDownYears.ValueChanged += new System.EventHandler(this.numericUpDownYears_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(310, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Durée d\'abonnement :";
            // 
            // numericUpDownMonths
            // 
            this.numericUpDownMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMonths.Location = new System.Drawing.Point(331, 43);
            this.numericUpDownMonths.Name = "numericUpDownMonths";
            this.numericUpDownMonths.Size = new System.Drawing.Size(45, 26);
            this.numericUpDownMonths.TabIndex = 15;
            this.numericUpDownMonths.ValueChanged += new System.EventHandler(this.numericUpDownMonths_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "Date Début :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(382, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 19);
            this.label13.TabIndex = 22;
            this.label13.Text = "Mois";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 19);
            this.label14.TabIndex = 20;
            this.label14.Text = "Date Fin :";
            // 
            // Montant
            // 
            this.Montant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Montant.Location = new System.Drawing.Point(296, 500);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(65, 26);
            this.Montant.TabIndex = 37;
            // 
            // RESTANT
            // 
            this.RESTANT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESTANT.Location = new System.Drawing.Point(296, 537);
            this.RESTANT.Name = "RESTANT";
            this.RESTANT.Size = new System.Drawing.Size(65, 26);
            this.RESTANT.TabIndex = 38;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sportBindingSource
            // 
            this.sportBindingSource.DataMember = "Sport";
            this.sportBindingSource.DataSource = this.database1DataSet;
            // 
            // sportTableAdapter
            // 
            this.sportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdherentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Sports_PratiquesTableAdapter = null;
            this.tableAdapterManager.SportTableAdapter = this.sportTableAdapter;
            this.tableAdapterManager.UpdateOrder = club_sport_app.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listBoxSports
            // 
            this.listBoxSports.DataSource = this.sportBindingSource;
            this.listBoxSports.DisplayMember = "Id_sport";
            this.listBoxSports.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSports.FormattingEnabled = true;
            this.listBoxSports.ItemHeight = 18;
            this.listBoxSports.Location = new System.Drawing.Point(408, 500);
            this.listBoxSports.Name = "listBoxSports";
            this.listBoxSports.Size = new System.Drawing.Size(88, 94);
            this.listBoxSports.TabIndex = 39;
            this.listBoxSports.ValueMember = "Id_sport";
            // 
            // listBoxPrices
            // 
            this.listBoxPrices.DataSource = this.sportBindingSource;
            this.listBoxPrices.DisplayMember = "prix";
            this.listBoxPrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPrices.FormattingEnabled = true;
            this.listBoxPrices.ItemHeight = 18;
            this.listBoxPrices.Location = new System.Drawing.Point(523, 500);
            this.listBoxPrices.Name = "listBoxPrices";
            this.listBoxPrices.Size = new System.Drawing.Size(50, 94);
            this.listBoxPrices.TabIndex = 40;
            this.listBoxPrices.ValueMember = "Id_sport";
            this.listBoxPrices.SelectedIndexChanged += new System.EventHandler(this.listBoxPrices_SelectedIndexChanged_1);
            // 
            // listBoxSportsPratiques
            // 
            this.listBoxSportsPratiques.DataSource = this.sportBindingSource;
            this.listBoxSportsPratiques.DisplayMember = "lib_sport";
            this.listBoxSportsPratiques.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSportsPratiques.FormattingEnabled = true;
            this.listBoxSportsPratiques.ItemHeight = 18;
            this.listBoxSportsPratiques.Location = new System.Drawing.Point(603, 500);
            this.listBoxSportsPratiques.Name = "listBoxSportsPratiques";
            this.listBoxSportsPratiques.Size = new System.Drawing.Size(117, 94);
            this.listBoxSportsPratiques.TabIndex = 41;
            this.listBoxSportsPratiques.ValueMember = "Id_sport";
            this.listBoxSportsPratiques.SelectedIndexChanged += new System.EventHandler(this.listBoxSportsPratiques_SelectedIndexChanged);
            // 
            // metroGrid8
            // 
            this.metroGrid8.AllowUserToResizeRows = false;
            this.metroGrid8.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.metroGrid8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid8.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid8.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid8.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid8.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid8.EnableHeadersVisualStyles = false;
            this.metroGrid8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid8.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid8.Location = new System.Drawing.Point(182, 112);
            this.metroGrid8.Name = "metroGrid8";
            this.metroGrid8.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid8.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid8.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid8.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid8.Size = new System.Drawing.Size(538, 150);
            this.metroGrid8.TabIndex = 42;
            this.metroGrid8.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            this.metroGrid8.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick_1);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(424, 21);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(227, 42);
            this.metroButton3.TabIndex = 43;
            this.metroButton3.Text = "Chercher";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // cherche1
            // 
            // 
            // 
            // 
            this.cherche1.CustomButton.Image = null;
            this.cherche1.CustomButton.Location = new System.Drawing.Point(187, 2);
            this.cherche1.CustomButton.Name = "";
            this.cherche1.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.cherche1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cherche1.CustomButton.TabIndex = 1;
            this.cherche1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cherche1.CustomButton.UseSelectable = true;
            this.cherche1.CustomButton.Visible = false;
            this.cherche1.Lines = new string[0];
            this.cherche1.Location = new System.Drawing.Point(190, 21);
            this.cherche1.MaxLength = 32767;
            this.cherche1.Name = "cherche1";
            this.cherche1.PasswordChar = '\0';
            this.cherche1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cherche1.SelectedText = "";
            this.cherche1.SelectionLength = 0;
            this.cherche1.SelectionStart = 0;
            this.cherche1.ShortcutsEnabled = true;
            this.cherche1.Size = new System.Drawing.Size(227, 42);
            this.cherche1.TabIndex = 44;
            this.cherche1.UseSelectable = true;
            this.cherche1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cherche1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ADHR
            // 
            this.ADHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADHR.Location = new System.Drawing.Point(296, 569);
            this.ADHR.Name = "ADHR";
            this.ADHR.Size = new System.Drawing.Size(65, 26);
            this.ADHR.TabIndex = 45;
            // 
            // Num_
            // 
            this.Num_.AutoSize = true;
            this.Num_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_.Location = new System.Drawing.Point(198, 577);
            this.Num_.Name = "Num_";
            this.Num_.Size = new System.Drawing.Size(60, 13);
            this.Num_.TabIndex = 46;
            this.Num_.Text = "N° ADHR";
            // 
            // Abonnés
            // 
            this.ClientSize = new System.Drawing.Size(743, 733);
            this.Controls.Add(this.Num_);
            this.Controls.Add(this.ADHR);
            this.Controls.Add(this.cherche1);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroGrid8);
            this.Controls.Add(this.listBoxSportsPratiques);
            this.Controls.Add(this.listBoxPrices);
            this.Controls.Add(this.listBoxSports);
            this.Controls.Add(this.RESTANT);
            this.Controls.Add(this.Montant);
            this.Controls.Add(this.metroPanel);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Abonnés";
            this.Load += new System.EventHandler(this.Abonnés_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.metroPanel.ResumeLayout(false);
            this.metroPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private SelectedRow selectedRow = new SelectedRow();

        public object MetroGrid2 { get; private set; }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {

            Form1 fromm = new Form1();
            fromm.Show();
            this.Hide();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            Reglement reglement = new Reglement();
            reglement.Show();
            this.Hide();
        }


      

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            SettingAbonnés settingAbonnés = new SettingAbonnés();
            settingAbonnés.Show();
            this.Hide();
        }



        private void listBoxSports_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cherche_OnTextChange(object sender, EventArgs e)
        {
            if (cherche1.Text == "Nom")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Id,Nom, Prenom  from [Adherents] where Nom like'" + cherche1.Text + "%'";
                cmd.ExecuteNonQuery();



                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection);
                dataadp.Fill(dta);
                MetroGrid metro = new MetroGrid();
                metro.DataSource = dta;
                connection.Close();


            }

            else if (cherche1.Text == "Prenom")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Id,Nom, Prenom  from [Adherents] where Prenom like'" + cherche1.Text + "%'";
                cmd.ExecuteNonQuery();


                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection);
                dataadp.Fill(dta);
                MetroGrid metro = new MetroGrid();
                metro.DataSource = dta;
                connection.Close();

            }

            else if (cherche1.Text == "Id")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Id,Nom, Prenom  from [Adherents] where Id like'%" + cherche1.Text + "%'";
                cmd.ExecuteNonQuery();



                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection);
                dataadp.Fill(dta);
                MetroGrid metro = new MetroGrid();
                metro.DataSource = dta;
                connection.Close();
            }

        }



        private void Abonnés_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.Sport'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.sportTableAdapter.Fill(this.database1DataSet.Sport);
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.Sport'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.sportTableAdapter.Fill(this.database1DataSet.Sport);

           display_data();


        }
        int item_price = 0;
        private void listBoxPrices_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataRowView rowView = listBoxPrices.SelectedItem as DataRowView;
            if (rowView != null)
            {
                if (!String.IsNullOrEmpty(Montant.Text))
                {

                    item_price = int.Parse(rowView["prix"].ToString());
                    int montant = int.Parse(Montant.Text.Trim());
                    int restant = item_price - montant;
                    decimal decimalValue = (decimal)restant;

                    RESTANT.Text = decimalValue.ToString();


                }




            }
        }

        private void listBoxSportsPratiques_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView rowView = listBoxSports.SelectedItem as DataRowView;
            if (rowView != null)
            {
                TextBoxSportChoisi.Text = rowView["lib_Sport"].ToString();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            if (listBoxSports.SelectedIndex != -1)
            {
                
    
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into [SportsPratiques] (nom_Sport,AdherentID,date_Debut,date_Fin,Payer,Restant) values ('" + TextBoxSportChoisi.Text + "','" + ADHR.Text + "','" + DateDebut.Value + "','" + DateFin.Value + "','" + Montant.Text + "','" + RESTANT.Text+ "')";
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Votre enregistrement est bien effectuée");
                
               
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un sport dans la liste déroulante.");
            }


        }

        private void numericUpDownMonths_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)numericUpDownMonths.Value;
            if (value > 0)
            {
                DateTime selectedDateTime = DateDebut.Value;
                int year = selectedDateTime.Year;
                int month = selectedDateTime.Month;
                int day = selectedDateTime.Day;
                int hour = selectedDateTime.Hour;
                int minute = selectedDateTime.Minute;
                int second = selectedDateTime.Second;
                month += value;
                DateFin.Value = new DateTime(year, month, day, hour, minute, second);
            }
        }

        private void numericUpDownYears_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)numericUpDownYears.Value;
            if (value > 0)
            {
                DateTime selectedDateTime = DateDebut.Value;
                int year = selectedDateTime.Year;
                int month = selectedDateTime.Month;
                int day = selectedDateTime.Day;
                int hour = selectedDateTime.Hour;
                int minute = selectedDateTime.Minute;
                int second = selectedDateTime.Second;
                year += value;
                DateFin.Value = new DateTime(year, month, day, hour, minute, second);
            }
        }

        private void metroGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

       
            
        


        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void display_data()
        {
            
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT p.PhotoData, sp.nom_Sport, a.Nom, a.Prenom, sp.date_Fin FROM [dbo].[Adherents] a INNER JOIN [dbo].[SportsPratiques] sp ON a.Id = sp.AdherentID INNER JOIN [dbo].[Photos] p ON a.Id = p.AdherentId ";
                cmd.ExecuteNonQuery();
                connection.Close();

                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd.CommandText, connection);
                dataAdapter.Fill(dataTable);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                // Appliquer un filtre à la source de données en fonction de la chaîne de recherche
                bindingSource.Filter = string.Format(" CONVERT(nom_Sport, 'System.String') LIKE '%{0}%'", cherche1.Text);

            // Affecter la source de données filtrée à la grille existante
            MetroGrid metroGrid1 = new MetroGrid();
            metroGrid8.DataSource = dataTable;
            
            metroGrid8.DataSource = bindingSource;

                // Rafraîchir la grille
                bindingSource.ResetBindings(false);
            SetGridColumnWidth(metroGrid8, 120);




        }
        public void SetGridColumnWidth(DataGridView grid, int width)
        {
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                grid.Columns[i].Width = width;
            }
        }

        private void metroGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current column is the one with the image
            if (metroGrid8.Columns[e.ColumnIndex].Name == "PhotoData")
            {
                // Get the image from the cell value
                Image image = (Image)e.Value;

                // Check if the image is not null
                if (image != null)
                {
                    // Create a new image with the desired size
                    Image newImage = new Bitmap(image, new Size(15,15));

                    // Set the new image as the cell value
                    e.Value = newImage;

                    // Set the cell style to display the image
                    e.CellStyle.NullValue = newImage;
                    e.CellStyle.Padding = new Padding(10);
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    
                }
            }
        }


        private void metroButton3_Click(object sender, EventArgs e)
        {


            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT p.PhotoData, sp.nom_Sport, a.Nom, a.Prenom, sp.date_Fin FROM [dbo].[Adherents] a INNER JOIN [dbo].[SportsPratiques] sp ON a.Id = sp.AdherentID INNER JOIN [dbo].[Photos] p ON a.Id = p.AdherentId ";
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
            MetroGrid metroGrid1 = new MetroGrid();
            metroGrid8.DataSource = dataTable;

            metroGrid8.DataSource = bindingSource;

            // Rafraîchir la grille
            bindingSource.ResetBindings(false);
            SetGridColumnWidth(metroGrid8, 120);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
  

}


     
    


