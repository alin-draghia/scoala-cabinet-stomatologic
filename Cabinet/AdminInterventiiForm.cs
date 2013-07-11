using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinet
{
    public partial class AdminInterventiiForm : Form
    {

        CabinetEntities context = new CabinetEntities();

        public AdminInterventiiForm()
        {
            InitializeComponent();
        }

        private void AdminInterventiiForm_Load(object sender, EventArgs e)
        {
           
            context.TipIntervenie.ToList();
            tipIntervenieBindingSource.DataSource = context.TipIntervenie.Local;
        }

        private void tipIntervenieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException)
            {
                var validationErrors = context.GetValidationErrors();
                var firstError = validationErrors.First();
                var campulInvalid = firstError.ValidationErrors.First().PropertyName;
                MessageBox.Show(
                    "Campul [" + campulInvalid + "] este invalid!",
                    "Eroare",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
}
