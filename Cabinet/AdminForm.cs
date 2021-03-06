﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinet
{
    public partial class AdminForm : Form
    {
        private int childFormNumber = 0;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }        

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void mediciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["AdminMedicForm"] as AdminMedicForm) == null)
            {
                var medicForm = new AdminMedicForm();
                medicForm.MdiParent = this;
                medicForm.Show();
            }    
        }

        private void interventiiToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if ((Application.OpenForms["AdminInterventiiForm"] as AdminInterventiiForm) == null)
            {
                var interventiiForm = new AdminInterventiiForm();
                interventiiForm.MdiParent = this;
                interventiiForm.Show();
            }    
        }

        private void preturiToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            if ((Application.OpenForms["AdminPreturiFrom"] as AdminPreturiFrom) == null)
            {
                var preturi = new AdminPreturiFrom();
                preturi.MdiParent = this;
                preturi.Show();
            }    
        }

        private void btnMedici_Click(object sender, EventArgs e)
        {
            mediciToolStripMenuItem_Click(this, new EventArgs());
        }

        private void btnInterventii_Click(object sender, EventArgs e)
        {
            interventiiToolStripMenuItem_Click(this, new EventArgs());
        }

        private void btnPreturi_Click(object sender, EventArgs e)
        {
            preturiToolStripMenuItem_Click(this, new EventArgs());
        }
    }
}
