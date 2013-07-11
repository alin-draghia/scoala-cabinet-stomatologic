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
    public partial class AdminPreturiFrom : Form
    {
        CabinetEntities context = new CabinetEntities();

        public AdminPreturiFrom()
        {
            InitializeComponent();
        }

        private void AdminPreturiFrom_Load(object sender, EventArgs e)
        {
           
            context.Pret.ToList();
            context.TipIntervenie.ToList();
            pretBindingSource.DataSource = context.Pret.Local;
            tipIntervenieBindingSource.DataSource = context.TipIntervenie.Local;
           
        }

        private void pretDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void pretBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {               
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);
               
                var fullErrorMessage = string.Join("; ", errorMessages);

                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);
          
                MessageBox.Show(
                    exceptionMessage,
                    "Exceptie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
