namespace club_sport_app
{
    partial class FormNewMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxIdentification = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButtonFemme = new System.Windows.Forms.RadioButton();
            this.radioButtonHomme = new System.Windows.Forms.RadioButton();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextboxPrenom = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TextboxNom = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.groupBoxCommunications = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextboxTel = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TextboxEmail = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnAddUser = new MetroFramework.Controls.MetroTile();
            this.btnClear = new MetroFramework.Controls.MetroTile();
            this.btnGoBack = new MetroFramework.Controls.MetroTile();
            this.btnEditUser = new MetroFramework.Controls.MetroTile();
            this.groupBoxIdentification.SuspendLayout();
            this.groupBoxCommunications.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIdentification
            // 
            this.groupBoxIdentification.BackColor = System.Drawing.Color.White;
            this.groupBoxIdentification.Controls.Add(this.label9);
            this.groupBoxIdentification.Controls.Add(this.radioButtonFemme);
            this.groupBoxIdentification.Controls.Add(this.radioButtonHomme);
            this.groupBoxIdentification.Controls.Add(this.metroProgressBar1);
            this.groupBoxIdentification.Controls.Add(this.label2);
            this.groupBoxIdentification.Controls.Add(this.label1);
            this.groupBoxIdentification.Controls.Add(this.TextboxPrenom);
            this.groupBoxIdentification.Controls.Add(this.TextboxNom);
            this.groupBoxIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxIdentification.Location = new System.Drawing.Point(46, 93);
            this.groupBoxIdentification.Name = "groupBoxIdentification";
            this.groupBoxIdentification.Size = new System.Drawing.Size(597, 241);
            this.groupBoxIdentification.TabIndex = 0;
            this.groupBoxIdentification.TabStop = false;
            this.groupBoxIdentification.Text = "Identification";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Genre";
            // 
            // radioButtonFemme
            // 
            this.radioButtonFemme.AutoSize = true;
            this.radioButtonFemme.Location = new System.Drawing.Point(255, 198);
            this.radioButtonFemme.Name = "radioButtonFemme";
            this.radioButtonFemme.Size = new System.Drawing.Size(82, 22);
            this.radioButtonFemme.TabIndex = 14;
            this.radioButtonFemme.Text = "Femme";
            this.radioButtonFemme.UseVisualStyleBackColor = true;
            // 
            // radioButtonHomme
            // 
            this.radioButtonHomme.AutoSize = true;
            this.radioButtonHomme.Checked = true;
            this.radioButtonHomme.Location = new System.Drawing.Point(126, 198);
            this.radioButtonHomme.Name = "radioButtonHomme";
            this.radioButtonHomme.Size = new System.Drawing.Size(85, 22);
            this.radioButtonHomme.TabIndex = 13;
            this.radioButtonHomme.TabStop = true;
            this.radioButtonHomme.Text = "Homme";
            this.radioButtonHomme.UseVisualStyleBackColor = true;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(6, 190);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(371, 40);
            this.metroProgressBar1.TabIndex = 12;
            this.metroProgressBar1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom";
            // 
            // TextboxPrenom
            // 
            this.TextboxPrenom.BorderColor = System.Drawing.Color.SeaGreen;
            this.TextboxPrenom.Location = new System.Drawing.Point(99, 108);
            this.TextboxPrenom.Name = "TextboxPrenom";
            this.TextboxPrenom.Size = new System.Drawing.Size(166, 24);
            this.TextboxPrenom.TabIndex = 1;
            // 
            // TextboxNom
            // 
            this.TextboxNom.BorderColor = System.Drawing.Color.SeaGreen;
            this.TextboxNom.Location = new System.Drawing.Point(99, 38);
            this.TextboxNom.Name = "TextboxNom";
            this.TextboxNom.Size = new System.Drawing.Size(164, 24);
            this.TextboxNom.TabIndex = 0;
            // 
            // groupBoxCommunications
            // 
            this.groupBoxCommunications.BackColor = System.Drawing.Color.White;
            this.groupBoxCommunications.Controls.Add(this.label5);
            this.groupBoxCommunications.Controls.Add(this.label7);
            this.groupBoxCommunications.Controls.Add(this.TextboxTel);
            this.groupBoxCommunications.Controls.Add(this.TextboxEmail);
            this.groupBoxCommunications.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCommunications.Location = new System.Drawing.Point(46, 359);
            this.groupBoxCommunications.Name = "groupBoxCommunications";
            this.groupBoxCommunications.Size = new System.Drawing.Size(597, 129);
            this.groupBoxCommunications.TabIndex = 2;
            this.groupBoxCommunications.TabStop = false;
            this.groupBoxCommunications.Text = "Communications";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Téléphone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email";
            // 
            // TextboxTel
            // 
            this.TextboxTel.BorderColor = System.Drawing.Color.SeaGreen;
            this.TextboxTel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextboxTel.Location = new System.Drawing.Point(117, 93);
            this.TextboxTel.Name = "TextboxTel";
            this.TextboxTel.Size = new System.Drawing.Size(164, 24);
            this.TextboxTel.TabIndex = 2;
            // 
            // TextboxEmail
            // 
            this.TextboxEmail.BorderColor = System.Drawing.Color.SeaGreen;
            this.TextboxEmail.Location = new System.Drawing.Point(117, 38);
            this.TextboxEmail.Name = "TextboxEmail";
            this.TextboxEmail.Size = new System.Drawing.Size(204, 24);
            this.TextboxEmail.TabIndex = 0;
            // 
            // btnAddUser
            // 
            this.btnAddUser.ActiveControl = null;
            this.btnAddUser.Location = new System.Drawing.Point(46, 674);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(109, 52);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Ajouter";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddUser.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAddUser.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnAddUser.UseSelectable = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnClear
            // 
            this.btnClear.ActiveControl = null;
            this.btnClear.Location = new System.Drawing.Point(218, 674);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 52);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Refaire";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnClear.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnClear.UseSelectable = true;
            // 
            // btnGoBack
            // 
            this.btnGoBack.ActiveControl = null;
            this.btnGoBack.Location = new System.Drawing.Point(550, 674);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(109, 52);
            this.btnGoBack.TabIndex = 6;
            this.btnGoBack.Text = "Retour";
            this.btnGoBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGoBack.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnGoBack.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnGoBack.UseSelectable = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.ActiveControl = null;
            this.btnEditUser.Location = new System.Drawing.Point(379, 674);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(109, 52);
            this.btnEditUser.TabIndex = 7;
            this.btnEditUser.Text = "Modifier";
            this.btnEditUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditUser.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnEditUser.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnEditUser.UseSelectable = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // FormNewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 738);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.groupBoxCommunications);
            this.Controls.Add(this.groupBoxIdentification);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormNewMember";
            this.Text = "FormNewMember";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.FormNewMember_Load);
            this.groupBoxIdentification.ResumeLayout(false);
            this.groupBoxIdentification.PerformLayout();
            this.groupBoxCommunications.ResumeLayout(false);
            this.groupBoxCommunications.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIdentification;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TextboxPrenom;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TextboxNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxCommunications;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TextboxTel;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TextboxEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButtonFemme;
        private System.Windows.Forms.RadioButton radioButtonHomme;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroTile btnAddUser;
        private MetroFramework.Controls.MetroTile btnClear;
        private MetroFramework.Controls.MetroTile btnGoBack;
        private MetroFramework.Controls.MetroTile btnEditUser;
    }
}