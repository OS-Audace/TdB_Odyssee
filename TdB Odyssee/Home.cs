using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TdB_Odyssee.UserControlLibrary;
using Telerik.WinControls;

namespace TdB_Odyssee
{
    public partial class Home : Form
    {
        private Telerik.WinControls.UI.RadButtonElement CurrentButton = null;

        public Home()
        {
            InitializeComponent();
        }

        private void radRibbonBar1_Click(object sender, EventArgs e)
        {

        }

        private void rbeNational_Click(object sender, EventArgs e)
        {
            if (this.CurrentButton != null)
                this.CurrentButton.Enabled = true;
            this.CurrentButton = (Telerik.WinControls.UI.RadButtonElement)sender;
            this.CurrentButton.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                radPanelHome.Controls.Clear();
                var ucVisu = new ucTdbNational();
                radPanelHome.Controls.Add(ucVisu);
                ucVisu.Dock = DockStyle.Fill;
                ucVisu.Init();
                radPanelHome.Refresh();
            }
            catch (Exception ex)
            {
                string caption = "Erreur !";
                string result = "Erreur de chargement de l'écran : " + ex.Message + ".";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            Cursor.Current = Cursors.Default;
        }

        private void rbeFiliere_Click(object sender, EventArgs e)
        {
            if (this.CurrentButton != null)
                this.CurrentButton.Enabled = true;
            this.CurrentButton = (Telerik.WinControls.UI.RadButtonElement)sender;
            this.CurrentButton.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                radPanelHome.Controls.Clear();
                var ucVisu = new ucTdbFiliere();
                radPanelHome.Controls.Add(ucVisu);
                ucVisu.Dock = DockStyle.Fill;
                ucVisu.Init();
                radPanelHome.Refresh();
            }
            catch (Exception ex)
            {
                string caption = "Erreur !";
                string result = "Erreur de chargement de l'écran : " + ex.Message + ".";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            Cursor.Current = Cursors.Default;
        }

        private void rbeVague_Click(object sender, EventArgs e)
        {
            if (this.CurrentButton != null)
                this.CurrentButton.Enabled = true;
            this.CurrentButton = (Telerik.WinControls.UI.RadButtonElement)sender;
            this.CurrentButton.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                radPanelHome.Controls.Clear();
                var ucVisu = new ucTdbVagues();
                radPanelHome.Controls.Add(ucVisu);
                ucVisu.Dock = DockStyle.Fill;
                ucVisu.Init();
                radPanelHome.Refresh();
            }
            catch (Exception ex)
            {
                string caption = "Erreur !";
                string result = "Erreur de chargement de l'écran : " + ex.Message + ".";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            Cursor.Current = Cursors.Default;
        }

        private void rbeAgence_Click(object sender, EventArgs e)
        {
            if (this.CurrentButton != null)
                this.CurrentButton.Enabled = true;
            this.CurrentButton = (Telerik.WinControls.UI.RadButtonElement)sender;
            this.CurrentButton.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                radPanelHome.Controls.Clear();
                var ucVisu = new ucTdbAgence();
                radPanelHome.Controls.Add(ucVisu);
                ucVisu.Dock = DockStyle.Fill;
                ucVisu.Init();
                radPanelHome.Refresh();
            }
            catch (Exception ex)
            {
                string caption = "Erreur !";
                string result = "Erreur de chargement de l'écran : " + ex.Message + ".";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            Cursor.Current = Cursors.Default;
        }

        private void radButtonElement5_Click(object sender, EventArgs e)
        {
            if (this.CurrentButton != null)
                this.CurrentButton.Enabled = true;
            this.CurrentButton = (Telerik.WinControls.UI.RadButtonElement)sender;
            this.CurrentButton.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                radPanelHome.Controls.Clear();
                var ucVisu = new ucAideUtilisation();
                radPanelHome.Controls.Add(ucVisu);
                ucVisu.Dock = DockStyle.Fill;
                ucVisu.Init();
                radPanelHome.Refresh();
            }
            catch (Exception ex)
            {
                string caption = "Erreur !";
                string result = "Erreur de chargement de l'écran : " + ex.Message + ".";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            Cursor.Current = Cursors.Default;
        }

        private void rbeVersions_Click(object sender, EventArgs e)
        {
            if (this.CurrentButton != null)
                this.CurrentButton.Enabled = true;
            this.CurrentButton = (Telerik.WinControls.UI.RadButtonElement)sender;
            this.CurrentButton.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                radPanelHome.Controls.Clear();
                var ucVisu = new ucAideVersions();
                radPanelHome.Controls.Add(ucVisu);
                ucVisu.Dock = DockStyle.Fill;
                ucVisu.Init();
                radPanelHome.Refresh();
            }
            catch (Exception ex)
            {
                string caption = "Erreur !";
                string result = "Erreur de chargement de l'écran : " + ex.Message + ".";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            Cursor.Current = Cursors.Default;
        }

        private void rbeCommunes_Click(object sender, EventArgs e)
        {
            
        }

        private void rbeAdminConsignes_Click(object sender, EventArgs e)
        {
            
        }

        private void radButtonElementCommunes_Click(object sender, EventArgs e)
        {
            if (this.CurrentButton != null)
                this.CurrentButton.Enabled = true;
            this.CurrentButton = (Telerik.WinControls.UI.RadButtonElement)sender;
            this.CurrentButton.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                radPanelHome.Controls.Clear();
                var ucVisu = new ucAdminCommunes();
                radPanelHome.Controls.Add(ucVisu);
                ucVisu.Dock = DockStyle.Fill;
                ucVisu.Init();
                radPanelHome.Refresh();
            }
            catch (Exception ex)
            {
                string caption = "Erreur !";
                string result = "Erreur de chargement de l'écran : " + ex.Message + ".";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            Cursor.Current = Cursors.Default;
        }

        private void rbeConsigneExecute_Click(object sender, EventArgs e)
        {
            
        }

        private void rbeAdminVagues_Click(object sender, EventArgs e)
        {
            if (this.CurrentButton != null)
                this.CurrentButton.Enabled = true;
            this.CurrentButton = (Telerik.WinControls.UI.RadButtonElement)sender;
            this.CurrentButton.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                radPanelHome.Controls.Clear();
                var ucVisu = new ucAdminVague();
                radPanelHome.Controls.Add(ucVisu);
                ucVisu.Dock = DockStyle.Fill;
                ucVisu.Init();
                radPanelHome.Refresh();
            }
            catch (Exception ex)
            {
                string caption = "Erreur !";
                string result = "Erreur de chargement de l'écran : " + ex.Message + ".";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            Cursor.Current = Cursors.Default;
        }

        private void rbeAdminConsigne_Click(object sender, EventArgs e)
        {
            if (this.CurrentButton != null)
                this.CurrentButton.Enabled = true;
            this.CurrentButton = (Telerik.WinControls.UI.RadButtonElement)sender;
            this.CurrentButton.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                radPanelHome.Controls.Clear();
                var ucVisu = new ucAdminConsignes();
                radPanelHome.Controls.Add(ucVisu);
                ucVisu.Dock = DockStyle.Fill;
                ucVisu.Init();
                radPanelHome.Refresh();
            }
            catch (Exception ex)
            {
                string caption = "Erreur !";
                string result = "Erreur de chargement de l'écran : " + ex.Message + ".";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            Cursor.Current = Cursors.Default;
        }

        private void rbeAdminConsignesExec_Click(object sender, EventArgs e)
        {
            if (this.CurrentButton != null)
                this.CurrentButton.Enabled = true;
            this.CurrentButton = (Telerik.WinControls.UI.RadButtonElement)sender;
            this.CurrentButton.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                radPanelHome.Controls.Clear();
                var ucVisu = new ucAdminConsignesExecute();
                radPanelHome.Controls.Add(ucVisu);
                ucVisu.Dock = DockStyle.Fill;
                ucVisu.Init();
                radPanelHome.Refresh();
            }
            catch (Exception ex)
            {
                string caption = "Erreur !";
                string result = "Erreur de chargement de l'écran : " + ex.Message + ".";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            Cursor.Current = Cursors.Default;
        }

        private void rbeAdminPriorites_Click(object sender, EventArgs e)
        {
            if (this.CurrentButton != null)
                this.CurrentButton.Enabled = true;
            this.CurrentButton = (Telerik.WinControls.UI.RadButtonElement)sender;
            this.CurrentButton.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                radPanelHome.Controls.Clear();
                var ucVisu = new ucAdminPriorties();
                radPanelHome.Controls.Add(ucVisu);
                ucVisu.Dock = DockStyle.Fill;
                ucVisu.Init();
                radPanelHome.Refresh();
            }
            catch (Exception ex)
            {
                string caption = "Erreur !";
                string result = "Erreur de chargement de l'écran : " + ex.Message + ".";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            Cursor.Current = Cursors.Default;
        }

        private void rbeAdminAgences_Click(object sender, EventArgs e)
        {
            if (this.CurrentButton != null)
                this.CurrentButton.Enabled = true;
            this.CurrentButton = (Telerik.WinControls.UI.RadButtonElement)sender;
            this.CurrentButton.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                radPanelHome.Controls.Clear();
                var ucVisu = new ucAdminAgences();
                radPanelHome.Controls.Add(ucVisu);
                ucVisu.Dock = DockStyle.Fill;
                ucVisu.Init();
                radPanelHome.Refresh();
            }
            catch (Exception ex)
            {
                string caption = "Erreur !";
                string result = "Erreur de chargement de l'écran : " + ex.Message + ".";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            Cursor.Current = Cursors.Default;
        }

        private void rbeSettings_Click(object sender, EventArgs e)
        {
            if (this.CurrentButton != null)
                this.CurrentButton.Enabled = true;
            this.CurrentButton = (Telerik.WinControls.UI.RadButtonElement)sender;
            this.CurrentButton.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                radPanelHome.Controls.Clear();
                var ucVisu = new ucAdminSettings();
                radPanelHome.Controls.Add(ucVisu);
                ucVisu.Dock = DockStyle.Fill;
                ucVisu.Init();
                radPanelHome.Refresh();
            }
            catch (Exception ex)
            {
                string caption = "Erreur !";
                string result = "Erreur de chargement de l'écran : " + ex.Message + ".";
                RadMessageBox.Show(result, caption, MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
