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
    
    public partial class ProgramariForm : Form
    {
       
        CabinetEntities context = new CabinetEntities();
        List<Pacient> pacienti = null;
        List<Programare> programari = null;
        List<TipIntervenie> tipInterventii = null;

        public ProgramariForm()
        {
            InitializeComponent();
        }

        private void SalveazaInBazaDeDate()
        {
            try
            {
                var entries = context.ChangeTracker.Entries();
                var deAdaugat = entries.Where(e => e.State == EntityState.Added);

                foreach (var el in deAdaugat)
                {
                    var p = el.Entity as Programare;
                    p.MedicID = Program.utilizator_curent.MedicID;
                }

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

        private void ProgramariForm_Load(object sender, EventArgs e)
        {
            try
            {
              
                dataDateTimePicker.Value = DateTime.Now;

                var tmp =
                    (from p in context.Programare
                     where p.MedicID == Program.utilizator_curent.MedicID
                     select p);
                tmp.ToList();

                programareBindingSource.DataSource = context.Programare.Local;
           

                tipInterventieIDComboBox.DataSource = 
                    (from ti in context.TipIntervenie
                     select ti).ToList();

                pacientIDComboBox.DataSource =
                    (from p in context.Pacient
                     where p.MedicID == Program.utilizator_curent.MedicID
                     select p).ToList();

            }
            catch (Exception ex)
            {
            }
           
        }

        

        private void ProgramariForm_FormClosing(object sender, FormClosingEventArgs ev)
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

        private void programareBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                SalveazaInBazaDeDate();
            }
            catch { }
        }

        private void FiledValidated(object sender, EventArgs e)
        {
            programareDataGridView.Refresh();
        }

        
    }
}
