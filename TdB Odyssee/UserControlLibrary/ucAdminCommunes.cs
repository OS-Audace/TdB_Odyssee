using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace TdB_Odyssee.UserControlLibrary
{
    public partial class ucAdminCommunes : UserControl
    {
        private bool majMultipleEnCours = false;

        internal void Init()
        {
            tDB_COMMUNESTableAdapter.Fill(dsTdbOdyssee.TDB_COMMUNES);
            tDB_VAGUETableAdapter.Fill(dsTdbOdyssee.TDB_VAGUE);
            tDB_AGENCETableAdapter.Fill(dsTdbOdyssee.TDB_AGENCE);
            CommuneRadGV.TableElement.BackColor = Color.Transparent;
        }

        public ucAdminCommunes()
        {
            InitializeComponent();
        }

        private void btnExportRapproClientCateg_Click(object sender, EventArgs e)
        {

        }

        private void radGridView1_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            var CurrentRGV = CommuneRadGV;

            if (CurrentRGV.SelectedRows.Count >= 1 && majMultipleEnCours.Equals(false))
            {
                switch (CurrentRGV.CurrentColumn.Name)
                {
                    case "cbxVague":
                        majMultipleEnCours = true;
                        string CurrentVague = CurrentRGV.CurrentCell.Value.ToString();

                        GridViewRowInfo[] selectedRows2 = CurrentRGV.SelectedRows.ToArray();
                        for (int i = selectedRows2.Length - 1; i >= 0; i += -1)
                        {
                            if (selectedRows2[i].Cells["cbxVague"].Value.Equals(CurrentVague))
                            {
                            }
                            else
                            {
                                selectedRows2[i].Cells["cbxVague"].Value = CurrentVague;
                            }
                            selectedRows2[i].Cells["cbxVague"].IsSelected = false;
                        }
                        majMultipleEnCours = false;
                        break;
                    default:
                        break;
                }
            }
            
            this.tDBCOMMUNESBindingSource.EndEdit();
            this.tDB_COMMUNESTableAdapter.Update(dsTdbOdyssee);
        }

        private void radGridView1_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            DataRowView dataRowView = e.Rows[0].DataBoundItem as DataRowView;
            DataRow row = dataRowView.Row;

            this.tDB_COMMUNESTableAdapter.Update(row);
        }

        private void CommuneRadGV_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            DataRowView dataRowView = e.Rows[0].DataBoundItem as DataRowView;
            DataRow row = dataRowView.Row;

            this.tDB_COMMUNESTableAdapter.Delete(int.Parse(row["ID_COMMUNE"].ToString()));
        }

        private void btnImpCyc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var ExportComcycFiles = new TdB_Odyssee.Extract.ExportComcycFiles();
            var ImportComcycFiles = new TdB_Odyssee.Import.ImportComcycFiles();
            string ActuelImportDir = ConfigurationManager.ConnectionStrings["TdB_Odyssee.Properties.Settings.csDir"].ToString();

            string result = "";
            string resultE = "";
            string resultI = "";
            string caption = "";
            try
            {
                caption = "Import Terminé !";
                resultE = ExportComcycFiles.exportComcycFiles(ActuelImportDir + "\\comcyc.data");
                resultI = ImportComcycFiles.importComcycFiles(ActuelImportDir + "\\comcyc.data");

                tDB_COMMUNESTableAdapter.Fill(dsTdbOdyssee.TDB_COMMUNES);
            }
            catch (Exception ex)
            {
                caption = "Import en échec !";
                result = "Erreur de chargement du fichier : " + ex.Message + ".";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            Cursor.Current = Cursors.Default;
        }


    }
}
