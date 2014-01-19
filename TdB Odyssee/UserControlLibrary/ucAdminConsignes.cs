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
    public partial class ucAdminConsignes : UserControl
    {
        private int CurrentIdConsigne = -1;
        private bool InitPhase = false;

        public ucAdminConsignes()
        {
            InitializeComponent();
        }

        public void Init()
        {
            this.InitPhase = true;

            this.tDB_CONSIGNETableAdapter.Fill(dsTdbOdyssee.TDB_CONSIGNE);
            this.tDB_PRIORITETableAdapter.Fill(dsTdbOdyssee.TDB_PRIORITE);

            //forcer la taille du Grid de la MultiColonne Combobox
            this.rmcbxListeConsignes.MultiColumnComboBoxElement.DropDownWidth = 500;

            this.tbConsignes.Text =
                @"Attention, sont obligatoires :
                    1- En première et deuxième positions les champs CODE_BASE et CODE_COMMUNE
                    2- Dans la clause WHERE, un Filtre sur lu numéro de Base/Firme @@Base";

            //Vider la saisie
            this.tbCodeConsigne.Text = "";
            this.rtbQuery.Text = "";
            this.numCoutUnitaire.Value = 0;
            this.rbEpsydre.Checked = false;
            this.rbCyclade.Checked = false;

            this.splitContainer1.Panel2.Enabled = false;

            this.InitPhase = false;
        }

        private void rmcbxListeConsignes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.InitPhase)
            {
                this.CurrentIdConsigne = (int)rmcbxListeConsignes.EditorControl.Rows[rmcbxListeConsignes.SelectedIndex].Cells["ID_CONSIGNE"].Value;

                FillQueryPanel(this.CurrentIdConsigne);
            }
        }

        private void FillQueryPanel(int _idConsigne)
        {
            int i = 0;
            if (_idConsigne != -1)
            {
                string currentSource = rmcbxListeConsignes.EditorControl.Rows[rmcbxListeConsignes.SelectedIndex].Cells["APPLICATION_SOURCE"].Value.ToString();
                string currentNomConsigne = rmcbxListeConsignes.EditorControl.Rows[rmcbxListeConsignes.SelectedIndex].Cells["CODE_CONSIGNE"].Value.ToString();
                string currentQuery = rmcbxListeConsignes.EditorControl.Rows[rmcbxListeConsignes.SelectedIndex].Cells["REQUETE_CONSIGNE"].Value.ToString();
                string currentDescConsigne = rmcbxListeConsignes.EditorControl.Rows[rmcbxListeConsignes.SelectedIndex].Cells["DESC_CONSIGNE"].Value.ToString();
                
                Int64 currentCoutUnitaire = 0;
                Int64 currentIdPriorite = 0;

                Int64.TryParse(rmcbxListeConsignes.EditorControl.Rows[rmcbxListeConsignes.SelectedIndex].Cells["COUT_CORRECTION"].Value.ToString(), out currentCoutUnitaire);
                Int64.TryParse(rmcbxListeConsignes.EditorControl.Rows[rmcbxListeConsignes.SelectedIndex].Cells["ID_PRIORITE"].Value.ToString(), out currentIdPriorite);

                this.tbCodeConsigne.Text = currentNomConsigne;
                this.tbDescConsigne.Text = currentDescConsigne;
                this.rtbQuery.Text = currentQuery;
                this.numCoutUnitaire.Value = currentCoutUnitaire;
                this.cbPriorite.SelectedValue = currentIdPriorite;

                switch (currentSource)
                {
                    case "CYCLADES":
                        this.rbCyclade.Checked = true;
                        break;
                    case "EPSYDRE":
                        this.rbEpsydre.Checked = true;
                        break;
                    default:
                        this.rbEpsydre.Checked = false;
                        this.rbCyclade.Checked = false;
                        break;
                }
            }
            else
            {
                this.tbCodeConsigne.Text = "";
                this.rtbQuery.Text = "";
                this.numCoutUnitaire.Value = 0;
                this.rbEpsydre.Checked = false;
                this.rbCyclade.Checked = false;
            }

            this.splitContainer1.Panel2.Enabled = true;
            this.tbCodeConsigne.Focus();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (this.CurrentIdConsigne != -1)
            {
                //UPDATE CONSIGNE
                this.tDB_CONSIGNETableAdapter.Update(
                      (int)cbPriorite.SelectedValue
                    , tbCodeConsigne.Text
                    , tbDescConsigne.Text
                    , (rbCyclade.Checked ? "CYCLADES" : "EPSYDRE")
                    , rtbQuery.Text
                    , (int)numCoutUnitaire.Value
                    , CurrentIdConsigne
                    , CurrentIdConsigne);
            }
            else
            {
                //INSERT CONSIGNE
                this.tDB_CONSIGNETableAdapter.Insert(
                      (int)cbPriorite.SelectedValue
                    , tbCodeConsigne.Text
                    , tbDescConsigne.Text
                    , (rbCyclade.Checked ? "CYCLADES" : "EPSYDRE")
                    , rtbQuery.Text
                    , (int)numCoutUnitaire.Value
                    );
            }

            this.Init();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (this.CurrentIdConsigne != -1)
            {
                this.tDB_CONSIGNETableAdapter.Delete(this.CurrentIdConsigne);
            }

            this.Init();
        }

        private void btnNouvelleConsigne_Click(object sender, EventArgs e)
        {
            this.CurrentIdConsigne = -1;
            splitContainer1.Panel2.Enabled = true;
        }
    }
}
