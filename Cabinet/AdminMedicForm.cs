﻿using System;
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
    public partial class AdminMedicForm : Form
    {

        CabinetEntities context = new CabinetEntities();

        public AdminMedicForm()
        {
            InitializeComponent();
        }

        private void AdminMedicForm_Load(object sender, EventArgs e)
        {
           
            context.Medic.ToList();
            medicBindingSource.DataSource = context.Medic.Local;
        }

        private void AdminMedicForm_Activated(object sender, EventArgs e)
        {
            medicBindingSource.ResetBindings(false);
        }

        private void medicBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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

        private void AdminMedicForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var db = context;
            var tracker = db.ChangeTracker;
            foreach (var row in db.Medic)
            {
                if (db.Entry(row).State == EntityState.Added )
                {
                }
            }
        }


        


    }
}
