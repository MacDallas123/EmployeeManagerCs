namespace EngineeringProjet
{
    partial class GestionDesProduits
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRule2ColorScale formatConditionRule2ColorScale2 = new DevExpress.XtraEditors.FormatConditionRule2ColorScale();
            this.UserProfil = new System.Windows.Forms.Label();
            this.ProductionDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ProductionId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ProductionCost = new System.Windows.Forms.TextBox();
            this.ProductionName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ProductBindingSouce = new System.Windows.Forms.BindingSource(this.components);
            this.ListeDesProduits = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.ProductionNb = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSouce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeDesProduits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserProfil
            // 
            this.UserProfil.AutoSize = true;
            this.UserProfil.Font = new System.Drawing.Font("Tahoma", 11F);
            this.UserProfil.Location = new System.Drawing.Point(8, 9);
            this.UserProfil.Name = "UserProfil";
            this.UserProfil.Size = new System.Drawing.Size(105, 18);
            this.UserProfil.TabIndex = 55;
            this.UserProfil.Text = "Choisir un profil";
            // 
            // ProductionDescription
            // 
            this.ProductionDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductionDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductionDescription.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.ProductionDescription.Location = new System.Drawing.Point(157, 304);
            this.ProductionDescription.Multiline = true;
            this.ProductionDescription.Name = "ProductionDescription";
            this.ProductionDescription.Size = new System.Drawing.Size(462, 75);
            this.ProductionDescription.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 53;
            this.label2.Text = "Description :";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(2, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 39);
            this.button2.TabIndex = 52;
            this.button2.Text = "Modifier";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProductionId
            // 
            this.ProductionId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductionId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductionId.Enabled = false;
            this.ProductionId.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.ProductionId.Location = new System.Drawing.Point(157, 115);
            this.ProductionId.Name = "ProductionId";
            this.ProductionId.Size = new System.Drawing.Size(202, 23);
            this.ProductionId.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(14, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 18);
            this.label13.TabIndex = 50;
            this.label13.Text = "Id :";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 4;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Snap ITC", 12F);
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(119, 389);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 39);
            this.button4.TabIndex = 49;
            this.button4.Text = "&Ajouter le produit";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(357, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 39);
            this.button3.TabIndex = 48;
            this.button3.Text = "Supprimer";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProductionCost
            // 
            this.ProductionCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductionCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductionCost.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.ProductionCost.Location = new System.Drawing.Point(157, 241);
            this.ProductionCost.Name = "ProductionCost";
            this.ProductionCost.Size = new System.Drawing.Size(462, 23);
            this.ProductionCost.TabIndex = 47;
            // 
            // ProductionName
            // 
            this.ProductionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductionName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.ProductionName.Location = new System.Drawing.Point(157, 178);
            this.ProductionName.Name = "ProductionName";
            this.ProductionName.Size = new System.Drawing.Size(462, 23);
            this.ProductionName.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(14, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 36);
            this.label4.TabIndex = 45;
            this.label4.Text = "Coût minimal du\r\nproduit :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Nom du produit :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 20F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(300, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 32);
            this.label1.TabIndex = 43;
            this.label1.Text = "Gestion des produits";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(923, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 440);
            this.splitter1.TabIndex = 42;
            this.splitter1.TabStop = false;
            // 
            // ListeDesProduits
            // 
            this.ListeDesProduits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListeDesProduits.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ListeDesProduits.Location = new System.Drawing.Point(625, 0);
            this.ListeDesProduits.MainView = this.layoutView1;
            this.ListeDesProduits.Name = "ListeDesProduits";
            this.ListeDesProduits.Size = new System.Drawing.Size(298, 397);
            this.ListeDesProduits.TabIndex = 56;
            this.ListeDesProduits.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.Appearance.Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.layoutView1.Appearance.Card.BackColor2 = System.Drawing.Color.White;
            this.layoutView1.Appearance.Card.Options.UseBackColor = true;
            this.layoutView1.Appearance.CardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.layoutView1.Appearance.CardCaption.Options.UseBackColor = true;
            this.layoutView1.Appearance.FieldCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.layoutView1.Appearance.FieldCaption.ForeColor = System.Drawing.Color.Blue;
            this.layoutView1.Appearance.FieldCaption.Options.UseFont = true;
            this.layoutView1.Appearance.FieldCaption.Options.UseForeColor = true;
            this.layoutView1.Appearance.FocusedCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.layoutView1.Appearance.FocusedCardCaption.BackColor2 = System.Drawing.Color.White;
            this.layoutView1.Appearance.FocusedCardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.layoutView1.Appearance.FocusedCardCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.layoutView1.Appearance.FocusedCardCaption.Options.UseBackColor = true;
            this.layoutView1.Appearance.FocusedCardCaption.Options.UseBorderColor = true;
            this.layoutView1.Appearance.SelectionFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.layoutView1.Appearance.SelectionFrame.BackColor2 = System.Drawing.Color.White;
            this.layoutView1.Appearance.SelectionFrame.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.layoutView1.Appearance.SelectionFrame.Options.UseBackColor = true;
            this.layoutView1.Appearance.SelectionFrame.Options.UseBorderColor = true;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format0";
            gridFormatRule2.Rule = formatConditionRule2ColorScale2;
            this.layoutView1.FormatRules.Add(gridFormatRule2);
            this.layoutView1.GridControl = this.ListeDesProduits;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsBehavior.AutoFocusNewCard = true;
            this.layoutView1.OptionsBehavior.Editable = false;
            this.layoutView1.OptionsBehavior.ReadOnly = true;
            this.layoutView1.OptionsCustomization.ShowGroupCardCaptions = false;
            this.layoutView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel;
            this.layoutView1.PaintStyleName = "Skin";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Name = "layoutViewTemplateCard";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // ProductionNb
            // 
            this.ProductionNb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductionNb.AutoSize = true;
            this.ProductionNb.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.ProductionNb.Location = new System.Drawing.Point(795, 400);
            this.ProductionNb.Name = "ProductionNb";
            this.ProductionNb.Size = new System.Drawing.Size(18, 18);
            this.ProductionNb.TabIndex = 68;
            this.ProductionNb.Text = "0";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(625, 410);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 18);
            this.label14.TabIndex = 67;
            this.label14.Text = "Nombre de produits :";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::EngineeringProjet.Properties.Resources.Microsoft_Excel_2_32;
            this.button5.Location = new System.Drawing.Point(474, 389);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 39);
            this.button5.TabIndex = 69;
            this.button5.Text = "Exporter la base de données";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // max
            // 
            this.max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.max.AutoSize = true;
            this.max.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.max.Location = new System.Drawing.Point(893, 410);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(18, 18);
            this.max.TabIndex = 71;
            this.max.Text = "0";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(839, 410);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 18);
            this.label10.TabIndex = 70;
            this.label10.Text = "Max :";
            // 
            // GestionDesProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 440);
            this.Controls.Add(this.ProductionNb);
            this.Controls.Add(this.max);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ListeDesProduits);
            this.Controls.Add(this.UserProfil);
            this.Controls.Add(this.ProductionDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ProductionId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ProductionCost);
            this.Controls.Add(this.ProductionName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Name = "GestionDesProduits";
            this.Text = "GestionDesProduits";
            this.Load += new System.EventHandler(this.GestionDesProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSouce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeDesProduits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserProfil;
        private System.Windows.Forms.TextBox ProductionDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ProductionId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox ProductionCost;
        private System.Windows.Forms.TextBox ProductionName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.BindingSource ProductBindingSouce;
        private DevExpress.XtraGrid.GridControl ListeDesProduits;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private System.Windows.Forms.Label ProductionNb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label label10;
    }
}