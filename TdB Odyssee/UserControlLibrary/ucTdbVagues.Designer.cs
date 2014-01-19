namespace TdB_Odyssee.UserControlLibrary
{
    partial class ucTdbVagues
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
            Telerik.Pivot.Core.PropertyAggregateDescription propertyAggregateDescription1 = new Telerik.Pivot.Core.PropertyAggregateDescription();
            Telerik.Pivot.Core.SumAggregateFunction sumAggregateFunction1 = new Telerik.Pivot.Core.SumAggregateFunction();
            Telerik.Pivot.Core.PropertyGroupDescription propertyGroupDescription1 = new Telerik.Pivot.Core.PropertyGroupDescription();
            Telerik.Pivot.Core.GroupNameComparer groupNameComparer1 = new Telerik.Pivot.Core.GroupNameComparer();
            Telerik.Pivot.Core.PropertyGroupDescription propertyGroupDescription2 = new Telerik.Pivot.Core.PropertyGroupDescription();
            Telerik.Pivot.Core.GroupNameComparer groupNameComparer2 = new Telerik.Pivot.Core.GroupNameComparer();
            Telerik.Pivot.Core.PropertyGroupDescription propertyGroupDescription3 = new Telerik.Pivot.Core.PropertyGroupDescription();
            Telerik.Pivot.Core.GroupNameComparer groupNameComparer3 = new Telerik.Pivot.Core.GroupNameComparer();
            Telerik.Pivot.Core.PropertyGroupDescription propertyGroupDescription4 = new Telerik.Pivot.Core.PropertyGroupDescription();
            Telerik.Pivot.Core.GroupNameComparer groupNameComparer4 = new Telerik.Pivot.Core.GroupNameComparer();
            Telerik.Pivot.Core.PropertyGroupDescription propertyGroupDescription5 = new Telerik.Pivot.Core.PropertyGroupDescription();
            Telerik.Pivot.Core.GroupNameComparer groupNameComparer5 = new Telerik.Pivot.Core.GroupNameComparer();
            Telerik.Pivot.Core.PropertyGroupDescription propertyGroupDescription6 = new Telerik.Pivot.Core.PropertyGroupDescription();
            Telerik.Pivot.Core.GroupNameComparer groupNameComparer6 = new Telerik.Pivot.Core.GroupNameComparer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mainPivotGrid = new Telerik.WinControls.UI.RadPivotGrid();
            this.tDBNATIONALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTdbOdyssee = new TdB_Odyssee.Dal.dsTdbOdyssee();
            this.cbExportT0 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExportDetail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportRapproClientCateg = new System.Windows.Forms.Button();
            this.cbExportMiseForme = new Telerik.WinControls.UI.RadCheckBox();
            this.bntExpandExport = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tDB_NATIONALTableAdapter = new TdB_Odyssee.Dal.dsTdbOdysseeTableAdapters.TDB_NATIONALTableAdapter();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPivotGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDBNATIONALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTdbOdyssee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbExportMiseForme)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mainPivotGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cbExportT0);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.btnExportDetail);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.btnExportRapproClientCateg);
            this.splitContainer1.Panel2.Controls.Add(this.cbExportMiseForme);
            this.splitContainer1.Panel2.Controls.Add(this.bntExpandExport);
            this.splitContainer1.Panel2.Controls.Add(this.shapeContainer1);
            this.splitContainer1.Size = new System.Drawing.Size(1024, 604);
            this.splitContainer1.SplitterDistance = 777;
            this.splitContainer1.TabIndex = 20;
            // 
            // mainPivotGrid
            // 
            propertyAggregateDescription1.AggregateFunction = sumAggregateFunction1;
            propertyAggregateDescription1.CustomName = null;
            propertyAggregateDescription1.PropertyName = "NB";
            propertyAggregateDescription1.StringFormat = null;
            propertyAggregateDescription1.StringFormatSelector = null;
            propertyAggregateDescription1.TotalFormat = null;
            this.mainPivotGrid.AggregateDescriptions.Add(propertyAggregateDescription1);
            this.mainPivotGrid.ColumnGrandTotalsPosition = Telerik.WinControls.UI.TotalsPos.First;
            propertyGroupDescription1.CustomName = null;
            propertyGroupDescription1.GroupComparer = groupNameComparer1;
            propertyGroupDescription1.GroupFilter = null;
            propertyGroupDescription1.PropertyName = "VAGUE";
            propertyGroupDescription1.ShowGroupsWithNoData = false;
            propertyGroupDescription1.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
            this.mainPivotGrid.ColumnGroupDescriptions.Add(propertyGroupDescription1);
            this.mainPivotGrid.ColumnsSubTotalsPosition = Telerik.WinControls.UI.TotalsPos.None;
            this.mainPivotGrid.ColumnWidth = 75;
            this.mainPivotGrid.DataSource = this.tDBNATIONALBindingSource;
            this.mainPivotGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPivotGrid.Location = new System.Drawing.Point(0, 0);
            this.mainPivotGrid.Name = "mainPivotGrid";
            propertyGroupDescription2.CustomName = null;
            propertyGroupDescription2.GroupComparer = groupNameComparer2;
            propertyGroupDescription2.GroupFilter = null;
            propertyGroupDescription2.PropertyName = "CODE";
            propertyGroupDescription2.ShowGroupsWithNoData = false;
            propertyGroupDescription2.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
            propertyGroupDescription3.CustomName = null;
            propertyGroupDescription3.GroupComparer = groupNameComparer3;
            propertyGroupDescription3.GroupFilter = null;
            propertyGroupDescription3.PropertyName = "PRIORITE";
            propertyGroupDescription3.ShowGroupsWithNoData = false;
            propertyGroupDescription3.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
            propertyGroupDescription4.CustomName = null;
            propertyGroupDescription4.GroupComparer = groupNameComparer4;
            propertyGroupDescription4.GroupFilter = null;
            propertyGroupDescription4.PropertyName = "FIL";
            propertyGroupDescription4.ShowGroupsWithNoData = false;
            propertyGroupDescription4.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
            propertyGroupDescription5.CustomName = null;
            propertyGroupDescription5.GroupComparer = groupNameComparer5;
            propertyGroupDescription5.GroupFilter = null;
            propertyGroupDescription5.PropertyName = "CONSIGNE";
            propertyGroupDescription5.ShowGroupsWithNoData = false;
            propertyGroupDescription5.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
            propertyGroupDescription6.CustomName = null;
            propertyGroupDescription6.GroupComparer = groupNameComparer6;
            propertyGroupDescription6.GroupFilter = null;
            propertyGroupDescription6.PropertyName = "T0";
            propertyGroupDescription6.ShowGroupsWithNoData = false;
            propertyGroupDescription6.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
            this.mainPivotGrid.RowGroupDescriptions.Add(propertyGroupDescription2);
            this.mainPivotGrid.RowGroupDescriptions.Add(propertyGroupDescription3);
            this.mainPivotGrid.RowGroupDescriptions.Add(propertyGroupDescription4);
            this.mainPivotGrid.RowGroupDescriptions.Add(propertyGroupDescription5);
            this.mainPivotGrid.RowGroupDescriptions.Add(propertyGroupDescription6);
            this.mainPivotGrid.RowsSubTotalsPosition = Telerik.WinControls.UI.TotalsPos.None;
            this.mainPivotGrid.Size = new System.Drawing.Size(777, 604);
            this.mainPivotGrid.TabIndex = 0;
            this.mainPivotGrid.Text = "radPivotGrid1";
            this.mainPivotGrid.ThemeName = "Office2010Black";
            // 
            // tDBNATIONALBindingSource
            // 
            this.tDBNATIONALBindingSource.DataMember = "TDB_NATIONAL";
            this.tDBNATIONALBindingSource.DataSource = this.dsTdbOdyssee;
            // 
            // dsTdbOdyssee
            // 
            this.dsTdbOdyssee.DataSetName = "dsTdbOdyssee";
            this.dsTdbOdyssee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbExportT0
            // 
            this.cbExportT0.AutoSize = true;
            this.cbExportT0.Location = new System.Drawing.Point(26, 358);
            this.cbExportT0.Name = "cbExportT0";
            this.cbExportT0.Size = new System.Drawing.Size(97, 17);
            this.cbExportT0.TabIndex = 67;
            this.cbExportT0.Text = "Exporter les T0";
            this.cbExportT0.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.Location = new System.Drawing.Point(26, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Détail à fiabiliser";
            // 
            // btnExportDetail
            // 
            this.btnExportDetail.Location = new System.Drawing.Point(26, 385);
            this.btnExportDetail.Name = "btnExportDetail";
            this.btnExportDetail.Size = new System.Drawing.Size(84, 23);
            this.btnExportDetail.TabIndex = 66;
            this.btnExportDetail.Text = "Export";
            this.btnExportDetail.UseVisualStyleBackColor = true;
            this.btnExportDetail.Click += new System.EventHandler(this.btnExportDetail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(25, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "Tableau de bord";
            // 
            // btnExportRapproClientCateg
            // 
            this.btnExportRapproClientCateg.Location = new System.Drawing.Point(25, 78);
            this.btnExportRapproClientCateg.Name = "btnExportRapproClientCateg";
            this.btnExportRapproClientCateg.Size = new System.Drawing.Size(84, 23);
            this.btnExportRapproClientCateg.TabIndex = 64;
            this.btnExportRapproClientCateg.Text = "Export";
            this.btnExportRapproClientCateg.UseVisualStyleBackColor = true;
            this.btnExportRapproClientCateg.Click += new System.EventHandler(this.btnExportRapproClientCateg_Click);
            // 
            // cbExportMiseForme
            // 
            this.cbExportMiseForme.Location = new System.Drawing.Point(25, 52);
            this.cbExportMiseForme.Name = "cbExportMiseForme";
            // 
            // 
            // 
            this.cbExportMiseForme.RootElement.StretchHorizontally = true;
            this.cbExportMiseForme.RootElement.StretchVertically = true;
            this.cbExportMiseForme.Size = new System.Drawing.Size(156, 18);
            this.cbExportMiseForme.TabIndex = 61;
            this.cbExportMiseForme.Text = "Conserver la mise en forme";
            // 
            // bntExpandExport
            // 
            this.bntExpandExport.FlatAppearance.BorderSize = 0;
            this.bntExpandExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntExpandExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExpandExport.Location = new System.Drawing.Point(2, 2);
            this.bntExpandExport.Name = "bntExpandExport";
            this.bntExpandExport.Size = new System.Drawing.Size(20, 20);
            this.bntExpandExport.TabIndex = 39;
            this.bntExpandExport.Text = ">";
            this.bntExpandExport.UseVisualStyleBackColor = true;
            this.bntExpandExport.Click += new System.EventHandler(this.bntExpandExport_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(243, 604);
            this.shapeContainer1.TabIndex = 59;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 28;
            this.lineShape1.X2 = 214;
            this.lineShape1.Y1 = 302;
            this.lineShape1.Y2 = 302;
            // 
            // tDB_NATIONALTableAdapter
            // 
            this.tDB_NATIONALTableAdapter.ClearBeforeFill = true;
            // 
            // ucTdbVagues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucTdbVagues";
            this.Size = new System.Drawing.Size(1024, 604);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPivotGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDBNATIONALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTdbOdyssee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbExportMiseForme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Telerik.WinControls.UI.RadPivotGrid mainPivotGrid;
        private System.Windows.Forms.BindingSource tDBNATIONALBindingSource;
        private Dal.dsTdbOdyssee dsTdbOdyssee;
        private System.Windows.Forms.CheckBox cbExportT0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExportDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExportRapproClientCateg;
        private Telerik.WinControls.UI.RadCheckBox cbExportMiseForme;
        private System.Windows.Forms.Button bntExpandExport;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private Dal.dsTdbOdysseeTableAdapters.TDB_NATIONALTableAdapter tDB_NATIONALTableAdapter;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
    }
}
