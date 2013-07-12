using System;
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
    public partial class MedicForm : Form
    {
        private int childFormNumber = 0;

        public MedicForm()
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

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void pacientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["PacientiForm"] as PacientiForm) == null)
            {
                var form = new PacientiForm();
                form.MdiParent = this;
                form.Show();
            }   
        }

        private void programariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["ProgramariForm"] as ProgramariForm) == null)
            {
                var form = new ProgramariForm();
                form.MdiParent = this;
                form.Show();
            }   
        }

        private void interventiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["InterventiiForm"] as InterventiiForm) == null)
            {
                var form = new InterventiiForm();
                form.MdiParent = this;
                form.Show();
            }   

        }

        private void listaPreturiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["ListaPreturiForm"] as ListaPreturiForm) == null)
            {
                var form = new ListaPreturiForm();
                form.MdiParent = this;
                form.Show();
            }   
        }

        private void listaProgramariCurenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["ListaProgramariCurenteForm"] as ListaProgramariCurenteForm) == null)
            {
                var form = new ListaProgramariCurenteForm();
                form.MdiParent = this;
                form.Show();
            }   
        }

        private void pacientiNrInterventiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["PacientiNrInterventii"] as PacientiNrInterventii) == null)
            {
                var form = new PacientiNrInterventii();
                form.MdiParent = this;
                form.Show();
            }   
        }
    }
}
