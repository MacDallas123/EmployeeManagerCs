namespace EngineeringProjet
{
    partial class GererLesUtilisateurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GererLesUtilisateurs));
            this.label1 = new System.Windows.Forms.Label();
            this.dbProfilBindingSource = new System.Windows.Forms.BindingSource();
            this.profilDataSet = new EngineeringProjet.ProfilDataSet();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IdText = new System.Windows.Forms.TextBox();
            this.UserText = new System.Windows.Forms.TextBox();
            this.CompagnieText = new System.Windows.Forms.TextBox();
            this.PassWordText = new System.Windows.Forms.TextBox();
            this.ConfirmPassText = new System.Windows.Forms.TextBox();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.NewBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.LastPassWordText = new System.Windows.Forms.TextBox();
            this.dbProfilTableAdapter = new EngineeringProjet.ProfilDataSetTableAdapters.DbProfilTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ListeDeProfils = new DevExpress.XtraVerticalGrid.VGridControl();
            this.rowId = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowUtilisateur = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCompagnie = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowMotDePasse = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDescription = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.ProfilsNb = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.UseProfilBtn = new System.Windows.Forms.Button();
            this.DeleteProfilBtn = new System.Windows.Forms.Button();
            this.EditProfilBtn = new System.Windows.Forms.Button();
            this.AddProfilBtn = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbProfilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeDeProfils)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 16F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des profils d\'utilisateurs";
            // 
            // dbProfilBindingSource
            // 
            this.dbProfilBindingSource.DataMember = "DbProfil";
            this.dbProfilBindingSource.DataSource = this.profilDataSet;
            // 
            // profilDataSet
            // 
            this.profilDataSet.DataSetName = "ProfilDataSet";
            this.profilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelBtn.Location = new System.Drawing.Point(586, 368);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(78, 46);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Annuler";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "N°  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nom du profil :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nom de la compagnie :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mot de passe : *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Confirmer le mot de passe : *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Description :";
            // 
            // IdText
            // 
            this.IdText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdText.BackColor = System.Drawing.Color.White;
            this.IdText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dbProfilBindingSource, "Id", true));
            this.IdText.Enabled = false;
            this.IdText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.IdText.Location = new System.Drawing.Point(239, 71);
            this.IdText.MaxLength = 9;
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(308, 22);
            this.IdText.TabIndex = 13;
            this.IdText.TextChanged += new System.EventHandler(this.IdText_TextChanged);
            // 
            // UserText
            // 
            this.UserText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserText.BackColor = System.Drawing.Color.White;
            this.UserText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dbProfilBindingSource, "Utilisateur", true));
            this.UserText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.UserText.Location = new System.Drawing.Point(239, 104);
            this.UserText.MaxLength = 40;
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(425, 22);
            this.UserText.TabIndex = 14;
            // 
            // CompagnieText
            // 
            this.CompagnieText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompagnieText.BackColor = System.Drawing.Color.White;
            this.CompagnieText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompagnieText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dbProfilBindingSource, "Compagnie", true));
            this.CompagnieText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.CompagnieText.Location = new System.Drawing.Point(239, 137);
            this.CompagnieText.MaxLength = 70;
            this.CompagnieText.Name = "CompagnieText";
            this.CompagnieText.Size = new System.Drawing.Size(425, 22);
            this.CompagnieText.TabIndex = 15;
            // 
            // PassWordText
            // 
            this.PassWordText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassWordText.BackColor = System.Drawing.Color.White;
            this.PassWordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassWordText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.PassWordText.Location = new System.Drawing.Point(239, 203);
            this.PassWordText.MaxLength = 25;
            this.PassWordText.Name = "PassWordText";
            this.PassWordText.Size = new System.Drawing.Size(425, 22);
            this.PassWordText.TabIndex = 16;
            this.PassWordText.UseSystemPasswordChar = true;
            // 
            // ConfirmPassText
            // 
            this.ConfirmPassText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmPassText.BackColor = System.Drawing.Color.White;
            this.ConfirmPassText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmPassText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ConfirmPassText.Location = new System.Drawing.Point(239, 236);
            this.ConfirmPassText.MaxLength = 25;
            this.ConfirmPassText.Name = "ConfirmPassText";
            this.ConfirmPassText.Size = new System.Drawing.Size(425, 22);
            this.ConfirmPassText.TabIndex = 17;
            this.ConfirmPassText.UseSystemPasswordChar = true;
            // 
            // DescriptionText
            // 
            this.DescriptionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionText.BackColor = System.Drawing.Color.White;
            this.DescriptionText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dbProfilBindingSource, "Description", true));
            this.DescriptionText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DescriptionText.Location = new System.Drawing.Point(239, 269);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(425, 93);
            this.DescriptionText.TabIndex = 18;
            // 
            // NewBtn
            // 
            this.NewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewBtn.BackColor = System.Drawing.Color.Beige;
            this.NewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewBtn.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.NewBtn.ForeColor = System.Drawing.Color.Black;
            this.NewBtn.Location = new System.Drawing.Point(76, 369);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(59, 46);
            this.NewBtn.TabIndex = 21;
            this.NewBtn.Text = "Vider les champs";
            this.NewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewBtn.UseVisualStyleBackColor = false;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(12, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ancien mot de passe : ";
            // 
            // LastPassWordText
            // 
            this.LastPassWordText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastPassWordText.BackColor = System.Drawing.Color.White;
            this.LastPassWordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastPassWordText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dbProfilBindingSource, "MotDePasse", true));
            this.LastPassWordText.Enabled = false;
            this.LastPassWordText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LastPassWordText.Location = new System.Drawing.Point(239, 170);
            this.LastPassWordText.MaxLength = 25;
            this.LastPassWordText.Name = "LastPassWordText";
            this.LastPassWordText.Size = new System.Drawing.Size(425, 22);
            this.LastPassWordText.TabIndex = 23;
            this.LastPassWordText.UseSystemPasswordChar = true;
            // 
            // dbProfilTableAdapter
            // 
            this.dbProfilTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 345);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(142, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Afficher le mot de passe";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 8F);
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(12, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 36);
            this.label9.TabIndex = 25;
            this.label9.Text = "Toute suppression ou modification\r\nd\'un profil nécessite le remplissage\r\ndes zone" +
    "s avec le symbole *";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 11F);
            this.label10.Location = new System.Drawing.Point(138, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "( En un mot )";
            // 
            // ListeDeProfils
            // 
            this.ListeDeProfils.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListeDeProfils.Appearance.Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(166)))), ((int)(((byte)(57)))));
            this.ListeDeProfils.Appearance.Category.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(166)))), ((int)(((byte)(37)))));
            this.ListeDeProfils.Appearance.Category.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.ListeDeProfils.Appearance.Category.ForeColor = System.Drawing.Color.White;
            this.ListeDeProfils.Appearance.Category.Options.UseBackColor = true;
            this.ListeDeProfils.Appearance.Category.Options.UseBorderColor = true;
            this.ListeDeProfils.Appearance.Category.Options.UseFont = true;
            this.ListeDeProfils.Appearance.Category.Options.UseForeColor = true;
            this.ListeDeProfils.Appearance.CategoryExpandButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(48)))));
            this.ListeDeProfils.Appearance.CategoryExpandButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(48)))));
            this.ListeDeProfils.Appearance.CategoryExpandButton.ForeColor = System.Drawing.Color.White;
            this.ListeDeProfils.Appearance.CategoryExpandButton.Options.UseBackColor = true;
            this.ListeDeProfils.Appearance.CategoryExpandButton.Options.UseBorderColor = true;
            this.ListeDeProfils.Appearance.CategoryExpandButton.Options.UseForeColor = true;
            this.ListeDeProfils.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.ListeDeProfils.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.ListeDeProfils.Appearance.Empty.Options.UseBackColor = true;
            this.ListeDeProfils.Appearance.ExpandButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(193)))), ((int)(((byte)(74)))));
            this.ListeDeProfils.Appearance.ExpandButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(193)))), ((int)(((byte)(74)))));
            this.ListeDeProfils.Appearance.ExpandButton.ForeColor = System.Drawing.Color.White;
            this.ListeDeProfils.Appearance.ExpandButton.Options.UseBackColor = true;
            this.ListeDeProfils.Appearance.ExpandButton.Options.UseBorderColor = true;
            this.ListeDeProfils.Appearance.ExpandButton.Options.UseForeColor = true;
            this.ListeDeProfils.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.ListeDeProfils.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.ListeDeProfils.Appearance.FocusedCell.Options.UseBackColor = true;
            this.ListeDeProfils.Appearance.FocusedCell.Options.UseForeColor = true;
            this.ListeDeProfils.Appearance.FocusedRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(236)))));
            this.ListeDeProfils.Appearance.FocusedRecord.Options.UseBackColor = true;
            this.ListeDeProfils.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(114)))), ((int)(((byte)(50)))));
            this.ListeDeProfils.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(114)))), ((int)(((byte)(50)))));
            this.ListeDeProfils.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.ListeDeProfils.Appearance.FocusedRow.Options.UseBackColor = true;
            this.ListeDeProfils.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.ListeDeProfils.Appearance.FocusedRow.Options.UseForeColor = true;
            this.ListeDeProfils.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(158)))), ((int)(((byte)(64)))));
            this.ListeDeProfils.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.ListeDeProfils.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.ListeDeProfils.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.ListeDeProfils.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(166)))), ((int)(((byte)(37)))));
            this.ListeDeProfils.Appearance.HorzLine.Options.UseBackColor = true;
            this.ListeDeProfils.Appearance.RecordValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(230)))));
            this.ListeDeProfils.Appearance.RecordValue.ForeColor = System.Drawing.Color.Black;
            this.ListeDeProfils.Appearance.RecordValue.Options.UseBackColor = true;
            this.ListeDeProfils.Appearance.RecordValue.Options.UseForeColor = true;
            this.ListeDeProfils.Appearance.RowHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(193)))), ((int)(((byte)(55)))));
            this.ListeDeProfils.Appearance.RowHeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(193)))), ((int)(((byte)(55)))));
            this.ListeDeProfils.Appearance.RowHeaderPanel.ForeColor = System.Drawing.Color.White;
            this.ListeDeProfils.Appearance.RowHeaderPanel.Options.UseBackColor = true;
            this.ListeDeProfils.Appearance.RowHeaderPanel.Options.UseBorderColor = true;
            this.ListeDeProfils.Appearance.RowHeaderPanel.Options.UseForeColor = true;
            this.ListeDeProfils.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(166)))), ((int)(((byte)(37)))));
            this.ListeDeProfils.Appearance.VertLine.Options.UseBackColor = true;
            this.ListeDeProfils.DataSource = this.dbProfilBindingSource;
            this.ListeDeProfils.FindPanelVisible = true;
            this.ListeDeProfils.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ListeDeProfils.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.ListeDeProfils.Location = new System.Drawing.Point(670, 41);
            this.ListeDeProfils.Name = "ListeDeProfils";
            this.ListeDeProfils.OptionsBehavior.Editable = false;
            this.ListeDeProfils.RecordWidth = 130;
            this.ListeDeProfils.RowHeaderWidth = 70;
            this.ListeDeProfils.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowId,
            this.rowUtilisateur,
            this.rowCompagnie,
            this.rowMotDePasse,
            this.rowDescription});
            this.ListeDeProfils.ShowButtonMode = DevExpress.XtraVerticalGrid.ShowButtonModeEnum.ShowForFocusedRow;
            this.ListeDeProfils.Size = new System.Drawing.Size(342, 352);
            this.ListeDeProfils.TabIndex = 27;
            // 
            // rowId
            // 
            this.rowId.Expanded = false;
            this.rowId.Name = "rowId";
            this.rowId.OptionsRow.AllowMove = false;
            this.rowId.OptionsRow.AllowSize = false;
            this.rowId.Properties.Caption = "Id";
            this.rowId.Properties.FieldName = "Id";
            this.rowId.Visible = false;
            // 
            // rowUtilisateur
            // 
            this.rowUtilisateur.Expanded = false;
            this.rowUtilisateur.Name = "rowUtilisateur";
            this.rowUtilisateur.OptionsRow.AllowMove = false;
            this.rowUtilisateur.OptionsRow.AllowSize = false;
            this.rowUtilisateur.Properties.Caption = "Utilisateur";
            this.rowUtilisateur.Properties.FieldName = "Utilisateur";
            // 
            // rowCompagnie
            // 
            this.rowCompagnie.Expanded = false;
            this.rowCompagnie.Name = "rowCompagnie";
            this.rowCompagnie.OptionsRow.AllowMove = false;
            this.rowCompagnie.OptionsRow.AllowSize = false;
            this.rowCompagnie.Properties.Caption = "Compagnie";
            this.rowCompagnie.Properties.FieldName = "Compagnie";
            // 
            // rowMotDePasse
            // 
            this.rowMotDePasse.Expanded = false;
            this.rowMotDePasse.Name = "rowMotDePasse";
            this.rowMotDePasse.OptionsRow.AllowMove = false;
            this.rowMotDePasse.OptionsRow.AllowSize = false;
            this.rowMotDePasse.Properties.Caption = "Mot De Passe";
            this.rowMotDePasse.Properties.FieldName = "MotDePasse";
            this.rowMotDePasse.Visible = false;
            // 
            // rowDescription
            // 
            this.rowDescription.Expanded = false;
            this.rowDescription.Name = "rowDescription";
            this.rowDescription.OptionsRow.AllowMove = false;
            this.rowDescription.OptionsRow.AllowSize = false;
            this.rowDescription.Properties.Caption = "Description";
            this.rowDescription.Properties.FieldName = "Description";
            // 
            // ProfilsNb
            // 
            this.ProfilsNb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfilsNb.AutoSize = true;
            this.ProfilsNb.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.ProfilsNb.Location = new System.Drawing.Point(832, 397);
            this.ProfilsNb.Name = "ProfilsNb";
            this.ProfilsNb.Size = new System.Drawing.Size(18, 18);
            this.ProfilsNb.TabIndex = 34;
            this.ProfilsNb.Text = "0";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(670, 396);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 18);
            this.label14.TabIndex = 33;
            this.label14.Text = "Profils disponibles :";
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Image = global::EngineeringProjet.Properties.Resources.Next_track;
            this.button7.Location = new System.Drawing.Point(639, 69);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(25, 25);
            this.button7.TabIndex = 20;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Image = global::EngineeringProjet.Properties.Resources.Previous_record;
            this.button6.Location = new System.Drawing.Point(553, 69);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 25);
            this.button6.TabIndex = 19;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // UseProfilBtn
            // 
            this.UseProfilBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UseProfilBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UseProfilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UseProfilBtn.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.UseProfilBtn.ForeColor = System.Drawing.Color.White;
            this.UseProfilBtn.Image = global::EngineeringProjet.Properties.Resources.Use_Card_32;
            this.UseProfilBtn.Location = new System.Drawing.Point(264, 368);
            this.UseProfilBtn.Name = "UseProfilBtn";
            this.UseProfilBtn.Size = new System.Drawing.Size(316, 46);
            this.UseProfilBtn.TabIndex = 5;
            this.UseProfilBtn.Text = "&Utiliser";
            this.UseProfilBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UseProfilBtn.UseVisualStyleBackColor = false;
            this.UseProfilBtn.Click += new System.EventHandler(this.UseProfilBtn_Click);
            this.UseProfilBtn.MouseHover += new System.EventHandler(this.UseProfilBtn_MouseHover);
            // 
            // DeleteProfilBtn
            // 
            this.DeleteProfilBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteProfilBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteProfilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteProfilBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteProfilBtn.Image = global::EngineeringProjet.Properties.Resources.Trash_32;
            this.DeleteProfilBtn.Location = new System.Drawing.Point(205, 368);
            this.DeleteProfilBtn.Name = "DeleteProfilBtn";
            this.DeleteProfilBtn.Size = new System.Drawing.Size(53, 46);
            this.DeleteProfilBtn.TabIndex = 4;
            this.DeleteProfilBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteProfilBtn.UseVisualStyleBackColor = false;
            this.DeleteProfilBtn.Click += new System.EventHandler(this.DeleteProfilBtn_Click);
            // 
            // EditProfilBtn
            // 
            this.EditProfilBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditProfilBtn.BackColor = System.Drawing.Color.Blue;
            this.EditProfilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditProfilBtn.ForeColor = System.Drawing.Color.White;
            this.EditProfilBtn.Image = global::EngineeringProjet.Properties.Resources.edit;
            this.EditProfilBtn.Location = new System.Drawing.Point(141, 368);
            this.EditProfilBtn.Name = "EditProfilBtn";
            this.EditProfilBtn.Size = new System.Drawing.Size(58, 46);
            this.EditProfilBtn.TabIndex = 3;
            this.EditProfilBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditProfilBtn.UseVisualStyleBackColor = false;
            this.EditProfilBtn.Click += new System.EventHandler(this.EditProfilBtn_Click);
            // 
            // AddProfilBtn
            // 
            this.AddProfilBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddProfilBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddProfilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddProfilBtn.ForeColor = System.Drawing.Color.White;
            this.AddProfilBtn.Image = global::EngineeringProjet.Properties.Resources.Add;
            this.AddProfilBtn.Location = new System.Drawing.Point(12, 369);
            this.AddProfilBtn.Name = "AddProfilBtn";
            this.AddProfilBtn.Size = new System.Drawing.Size(58, 46);
            this.AddProfilBtn.TabIndex = 2;
            this.AddProfilBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddProfilBtn.UseVisualStyleBackColor = false;
            this.AddProfilBtn.Click += new System.EventHandler(this.AddProfilBtn_Click);
            // 
            // max
            // 
            this.max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.max.AutoSize = true;
            this.max.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.max.Location = new System.Drawing.Point(969, 396);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(18, 18);
            this.max.TabIndex = 36;
            this.max.Text = "0";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(915, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 18);
            this.label12.TabIndex = 35;
            this.label12.Text = "Max :";
            // 
            // GererLesUtilisateurs
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 426);
            this.Controls.Add(this.max);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ProfilsNb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ListeDeProfils);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.LastPassWordText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.ConfirmPassText);
            this.Controls.Add(this.PassWordText);
            this.Controls.Add(this.CompagnieText);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.IdText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.UseProfilBtn);
            this.Controls.Add(this.DeleteProfilBtn);
            this.Controls.Add(this.EditProfilBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.AddProfilBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GererLesUtilisateurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GererLesUtilisateurs";
            this.Load += new System.EventHandler(this.GererLesUtilisateurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbProfilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeDeProfils)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddProfilBtn;
        private System.Windows.Forms.Button EditProfilBtn;
        private System.Windows.Forms.Button DeleteProfilBtn;
        private System.Windows.Forms.Button UseProfilBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IdText;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.TextBox CompagnieText;
        private System.Windows.Forms.TextBox PassWordText;
        private System.Windows.Forms.TextBox ConfirmPassText;
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LastPassWordText;
        private ProfilDataSet profilDataSet;
        private System.Windows.Forms.BindingSource dbProfilBindingSource;
        private ProfilDataSetTableAdapters.DbProfilTableAdapter dbProfilTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraVerticalGrid.VGridControl ListeDeProfils;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowId;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowUtilisateur;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCompagnie;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowMotDePasse;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDescription;
        private System.Windows.Forms.Label ProfilsNb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label label12;
    }
}