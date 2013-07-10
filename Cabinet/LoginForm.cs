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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var db = new CabinetEntities();
            var user = (from u in db.Medic
                        where u.User.Equals(tbUser.Text) &&
                              u.Pass.Equals(tbPass.Text)
                        select u).FirstOrDefault();
            if (user == null)
            {
                this.lblLoginError.Visible = true;
                this.DialogResult = DialogResult.None;
            }
            else
            {
                Program.utilizator = user;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.lblLoginError.Visible = false;
        }
    }
}
