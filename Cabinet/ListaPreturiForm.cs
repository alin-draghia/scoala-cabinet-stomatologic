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
    public partial class ListaPreturiForm : Form
    {
        public ListaPreturiForm()
        {
            InitializeComponent();
        }

        private void ListaPreturiForm_Load(object sender, EventArgs e)
        {
            var ctx = new CabinetEntities();
            var preturi = (
                from p in ctx.Pret
                where DateTime.Now <= p.DataSfarsit && DateTime.Now >= p.DataInceput
                select p).ToList();
            pretBindingSource.DataSource = preturi;
        }
    }
}
