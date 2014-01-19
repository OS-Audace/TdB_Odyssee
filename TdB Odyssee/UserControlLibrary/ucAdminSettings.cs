using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Telerik.WinControls;
using System.Configuration;
using System.Data.SqlClient;

namespace TdB_Odyssee.UserControlLibrary
{
    public partial class ucAdminSettings : UserControl
    {
        public ucAdminSettings()
        {
            InitializeComponent();
        }

        internal void Init()
        {
            string MedocCstring = ConfigurationManager.ConnectionStrings["TdB_Odyssee.Properties.Settings.MedocConnectionString"].ConnectionString;
            var tabCnxMedoc = MedocCstring.Split(';');
            tbAliasMedoc.Text = tabCnxMedoc[0].Split('=')[1].ToString();
            tbLoginMedoc.Text = tabCnxMedoc[3].Split('=')[1].ToString();
            tbPassMedoc.Text = tabCnxMedoc[1].Split('=')[1].ToString();

            string ActuelLocalCstring = ConfigurationManager.ConnectionStrings["TdB_Odyssee.Properties.Settings.TdbOdysseeConnectionString"].ConnectionString;
            var tabLocCnx = ActuelLocalCstring.Split(';');
            tbDatasourceLocale.Text = tabLocCnx[0].Split('=')[1].ToString();
            tbCatalogueLocale.Text = tabLocCnx[1].Split('=')[1].ToString();

            string ActuelImportDir = ConfigurationManager.ConnectionStrings["TdB_Odyssee.Properties.Settings.csDir"].ToString();
            tbImportDir.Text = ActuelImportDir;
        }

        private void btnTesterConnexion_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string medocConnectionString = string.Format("DATA SOURCE={0};PASSWORD={2};PERSIST SECURITY INFO=True;USER ID={1}",
                                            tbAliasMedoc.Text,
                                            tbLoginMedoc.Text,
                                            tbPassMedoc.Text);
            try
            {
                OracleConnection conn = new OracleConnection();
                conn.ConnectionString = medocConnectionString;
                conn.Open();
                conn.Close();

                string caption = "Success !";
                string result = "Connexion à la Base MEDOC réussie.";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);

                btnSaveDataBaseSetting.Enabled = true;
            }
            catch (Exception ex)
            {
                string caption = "Error !";
                string result = "Erreur de connexion à la base de donnée MEDOC : " + ex.Message + ".";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnSaveDataBaseSetting_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string newCstring = string.Format("DATA SOURCE={0};PASSWORD={2};PERSIST SECURITY INFO=True;USER ID={1}",
                                tbAliasMedoc.Text,
                                tbLoginMedoc.Text,
                                tbPassMedoc.Text);
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["TdB_Odyssee.Properties.Settings.MedocConnectionString"].ConnectionString = newCstring;
                config.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("connectionStrings");

                string caption = "Success !";
                string result = "Modification enregistrée.";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            catch (Exception ex)
            {
                string caption = "Erreur !";
                string result = "Erreur d'enregistrement : " + ex.Message + ".";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnTesterBddLocale_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string cs = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True",
                                                                        tbDatasourceLocale.Text,
                                                                        tbCatalogueLocale.Text);
            string csMaster = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True",
                                                                           tbDatasourceLocale.Text,
                                                                           "master");
            try
            {
                var conn = new SqlConnection(cs);
                conn.Open();
                conn.Close();
                string caption = "Success !";
                string result = "Connexion à la base locale réussie.";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            catch (Exception ex)
            {
                // La connexion à la base ne s'est pas fait : on essaye de se connecter au moteur sur MASTER et on propose de créer la base
                try
                {
                    var connMaster = new SqlConnection(csMaster);
                    connMaster.Open();
                    connMaster.Close();
                    string caption = "Attention !";
                    string result = "Une base de données MSSql est disponible mais <TdB Odyssée> n'y est pas installée.";
                    RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
                }
                catch
                {
                    string caption = "Echec !";
                    string result = "Impossible de se connecter au moteur local SQLExpress.";
                    RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnEnregistrerBddLocale_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string newCstring = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True",
                                                   tbDatasourceLocale.Text,
                                                   tbCatalogueLocale.Text);
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["TdB_Odyssee.Properties.Settings.TdbOdysseeConnectionString"].ConnectionString = newCstring;
                
                config.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("connectionStrings");

                string caption = "Success !";
                string result = "Modification enregistrée.";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            catch (Exception ex)
            {
                string caption = "Echec !";
                string result = "Erreur d'enregistrement : " + ex.Message + ".";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnFolderSearch_Click(object sender, EventArgs e)
        {
            var result = this.folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                tbImportDir.Text = this.folderBrowserDialog1.SelectedPath;
                btnSaveImportDir.Enabled = true;
            }
        }

        private void btnSaveImportDir_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                //Create the object
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["TdB_Odyssee.Properties.Settings.csDIR"].ConnectionString = tbImportDir.Text;

                config.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("connectionStrings");

                string caption = "Success !";
                string result = "Modification enregistrée.";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            catch (Exception ex)
            {
                string caption = "Error !";
                string result = "Erreur d'enregistrement : " + ex.Message + ".";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
