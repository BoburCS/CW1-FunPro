namespace lastprep
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label dobLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label gradeLevelLabel;
            System.Windows.Forms.Label isActiveLabel;
            System.Windows.Forms.Label countryIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.dbDataSet = new lastprep.dbDataSet();
            this.tbTeacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbTeacherTableAdapter = new lastprep.dbDataSetTableAdapters.tbTeacherTableAdapter();
            this.tableAdapterManager = new lastprep.dbDataSetTableAdapters.TableAdapterManager();
            this.tbCountryTableAdapter = new lastprep.dbDataSetTableAdapters.tbCountryTableAdapter();
            this.tbTeacherBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbTeacherBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.dtpDateofBirth = new System.Windows.Forms.DateTimePicker();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.chbActive = new System.Windows.Forms.CheckBox();
            this.nudGradeLevel = new System.Windows.Forms.NumericUpDown();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.tbCountryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbNewActive = new System.Windows.Forms.CheckBox();
            this.tbxNewPhone = new System.Windows.Forms.TextBox();
            this.dtpNewDataofBirth = new System.Windows.Forms.DateTimePicker();
            this.tbxNewLastName = new System.Windows.Forms.TextBox();
            this.tbxNewFirstName = new System.Windows.Forms.TextBox();
            this.nudNewGradeLevel = new System.Windows.Forms.NumericUpDown();
            this.cmbNewCountry = new System.Windows.Forms.ComboBox();
            this.tbCountryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            dobLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            gradeLevelLabel = new System.Windows.Forms.Label();
            isActiveLabel = new System.Windows.Forms.Label();
            countryIdLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeacherBindingNavigator)).BeginInit();
            this.tbTeacherBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGradeLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountryBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewGradeLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(357, 56);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(57, 13);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "first Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(357, 82);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(57, 13);
            lastNameLabel.TabIndex = 6;
            lastNameLabel.Text = "last Name:";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new System.Drawing.Point(357, 109);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new System.Drawing.Size(28, 13);
            dobLabel.TabIndex = 8;
            dobLabel.Text = "dob:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(357, 134);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(40, 13);
            phoneLabel.TabIndex = 10;
            phoneLabel.Text = "phone:";
            // 
            // gradeLevelLabel
            // 
            gradeLevelLabel.AutoSize = true;
            gradeLevelLabel.Location = new System.Drawing.Point(357, 160);
            gradeLevelLabel.Name = "gradeLevelLabel";
            gradeLevelLabel.Size = new System.Drawing.Size(66, 13);
            gradeLevelLabel.TabIndex = 12;
            gradeLevelLabel.Text = "grade Level:";
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new System.Drawing.Point(357, 188);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(50, 13);
            isActiveLabel.TabIndex = 14;
            isActiveLabel.Text = "is Active:";
            // 
            // countryIdLabel
            // 
            countryIdLabel.AutoSize = true;
            countryIdLabel.Location = new System.Drawing.Point(357, 216);
            countryIdLabel.Name = "countryIdLabel";
            countryIdLabel.Size = new System.Drawing.Size(57, 13);
            countryIdLabel.TabIndex = 16;
            countryIdLabel.Text = "country Id:";
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbTeacherBindingSource
            // 
            this.tbTeacherBindingSource.DataMember = "tbTeacher";
            this.tbTeacherBindingSource.DataSource = this.dbDataSet;
            this.tbTeacherBindingSource.CurrentChanged += new System.EventHandler(this.tbTeacherBindingSource_CurrentChanged);
            // 
            // tbTeacherTableAdapter
            // 
            this.tbTeacherTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbCountryTableAdapter = this.tbCountryTableAdapter;
            this.tableAdapterManager.tbTeacherTableAdapter = this.tbTeacherTableAdapter;
            this.tableAdapterManager.UpdateOrder = lastprep.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbCountryTableAdapter
            // 
            this.tbCountryTableAdapter.ClearBeforeFill = true;
            // 
            // tbTeacherBindingNavigator
            // 
            this.tbTeacherBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbTeacherBindingNavigator.BindingSource = this.tbTeacherBindingSource;
            this.tbTeacherBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbTeacherBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbTeacherBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbTeacherBindingNavigatorSaveItem});
            this.tbTeacherBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbTeacherBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbTeacherBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbTeacherBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbTeacherBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbTeacherBindingNavigator.Name = "tbTeacherBindingNavigator";
            this.tbTeacherBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbTeacherBindingNavigator.Size = new System.Drawing.Size(1061, 25);
            this.tbTeacherBindingNavigator.TabIndex = 0;
            this.tbTeacherBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // tbTeacherBindingNavigatorSaveItem
            // 
            this.tbTeacherBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbTeacherBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbTeacherBindingNavigatorSaveItem.Image")));
            this.tbTeacherBindingNavigatorSaveItem.Name = "tbTeacherBindingNavigatorSaveItem";
            this.tbTeacherBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbTeacherBindingNavigatorSaveItem.Text = "Save Data";
            this.tbTeacherBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbTeacherBindingNavigatorSaveItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.tbTeacherBindingSource;
            this.listBox1.DisplayMember = "lastName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(318, 303);
            this.listBox1.TabIndex = 1;
            this.listBox1.ValueMember = "id";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbTeacherBindingSource, "firstName", true));
            this.tbxFirstName.Location = new System.Drawing.Point(429, 53);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(200, 20);
            this.tbxFirstName.TabIndex = 5;
            this.tbxFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbxFirstName_Validating);
            // 
            // tbxLastName
            // 
            this.tbxLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbTeacherBindingSource, "lastName", true));
            this.tbxLastName.Location = new System.Drawing.Point(429, 79);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(200, 20);
            this.tbxLastName.TabIndex = 7;
            // 
            // dtpDateofBirth
            // 
            this.dtpDateofBirth.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbTeacherBindingSource, "dob", true));
            this.dtpDateofBirth.Location = new System.Drawing.Point(429, 105);
            this.dtpDateofBirth.Name = "dtpDateofBirth";
            this.dtpDateofBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateofBirth.TabIndex = 9;
            // 
            // tbxPhone
            // 
            this.tbxPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbTeacherBindingSource, "phone", true));
            this.tbxPhone.Location = new System.Drawing.Point(429, 131);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(200, 20);
            this.tbxPhone.TabIndex = 11;
            // 
            // chbActive
            // 
            this.chbActive.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbTeacherBindingSource, "isActive", true));
            this.chbActive.Location = new System.Drawing.Point(429, 183);
            this.chbActive.Name = "chbActive";
            this.chbActive.Size = new System.Drawing.Size(200, 24);
            this.chbActive.TabIndex = 15;
            this.chbActive.Text = "checkBox1";
            this.chbActive.UseVisualStyleBackColor = true;
            // 
            // nudGradeLevel
            // 
            this.nudGradeLevel.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbTeacherBindingSource, "gradeLevel", true));
            this.nudGradeLevel.Location = new System.Drawing.Point(429, 160);
            this.nudGradeLevel.Name = "nudGradeLevel";
            this.nudGradeLevel.Size = new System.Drawing.Size(200, 20);
            this.nudGradeLevel.TabIndex = 17;
            // 
            // cmbCountry
            // 
            this.cmbCountry.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbTeacherBindingSource, "countryId", true));
            this.cmbCountry.DataSource = this.tbCountryBindingSource;
            this.cmbCountry.DisplayMember = "Name";
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(429, 214);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(193, 21);
            this.cmbCountry.TabIndex = 18;
            this.cmbCountry.ValueMember = "Id";
            // 
            // tbCountryBindingSource
            // 
            this.tbCountryBindingSource.DataMember = "tbCountry";
            this.tbCountryBindingSource.DataSource = this.dbDataSet;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(510, 288);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(429, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tbxNewPhone);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.chbNewActive);
            this.groupBox1.Controls.Add(this.cmbNewCountry);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.nudNewGradeLevel);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label7);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.tbxNewFirstName);
            this.groupBox1.Controls.Add(this.dtpNewDataofBirth);
            this.groupBox1.Controls.Add(label6);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(this.tbxNewLastName);
            this.groupBox1.Location = new System.Drawing.Point(712, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 301);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 191);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 13);
            label1.TabIndex = 16;
            label1.Text = "country Id:";
            // 
            // chbNewActive
            // 
            this.chbNewActive.Location = new System.Drawing.Point(86, 158);
            this.chbNewActive.Name = "chbNewActive";
            this.chbNewActive.Size = new System.Drawing.Size(200, 24);
            this.chbNewActive.TabIndex = 15;
            this.chbNewActive.Text = "checkBox1";
            this.chbNewActive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 163);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 13);
            label2.TabIndex = 14;
            label2.Text = "is Active:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(14, 135);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(66, 13);
            label3.TabIndex = 12;
            label3.Text = "grade Level:";
            // 
            // tbxNewPhone
            // 
            this.tbxNewPhone.Location = new System.Drawing.Point(86, 106);
            this.tbxNewPhone.Name = "tbxNewPhone";
            this.tbxNewPhone.Size = new System.Drawing.Size(200, 20);
            this.tbxNewPhone.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(14, 109);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 13);
            label4.TabIndex = 10;
            label4.Text = "phone:";
            // 
            // dtpNewDataofBirth
            // 
            this.dtpNewDataofBirth.Location = new System.Drawing.Point(86, 80);
            this.dtpNewDataofBirth.Name = "dtpNewDataofBirth";
            this.dtpNewDataofBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpNewDataofBirth.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(14, 84);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(28, 13);
            label5.TabIndex = 8;
            label5.Text = "dob:";
            // 
            // tbxNewLastName
            // 
            this.tbxNewLastName.Location = new System.Drawing.Point(86, 54);
            this.tbxNewLastName.Name = "tbxNewLastName";
            this.tbxNewLastName.Size = new System.Drawing.Size(200, 20);
            this.tbxNewLastName.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(14, 57);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(57, 13);
            label6.TabIndex = 6;
            label6.Text = "last Name:";
            // 
            // tbxNewFirstName
            // 
            this.tbxNewFirstName.Location = new System.Drawing.Point(86, 28);
            this.tbxNewFirstName.Name = "tbxNewFirstName";
            this.tbxNewFirstName.Size = new System.Drawing.Size(200, 20);
            this.tbxNewFirstName.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(14, 31);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(57, 13);
            label7.TabIndex = 4;
            label7.Text = "first Name:";
            // 
            // nudNewGradeLevel
            // 
            this.nudNewGradeLevel.Location = new System.Drawing.Point(86, 135);
            this.nudNewGradeLevel.Name = "nudNewGradeLevel";
            this.nudNewGradeLevel.Size = new System.Drawing.Size(200, 20);
            this.nudNewGradeLevel.TabIndex = 17;
            // 
            // cmbNewCountry
            // 
            this.cmbNewCountry.DataSource = this.tbCountryBindingSource1;
            this.cmbNewCountry.DisplayMember = "Name";
            this.cmbNewCountry.FormattingEnabled = true;
            this.cmbNewCountry.Location = new System.Drawing.Point(86, 189);
            this.cmbNewCountry.Name = "cmbNewCountry";
            this.cmbNewCountry.Size = new System.Drawing.Size(193, 21);
            this.cmbNewCountry.TabIndex = 18;
            // 
            // tbCountryBindingSource1
            // 
            this.tbCountryBindingSource1.DataMember = "tbCountry";
            this.tbCountryBindingSource1.DataSource = this.dbDataSet;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(86, 247);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxFilter
            // 
            this.tbxFilter.Location = new System.Drawing.Point(21, 24);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(318, 20);
            this.tbxFilter.TabIndex = 26;
            this.tbxFilter.TextChanged += new System.EventHandler(this.tbxFilter_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 374);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.nudGradeLevel);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(dobLabel);
            this.Controls.Add(this.dtpDateofBirth);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(gradeLevelLabel);
            this.Controls.Add(isActiveLabel);
            this.Controls.Add(this.chbActive);
            this.Controls.Add(countryIdLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbTeacherBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeacherBindingNavigator)).EndInit();
            this.tbTeacherBindingNavigator.ResumeLayout(false);
            this.tbTeacherBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGradeLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountryBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewGradeLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource tbTeacherBindingSource;
        private dbDataSetTableAdapters.tbTeacherTableAdapter tbTeacherTableAdapter;
        private dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbTeacherBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbTeacherBindingNavigatorSaveItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.DateTimePicker dtpDateofBirth;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.CheckBox chbActive;
        private System.Windows.Forms.NumericUpDown nudGradeLevel;
        private System.Windows.Forms.ComboBox cmbCountry;
        private dbDataSetTableAdapters.tbCountryTableAdapter tbCountryTableAdapter;
        private System.Windows.Forms.BindingSource tbCountryBindingSource;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxNewPhone;
        private System.Windows.Forms.CheckBox chbNewActive;
        private System.Windows.Forms.ComboBox cmbNewCountry;
        private System.Windows.Forms.NumericUpDown nudNewGradeLevel;
        private System.Windows.Forms.TextBox tbxNewFirstName;
        private System.Windows.Forms.DateTimePicker dtpNewDataofBirth;
        private System.Windows.Forms.TextBox tbxNewLastName;
        private System.Windows.Forms.BindingSource tbCountryBindingSource1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxFilter;
    }
}

