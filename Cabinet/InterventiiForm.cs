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
    public partial class InterventiiForm : Form
    {

        CabinetEntities context = new CabinetEntities();

        public InterventiiForm()
        {
            InitializeComponent();
        }
        private void SalveazaInBazaDeDate()
        {
            var entries = context.ChangeTracker.Entries();
           
            var deAdaugat = entries.Where(e => e.State == EntityState.Added);

            foreach (var el in deAdaugat)
            {
                var it = el.Entity as Interventie;
                it.MedicID = Program.utilizator_curent.MedicID;
                it.PacientID = (int)pacientIDComboBox.SelectedValue;
                it.TipInterventieID = (int)tipInterventieIDComboBox.SelectedValue;
                var t = dataOraDateTimePicker.Value;
                it.DataOra = t;
                it.PretID =
                    (from p in (tipInterventieIDComboBox.SelectedItem as TipIntervenie).Pret
                     where p.DataInceput <= t && p.DataSfarsit >= t
                     select p.PretID).FirstOrDefault();
            }

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

        private void InterventiiForm_Load(object sender, EventArgs e)
        {
            var interv =
                (from it in context.Interventie
                 where it.MedicID == Program.utilizator_curent.MedicID
                 select it).ToList();

            var local = context.Interventie.Local;

            interventieBindingSource.DataSource = local;

            pacientIDComboBox.DataSource =
                (from p in context.Pacient
                 where p.MedicID == Program.utilizator_curent.MedicID
                 select p).ToList();

            tipInterventieIDComboBox.DataSource =
                (from ti in context.TipIntervenie
                 select ti).ToList();

          

        }

        private void InterventiiForm_FormClosing(object sender, FormClosingEventArgs ev)
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

        private void tipInterventieIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = tipInterventieIDComboBox.SelectedItem as TipIntervenie;
            if (item == null)
            {
                tipInterventieIDComboBox.SelectedIndex = 0;
                item = tipInterventieIDComboBox.SelectedItem as TipIntervenie;
            }
            var pret =
                (from p in context.Pret
                 where p.TipInterventieID == item.TipInterventieID
                 orderby p.DataSfarsit descending
                 select p).FirstOrDefault().Pret1;
            pretDisplayTextBox.Text = pret.ToString();
        }

        private void interventieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                SalveazaInBazaDeDate();
            }
            catch { }
        }
    }
}
