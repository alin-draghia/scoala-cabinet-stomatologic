namespace Cabinet
{
    partial class InterventiiForm
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
            System.Windows.Forms.Label interventieIDLabel;
            System.Windows.Forms.Label medicIDLabel;
            System.Windows.Forms.Label pacientIDLabel;
            System.Windows.Forms.Label pretIDLabel;
            System.Windows.Forms.Label tipInterventieIDLabel;
            System.Windows.Forms.Label pretDisplayLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterventiiForm));
            this.interventieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.interventieBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.interventieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataOraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.interventieIDTextBox = new System.Windows.Forms.TextBox();
            this.medicIDTextBox = new System.Windows.Forms.TextBox();
            this.pretIDTextBox = new System.Windows.Forms.TextBox();
            this.tipInterventieIDComboBox = new System.Windows.Forms.ComboBox();
            this.tipIntervenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientIDComboBox = new System.Windows.Forms.ComboBox();
            this.pacientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pretDisplayTextBox = new System.Windows.Forms.TextBox();
            this.pretBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.interventieDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataOraLabel = new System.Windows.Forms.Label();
            interventieIDLabel = new System.Windows.Forms.Label();
            medicIDLabel = new System.Windows.Forms.Label();
            pacientIDLabel = new System.Windows.Forms.Label();
            pretIDLabel = new System.Windows.Forms.Label();
            tipInterventieIDLabel = new System.Windows.Forms.Label();
            pretDisplayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.interventieBindingNavigator)).BeginInit();
            this.interventieBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interventieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipIntervenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataOraLabel
            // 
            dataOraLabel.AutoSize = true;
            dataOraLabel.Location = new System.Drawing.Point(12, 39);
            dataOraLabel.Name = "dataOraLabel";
            dataOraLabel.Size = new System.Drawing.Size(53, 13);
            dataOraLabel.TabIndex = 1;
            dataOraLabel.Text = "Data Ora:";
            // 
            // interventieIDLabel
            // 
            interventieIDLabel.AutoSize = true;
            interventieIDLabel.Location = new System.Drawing.Point(296, 129);
            interventieIDLabel.Name = "interventieIDLabel";
            interventieIDLabel.Size = new System.Drawing.Size(74, 13);
            interventieIDLabel.TabIndex = 3;
            interventieIDLabel.Text = "Interventie ID:";
            interventieIDLabel.Visible = false;
            // 
            // medicIDLabel
            // 
            medicIDLabel.AutoSize = true;
            medicIDLabel.Location = new System.Drawing.Point(317, 161);
            medicIDLabel.Name = "medicIDLabel";
            medicIDLabel.Size = new System.Drawing.Size(53, 13);
            medicIDLabel.TabIndex = 5;
            medicIDLabel.Text = "Medic ID:";
            medicIDLabel.Visible = false;
            // 
            // pacientIDLabel
            // 
            pacientIDLabel.AutoSize = true;
            pacientIDLabel.Location = new System.Drawing.Point(12, 96);
            pacientIDLabel.Name = "pacientIDLabel";
            pacientIDLabel.Size = new System.Drawing.Size(60, 13);
            pacientIDLabel.TabIndex = 7;
            pacientIDLabel.Text = "Pacient ID:";
            // 
            // pretIDLabel
            // 
            pretIDLabel.AutoSize = true;
            pretIDLabel.Location = new System.Drawing.Point(327, 187);
            pretIDLabel.Name = "pretIDLabel";
            pretIDLabel.Size = new System.Drawing.Size(43, 13);
            pretIDLabel.TabIndex = 9;
            pretIDLabel.Text = "Pret ID:";
            pretIDLabel.Visible = false;
            // 
            // tipInterventieIDLabel
            // 
            tipInterventieIDLabel.AutoSize = true;
            tipInterventieIDLabel.Location = new System.Drawing.Point(12, 154);
            tipInterventieIDLabel.Name = "tipInterventieIDLabel";
            tipInterventieIDLabel.Size = new System.Drawing.Size(92, 13);
            tipInterventieIDLabel.TabIndex = 11;
            tipInterventieIDLabel.Text = "Tip Interventie ID:";
            // 
            // pretDisplayLabel
            // 
            pretDisplayLabel.AutoSize = true;
            pretDisplayLabel.Location = new System.Drawing.Point(12, 220);
            pretDisplayLabel.Name = "pretDisplayLabel";
            pretDisplayLabel.Size = new System.Drawing.Size(66, 13);
            pretDisplayLabel.TabIndex = 17;
            pretDisplayLabel.Text = "Pret Display:";
            // 
            // interventieBindingNavigator
            // 
            this.interventieBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.interventieBindingNavigator.BindingSource = this.interventieBindingSource;
            this.interventieBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.interventieBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.interventieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.interventieBindingNavigatorSaveItem});
            this.interventieBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.interventieBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.interventieBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.interventieBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.interventieBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.interventieBindingNavigator.Name = "interventieBindingNavigator";
            this.interventieBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.interventieBindingNavigator.Size = new System.Drawing.Size(651, 25);
            this.interventieBindingNavigator.TabIndex = 0;
            this.interventieBindingNavigator.Text = "bindingNavigator1";
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
            // interventieBindingSource
            // 
            this.interventieBindingSource.DataSource = typeof(Cabinet.Interventie);
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
            // interventieBindingNavigatorSaveItem
            // 
            this.interventieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.interventieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("interventieBindingNavigatorSaveItem.Image")));
            this.interventieBindingNavigatorSaveItem.Name = "interventieBindingNavigatorSaveItem";
            this.interventieBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.interventieBindingNavigatorSaveItem.Text = "Save Data";
            this.interventieBindingNavigatorSaveItem.Click += new System.EventHandler(this.interventieBindingNavigatorSaveItem_Click);
            // 
            // dataOraDateTimePicker
            // 
            this.dataOraDateTimePicker.CustomFormat = "dd/MM/yyy HH:mm";
            this.dataOraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.interventieBindingSource, "DataOra", true));
            this.dataOraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataOraDateTimePicker.Location = new System.Drawing.Point(15, 55);
            this.dataOraDateTimePicker.Name = "dataOraDateTimePicker";
            this.dataOraDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataOraDateTimePicker.TabIndex = 2;
            // 
            // interventieIDTextBox
            // 
            this.interventieIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.interventieBindingSource, "InterventieID", true));
            this.interventieIDTextBox.Location = new System.Drawing.Point(394, 126);
            this.interventieIDTextBox.Name = "interventieIDTextBox";
            this.interventieIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.interventieIDTextBox.TabIndex = 4;
            this.interventieIDTextBox.Visible = false;
            // 
            // medicIDTextBox
            // 
            this.medicIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.interventieBindingSource, "MedicID", true));
            this.medicIDTextBox.Location = new System.Drawing.Point(394, 158);
            this.medicIDTextBox.Name = "medicIDTextBox";
            this.medicIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.medicIDTextBox.TabIndex = 6;
            this.medicIDTextBox.Visible = false;
            // 
            // pretIDTextBox
            // 
            this.pretIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.interventieBindingSource, "PretID", true));
            this.pretIDTextBox.Location = new System.Drawing.Point(394, 184);
            this.pretIDTextBox.Name = "pretIDTextBox";
            this.pretIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.pretIDTextBox.TabIndex = 10;
            this.pretIDTextBox.Visible = false;
            // 
            // tipInterventieIDComboBox
            // 
            this.tipInterventieIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.interventieBindingSource, "TipInterventieID", true));
            this.tipInterventieIDComboBox.DataSource = this.tipIntervenieBindingSource;
            this.tipInterventieIDComboBox.DisplayMember = "Denumire";
            this.tipInterventieIDComboBox.FormattingEnabled = true;
            this.tipInterventieIDComboBox.Location = new System.Drawing.Point(15, 170);
            this.tipInterventieIDComboBox.Name = "tipInterventieIDComboBox";
            this.tipInterventieIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.tipInterventieIDComboBox.TabIndex = 14;
            this.tipInterventieIDComboBox.ValueMember = "TipInterventieID";
            this.tipInterventieIDComboBox.SelectedIndexChanged += new System.EventHandler(this.tipInterventieIDComboBox_SelectedIndexChanged);
            // 
            // tipIntervenieBindingSource
            // 
            this.tipIntervenieBindingSource.DataSource = typeof(Cabinet.TipIntervenie);
            // 
            // pacientIDComboBox
            // 
            this.pacientIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.interventieBindingSource, "PacientID", true));
            this.pacientIDComboBox.DataSource = this.pacientBindingSource;
            this.pacientIDComboBox.DisplayMember = "DisplayName";
            this.pacientIDComboBox.FormattingEnabled = true;
            this.pacientIDComboBox.Location = new System.Drawing.Point(15, 112);
            this.pacientIDComboBox.Name = "pacientIDComboBox";
            this.pacientIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.pacientIDComboBox.TabIndex = 15;
            this.pacientIDComboBox.ValueMember = "PacientID";
            // 
            // pacientBindingSource
            // 
            this.pacientBindingSource.DataSource = typeof(Cabinet.Pacient);
            // 
            // pretDisplayTextBox
            // 
            this.pretDisplayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pretBindingSource, "Pret1", true));
            this.pretDisplayTextBox.Location = new System.Drawing.Point(15, 236);
            this.pretDisplayTextBox.Name = "pretDisplayTextBox";
            this.pretDisplayTextBox.ReadOnly = true;
            this.pretDisplayTextBox.Size = new System.Drawing.Size(200, 20);
            this.pretDisplayTextBox.TabIndex = 18;
            // 
            // pretBindingSource
            // 
            this.pretBindingSource.DataSource = typeof(Cabinet.Pret);
            // 
            // interventieDataGridView
            // 
            this.interventieDataGridView.AllowUserToAddRows = false;
            this.interventieDataGridView.AllowUserToDeleteRows = false;
            this.interventieDataGridView.AutoGenerateColumns = false;
            this.interventieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.interventieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.interventieDataGridView.DataSource = this.interventieBindingSource;
            this.interventieDataGridView.Location = new System.Drawing.Point(231, 55);
            this.interventieDataGridView.Name = "interventieDataGridView";
            this.interventieDataGridView.ReadOnly = true;
            this.interventieDataGridView.Size = new System.Drawing.Size(399, 290);
            this.interventieDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DataOra";
            this.dataGridViewTextBoxColumn5.HeaderText = "DataOra";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PacientDisplayName";
            this.dataGridViewTextBoxColumn11.HeaderText = "Pacient";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "InterventieDisplayName";
            this.dataGridViewTextBoxColumn13.HeaderText = "Interventie";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "PretDisplay";
            this.dataGridViewTextBoxColumn14.HeaderText = "Pret";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // InterventiiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 369);
            this.Controls.Add(pretDisplayLabel);
            this.Controls.Add(this.pretDisplayTextBox);
            this.Controls.Add(this.pacientIDComboBox);
            this.Controls.Add(this.tipInterventieIDComboBox);
            this.Controls.Add(dataOraLabel);
            this.Controls.Add(this.dataOraDateTimePicker);
            this.Controls.Add(interventieIDLabel);
            this.Controls.Add(this.interventieIDTextBox);
            this.Controls.Add(medicIDLabel);
            this.Controls.Add(pacientIDLabel);
            this.Controls.Add(pretIDLabel);
            this.Controls.Add(this.pretIDTextBox);
            this.Controls.Add(tipInterventieIDLabel);
            this.Controls.Add(this.interventieBindingNavigator);
            this.Controls.Add(this.medicIDTextBox);
            this.Controls.Add(this.interventieDataGridView);
            this.Name = "InterventiiForm";
            this.Text = "Interventii";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InterventiiForm_FormClosing);
            this.Load += new System.EventHandler(this.InterventiiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.interventieBindingNavigator)).EndInit();
            this.interventieBindingNavigator.ResumeLayout(false);
            this.interventieBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interventieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipIntervenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventieDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource interventieBindingSource;
        private System.Windows.Forms.BindingNavigator interventieBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton interventieBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker dataOraDateTimePicker;
        private System.Windows.Forms.TextBox interventieIDTextBox;
        private System.Windows.Forms.TextBox medicIDTextBox;
        private System.Windows.Forms.TextBox pretIDTextBox;
        private System.Windows.Forms.ComboBox tipInterventieIDComboBox;
        private System.Windows.Forms.BindingSource tipIntervenieBindingSource;
        private System.Windows.Forms.ComboBox pacientIDComboBox;
        private System.Windows.Forms.BindingSource pacientBindingSource;
        private System.Windows.Forms.TextBox pretDisplayTextBox;
        private System.Windows.Forms.DataGridView interventieDataGridView;
        private System.Windows.Forms.BindingSource pretBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}