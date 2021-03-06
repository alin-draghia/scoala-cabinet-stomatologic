﻿using Cabinet.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
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
            if (tbUser.Text.Equals(Resources.AdminUser) &&
                tbPass.Text.Equals(Resources.AdminPass))
            {
                Medic admin = new Medic() { isAdmin = true };
                Program.utilizator_curent = admin;
                return;
            }

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
                Program.utilizator_curent = user;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.lblLoginError.Visible = false;
        }
    }
}
