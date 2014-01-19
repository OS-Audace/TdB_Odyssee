using System;
using System.Windows.Forms;
using System.Configuration;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;
//using TdB_Odyssee.Dal.dsTdbOdysseeTableAdapters;

namespace TdB_Odyssee.UserControlLibrary
{
    public partial class ucTdbNational : UserControl
    {
        public ucTdbNational()
        {
            InitializeComponent();
        }

        internal void Init()
        {
            new Dal.dsTdbOdysseeTableAdapters.vComptageResultatsTableAdapter().Fill(dsTdbOdyssee.vComptageResultats);

            bntExpandExport.Text = "<";
            this.splitContainer1.SplitterDistance = this.splitContainer1.Width - 30;
            
        }

        private void bntExpandExport_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            if (btn.Text == ">")
            {
                btn.Text = "<";
                this.splitContainer1.SplitterDistance = this.splitContainer1.Width - 30;
            }
            else
            {
                btn.Text = ">";
                this.splitContainer1.SplitterDistance = this.splitContainer1.Width - 245;
            }
        }

        private void btnExportDetail_Click(object sender, EventArgs e)
        {
            new ExportToFile.ExportToFile().RunExportDetails(cbExportT0.Checked);

            MessageBox.Show("Opération Terminée");

            string FilePath = ConfigurationManager.ConnectionStrings["TdB_Odyssee.Properties.Settings.csResultstFilePath"].ConnectionString;

            System.Diagnostics.Process.Start(FilePath);
        }

        private void btnExportRapproClientCateg_Click(object sender, EventArgs e)
        {
            string FilePath = 
                    string.Format(@"{0}\" + "Tdb_National_"
                                        + DateTime.Now.ToString("yyyyMMdd_HHmmss")
                                        + ".xls", ConfigurationManager.ConnectionStrings["TdB_Odyssee.Properties.Settings.csExportFilePath"].ToString());

            new ExportToFile.ExportToFile().RunExportPivotToExcel(this.mainPivotGrid, FilePath, "TdbNational", true);

            System.Diagnostics.Process.Start(FilePath);
        }
    }
}
