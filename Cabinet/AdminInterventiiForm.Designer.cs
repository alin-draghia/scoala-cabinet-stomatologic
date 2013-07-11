namespace Cabinet
{
    partial class AdminInterventiiForm
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
            System.Windows.Forms.Label denumireLabel;
            System.Windows.Forms.Label tipInterventieIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInterventiiForm));
            this.tipIntervenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipIntervenieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tipIntervenieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.denumireTextBox = new System.Windows.Forms.TextBox();
            this.tipInterventieIDTextBox = new System.Windows.Forms.TextBox();
            this.tipIntervenieDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            denumireLabel = new System.Windows.Forms.Label();
            tipInterventieIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tipIntervenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipIntervenieBindingNavigator)).BeginInit();
            this.tipIntervenieBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipIntervenieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // denumireLabel
            // 
            denumireLabel.AutoSize = true;
            denumireLabel.Location = new System.Drawing.Point(20, 42);
            denumireLabel.Name = "denumireLabel";
            denumireLabel.Size = new System.Drawing.Size(55, 13);
            denumireLabel.TabIndex = 1;
            denumireLabel.Text = "Denumire:";
            // 
            // tipInterventieIDLabel
            // 
            tipInterventieIDLabel.AutoSize = true;
            tipInterventieIDLabel.Location = new System.Drawing.Point(92, 274);
            tipInterventieIDLabel.Name = "tipInterventieIDLabel";
            tipInterventieIDLabel.Size = new System.Drawing.Size(92, 13);
            tipInterventieIDLabel.TabIndex = 3;
            tipInterventieIDLabel.Text = "Tip Interventie ID:";
            tipInterventieIDLabel.Visible = false;
            // 
            // tipIntervenieBindingSource
            // 
            this.tipIntervenieBindingSource.DataSource = typeof(Cabinet.TipIntervenie);
            // 
            // tipIntervenieBindingNavigator
            // 
            this.tipIntervenieBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tipIntervenieBindingNavigator.BindingSource = this.tipIntervenieBindingSource;
            this.tipIntervenieBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tipIntervenieBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tipIntervenieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tipIntervenieBindingNavigatorSaveItem});
            this.tipIntervenieBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tipIntervenieBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tipIntervenieBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tipIntervenieBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tipIntervenieBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tipIntervenieBindingNavigator.Name = "tipIntervenieBindingNavigator";
            this.tipIntervenieBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tipIntervenieBindingNavigator.Size = new System.Drawing.Size(350, 25);
            this.tipIntervenieBindingNavigator.TabIndex = 0;
            this.tipIntervenieBindingNavigator.Text = "bindingNavigator1";
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
            // tipIntervenieBindingNavigatorSaveItem
            // 
            this.tipIntervenieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tipIntervenieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tipIntervenieBindingNavigatorSaveItem.Image")));
            this.tipIntervenieBindingNavigatorSaveItem.Name = "tipIntervenieBindingNavigatorSaveItem";
            this.tipIntervenieBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tipIntervenieBindingNavigatorSaveItem.Text = "Save Data";
            this.tipIntervenieBindingNavigatorSaveItem.Click += new System.EventHandler(this.tipIntervenieBindingNavigatorSaveItem_Click);
            // 
            // denumireTextBox
            // 
            this.denumireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipIntervenieBindingSource, "Denumire", true));
            this.denumireTextBox.Location = new System.Drawing.Point(23, 58);
            this.denumireTextBox.Name = "denumireTextBox";
            this.denumireTextBox.Size = new System.Drawing.Size(300, 20);
            this.denumireTextBox.TabIndex = 1;
            // 
            // tipInterventieIDTextBox
            // 
            this.tipInterventieIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipIntervenieBindingSource, "TipInterventieID", true));
            this.tipInterventieIDTextBox.Location = new System.Drawing.Point(190, 271);
            this.tipInterventieIDTextBox.Name = "tipInterventieIDTextBox";
            this.tipInterventieIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipInterventieIDTextBox.TabIndex = 4;
            this.tipInterventieIDTextBox.Visible = false;
            // 
            // tipIntervenieDataGridView
            // 
            this.tipIntervenieDataGridView.AllowUserToAddRows = false;
            this.tipIntervenieDataGridView.AutoGenerateColumns = false;
            this.tipIntervenieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipIntervenieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tipIntervenieDataGridView.DataSource = this.tipIntervenieBindingSource;
            this.tipIntervenieDataGridView.Location = new System.Drawing.Point(23, 84);
            this.tipIntervenieDataGridView.Name = "tipIntervenieDataGridView";
            this.tipIntervenieDataGridView.Size = new System.Drawing.Size(300, 220);
            this.tipIntervenieDataGridView.TabIndex = 2;
            this.tipIntervenieDataGridView.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TipInterventieID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TipInterventieID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Denumire";
            this.dataGridViewTextBoxColumn2.HeaderText = "Denumire";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // AdminInterventiiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 330);
            this.Controls.Add(denumireLabel);
            this.Controls.Add(this.denumireTextBox);
            this.Controls.Add(tipInterventieIDLabel);
            this.Controls.Add(this.tipInterventieIDTextBox);
            this.Controls.Add(this.tipIntervenieBindingNavigator);
            this.Controls.Add(this.tipIntervenieDataGridView);
            this.Name = "AdminInterventiiForm";
            this.Text = "Interventii";
            this.Activated += new System.EventHandler(this.AdminInterventiiForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminInterventiiForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminInterventiiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipIntervenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipIntervenieBindingNavigator)).EndInit();
            this.tipIntervenieBindingNavigator.ResumeLayout(false);
            this.tipIntervenieBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipIntervenieDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tipIntervenieBindingSource;
        private System.Windows.Forms.BindingNavigator tipIntervenieBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tipIntervenieBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox denumireTextBox;
        private System.Windows.Forms.TextBox tipInterventieIDTextBox;
        private System.Windows.Forms.DataGridView tipIntervenieDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

    }
}