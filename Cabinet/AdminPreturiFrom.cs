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
                SalveazaInBazaDeDate();
            }
            catch { }
           
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            dataInceputDateTimePicker.Value = DateTime.Now;
            dataSfarsitDateTimePicker.Value = DateTime.Now;
            //tipInterventieIDComboBox.SelectedIndex = 1;
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

        private void AdminPreturiFrom_FormClosing(object sender, FormClosingEventArgs ev)
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

        private void AdminPreturiFrom_Activated(object sender, EventArgs e)
        {
            //pretBindingSource.ResetBindings(false);
            //tipIntervenieBindingSource.ResetBindings(false);

            context.Pret.ToList();
            context.TipIntervenie.ToList();
        }
    }
}
