namespace Cabinet
{
    partial class ProgramariForm
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
            System.Windows.Forms.Label dataOraLabel;
            System.Windows.Forms.Label medicIDLabel;
            System.Windows.Forms.Label pacientIDLabel;
            System.Windows.Forms.Label programareIDLabel;
            System.Windows.Forms.Label tipInterventieIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramariForm));
            this.programareBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.programareBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.programareBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.medicIDTextBox = new System.Windows.Forms.TextBox();
            this.programareIDTextBox = new System.Windows.Forms.TextBox();
            this.pacientIDComboBox = new System.Windows.Forms.ComboBox();
            this.pacientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipInterventieIDComboBox = new System.Windows.Forms.ComboBox();
            this.tipIntervenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programareDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataOraLabel = new System.Windows.Forms.Label();
            medicIDLabel = new System.Windows.Forms.Label();
            pacientIDLabel = new System.Windows.Forms.Label();
            programareIDLabel = new System.Windows.Forms.Label();
            tipInterventieIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.programareBindingNavigator)).BeginInit();
            this.programareBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipIntervenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programareDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataOraLabel
            // 
            dataOraLabel.AutoSize = true;
            dataOraLabel.Location = new System.Drawing.Point(12, 48);
            dataOraLabel.Name = "dataOraLabel";
            dataOraLabel.Size = new System.Drawing.Size(53, 13);
            dataOraLabel.TabIndex = 9;
            dataOraLabel.Text = "Data Ora:";
            // 
            // medicIDLabel
            // 
            medicIDLabel.AutoSize = true;
            medicIDLabel.Location = new System.Drawing.Point(371, 300);
            medicIDLabel.Name = "medicIDLabel";
            medicIDLabel.Size = new System.Drawing.Size(53, 13);
            medicIDLabel.TabIndex = 11;
            medicIDLabel.Text = "Medic ID:";
            medicIDLabel.Visible = false;
            // 
            // pacientIDLabel
            // 
            pacientIDLabel.AutoSize = true;
            pacientIDLabel.Location = new System.Drawing.Point(12, 111);
            pacientIDLabel.Name = "pacientIDLabel";
            pacientIDLabel.Size = new System.Drawing.Size(60, 13);
            pacientIDLabel.TabIndex = 13;
            pacientIDLabel.Text = "Pacient ID:";
            // 
            // programareIDLabel
            // 
            programareIDLabel.AutoSize = true;
            programareIDLabel.Location = new System.Drawing.Point(371, 355);
            programareIDLabel.Name = "programareIDLabel";
            programareIDLabel.Size = new System.Drawing.Size(78, 13);
            programareIDLabel.TabIndex = 15;
            programareIDLabel.Text = "Programare ID:";
            programareIDLabel.Visible = false;
            // 
            // tipInterventieIDLabel
            // 
            tipInterventieIDLabel.AutoSize = true;
            tipInterventieIDLabel.Location = new System.Drawing.Point(12, 179);
            tipInterventieIDLabel.Name = "tipInterventieIDLabel";
            tipInterventieIDLabel.Size = new System.Drawing.Size(92, 13);
            tipInterventieIDLabel.TabIndex = 17;
            tipInterventieIDLabel.Text = "Tip Interventie ID:";
            // 
            // programareBindingNavigator
            // 
            this.programareBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.programareBindingNavigator.BindingSource = this.programareBindingSource;
            this.programareBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.programareBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.programareBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.programareBindingNavigatorSaveItem});
            this.programareBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.programareBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.programareBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.programareBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.programareBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.programareBindingNavigator.Name = "programareBindingNavigator";
            this.programareBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.programareBindingNavigator.Size = new System.Drawing.Size(756, 25);
            this.programareBindingNavigator.TabIndex = 9;
            this.programareBindingNavigator.Text = "bindingNavigator1";
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
            // programareBindingSource
            // 
            this.programareBindingSource.DataSource = typeof(Cabinet.Programare);
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
            // programareBindingNavigatorSaveItem
            // 
            this.programareBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.programareBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("programareBindingNavigatorSaveItem.Image")));
            this.programareBindingNavigatorSaveItem.Name = "programareBindingNavigatorSaveItem";
            this.programareBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.programareBindingNavigatorSaveItem.Text = "Save Data";
            this.programareBindingNavigatorSaveItem.Click += new System.EventHandler(this.programareBindingNavigatorSaveItem_Click);
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.CustomFormat = "dd:MM:yyyy HH:mm";
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.programareBindingSource, "DataOra", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDateTimePicker.Location = new System.Drawing.Point(15, 64);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(164, 20);
            this.dataDateTimePicker.TabIndex = 10;
            this.dataDateTimePicker.Validated += new System.EventHandler(this.FiledValidated);
            // 
            // medicIDTextBox
            // 
            this.medicIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programareBindingSource, "MedicID", true));
            this.medicIDTextBox.Location = new System.Drawing.Point(469, 300);
            this.medicIDTextBox.Name = "medicIDTextBox";
            this.medicIDTextBox.Size = new System.Drawing.Size(77, 20);
            this.medicIDTextBox.TabIndex = 12;
            this.medicIDTextBox.Visible = false;
            // 
            // programareIDTextBox
            // 
            this.programareIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programareBindingSource, "ProgramareID", true));
            this.programareIDTextBox.Location = new System.Drawing.Point(469, 352);
            this.programareIDTextBox.Name = "programareIDTextBox";
            this.programareIDTextBox.Size = new System.Drawing.Size(77, 20);
            this.programareIDTextBox.TabIndex = 16;
            this.programareIDTextBox.Visible = false;
            // 
            // pacientIDComboBox
            // 
            this.pacientIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.programareBindingSource, "PacientID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pacientIDComboBox.DataSource = this.pacientBindingSource;
            this.pacientIDComboBox.DisplayMember = "DisplayName";
            this.pacientIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pacientIDComboBox.FormattingEnabled = true;
            this.pacientIDComboBox.Location = new System.Drawing.Point(15, 127);
            this.pacientIDComboBox.Name = "pacientIDComboBox";
            this.pacientIDComboBox.Size = new System.Drawing.Size(164, 21);
            this.pacientIDComboBox.TabIndex = 19;
            this.pacientIDComboBox.ValueMember = "PacientID";
            this.pacientIDComboBox.Validated += new System.EventHandler(this.FiledValidated);
            // 
            // pacientBindingSource
            // 
            this.pacientBindingSource.DataSource = typeof(Cabinet.Pacient);
            // 
            // tipInterventieIDComboBox
            // 
            this.tipInterventieIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.programareBindingSource, "TipInterventieID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tipInterventieIDComboBox.DataSource = this.tipIntervenieBindingSource;
            this.tipInterventieIDComboBox.DisplayMember = "Denumire";
            this.tipInterventieIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipInterventieIDComboBox.FormattingEnabled = true;
            this.tipInterventieIDComboBox.Location = new System.Drawing.Point(18, 195);
            this.tipInterventieIDComboBox.Name = "tipInterventieIDComboBox";
            this.tipInterventieIDComboBox.Size = new System.Drawing.Size(161, 21);
            this.tipInterventieIDComboBox.TabIndex = 20;
            this.tipInterventieIDComboBox.ValueMember = "TipInterventieID";
            this.tipInterventieIDComboBox.Validated += new System.EventHandler(this.FiledValidated);
            // 
            // tipIntervenieBindingSource
            // 
            this.tipIntervenieBindingSource.DataSource = typeof(Cabinet.TipIntervenie);
            // 
            // programareDataGridView
            // 
            this.programareDataGridView.AllowUserToAddRows = false;
            this.programareDataGridView.AutoGenerateColumns = false;
            this.programareDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn4});
            this.programareDataGridView.DataSource = this.programareBindingSource;
            this.programareDataGridView.Location = new System.Drawing.Point(208, 64);
            this.programareDataGridView.Name = "programareDataGridView";
            this.programareDataGridView.Size = new System.Drawing.Size(469, 354);
            this.programareDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProgramareID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProgramareID";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PacientID";
            this.dataGridViewTextBoxColumn3.HeaderText = "PacientID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TipInterventieID";
            this.dataGridViewTextBoxColumn5.HeaderText = "TipInterventieID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Medic";
            this.dataGridViewTextBoxColumn6.HeaderText = "Medic";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Pacient";
            this.dataGridViewTextBoxColumn7.HeaderText = "Pacient";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TipIntervenie";
            this.dataGridViewTextBoxColumn8.HeaderText = "TipIntervenie";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MedicDisplayName";
            this.dataGridViewTextBoxColumn10.HeaderText = "MedicDisplayName";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PacientDisplayName";
            this.dataGridViewTextBoxColumn9.HeaderText = "Pacient";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "InterventieDisplayName";
            this.dataGridViewTextBoxColumn11.HeaderText = "Interventie";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataOra";
            this.dataGridViewTextBoxColumn4.HeaderText = "DataOra";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // ProgramariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 598);
            this.Controls.Add(this.programareDataGridView);
            this.Controls.Add(this.tipInterventieIDComboBox);
            this.Controls.Add(this.pacientIDComboBox);
            this.Controls.Add(dataOraLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(medicIDLabel);
            this.Controls.Add(this.medicIDTextBox);
            this.Controls.Add(pacientIDLabel);
            this.Controls.Add(programareIDLabel);
            this.Controls.Add(this.programareIDTextBox);
            this.Controls.Add(tipInterventieIDLabel);
            this.Controls.Add(this.programareBindingNavigator);
            this.Name = "ProgramariForm";
            this.Text = "Programari";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgramariForm_FormClosing);
            this.Load += new System.EventHandler(this.ProgramariForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.programareBindingNavigator)).EndInit();
            this.programareBindingNavigator.ResumeLayout(false);
            this.programareBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipIntervenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programareDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource programareBindingSource;
        private System.Windows.Forms.BindingNavigator programareBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton programareBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox medicIDTextBox;
        private System.Windows.Forms.TextBox programareIDTextBox;
        private System.Windows.Forms.ComboBox pacientIDComboBox;
        private System.Windows.Forms.ComboBox tipInterventieIDComboBox;
        private System.Windows.Forms.BindingSource pacientBindingSource;
        private System.Windows.Forms.BindingSource tipIntervenieBindingSource;
        private System.Windows.Forms.DataGridView programareDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;







    }
}