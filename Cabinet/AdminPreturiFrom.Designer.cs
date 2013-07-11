namespace Cabinet
{
    partial class AdminPreturiFrom
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
            System.Windows.Forms.Label dataInceputLabel;
            System.Windows.Forms.Label dataSfarsitLabel;
            System.Windows.Forms.Label pret1Label;
            System.Windows.Forms.Label pretIDLabel;
            System.Windows.Forms.Label tipInterventieIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPreturiFrom));
            this.pretBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.pretBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.pretBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataInceputDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataSfarsitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pret1TextBox = new System.Windows.Forms.TextBox();
            this.pretIDTextBox = new System.Windows.Forms.TextBox();
            this.tipInterventieIDComboBox = new System.Windows.Forms.ComboBox();
            this.tipIntervenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pretDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataInceputLabel = new System.Windows.Forms.Label();
            dataSfarsitLabel = new System.Windows.Forms.Label();
            pret1Label = new System.Windows.Forms.Label();
            pretIDLabel = new System.Windows.Forms.Label();
            tipInterventieIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pretBindingNavigator)).BeginInit();
            this.pretBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pretBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipIntervenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataInceputLabel
            // 
            dataInceputLabel.AutoSize = true;
            dataInceputLabel.Location = new System.Drawing.Point(31, 38);
            dataInceputLabel.Name = "dataInceputLabel";
            dataInceputLabel.Size = new System.Drawing.Size(72, 13);
            dataInceputLabel.TabIndex = 1;
            dataInceputLabel.Text = "Data Inceput:";
            // 
            // dataSfarsitLabel
            // 
            dataSfarsitLabel.AutoSize = true;
            dataSfarsitLabel.Location = new System.Drawing.Point(237, 38);
            dataSfarsitLabel.Name = "dataSfarsitLabel";
            dataSfarsitLabel.Size = new System.Drawing.Size(65, 13);
            dataSfarsitLabel.TabIndex = 3;
            dataSfarsitLabel.Text = "Data Sfarsit:";
            // 
            // pret1Label
            // 
            pret1Label.AutoSize = true;
            pret1Label.Location = new System.Drawing.Point(237, 89);
            pret1Label.Name = "pret1Label";
            pret1Label.Size = new System.Drawing.Size(29, 13);
            pret1Label.TabIndex = 5;
            pret1Label.Text = "Pret:";
            // 
            // pretIDLabel
            // 
            pretIDLabel.AutoSize = true;
            pretIDLabel.Location = new System.Drawing.Point(89, 271);
            pretIDLabel.Name = "pretIDLabel";
            pretIDLabel.Size = new System.Drawing.Size(43, 13);
            pretIDLabel.TabIndex = 7;
            pretIDLabel.Text = "Pret ID:";
            pretIDLabel.Visible = false;
            // 
            // tipInterventieIDLabel
            // 
            tipInterventieIDLabel.AutoSize = true;
            tipInterventieIDLabel.Location = new System.Drawing.Point(31, 89);
            tipInterventieIDLabel.Name = "tipInterventieIDLabel";
            tipInterventieIDLabel.Size = new System.Drawing.Size(60, 13);
            tipInterventieIDLabel.TabIndex = 9;
            tipInterventieIDLabel.Text = "Interventie:";
            // 
            // pretBindingNavigator
            // 
            this.pretBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pretBindingNavigator.BindingSource = this.pretBindingSource;
            this.pretBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pretBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pretBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pretBindingNavigatorSaveItem});
            this.pretBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pretBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pretBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pretBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pretBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pretBindingNavigator.Name = "pretBindingNavigator";
            this.pretBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pretBindingNavigator.Size = new System.Drawing.Size(474, 25);
            this.pretBindingNavigator.TabIndex = 0;
            this.pretBindingNavigator.Text = "bindingNavigator1";
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
            // pretBindingSource
            // 
            this.pretBindingSource.DataSource = typeof(Cabinet.Pret);
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
            // pretBindingNavigatorSaveItem
            // 
            this.pretBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pretBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pretBindingNavigatorSaveItem.Image")));
            this.pretBindingNavigatorSaveItem.Name = "pretBindingNavigatorSaveItem";
            this.pretBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pretBindingNavigatorSaveItem.Text = "Save Data";
            this.pretBindingNavigatorSaveItem.Click += new System.EventHandler(this.pretBindingNavigatorSaveItem_Click);
            // 
            // dataInceputDateTimePicker
            // 
            this.dataInceputDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pretBindingSource, "DataInceput", true));
            this.dataInceputDateTimePicker.Location = new System.Drawing.Point(34, 54);
            this.dataInceputDateTimePicker.Name = "dataInceputDateTimePicker";
            this.dataInceputDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataInceputDateTimePicker.TabIndex = 2;
            // 
            // dataSfarsitDateTimePicker
            // 
            this.dataSfarsitDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pretBindingSource, "DataSfarsit", true));
            this.dataSfarsitDateTimePicker.Location = new System.Drawing.Point(240, 54);
            this.dataSfarsitDateTimePicker.Name = "dataSfarsitDateTimePicker";
            this.dataSfarsitDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataSfarsitDateTimePicker.TabIndex = 4;
            // 
            // pret1TextBox
            // 
            this.pret1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pretBindingSource, "Pret1", true));
            this.pret1TextBox.Location = new System.Drawing.Point(240, 107);
            this.pret1TextBox.Name = "pret1TextBox";
            this.pret1TextBox.Size = new System.Drawing.Size(200, 20);
            this.pret1TextBox.TabIndex = 6;
            // 
            // pretIDTextBox
            // 
            this.pretIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pretBindingSource, "PretID", true));
            this.pretIDTextBox.Location = new System.Drawing.Point(187, 268);
            this.pretIDTextBox.Name = "pretIDTextBox";
            this.pretIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.pretIDTextBox.TabIndex = 8;
            this.pretIDTextBox.Visible = false;
            // 
            // tipInterventieIDComboBox
            // 
            this.tipInterventieIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pretBindingSource, "TipInterventieID", true));
            this.tipInterventieIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipIntervenieBindingSource, "Denumire", true));
            this.tipInterventieIDComboBox.DataSource = this.tipIntervenieBindingSource;
            this.tipInterventieIDComboBox.DisplayMember = "Denumire";
            this.tipInterventieIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipInterventieIDComboBox.FormattingEnabled = true;
            this.tipInterventieIDComboBox.Location = new System.Drawing.Point(34, 106);
            this.tipInterventieIDComboBox.Name = "tipInterventieIDComboBox";
            this.tipInterventieIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.tipInterventieIDComboBox.TabIndex = 10;
            this.tipInterventieIDComboBox.ValueMember = "TipInterventieID";
            // 
            // tipIntervenieBindingSource
            // 
            this.tipIntervenieBindingSource.DataSource = typeof(Cabinet.TipIntervenie);
            // 
            // pretDataGridView
            // 
            this.pretDataGridView.AllowUserToAddRows = false;
            this.pretDataGridView.AutoGenerateColumns = false;
            this.pretDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pretDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pretDataGridView.DataSource = this.pretBindingSource;
            this.pretDataGridView.Location = new System.Drawing.Point(34, 133);
            this.pretDataGridView.Name = "pretDataGridView";
            this.pretDataGridView.Size = new System.Drawing.Size(406, 220);
            this.pretDataGridView.TabIndex = 11;
            this.pretDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.pretDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PretID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PretID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TipInterventieID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Interventie";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DataInceput";
            this.dataGridViewTextBoxColumn3.HeaderText = "DataInceput";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataSfarsit";
            this.dataGridViewTextBoxColumn4.HeaderText = "DataSfarsit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pret1";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pret";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // AdminPreturiFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 380);
            this.Controls.Add(dataInceputLabel);
            this.Controls.Add(this.dataInceputDateTimePicker);
            this.Controls.Add(dataSfarsitLabel);
            this.Controls.Add(this.dataSfarsitDateTimePicker);
            this.Controls.Add(pret1Label);
            this.Controls.Add(this.pret1TextBox);
            this.Controls.Add(pretIDLabel);
            this.Controls.Add(this.pretIDTextBox);
            this.Controls.Add(tipInterventieIDLabel);
            this.Controls.Add(this.tipInterventieIDComboBox);
            this.Controls.Add(this.pretBindingNavigator);
            this.Controls.Add(this.pretDataGridView);
            this.Name = "AdminPreturiFrom";
            this.Text = "Preturi";
            this.Activated += new System.EventHandler(this.AdminPreturiFrom_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPreturiFrom_FormClosing);
            this.Load += new System.EventHandler(this.AdminPreturiFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pretBindingNavigator)).EndInit();
            this.pretBindingNavigator.ResumeLayout(false);
            this.pretBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pretBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipIntervenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource pretBindingSource;
        private System.Windows.Forms.BindingNavigator pretBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pretBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker dataInceputDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataSfarsitDateTimePicker;
        private System.Windows.Forms.TextBox pret1TextBox;
        private System.Windows.Forms.TextBox pretIDTextBox;
        private System.Windows.Forms.ComboBox tipInterventieIDComboBox;
        private System.Windows.Forms.DataGridView pretDataGridView;
        private System.Windows.Forms.BindingSource tipIntervenieBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;





    }
}