namespace Cabinet
{
    partial class PacientiForm
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
            System.Windows.Forms.Label medicIDLabel;
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label pacientIDLabel;
            System.Windows.Forms.Label prenumeLabel;
            System.Windows.Forms.Label stersLabel;
            System.Windows.Forms.Label telefonLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacientiForm));
            this.pacientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.pacientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pacientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.medicIDTextBox = new System.Windows.Forms.TextBox();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.pacientIDTextBox = new System.Windows.Forms.TextBox();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.stersCheckBox = new System.Windows.Forms.CheckBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            medicIDLabel = new System.Windows.Forms.Label();
            numeLabel = new System.Windows.Forms.Label();
            pacientIDLabel = new System.Windows.Forms.Label();
            prenumeLabel = new System.Windows.Forms.Label();
            stersLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingNavigator)).BeginInit();
            this.pacientBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // medicIDLabel
            // 
            medicIDLabel.AutoSize = true;
            medicIDLabel.Location = new System.Drawing.Point(409, 291);
            medicIDLabel.Name = "medicIDLabel";
            medicIDLabel.Size = new System.Drawing.Size(53, 13);
            medicIDLabel.TabIndex = 2;
            medicIDLabel.Text = "Medic ID:";
            medicIDLabel.Visible = false;
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.Location = new System.Drawing.Point(26, 42);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(38, 13);
            numeLabel.TabIndex = 4;
            numeLabel.Text = "Nume:";
            // 
            // pacientIDLabel
            // 
            pacientIDLabel.AutoSize = true;
            pacientIDLabel.Location = new System.Drawing.Point(409, 347);
            pacientIDLabel.Name = "pacientIDLabel";
            pacientIDLabel.Size = new System.Drawing.Size(60, 13);
            pacientIDLabel.TabIndex = 6;
            pacientIDLabel.Text = "Pacient ID:";
            pacientIDLabel.Visible = false;
            // 
            // prenumeLabel
            // 
            prenumeLabel.AutoSize = true;
            prenumeLabel.Location = new System.Drawing.Point(26, 91);
            prenumeLabel.Name = "prenumeLabel";
            prenumeLabel.Size = new System.Drawing.Size(52, 13);
            prenumeLabel.TabIndex = 8;
            prenumeLabel.Text = "Prenume:";
            // 
            // stersLabel
            // 
            stersLabel.AutoSize = true;
            stersLabel.Location = new System.Drawing.Point(436, 319);
            stersLabel.Name = "stersLabel";
            stersLabel.Size = new System.Drawing.Size(34, 13);
            stersLabel.TabIndex = 10;
            stersLabel.Text = "Sters:";
            stersLabel.Visible = false;
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(26, 150);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(46, 13);
            telefonLabel.TabIndex = 12;
            telefonLabel.Text = "Telefon:";
            // 
            // pacientBindingSource
            // 
            this.pacientBindingSource.DataSource = typeof(Cabinet.Pacient);
            // 
            // pacientBindingNavigator
            // 
            this.pacientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pacientBindingNavigator.BindingSource = this.pacientBindingSource;
            this.pacientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pacientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pacientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pacientBindingNavigatorSaveItem});
            this.pacientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pacientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pacientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pacientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pacientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pacientBindingNavigator.Name = "pacientBindingNavigator";
            this.pacientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pacientBindingNavigator.Size = new System.Drawing.Size(653, 25);
            this.pacientBindingNavigator.TabIndex = 0;
            this.pacientBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // pacientBindingNavigatorSaveItem
            // 
            this.pacientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pacientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pacientBindingNavigatorSaveItem.Image")));
            this.pacientBindingNavigatorSaveItem.Name = "pacientBindingNavigatorSaveItem";
            this.pacientBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pacientBindingNavigatorSaveItem.Text = "Save Data";
            this.pacientBindingNavigatorSaveItem.Click += new System.EventHandler(this.pacientBindingNavigatorSaveItem_Click);
            // 
            // pacientDataGridView
            // 
            this.pacientDataGridView.AllowUserToAddRows = false;
            this.pacientDataGridView.AutoGenerateColumns = false;
            this.pacientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.pacientDataGridView.DataSource = this.pacientBindingSource;
            this.pacientDataGridView.Location = new System.Drawing.Point(239, 58);
            this.pacientDataGridView.Name = "pacientDataGridView";
            this.pacientDataGridView.Size = new System.Drawing.Size(381, 313);
            this.pacientDataGridView.TabIndex = 4;
            this.pacientDataGridView.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PacientID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PacientID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MedicID";
            this.dataGridViewTextBoxColumn2.HeaderText = "MedicID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nume";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nume";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Prenume";
            this.dataGridViewTextBoxColumn4.HeaderText = "Prenume";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Sters";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Sters";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // medicIDTextBox
            // 
            this.medicIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientBindingSource, "MedicID", true));
            this.medicIDTextBox.Location = new System.Drawing.Point(475, 288);
            this.medicIDTextBox.Name = "medicIDTextBox";
            this.medicIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.medicIDTextBox.TabIndex = 3;
            this.medicIDTextBox.Visible = false;
            // 
            // numeTextBox
            // 
            this.numeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientBindingSource, "Nume", true));
            this.numeTextBox.Location = new System.Drawing.Point(29, 58);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(190, 20);
            this.numeTextBox.TabIndex = 1;
            // 
            // pacientIDTextBox
            // 
            this.pacientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientBindingSource, "PacientID", true));
            this.pacientIDTextBox.Location = new System.Drawing.Point(475, 344);
            this.pacientIDTextBox.Name = "pacientIDTextBox";
            this.pacientIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.pacientIDTextBox.TabIndex = 7;
            this.pacientIDTextBox.Visible = false;
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientBindingSource, "Prenume", true));
            this.prenumeTextBox.Location = new System.Drawing.Point(29, 107);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(190, 20);
            this.prenumeTextBox.TabIndex = 2;
            // 
            // stersCheckBox
            // 
            this.stersCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pacientBindingSource, "Sters", true));
            this.stersCheckBox.Location = new System.Drawing.Point(502, 314);
            this.stersCheckBox.Name = "stersCheckBox";
            this.stersCheckBox.Size = new System.Drawing.Size(104, 24);
            this.stersCheckBox.TabIndex = 11;
            this.stersCheckBox.Text = "checkBox1";
            this.stersCheckBox.UseVisualStyleBackColor = true;
            this.stersCheckBox.Visible = false;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(29, 166);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(104, 20);
            this.telefonTextBox.TabIndex = 3;
            // 
            // PacientiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 404);
            this.Controls.Add(medicIDLabel);
            this.Controls.Add(this.medicIDTextBox);
            this.Controls.Add(numeLabel);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(pacientIDLabel);
            this.Controls.Add(this.pacientIDTextBox);
            this.Controls.Add(prenumeLabel);
            this.Controls.Add(this.prenumeTextBox);
            this.Controls.Add(stersLabel);
            this.Controls.Add(this.stersCheckBox);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.pacientDataGridView);
            this.Controls.Add(this.pacientBindingNavigator);
            this.Name = "PacientiForm";
            this.Text = "Pacienti";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PacientiForm_FormClosing);
            this.Load += new System.EventHandler(this.PacientiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingNavigator)).EndInit();
            this.pacientBindingNavigator.ResumeLayout(false);
            this.pacientBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.BindingSource pacientBindingSource;
        private System.Windows.Forms.BindingNavigator pacientBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pacientBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pacientDataGridView;
        private System.Windows.Forms.TextBox medicIDTextBox;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox pacientIDTextBox;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.CheckBox stersCheckBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}