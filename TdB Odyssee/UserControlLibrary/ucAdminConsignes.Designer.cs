namespace TdB_Odyssee.UserControlLibrary
{
    partial class ucAdminConsignes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            this.lblListeConsignes = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnNouvelleConsigne = new System.Windows.Forms.Button();
            this.rmcbxListeConsignes = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.dsTdbOdyssee = new TdB_Odyssee.Dal.dsTdbOdyssee();
            this.tbDescConsigne = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPriorite = new System.Windows.Forms.ComboBox();
            this.tDBPRIORITEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numCoutUnitaire = new System.Windows.Forms.NumericUpDown();
            this.lblPriorite = new System.Windows.Forms.Label();
            this.lblCoutUnitaire = new System.Windows.Forms.Label();
            this.tbCodeConsigne = new System.Windows.Forms.TextBox();
            this.lblNomConsigne = new System.Windows.Forms.Label();
            this.gbRequeteEditor = new System.Windows.Forms.GroupBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.pnlConsignes = new System.Windows.Forms.Panel();
            this.tbConsignes = new System.Windows.Forms.TextBox();
            this.rtbQuery = new Telerik.WinControls.UI.RadTextBoxControl();
            this.gbBaseSource = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbEpsydre = new System.Windows.Forms.RadioButton();
            this.rbCyclade = new System.Windows.Forms.RadioButton();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.tDBCONSIGNEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tDB_CONSIGNETableAdapter = new TdB_Odyssee.Dal.dsTdbOdysseeTableAdapters.TDB_CONSIGNETableAdapter();
            this.tDB_PRIORITETableAdapter = new TdB_Odyssee.Dal.dsTdbOdysseeTableAdapters.TDB_PRIORITETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rmcbxListeConsignes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmcbxListeConsignes.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmcbxListeConsignes.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTdbOdyssee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDBPRIORITEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoutUnitaire)).BeginInit();
            this.gbRequeteEditor.SuspendLayout();
            this.pnlConsignes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtbQuery)).BeginInit();
            this.gbBaseSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tDBCONSIGNEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListeConsignes
            // 
            this.lblListeConsignes.AutoSize = true;
            this.lblListeConsignes.BackColor = System.Drawing.Color.Transparent;
            this.lblListeConsignes.ForeColor = System.Drawing.Color.White;
            this.lblListeConsignes.Location = new System.Drawing.Point(9, 33);
            this.lblListeConsignes.Name = "lblListeConsignes";
            this.lblListeConsignes.Size = new System.Drawing.Size(56, 13);
            this.lblListeConsignes.TabIndex = 1;
            this.lblListeConsignes.Text = "Consignes";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::TdB_Odyssee.Properties.Resources.FOND;
            this.splitContainer1.Panel1.Controls.Add(this.btnNouvelleConsigne);
            this.splitContainer1.Panel1.Controls.Add(this.lblListeConsignes);
            this.splitContainer1.Panel1.Controls.Add(this.rmcbxListeConsignes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::TdB_Odyssee.Properties.Resources.FOND;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.tbDescConsigne);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.cbPriorite);
            this.splitContainer1.Panel2.Controls.Add(this.numCoutUnitaire);
            this.splitContainer1.Panel2.Controls.Add(this.lblPriorite);
            this.splitContainer1.Panel2.Controls.Add(this.lblCoutUnitaire);
            this.splitContainer1.Panel2.Controls.Add(this.tbCodeConsigne);
            this.splitContainer1.Panel2.Controls.Add(this.lblNomConsigne);
            this.splitContainer1.Panel2.Controls.Add(this.gbRequeteEditor);
            this.splitContainer1.Panel2.Controls.Add(this.gbBaseSource);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 554);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnNouvelleConsigne
            // 
            this.btnNouvelleConsigne.Location = new System.Drawing.Point(6, 59);
            this.btnNouvelleConsigne.Name = "btnNouvelleConsigne";
            this.btnNouvelleConsigne.Size = new System.Drawing.Size(194, 23);
            this.btnNouvelleConsigne.TabIndex = 2;
            this.btnNouvelleConsigne.Text = "Nouvelle Consigne";
            this.btnNouvelleConsigne.UseVisualStyleBackColor = true;
            this.btnNouvelleConsigne.Click += new System.EventHandler(this.btnNouvelleConsigne_Click);
            // 
            // rmcbxListeConsignes
            // 
            this.rmcbxListeConsignes.DataSource = this.dsTdbOdyssee;
            // 
            // rmcbxListeConsignes.NestedRadGridView
            // 
            this.rmcbxListeConsignes.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.rmcbxListeConsignes.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.rmcbxListeConsignes.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rmcbxListeConsignes.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rmcbxListeConsignes.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rmcbxListeConsignes.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.rmcbxListeConsignes.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.rmcbxListeConsignes.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.rmcbxListeConsignes.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.rmcbxListeConsignes.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID_CONSIGNE";
            gridViewDecimalColumn1.HeaderText = "ID_CONSIGNE";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID_CONSIGNE";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ID_PRIORITE";
            gridViewDecimalColumn2.HeaderText = "ID_PRIORITE";
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "ID_PRIORITE";
            gridViewDecimalColumn2.Width = 111;
            gridViewTextBoxColumn1.FieldName = "CODE_CONSIGNE";
            gridViewTextBoxColumn1.HeaderText = "Code Consigne";
            gridViewTextBoxColumn1.Name = "CODE_CONSIGNE";
            gridViewTextBoxColumn2.FieldName = "DESC_CONSIGNE";
            gridViewTextBoxColumn2.HeaderText = "Desc Consigne";
            gridViewTextBoxColumn2.Name = "DESC_CONSIGNE";
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "APPLICATION_SOURCE";
            gridViewTextBoxColumn3.HeaderText = "Application Source";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "APPLICATION_SOURCE";
            gridViewTextBoxColumn3.Width = 110;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "REQUETE_CONSIGNE";
            gridViewTextBoxColumn4.HeaderText = "Requete";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "REQUETE_CONSIGNE";
            gridViewTextBoxColumn4.Width = 201;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "COUT_CORRECTION";
            gridViewDecimalColumn3.HeaderText = "Cout unitaire";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "COUT_CORRECTION";
            gridViewDecimalColumn3.Width = 145;
            this.rmcbxListeConsignes.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn3});
            this.rmcbxListeConsignes.EditorControl.MasterTemplate.DataMember = "TDB_CONSIGNE";
            this.rmcbxListeConsignes.EditorControl.MasterTemplate.DataSource = this.dsTdbOdyssee;
            this.rmcbxListeConsignes.EditorControl.MasterTemplate.EnableFiltering = true;
            this.rmcbxListeConsignes.EditorControl.MasterTemplate.EnableGrouping = false;
            this.rmcbxListeConsignes.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.rmcbxListeConsignes.EditorControl.Name = "NestedRadGridView";
            this.rmcbxListeConsignes.EditorControl.ReadOnly = true;
            this.rmcbxListeConsignes.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rmcbxListeConsignes.EditorControl.ShowGroupPanel = false;
            this.rmcbxListeConsignes.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.rmcbxListeConsignes.EditorControl.TabIndex = 0;
            this.rmcbxListeConsignes.Location = new System.Drawing.Point(71, 30);
            this.rmcbxListeConsignes.Name = "rmcbxListeConsignes";
            this.rmcbxListeConsignes.Size = new System.Drawing.Size(129, 20);
            this.rmcbxListeConsignes.TabIndex = 0;
            this.rmcbxListeConsignes.TabStop = false;
            this.rmcbxListeConsignes.ThemeName = "Office2010Black";
            this.rmcbxListeConsignes.SelectedIndexChanged += new System.EventHandler(this.rmcbxListeConsignes_SelectedIndexChanged);
            // 
            // dsTdbOdyssee
            // 
            this.dsTdbOdyssee.DataSetName = "dsTdbOdyssee";
            this.dsTdbOdyssee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbDescConsigne
            // 
            this.tbDescConsigne.Location = new System.Drawing.Point(130, 54);
            this.tbDescConsigne.Name = "tbDescConsigne";
            this.tbDescConsigne.Size = new System.Drawing.Size(430, 20);
            this.tbDescConsigne.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Description";
            // 
            // cbPriorite
            // 
            this.cbPriorite.DataSource = this.tDBPRIORITEBindingSource;
            this.cbPriorite.DisplayMember = "DESCRIPTION_PRIORITE";
            this.cbPriorite.FormattingEnabled = true;
            this.cbPriorite.Location = new System.Drawing.Point(130, 105);
            this.cbPriorite.Name = "cbPriorite";
            this.cbPriorite.Size = new System.Drawing.Size(430, 21);
            this.cbPriorite.TabIndex = 5;
            this.cbPriorite.ValueMember = "ID_PRIORITE";
            // 
            // tDBPRIORITEBindingSource
            // 
            this.tDBPRIORITEBindingSource.DataMember = "TDB_PRIORITE";
            this.tDBPRIORITEBindingSource.DataSource = this.dsTdbOdyssee;
            // 
            // numCoutUnitaire
            // 
            this.numCoutUnitaire.Location = new System.Drawing.Point(130, 79);
            this.numCoutUnitaire.Name = "numCoutUnitaire";
            this.numCoutUnitaire.Size = new System.Drawing.Size(430, 20);
            this.numCoutUnitaire.TabIndex = 4;
            // 
            // lblPriorite
            // 
            this.lblPriorite.AutoSize = true;
            this.lblPriorite.BackColor = System.Drawing.Color.Transparent;
            this.lblPriorite.ForeColor = System.Drawing.Color.White;
            this.lblPriorite.Location = new System.Drawing.Point(11, 108);
            this.lblPriorite.Name = "lblPriorite";
            this.lblPriorite.Size = new System.Drawing.Size(39, 13);
            this.lblPriorite.TabIndex = 2;
            this.lblPriorite.Text = "Priorité";
            // 
            // lblCoutUnitaire
            // 
            this.lblCoutUnitaire.AutoSize = true;
            this.lblCoutUnitaire.BackColor = System.Drawing.Color.Transparent;
            this.lblCoutUnitaire.ForeColor = System.Drawing.Color.White;
            this.lblCoutUnitaire.Location = new System.Drawing.Point(11, 82);
            this.lblCoutUnitaire.Name = "lblCoutUnitaire";
            this.lblCoutUnitaire.Size = new System.Drawing.Size(108, 13);
            this.lblCoutUnitaire.TabIndex = 2;
            this.lblCoutUnitaire.Text = "Cout d\'une correction";
            // 
            // tbCodeConsigne
            // 
            this.tbCodeConsigne.Location = new System.Drawing.Point(130, 30);
            this.tbCodeConsigne.Name = "tbCodeConsigne";
            this.tbCodeConsigne.Size = new System.Drawing.Size(430, 20);
            this.tbCodeConsigne.TabIndex = 3;
            // 
            // lblNomConsigne
            // 
            this.lblNomConsigne.AutoSize = true;
            this.lblNomConsigne.BackColor = System.Drawing.Color.Transparent;
            this.lblNomConsigne.ForeColor = System.Drawing.Color.White;
            this.lblNomConsigne.Location = new System.Drawing.Point(11, 33);
            this.lblNomConsigne.Name = "lblNomConsigne";
            this.lblNomConsigne.Size = new System.Drawing.Size(104, 13);
            this.lblNomConsigne.TabIndex = 2;
            this.lblNomConsigne.Text = "Code de la consigne";
            // 
            // gbRequeteEditor
            // 
            this.gbRequeteEditor.BackColor = System.Drawing.Color.Transparent;
            this.gbRequeteEditor.Controls.Add(this.btnSupprimer);
            this.gbRequeteEditor.Controls.Add(this.btnEnregistrer);
            this.gbRequeteEditor.Controls.Add(this.pnlConsignes);
            this.gbRequeteEditor.Controls.Add(this.rtbQuery);
            this.gbRequeteEditor.ForeColor = System.Drawing.Color.White;
            this.gbRequeteEditor.Location = new System.Drawing.Point(14, 131);
            this.gbRequeteEditor.Name = "gbRequeteEditor";
            this.gbRequeteEditor.Size = new System.Drawing.Size(752, 420);
            this.gbRequeteEditor.TabIndex = 1;
            this.gbRequeteEditor.TabStop = false;
            this.gbRequeteEditor.Text = "Requête";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.ForeColor = System.Drawing.Color.Black;
            this.btnSupprimer.Location = new System.Drawing.Point(101, 390);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.ForeColor = System.Drawing.Color.Black;
            this.btnEnregistrer.Location = new System.Drawing.Point(20, 390);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 2;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // pnlConsignes
            // 
            this.pnlConsignes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlConsignes.Controls.Add(this.tbConsignes);
            this.pnlConsignes.Location = new System.Drawing.Point(20, 19);
            this.pnlConsignes.Name = "pnlConsignes";
            this.pnlConsignes.Size = new System.Drawing.Size(714, 111);
            this.pnlConsignes.TabIndex = 1;
            // 
            // tbConsignes
            // 
            this.tbConsignes.BackColor = System.Drawing.SystemColors.Control;
            this.tbConsignes.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbConsignes.Location = new System.Drawing.Point(0, 0);
            this.tbConsignes.Multiline = true;
            this.tbConsignes.Name = "tbConsignes";
            this.tbConsignes.ReadOnly = true;
            this.tbConsignes.Size = new System.Drawing.Size(710, 109);
            this.tbConsignes.TabIndex = 0;
            // 
            // rtbQuery
            // 
            this.rtbQuery.Location = new System.Drawing.Point(20, 136);
            this.rtbQuery.Multiline = true;
            this.rtbQuery.Name = "rtbQuery";
            this.rtbQuery.Size = new System.Drawing.Size(714, 248);
            this.rtbQuery.TabIndex = 0;
            // 
            // gbBaseSource
            // 
            this.gbBaseSource.BackColor = System.Drawing.Color.Transparent;
            this.gbBaseSource.Controls.Add(this.radioButton1);
            this.gbBaseSource.Controls.Add(this.rbEpsydre);
            this.gbBaseSource.Controls.Add(this.rbCyclade);
            this.gbBaseSource.ForeColor = System.Drawing.Color.White;
            this.gbBaseSource.Location = new System.Drawing.Point(566, 21);
            this.gbBaseSource.Name = "gbBaseSource";
            this.gbBaseSource.Size = new System.Drawing.Size(200, 105);
            this.gbBaseSource.TabIndex = 0;
            this.gbBaseSource.TabStop = false;
            this.gbBaseSource.Text = "Source";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(34, 69);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "REPCLI";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbEpsydre
            // 
            this.rbEpsydre.AutoSize = true;
            this.rbEpsydre.Location = new System.Drawing.Point(34, 46);
            this.rbEpsydre.Name = "rbEpsydre";
            this.rbEpsydre.Size = new System.Drawing.Size(76, 17);
            this.rbEpsydre.TabIndex = 1;
            this.rbEpsydre.TabStop = true;
            this.rbEpsydre.Text = "EPSYDRE";
            this.rbEpsydre.UseVisualStyleBackColor = true;
            // 
            // rbCyclade
            // 
            this.rbCyclade.AutoSize = true;
            this.rbCyclade.Location = new System.Drawing.Point(34, 23);
            this.rbCyclade.Name = "rbCyclade";
            this.rbCyclade.Size = new System.Drawing.Size(81, 17);
            this.rbCyclade.TabIndex = 0;
            this.rbCyclade.TabStop = true;
            this.rbCyclade.Text = "CYCLADES";
            this.rbCyclade.UseVisualStyleBackColor = true;
            // 
            // tDBCONSIGNEBindingSource
            // 
            this.tDBCONSIGNEBindingSource.DataMember = "TDB_CONSIGNE";
            this.tDBCONSIGNEBindingSource.DataSource = this.dsTdbOdyssee;
            // 
            // tDB_CONSIGNETableAdapter
            // 
            this.tDB_CONSIGNETableAdapter.ClearBeforeFill = true;
            // 
            // tDB_PRIORITETableAdapter
            // 
            this.tDB_PRIORITETableAdapter.ClearBeforeFill = true;
            // 
            // ucAdminConsignes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucAdminConsignes";
            this.Size = new System.Drawing.Size(1008, 554);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rmcbxListeConsignes.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmcbxListeConsignes.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmcbxListeConsignes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTdbOdyssee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDBPRIORITEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoutUnitaire)).EndInit();
            this.gbRequeteEditor.ResumeLayout(false);
            this.pnlConsignes.ResumeLayout(false);
            this.pnlConsignes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtbQuery)).EndInit();
            this.gbBaseSource.ResumeLayout(false);
            this.gbBaseSource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tDBCONSIGNEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tDBCONSIGNEBindingSource;
        private Dal.dsTdbOdyssee dsTdbOdyssee;
        private Dal.dsTdbOdysseeTableAdapters.TDB_CONSIGNETableAdapter tDB_CONSIGNETableAdapter;
        private Telerik.WinControls.UI.RadMultiColumnComboBox rmcbxListeConsignes;
        private System.Windows.Forms.Label lblListeConsignes;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbRequeteEditor;
        private System.Windows.Forms.GroupBox gbBaseSource;
        private System.Windows.Forms.Panel pnlConsignes;
        private System.Windows.Forms.TextBox tbConsignes;
        private Telerik.WinControls.UI.RadTextBoxControl rtbQuery;
        private System.Windows.Forms.RadioButton rbEpsydre;
        private System.Windows.Forms.RadioButton rbCyclade;
        private System.Windows.Forms.TextBox tbCodeConsigne;
        private System.Windows.Forms.Label lblNomConsigne;
        private System.Windows.Forms.NumericUpDown numCoutUnitaire;
        private System.Windows.Forms.Label lblCoutUnitaire;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnNouvelleConsigne;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private System.Windows.Forms.ComboBox cbPriorite;
        private System.Windows.Forms.BindingSource tDBPRIORITEBindingSource;
        private System.Windows.Forms.Label lblPriorite;
        private Dal.dsTdbOdysseeTableAdapters.TDB_PRIORITETableAdapter tDB_PRIORITETableAdapter;
        private System.Windows.Forms.TextBox tbDescConsigne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;

    }
}
