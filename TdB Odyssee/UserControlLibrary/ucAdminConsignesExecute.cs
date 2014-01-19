using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TdB_Odyssee.UserControlLibrary
{
    public partial class ucAdminConsignesExecute : UserControl
    {
        private bool InitPhase = false;

        public ucAdminConsignesExecute()
        {
            InitializeComponent();
        }

        public void Init()
        {
            this.InitPhase = true;

            this.tDB_CONSIGNETableAdapter.Fill(dsTdbOdyssee.TDB_CONSIGNE);
            this.rmcnxConsignes.MultiColumnComboBoxElement.DropDownWidth = 500;

            this.InitPhase = false;
        }
        private void rmcnxConsignes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.InitPhase)
            {
                //Fill the CheckBoxList 'Alamano'
                var truc = new TdB_Odyssee.Dal.dsTdbOdysseeTableAdapters.getBaseListFromApplicationSourceTableAdapter();

                this.getBaseListFromApplicationSourceTableAdapter.Fill(dsTdbOdyssee.getBaseListFromApplicationSource, "CYCLADES");
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            StringBuilder stringResultat = new StringBuilder();

            foreach (System.Data.DataRowView item in lbListeBases.SelectedItems)
            {

                string CurrentBaseName = item["BaseName"].ToString();
                //Execution Requete
                new Dal.dsTdbOdysseeTableAdapters.QueriesTableAdapter().spPrepareImportResultat((int)rmcnxConsignes.SelectedValue, CurrentBaseName, cbT0.Checked ? "O" : "N");
                
                var exportOpe = new Extract.ExportConsigneCycladesFile();

                var ResultatExport = exportOpe.export((int)rmcnxConsignes.SelectedValue, CurrentBaseName, cbT0.Checked ? "O" : "N");

                
                if (ResultatExport.IndexOf("Erreur") != -1)
                {
                    stringResultat.AppendLine("Base " + CurrentBaseName + " " + ResultatExport + ")");
                    tbResultat.Text = stringResultat.ToString();
                }
                else
                {
                    var importOpe = new Import.ImportResultatConsigne();
                    var resultatImport = importOpe.import(ResultatExport, cbT0.Checked);

                    var resultat = "Base " + CurrentBaseName + " " + (resultatImport.IndexOf("Erreur") != -1 ? "KO (" : "OK (") + resultatImport + ")";
                    
                    stringResultat.AppendLine(resultat);
                    tbResultat.Text = stringResultat.ToString();
                }

            }
        }
    }
}
