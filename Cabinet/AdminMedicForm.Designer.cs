namespace Cabinet
{
    partial class AdminMedicForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label isAdminLabel;
            System.Windows.Forms.Label medicIDLabel;
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label passLabel;
            System.Windows.Forms.Label prenumeLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label userLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMedicForm));
            this.medicBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.medicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.medicBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.medicDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.medicIDTextBox = new System.Windows.Forms.TextBox();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            isAdminLabel = new System.Windows.Forms.Label();
            medicIDLabel = new System.Windows.Forms.Label();
            numeLabel = new System.Windows.Forms.Label();
            passLabel = new System.Windows.Forms.Label();
            prenumeLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            userLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.medicBindingNavigator)).BeginInit();
            this.medicBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // isAdminLabel
            // 
            isAdminLabel.AutoSize = true;
            isAdminLabel.Location = new System.Drawing.Point(307, 228);
            isAdminLabel.Name = "isAdminLabel";
            isAdminLabel.Size = new System.Drawing.Size(49, 13);
            isAdminLabel.TabIndex = 2;
            isAdminLabel.Text = "is Admin:";
            isAdminLabel.Visible = false;
            // 
            // medicIDLabel
            // 
            medicIDLabel.AutoSize = true;
            medicIDLabel.Location = new System.Drawing.Point(307, 256);
            medicIDLabel.Name = "medicIDLabel";
            medicIDLabel.Size = new System.Drawing.Size(53, 13);
            medicIDLabel.TabIndex = 4;
            medicIDLabel.Text = "Medic ID:";
            medicIDLabel.Visible = false;
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.Location = new System.Drawing.Point(23, 39);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(38, 13);
            numeLabel.TabIndex = 6;
            numeLabel.Text = "Nume:";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new System.Drawing.Point(218, 84);
            passLabel.Name = "passLabel";
            passLabel.Size = new System.Drawing.Size(40, 13);
            passLabel.TabIndex = 8;
            passLabel.Text = "Parola:";
            // 
            // prenumeLabel
            // 
            prenumeLabel.AutoSize = true;
            prenumeLabel.Location = new System.Drawing.Point(218, 39);
            prenumeLabel.Name = "prenumeLabel";
            prenumeLabel.Size = new System.Drawing.Size(52, 13);
            prenumeLabel.TabIndex = 10;
            prenumeLabel.Text = "Prenume:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(413, 39);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(46, 13);
            telefonLabel.TabIndex = 12;
            telefonLabel.Text = "Telefon:";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new System.Drawing.Point(23, 84);
            userLabel.Name = "userLabel";
            userLabel.Size = new System.Drawing.Size(50, 13);
            userLabel.TabIndex = 14;
            userLabel.Text = "Utilizator:";
            // 
            // medicBindingNavigator
            // 
            this.medicBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medicBindingNavigator.BindingSource = this.medicBindingSource;
            this.medicBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medicBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.medicBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.medicBindingNavigatorSaveItem});
            this.medicBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.medicBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medicBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medicBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medicBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medicBindingNavigator.Name = "medicBindingNavigator";
            this.medicBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medicBindingNavigator.Size = new System.Drawing.Size(596, 25);
            this.medicBindingNavigator.TabIndex = 0;
            this.medicBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // medicBindingSource
            // 
            this.medicBindingSource.DataSource = typeof(Cabinet.Medic);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // medicBindingNavigatorSaveItem
            // 
            this.medicBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medicBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medicBindingNavigatorSaveItem.Image")));
            this.medicBindingNavigatorSaveItem.Name = "medicBindingNavigatorSaveItem";
            this.medicBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.medicBindingNavigatorSaveItem.Text = "Save Data";
            this.medicBindingNavigatorSaveItem.Click += new System.EventHandler(this.medicBindingNavigatorSaveItem_Click);
            // 
            // medicDataGridView
            // 
            this.medicDataGridView.AllowUserToAddRows = false;
            this.medicDataGridView.AllowUserToOrderColumns = true;
            this.medicDataGridView.AutoGenerateColumns = false;
            this.medicDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1});
            this.medicDataGridView.DataSource = this.medicBindingSource;
            this.medicDataGridView.Location = new System.Drawing.Point(26, 126);
            this.medicDataGridView.Name = "medicDataGridView";
            this.medicDataGridView.Size = new System.Drawing.Size(544, 254);
            this.medicDataGridView.TabIndex = 1;
            this.medicDataGridView.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MedicID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MedicID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nume";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prenume";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenume";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "User";
            this.dataGridViewTextBoxColumn5.HeaderText = "Utilizator";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Pass";
            this.dataGridViewTextBoxColumn6.HeaderText = "Parola";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "isAdmin";
            this.dataGridViewCheckBoxColumn1.HeaderText = "isAdmin";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // isAdminCheckBox
            // 
            this.isAdminCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.medicBindingSource, "isAdmin", true));
            this.isAdminCheckBox.Location = new System.Drawing.Point(366, 223);
            this.isAdminCheckBox.Name = "isAdminCheckBox";
            this.isAdminCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isAdminCheckBox.TabIndex = 3;
            this.isAdminCheckBox.Text = "checkBox1";
            this.isAdminCheckBox.UseVisualStyleBackColor = true;
            this.isAdminCheckBox.Visible = false;
            // 
            // medicIDTextBox
            // 
            this.medicIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicBindingSource, "MedicID", true));
            this.medicIDTextBox.Location = new System.Drawing.Point(366, 253);
            this.medicIDTextBox.Name = "medicIDTextBox";
            this.medicIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.medicIDTextBox.TabIndex = 5;
            this.medicIDTextBox.Visible = false;
            // 
            // numeTextBox
            // 
            this.numeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicBindingSource, "Nume", true));
            this.numeTextBox.Location = new System.Drawing.Point(26, 55);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(189, 20);
            this.numeTextBox.TabIndex = 0;
            // 
            // passTextBox
            // 
            this.passTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicBindingSource, "Pass", true));
            this.passTextBox.Location = new System.Drawing.Point(221, 100);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(189, 20);
            this.passTextBox.TabIndex = 4;
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicBindingSource, "Prenume", true));
            this.prenumeTextBox.Location = new System.Drawing.Point(221, 55);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(189, 20);
            this.prenumeTextBox.TabIndex = 1;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(416, 55);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(154, 20);
            this.telefonTextBox.TabIndex = 2;
            // 
            // userTextBox
            // 
            this.userTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicBindingSource, "User", true));
            this.userTextBox.Location = new System.Drawing.Point(26, 100);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(189, 20);
            this.userTextBox.TabIndex = 3;
            // 
            // AdminMedicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 412);
            this.Controls.Add(isAdminLabel);
            this.Controls.Add(this.isAdminCheckBox);
            this.Controls.Add(medicIDLabel);
            this.Controls.Add(this.medicIDTextBox);
            this.Controls.Add(numeLabel);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(passLabel);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(prenumeLabel);
            this.Controls.Add(this.prenumeTextBox);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(userLabel);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.medicDataGridView);
            this.Controls.Add(this.medicBindingNavigator);
            this.Name = "AdminMedicForm";
            this.Text = "Medic";
            this.Activated += new System.EventHandler(this.AdminMedicForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMedicForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminMedicForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicBindingNavigator)).EndInit();
            this.medicBindingNavigator.ResumeLayout(false);
            this.medicBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource medicBindingSource;
        private System.Windows.Forms.BindingNavigator medicBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton medicBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView medicDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.CheckBox isAdminCheckBox;
        private System.Windows.Forms.TextBox medicIDTextBox;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox userTextBox;



    }
}