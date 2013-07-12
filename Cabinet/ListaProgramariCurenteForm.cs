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
    public partial class ListaProgramariCurenteForm : Form
    {
        public ListaProgramariCurenteForm()
        {
            InitializeComponent();
        }

        private void ListaProgramariCurenteForm_Load(object sender, EventArgs e)
        {
            var ctx = new CabinetEntities();

            var t0 = DateTime.Today.AddHours(+8.0);
            var t1 = DateTime.Today.AddHours(+16.0);
            var programari =
                (from p in ctx.Programare
                 where p.MedicID == Program.utilizator_curent.MedicID &&
                    t0 <= p.DataOra && p.DataOra <= t1
                 select p).ToList();
            programareBindingSource.DataSource = programari;
        }
    }
}
