using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
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
                SalveazaInBazaDeDate();
            }
            catch (Exception) { }
          
        }

        private void SalveazaInBazaDeDate()
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

                var fullErrorMessage = string.Join(";\n", errorMessages);

                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                MessageBox.Show(
                    exceptionMessage,
                    "Exceptie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw;
            }
            catch (DbUpdateException ex)
            {

                var exceptionMessage = ex.Message;
                Exception it = ex;
                while (it.InnerException != null)
                {
                    exceptionMessage = string.Join(";\n", exceptionMessage, it.InnerException.Message);
                    it = it.InnerException;
                }

                MessageBox.Show(
                    exceptionMessage,
                    "Salvare esuata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Eroare neasteptata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw;
            }
        }

        private void AdminInterventiiForm_FormClosing(object sender, FormClosingEventArgs ev)
        {
            var changes = context.ChangeTracker.Entries().Any(
                 e => e.State == EntityState.Added || e.State == EntityState.Modified || e.State == EntityState.Deleted);
            if (changes)
            {
                DialogResult dlg = MessageBox.Show("Salvati schimbarile?", "Intrebare", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (dlg)
                {                   
                    case DialogResult.Cancel:
                        ev.Cancel = true;
                        break;
                    case DialogResult.No:
                        break;                   
                    case DialogResult.Yes:
                        try
                        {
                            SalveazaInBazaDeDate();
                        }
                        catch (Exception)
                        {
                            ev.Cancel = true;
                        }
                        
                        break;
                    default:
                        break;
                }
            }
        }

        private void AdminInterventiiForm_Activated(object sender, EventArgs e)
        {
            //tipIntervenieBindingSource.ResetBindings(false);
            context.TipIntervenie.ToList();
        }



    }
}
