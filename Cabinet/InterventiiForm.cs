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
    public partial class InterventiiForm : Form
    {

        CabinetEntities contex = new CabinetEntities();

        public InterventiiForm()
        {
            InitializeComponent();
        }

        private void InterventiiForm_Load(object sender, EventArgs e)
        {
            var interv =
                (from it in contex.Interventie
                 where it.MedicID == Program.utilizator_curent.MedicID
                 select it).ToList();

            var local = contex.Interventie.Local;

            interventieBindingSource.DataSource = local;

            pacientIDComboBox.DataSource =
                (from p in contex.Pacient
                 where p.MedicID == Program.utilizator_curent.MedicID
                 select p).ToList();

            tipInterventieIDComboBox.DataSource =
                (from ti in contex.TipIntervenie
                 select ti).ToList();

          

        }

        private void InterventiiForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
