namespace TdB_Odyssee.UserControlLibrary
{
    partial class ucAdminCommunes
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.ConditionalFormattingObject conditionalFormattingObject1 = new Telerik.WinControls.UI.ConditionalFormattingObject();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn2 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            this.tDBVAGUEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTdbOdyssee = new TdB_Odyssee.Dal.dsTdbOdyssee();
            this.tDBAGENCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CommuneRadGV = new Telerik.WinControls.UI.RadGridView();
            this.tDBCOMMUNESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tDB_VAGUETableAdapter = new TdB_Odyssee.Dal.dsTdbOdysseeTableAdapters.TDB_VAGUETableAdapter();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.btnImpCyc = new System.Windows.Forms.Button();
            this.btnImpEps = new System.Windows.Forms.Button();
            this.tDB_COMMUNESTableAdapter = new TdB_Odyssee.Dal.dsTdbOdysseeTableAdapters.TDB_COMMUNESTableAdapter();
            this.tDB_AGENCETableAdapter = new TdB_Odyssee.Dal.dsTdbOdysseeTableAdapters.TDB_AGENCETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tDBVAGUEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTdbOdyssee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDBAGENCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommuneRadGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommuneRadGV.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDBCOMMUNESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tDBVAGUEBindingSource
            // 
            this.tDBVAGUEBindingSource.DataMember = "TDB_VAGUE";
            this.tDBVAGUEBindingSource.DataSource = this.dsTdbOdyssee;
            // 
            // dsTdbOdyssee
            // 
            this.dsTdbOdyssee.DataSetName = "dsTdbOdyssee";
            this.dsTdbOdyssee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tDBAGENCEBindingSource
            // 
            this.tDBAGENCEBindingSource.DataMember = "TDB_AGENCE";
            this.tDBAGENCEBindingSource.DataSource = this.dsTdbOdyssee;
            // 
            // CommuneRadGV
            // 
            this.CommuneRadGV.BackColor = System.Drawing.Color.Transparent;
            this.CommuneRadGV.Cursor = System.Windows.Forms.Cursors.Default;
            this.CommuneRadGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CommuneRadGV.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.CommuneRadGV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CommuneRadGV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CommuneRadGV.Location = new System.Drawing.Point(0, 49);
            // 
            // CommuneRadGV
            // 
            this.CommuneRadGV.MasterTemplate.AllowColumnChooser = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "BASE_SOURCE";
            gridViewTextBoxColumn1.HeaderText = "Source";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "BASE_SOURCE";
            gridViewTextBoxColumn1.Width = 69;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID_COMMUNE";
            gridViewDecimalColumn1.HeaderText = "ID_COMMUNE";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID_COMMUNE";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewTextBoxColumn2.DataType = typeof(int);
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "ID_AGENCE";
            gridViewTextBoxColumn2.HeaderText = "ID_AGENCE";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "ID_AGENCE";
            gridViewTextBoxColumn2.Width = 66;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "NUM_BASE";
            gridViewTextBoxColumn3.HeaderText = "Base / Firme";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "NUM_BASE";
            gridViewTextBoxColumn3.Width = 120;
            conditionalFormattingObject1.ApplyToRow = true;
            conditionalFormattingObject1.CellBackColor = System.Drawing.Color.Empty;
            conditionalFormattingObject1.CellForeColor = System.Drawing.Color.Empty;
            conditionalFormattingObject1.ConditionType = Telerik.WinControls.UI.ConditionTypes.NotEqual;
            conditionalFormattingObject1.Name = "lineColor";
            conditionalFormattingObject1.RowBackColor = System.Drawing.Color.Beige;
            conditionalFormattingObject1.RowForeColor = System.Drawing.Color.Empty;
            conditionalFormattingObject1.TValue1 = "-1";
            gridViewTextBoxColumn4.ConditionalFormattingObjectList.Add(conditionalFormattingObject1);
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "CODE_COMMUNE";
            gridViewTextBoxColumn4.HeaderText = "Code";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "CODE_COMMUNE";
            gridViewTextBoxColumn4.Width = 100;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "NOM_COMMUNE";
            gridViewTextBoxColumn5.HeaderText = "Commune";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "NOM_COMMUNE";
            gridViewTextBoxColumn5.Width = 300;
            gridViewComboBoxColumn1.DataSource = this.tDBVAGUEBindingSource;
            gridViewComboBoxColumn1.DataType = typeof(int);
            gridViewComboBoxColumn1.DisplayMember = "NOM_VAGUE";
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.FieldName = "ID_VAGUE";
            gridViewComboBoxColumn1.HeaderText = "Vague";
            gridViewComboBoxColumn1.Name = "cbxVague";
            gridViewComboBoxColumn1.ValueMember = "ID_VAGUE";
            gridViewComboBoxColumn1.Width = 200;
            gridViewComboBoxColumn2.DataSource = this.tDBAGENCEBindingSource;
            gridViewComboBoxColumn2.DataType = typeof(int);
            gridViewComboBoxColumn2.DisplayMember = "NOM_AGENCE";
            gridViewComboBoxColumn2.EnableExpressionEditor = false;
            gridViewComboBoxColumn2.FieldName = "ID_AGENCE";
            gridViewComboBoxColumn2.HeaderText = "Agence";
            gridViewComboBoxColumn2.Name = "Agence";
            gridViewComboBoxColumn2.ValueMember = "ID_AGENCE";
            gridViewComboBoxColumn2.Width = 200;
            this.CommuneRadGV.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDecimalColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewComboBoxColumn1,
            gridViewComboBoxColumn2});
            this.CommuneRadGV.MasterTemplate.DataSource = this.tDBCOMMUNESBindingSource;
            this.CommuneRadGV.MasterTemplate.EnableFiltering = true;
            this.CommuneRadGV.MasterTemplate.MultiSelect = true;
            this.CommuneRadGV.Name = "CommuneRadGV";
            this.CommuneRadGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CommuneRadGV.Size = new System.Drawing.Size(1008, 505);
            this.CommuneRadGV.TabIndex = 0;
            this.CommuneRadGV.Text = "radGridView1";
            this.CommuneRadGV.ThemeName = "Office2010Black";
            this.CommuneRadGV.UserAddedRow += new Telerik.WinControls.UI.GridViewRowEventHandler(this.radGridView1_UserAddedRow);
            this.CommuneRadGV.UserDeletingRow += new Telerik.WinControls.UI.GridViewRowCancelEventHandler(this.CommuneRadGV_UserDeletingRow);
            this.CommuneRadGV.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellValueChanged);
            // 
            // tDBCOMMUNESBindingSource
            // 
            this.tDBCOMMUNESBindingSource.DataMember = "TDB_COMMUNES";
            this.tDBCOMMUNESBindingSource.DataSource = this.dsTdbOdyssee;
            // 
            // tDB_VAGUETableAdapter
            // 
            this.tDB_VAGUETableAdapter.ClearBeforeFill = true;
            // 
            // btnImpCyc
            // 
            this.btnImpCyc.Location = new System.Drawing.Point(44, 20);
            this.btnImpCyc.Name = "btnImpCyc";
            this.btnImpCyc.Size = new System.Drawing.Size(231, 23);
            this.btnImpCyc.TabIndex = 3;
            this.btnImpCyc.Text = "Import des communes Cyclades";
            this.btnImpCyc.UseVisualStyleBackColor = true;
            this.btnImpCyc.Click += new System.EventHandler(this.btnImpCyc_Click);
            // 
            // btnImpEps
            // 
            this.btnImpEps.Location = new System.Drawing.Point(720, 20);
            this.btnImpEps.Name = "btnImpEps";
            this.btnImpEps.Size = new System.Drawing.Size(231, 23);
            this.btnImpEps.TabIndex = 4;
            this.btnImpEps.Text = "Import des communes Epsydre";
            this.btnImpEps.UseVisualStyleBackColor = true;
            // 
            // tDB_COMMUNESTableAdapter
            // 
            this.tDB_COMMUNESTableAdapter.ClearBeforeFill = true;
            // 
            // tDB_AGENCETableAdapter
            // 
            this.tDB_AGENCETableAdapter.ClearBeforeFill = true;
            // 
            // ucAdminCommunes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TdB_Odyssee.Properties.Resources.FOND;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnImpEps);
            this.Controls.Add(this.btnImpCyc);
            this.Controls.Add(this.CommuneRadGV);
            this.DoubleBuffered = true;
            this.Name = "ucAdminCommunes";
            this.Size = new System.Drawing.Size(1008, 554);
            ((System.ComponentModel.ISupportInitialize)(this.tDBVAGUEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTdbOdyssee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDBAGENCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommuneRadGV.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommuneRadGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDBCOMMUNESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private Telerik.WinControls.UI.RadGridView CommuneRadGV;
        private System.Windows.Forms.BindingSource tDBVAGUEBindingSource;
        private Dal.dsTdbOdyssee dsTdbOdyssee;
        private Dal.dsTdbOdysseeTableAdapters.TDB_VAGUETableAdapter tDB_VAGUETableAdapter;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private System.Windows.Forms.Button btnImpCyc;
        private System.Windows.Forms.Button btnImpEps;
        private System.Windows.Forms.BindingSource tDBCOMMUNESBindingSource;
        private Dal.dsTdbOdysseeTableAdapters.TDB_COMMUNESTableAdapter tDB_COMMUNESTableAdapter;
        private System.Windows.Forms.BindingSource tDBAGENCEBindingSource;
        private Dal.dsTdbOdysseeTableAdapters.TDB_AGENCETableAdapter tDB_AGENCETableAdapter;
    }
}
