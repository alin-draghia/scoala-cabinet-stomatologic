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
    public partial class AdminMedicForm : Form
    {

        CabinetEntities db = new CabinetEntities();

        public AdminMedicForm()
        {
            InitializeComponent();
        }

        private void AdminMedicForm_Load(object sender, EventArgs e)
        {
            try
            {
                var tmp = db.Medic.ToList();                                 
                medicBindingSource.DataSource = db.Medic.Local;                
            }
            catch (Exception ex)
            {
                
            }
        }

        private void medicBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }               

        private void medicBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            db.SaveChanges();      
        }        
    }
}
