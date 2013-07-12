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
    public partial class PacientiNrInterventii : Form
    {
        public PacientiNrInterventii()
        {
            InitializeComponent();
        }

        private void PacientiNrInterventii_Load(object sender, EventArgs e)
        {
            var ctx = new CabinetEntities();
            var list = ctx
                .Interventie
                .Where(i => i.MedicID == 3)
                .GroupBy(i => new { i.PacientID, i.Pacient.Nume, i.Pacient.Prenume })
                .Select(g => new { Pacient = g.Key.Nume + ", " + g.Key.Prenume, Numar = g.Count() })
                .OrderByDescending(x => x.Numar).ToList();
          

            dataGridView1.DataSource = list;
        }
    }
}
