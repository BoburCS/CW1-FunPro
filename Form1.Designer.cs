namespace InClassTestLastYearRevision
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label moduleCodeLabel;
            System.Windows.Forms.Label moduleNameLabel;
            System.Windows.Forms.Label moduleYearLabel;
            System.Windows.Forms.Label moduleTypeLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.conn = new System.Data.OleDb.OleDbConnection();
            this.universityDataSet = new InClassTestLastYearRevision.UniversityDataSet();
            this.tb_ModuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ModuleTableAdapter = new InClassTestLastYearRevision.UniversityDataSetTableAdapters.tb_ModuleTableAdapter();
            this.tableAdapterManager = new InClassTestLastYearRevision.UniversityDataSetTableAdapters.TableAdapterManager();
            this.tb_ModuleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tb_ModuleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.Modules = new System.Windows.Forms.ListBox();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.tbModuleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ModuleTypeTableAdapter = new InClassTestLastYearRevision.UniversityDataSetTableAdapters.tb_ModuleTypeTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbxNewName = new System.Windows.Forms.TextBox();
            this.tbxNewCode = new System.Windows.Forms.TextBox();
            this.nudNewYear = new System.Windows.Forms.NumericUpDown();
            this.cbxNewType = new System.Windows.Forms.ComboBox();
            this.tbModuleTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            moduleCodeLabel = new System.Windows.Forms.Label();
            moduleNameLabel = new System.Windows.Forms.Label();
            moduleYearLabel = new System.Windows.Forms.Label();
            moduleTypeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ModuleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ModuleBindingNavigator)).BeginInit();
            this.tb_ModuleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbModuleTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbModuleTypeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // conn
            // 
            this.conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\wiut2\\source\\repos\\InClass" +
    "TestLastYearRevision\\InClassTestLastYearRevision\\University.mdb";
            // 
            // universityDataSet
            // 
            this.universityDataSet.DataSetName = "UniversityDataSet";
            this.universityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_ModuleBindingSource
            // 
            this.tb_ModuleBindingSource.DataMember = "tb_Module";
            this.tb_ModuleBindingSource.DataSource = this.universityDataSet;
            // 
            // tb_ModuleTableAdapter
            // 
            this.tb_ModuleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_ModuleTableAdapter = this.tb_ModuleTableAdapter;
            this.tableAdapterManager.tb_ModuleTypeTableAdapter = this.tb_ModuleTypeTableAdapter;
            this.tableAdapterManager.UpdateOrder = InClassTestLastYearRevision.UniversityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_ModuleBindingNavigator
            // 
            this.tb_ModuleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_ModuleBindingNavigator.BindingSource = this.tb_ModuleBindingSource;
            this.tb_ModuleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_ModuleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_ModuleBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tb_ModuleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tb_ModuleBindingNavigatorSaveItem});
            this.tb_ModuleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_ModuleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_ModuleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_ModuleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_ModuleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_ModuleBindingNavigator.Name = "tb_ModuleBindingNavigator";
            this.tb_ModuleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_ModuleBindingNavigator.Size = new System.Drawing.Size(971, 27);
            this.tb_ModuleBindingNavigator.TabIndex = 0;
            this.tb_ModuleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tb_ModuleBindingNavigatorSaveItem
            // 
            this.tb_ModuleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_ModuleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_ModuleBindingNavigatorSaveItem.Image")));
            this.tb_ModuleBindingNavigatorSaveItem.Name = "tb_ModuleBindingNavigatorSaveItem";
            this.tb_ModuleBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tb_ModuleBindingNavigatorSaveItem.Text = "Save Data";
            this.tb_ModuleBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_ModuleBindingNavigatorSaveItem_Click);
            // 
            // moduleCodeLabel
            // 
            moduleCodeLabel.AutoSize = true;
            moduleCodeLabel.Location = new System.Drawing.Point(284, 132);
            moduleCodeLabel.Name = "moduleCodeLabel";
            moduleCodeLabel.Size = new System.Drawing.Size(91, 16);
            moduleCodeLabel.TabIndex = 3;
            moduleCodeLabel.Text = "Module Code:";
            // 
            // tbxCode
            // 
            this.tbxCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ModuleBindingSource, "ModuleCode", true));
            this.tbxCode.Location = new System.Drawing.Point(385, 129);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(100, 22);
            this.tbxCode.TabIndex = 4;
            // 
            // moduleNameLabel
            // 
            moduleNameLabel.AutoSize = true;
            moduleNameLabel.Location = new System.Drawing.Point(284, 160);
            moduleNameLabel.Name = "moduleNameLabel";
            moduleNameLabel.Size = new System.Drawing.Size(95, 16);
            moduleNameLabel.TabIndex = 5;
            moduleNameLabel.Text = "Module Name:";
            // 
            // tbxName
            // 
            this.tbxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ModuleBindingSource, "ModuleName", true));
            this.tbxName.Location = new System.Drawing.Point(385, 157);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 22);
            this.tbxName.TabIndex = 6;
            // 
            // moduleYearLabel
            // 
            moduleYearLabel.AutoSize = true;
            moduleYearLabel.Location = new System.Drawing.Point(284, 188);
            moduleYearLabel.Name = "moduleYearLabel";
            moduleYearLabel.Size = new System.Drawing.Size(87, 16);
            moduleYearLabel.TabIndex = 7;
            moduleYearLabel.Text = "Module Year:";
            // 
            // moduleTypeLabel
            // 
            moduleTypeLabel.AutoSize = true;
            moduleTypeLabel.Location = new System.Drawing.Point(285, 219);
            moduleTypeLabel.Name = "moduleTypeLabel";
            moduleTypeLabel.Size = new System.Drawing.Size(90, 16);
            moduleTypeLabel.TabIndex = 9;
            moduleTypeLabel.Text = "Module Type:";
            // 
            // nudYear
            // 
            this.nudYear.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_ModuleBindingSource, "ModuleYear", true));
            this.nudYear.Location = new System.Drawing.Point(385, 188);
            this.nudYear.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(100, 22);
            this.nudYear.TabIndex = 11;
            // 
            // Modules
            // 
            this.Modules.DataSource = this.tb_ModuleBindingSource;
            this.Modules.DisplayMember = "ModuleName";
            this.Modules.FormattingEnabled = true;
            this.Modules.ItemHeight = 16;
            this.Modules.Location = new System.Drawing.Point(12, 93);
            this.Modules.Name = "Modules";
            this.Modules.Size = new System.Drawing.Size(266, 276);
            this.Modules.TabIndex = 12;
            this.Modules.ValueMember = "ID";
            // 
            // tbxFilter
            // 
            this.tbxFilter.Location = new System.Drawing.Point(12, 65);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(266, 22);
            this.tbxFilter.TabIndex = 13;
            this.tbxFilter.TextChanged += new System.EventHandler(this.tbxFilter_TextChanged);
            // 
            // cbxType
            // 
            this.cbxType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tb_ModuleBindingSource, "ModuleType", true));
            this.cbxType.DataSource = this.tbModuleTypeBindingSource;
            this.cbxType.DisplayMember = "ModuleTypeName";
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(385, 216);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(100, 24);
            this.cbxType.TabIndex = 14;
            this.cbxType.ValueMember = "Id";
            // 
            // tbModuleTypeBindingSource
            // 
            this.tbModuleTypeBindingSource.DataMember = "tb_ModuleType";
            this.tbModuleTypeBindingSource.DataSource = this.universityDataSet;
            // 
            // tb_ModuleTypeTableAdapter
            // 
            this.tb_ModuleTypeTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(410, 264);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 36);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(638, 219);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 16);
            label1.TabIndex = 9;
            label1.Text = "Module Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(637, 188);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 16);
            label2.TabIndex = 7;
            label2.Text = "Module Year:";
            // 
            // tbxNewName
            // 
            this.tbxNewName.Location = new System.Drawing.Point(738, 157);
            this.tbxNewName.Name = "tbxNewName";
            this.tbxNewName.Size = new System.Drawing.Size(100, 22);
            this.tbxNewName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(637, 160);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 16);
            label3.TabIndex = 5;
            label3.Text = "Module Name:";
            // 
            // tbxNewCode
            // 
            this.tbxNewCode.Location = new System.Drawing.Point(738, 129);
            this.tbxNewCode.Name = "tbxNewCode";
            this.tbxNewCode.Size = new System.Drawing.Size(100, 22);
            this.tbxNewCode.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(637, 132);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(91, 16);
            label4.TabIndex = 3;
            label4.Text = "Module Code:";
            // 
            // nudNewYear
            // 
            this.nudNewYear.Location = new System.Drawing.Point(738, 188);
            this.nudNewYear.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.nudNewYear.Name = "nudNewYear";
            this.nudNewYear.Size = new System.Drawing.Size(100, 22);
            this.nudNewYear.TabIndex = 11;
            // 
            // cbxNewType
            // 
            this.cbxNewType.DataSource = this.tbModuleTypeBindingSource1;
            this.cbxNewType.DisplayMember = "ModuleTypeName";
            this.cbxNewType.FormattingEnabled = true;
            this.cbxNewType.Location = new System.Drawing.Point(738, 216);
            this.cbxNewType.Name = "cbxNewType";
            this.cbxNewType.Size = new System.Drawing.Size(100, 24);
            this.cbxNewType.TabIndex = 14;
            this.cbxNewType.ValueMember = "Id";
            // 
            // tbModuleTypeBindingSource1
            // 
            this.tbModuleTypeBindingSource1.DataMember = "tb_ModuleType";
            this.tbModuleTypeBindingSource1.DataSource = this.universityDataSet;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(763, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(304, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbxNewType);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.Modules);
            this.Controls.Add(this.nudNewYear);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(label4);
            this.Controls.Add(moduleCodeLabel);
            this.Controls.Add(this.tbxNewCode);
            this.Controls.Add(this.tbxCode);
            this.Controls.Add(label3);
            this.Controls.Add(moduleNameLabel);
            this.Controls.Add(this.tbxNewName);
            this.Controls.Add(label2);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(label1);
            this.Controls.Add(moduleYearLabel);
            this.Controls.Add(moduleTypeLabel);
            this.Controls.Add(this.tb_ModuleBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ModuleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ModuleBindingNavigator)).EndInit();
            this.tb_ModuleBindingNavigator.ResumeLayout(false);
            this.tb_ModuleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbModuleTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbModuleTypeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OleDb.OleDbConnection conn;
        private UniversityDataSet universityDataSet;
        private System.Windows.Forms.BindingSource tb_ModuleBindingSource;
        private UniversityDataSetTableAdapters.tb_ModuleTableAdapter tb_ModuleTableAdapter;
        private UniversityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_ModuleBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tb_ModuleBindingNavigatorSaveItem;
        private UniversityDataSetTableAdapters.tb_ModuleTypeTableAdapter tb_ModuleTypeTableAdapter;
        private System.Windows.Forms.TextBox tbxCode;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.ListBox Modules;
        private System.Windows.Forms.TextBox tbxFilter;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.BindingSource tbModuleTypeBindingSource;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbxNewName;
        private System.Windows.Forms.TextBox tbxNewCode;
        private System.Windows.Forms.NumericUpDown nudNewYear;
        private System.Windows.Forms.ComboBox cbxNewType;
        private System.Windows.Forms.BindingSource tbModuleTypeBindingSource1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
    }
}

