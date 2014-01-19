namespace TdB_Odyssee.UserControlLibrary
{
    partial class ucAdminConsignesExecute
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.NestedRadGridView = new Telerik.WinControls.UI.MasterGridViewTemplate();
            this.rmcnxConsignes = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.tDBCONSIGNEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTdbOdyssee = new TdB_Odyssee.Dal.dsTdbOdyssee();
            this.lblConsigne = new System.Windows.Forms.Label();
            this.lblBasesList = new System.Windows.Forms.Label();
            this.tDB_CONSIGNETableAdapter = new TdB_Odyssee.Dal.dsTdbOdysseeTableAdapters.TDB_CONSIGNETableAdapter();
            this.lbListeBases = new System.Windows.Forms.ListBox();
            this.getBaseListFromApplicationSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getBaseListFromApplicationSourceTableAdapter = new TdB_Odyssee.Dal.dsTdbOdysseeTableAdapters.getBaseListFromApplicationSourceTableAdapter();
            this.btnExecute = new System.Windows.Forms.Button();
            this.gbResultat = new System.Windows.Forms.GroupBox();
            this.tbResultat = new System.Windows.Forms.TextBox();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.cbT0 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NestedRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmcnxConsignes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmcnxConsignes.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmcnxConsignes.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDBCONSIGNEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTdbOdyssee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getBaseListFromApplicationSourceBindingSource)).BeginInit();
            this.gbResultat.SuspendLayout();
            this.SuspendLayout();
            // 
            // NestedRadGridView
            // 
            this.NestedRadGridView.AllowAddNewRow = false;
            this.NestedRadGridView.AllowCellContextMenu = false;
            this.NestedRadGridView.AllowColumnChooser = false;
            this.NestedRadGridView.EnableGrouping = false;
            this.NestedRadGridView.ShowFilteringRow = false;
            // 
            // rmcnxConsignes
            // 
            this.rmcnxConsignes.DataSource = this.tDBCONSIGNEBindingSource;
            this.rmcnxConsignes.DisplayMember = "CODE_CONSIGNE";
            // 
            // rmcnxConsignes.NestedRadGridView
            // 
            this.rmcnxConsignes.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.rmcnxConsignes.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmcnxConsignes.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rmcnxConsignes.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.rmcnxConsignes.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.rmcnxConsignes.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.rmcnxConsignes.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.rmcnxConsignes.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "ID_CONSIGNE";
            gridViewDecimalColumn1.HeaderText = "ID_CONSIGNE";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID_CONSIGNE";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.FieldName = "CODE_CONSIGNE";
            gridViewTextBoxColumn1.HeaderText = "Code Consigne";
            gridViewTextBoxColumn1.Name = "CODE_CONSIGNE";
            gridViewTextBoxColumn2.FieldName = "DESC_CONSIGNE";
            gridViewTextBoxColumn2.HeaderText = "Desc Consigne";
            gridViewTextBoxColumn2.Name = "DESC_CONSIGNE";
            gridViewTextBoxColumn3.FieldName = "APPLICATION_SOURCE";
            gridViewTextBoxColumn3.HeaderText = "Application Source";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "APPLICATION_SOURCE";
            this.rmcnxConsignes.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.rmcnxConsignes.EditorControl.MasterTemplate.DataSource = this.tDBCONSIGNEBindingSource;
            this.rmcnxConsignes.EditorControl.MasterTemplate.EnableGrouping = false;
            this.rmcnxConsignes.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.rmcnxConsignes.EditorControl.Name = "NestedRadGridView";
            this.rmcnxConsignes.EditorControl.ReadOnly = true;
            this.rmcnxConsignes.EditorControl.ShowGroupPanel = false;
            this.rmcnxConsignes.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.rmcnxConsignes.EditorControl.TabIndex = 0;
            this.rmcnxConsignes.Location = new System.Drawing.Point(76, 12);
            this.rmcnxConsignes.Name = "rmcnxConsignes";
            this.rmcnxConsignes.Size = new System.Drawing.Size(114, 20);
            this.rmcnxConsignes.TabIndex = 0;
            this.rmcnxConsignes.TabStop = false;
            this.rmcnxConsignes.ThemeName = "Office2010Black";
            this.rmcnxConsignes.ValueMember = "ID_CONSIGNE";
            this.rmcnxConsignes.SelectedIndexChanged += new System.EventHandler(this.rmcnxConsignes_SelectedIndexChanged);
            // 
            // tDBCONSIGNEBindingSource
            // 
            this.tDBCONSIGNEBindingSource.DataMember = "TDB_CONSIGNE";
            this.tDBCONSIGNEBindingSource.DataSource = this.dsTdbOdyssee;
            // 
            // dsTdbOdyssee
            // 
            this.dsTdbOdyssee.DataSetName = "dsTdbOdyssee";
            this.dsTdbOdyssee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblConsigne
            // 
            this.lblConsigne.AutoSize = true;
            this.lblConsigne.BackColor = System.Drawing.Color.Transparent;
            this.lblConsigne.ForeColor = System.Drawing.Color.White;
            this.lblConsigne.Location = new System.Drawing.Point(18, 16);
            this.lblConsigne.Name = "lblConsigne";
            this.lblConsigne.Size = new System.Drawing.Size(51, 13);
            this.lblConsigne.TabIndex = 1;
            this.lblConsigne.Text = "Consigne";
            // 
            // lblBasesList
            // 
            this.lblBasesList.AutoSize = true;
            this.lblBasesList.BackColor = System.Drawing.Color.Transparent;
            this.lblBasesList.ForeColor = System.Drawing.Color.White;
            this.lblBasesList.Location = new System.Drawing.Point(18, 44);
            this.lblBasesList.Name = "lblBasesList";
            this.lblBasesList.Size = new System.Drawing.Size(36, 13);
            this.lblBasesList.TabIndex = 2;
            this.lblBasesList.Text = "Bases";
            // 
            // tDB_CONSIGNETableAdapter
            // 
            this.tDB_CONSIGNETableAdapter.ClearBeforeFill = true;
            // 
            // lbListeBases
            // 
            this.lbListeBases.DataSource = this.getBaseListFromApplicationSourceBindingSource;
            this.lbListeBases.DisplayMember = "BaseName";
            this.lbListeBases.FormattingEnabled = true;
            this.lbListeBases.Location = new System.Drawing.Point(76, 44);
            this.lbListeBases.Name = "lbListeBases";
            this.lbListeBases.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbListeBases.Size = new System.Drawing.Size(217, 472);
            this.lbListeBases.TabIndex = 3;
            this.lbListeBases.ValueMember = "BaseName";
            // 
            // getBaseListFromApplicationSourceBindingSource
            // 
            this.getBaseListFromApplicationSourceBindingSource.DataMember = "getBaseListFromApplicationSource";
            this.getBaseListFromApplicationSourceBindingSource.DataSource = this.dsTdbOdyssee;
            // 
            // getBaseListFromApplicationSourceTableAdapter
            // 
            this.getBaseListFromApplicationSourceTableAdapter.ClearBeforeFill = true;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(232, 11);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(61, 23);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "Exécuter";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // gbResultat
            // 
            this.gbResultat.BackColor = System.Drawing.Color.Transparent;
            this.gbResultat.Controls.Add(this.tbResultat);
            this.gbResultat.ForeColor = System.Drawing.Color.White;
            this.gbResultat.Location = new System.Drawing.Point(299, 12);
            this.gbResultat.Name = "gbResultat";
            this.gbResultat.Size = new System.Drawing.Size(677, 504);
            this.gbResultat.TabIndex = 5;
            this.gbResultat.TabStop = false;
            this.gbResultat.Text = "Résultat par Base";
            // 
            // tbResultat
            // 
            this.tbResultat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbResultat.Location = new System.Drawing.Point(3, 16);
            this.tbResultat.Multiline = true;
            this.tbResultat.Name = "tbResultat";
            this.tbResultat.Size = new System.Drawing.Size(671, 485);
            this.tbResultat.TabIndex = 0;
            // 
            // cbT0
            // 
            this.cbT0.AutoSize = true;
            this.cbT0.BackColor = System.Drawing.Color.Transparent;
            this.cbT0.ForeColor = System.Drawing.Color.White;
            this.cbT0.Location = new System.Drawing.Point(194, 15);
            this.cbT0.Name = "cbT0";
            this.cbT0.Size = new System.Drawing.Size(39, 17);
            this.cbT0.TabIndex = 6;
            this.cbT0.Text = "T0";
            this.cbT0.UseVisualStyleBackColor = false;
            // 
            // ucAdminConsignesExecute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TdB_Odyssee.Properties.Resources.FOND;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.cbT0);
            this.Controls.Add(this.gbResultat);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.lbListeBases);
            this.Controls.Add(this.lblBasesList);
            this.Controls.Add(this.lblConsigne);
            this.Controls.Add(this.rmcnxConsignes);
            this.DoubleBuffered = true;
            this.Name = "ucAdminConsignesExecute";
            this.Size = new System.Drawing.Size(1008, 554);
            ((System.ComponentModel.ISupportInitialize)(this.NestedRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmcnxConsignes.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmcnxConsignes.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmcnxConsignes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDBCONSIGNEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTdbOdyssee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getBaseListFromApplicationSourceBindingSource)).EndInit();
            this.gbResultat.ResumeLayout(false);
            this.gbResultat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.MasterGridViewTemplate NestedRadGridView;
        private Telerik.WinControls.UI.RadMultiColumnComboBox rmcnxConsignes;
        private System.Windows.Forms.BindingSource tDBCONSIGNEBindingSource;
        private Dal.dsTdbOdyssee dsTdbOdyssee;
        private System.Windows.Forms.Label lblConsigne;
        private Dal.dsTdbOdysseeTableAdapters.TDB_CONSIGNETableAdapter tDB_CONSIGNETableAdapter;
        private System.Windows.Forms.Label lblBasesList;
        private System.Windows.Forms.ListBox lbListeBases;
        private System.Windows.Forms.BindingSource getBaseListFromApplicationSourceBindingSource;
        private Dal.dsTdbOdysseeTableAdapters.getBaseListFromApplicationSourceTableAdapter getBaseListFromApplicationSourceTableAdapter;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.GroupBox gbResultat;
        private System.Windows.Forms.TextBox tbResultat;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private System.Windows.Forms.CheckBox cbT0;

    }
}
