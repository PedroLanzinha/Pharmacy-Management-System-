namespace CS_Pharmacy_Management_System
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            System.Windows.Forms.Label reference_NumberLabel;
            System.Windows.Forms.Label patient__IDLabel;
            System.Windows.Forms.Label doctor_s_NHS_NoLabel;
            System.Windows.Forms.Label medical_Centre_NameLabel;
            System.Windows.Forms.Label eMIS_NumberLabel;
            System.Windows.Forms.Label doctor_GP_Appointment_RefLabel;
            System.Windows.Forms.Label doctor_Patient_NHS_NumberLabel;
            System.Windows.Forms.Label gP_Appointment_GP_Appointment_RefLabel;
            System.Windows.Forms.Label gP_Appointment_Patient_NHS_NumberLabel;
            System.Windows.Forms.Label invoice_NoLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label date_of_BirthLabel;
            System.Windows.Forms.Label billing_NameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label post_CodeLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label countryLabel;
            this.pharmacyDataSet = new CS_Pharmacy_Management_System.PharmacyDataSet();
            this.pharmacy_OfficeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacy_OfficeTableAdapter = new CS_Pharmacy_Management_System.PharmacyDataSetTableAdapters.Pharmacy_OfficeTableAdapter();
            this.tableAdapterManager = new CS_Pharmacy_Management_System.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.pharmacy_OfficeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pharmacy_OfficeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.reference_NumberTextBox = new System.Windows.Forms.TextBox();
            this.patient__IDTextBox = new System.Windows.Forms.TextBox();
            this.doctor_s_NHS_NoTextBox = new System.Windows.Forms.TextBox();
            this.medical_Centre_NameTextBox = new System.Windows.Forms.TextBox();
            this.eMIS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.doctor_GP_Appointment_RefTextBox = new System.Windows.Forms.TextBox();
            this.doctor_Patient_NHS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.gP_Appointment_GP_Appointment_RefTextBox = new System.Windows.Forms.TextBox();
            this.gP_Appointment_Patient_NHS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.invoice_NoTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.date_of_BirthTextBox = new System.Windows.Forms.TextBox();
            this.billing_NameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.post_CodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            reference_NumberLabel = new System.Windows.Forms.Label();
            patient__IDLabel = new System.Windows.Forms.Label();
            doctor_s_NHS_NoLabel = new System.Windows.Forms.Label();
            medical_Centre_NameLabel = new System.Windows.Forms.Label();
            eMIS_NumberLabel = new System.Windows.Forms.Label();
            doctor_GP_Appointment_RefLabel = new System.Windows.Forms.Label();
            doctor_Patient_NHS_NumberLabel = new System.Windows.Forms.Label();
            gP_Appointment_GP_Appointment_RefLabel = new System.Windows.Forms.Label();
            gP_Appointment_Patient_NHS_NumberLabel = new System.Windows.Forms.Label();
            invoice_NoLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            date_of_BirthLabel = new System.Windows.Forms.Label();
            billing_NameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            post_CodeLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_OfficeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_OfficeBindingNavigator)).BeginInit();
            this.pharmacy_OfficeBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pharmacy_OfficeBindingSource
            // 
            this.pharmacy_OfficeBindingSource.DataMember = "Pharmacy_Office";
            this.pharmacy_OfficeBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacy_OfficeTableAdapter
            // 
            this.pharmacy_OfficeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.GP_AppointmentTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CS_Pharmacy_Management_System.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pharmacy_OfficeBindingNavigator
            // 
            this.pharmacy_OfficeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pharmacy_OfficeBindingNavigator.BindingSource = this.pharmacy_OfficeBindingSource;
            this.pharmacy_OfficeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pharmacy_OfficeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pharmacy_OfficeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pharmacy_OfficeBindingNavigatorSaveItem});
            this.pharmacy_OfficeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pharmacy_OfficeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pharmacy_OfficeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pharmacy_OfficeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pharmacy_OfficeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pharmacy_OfficeBindingNavigator.Name = "pharmacy_OfficeBindingNavigator";
            this.pharmacy_OfficeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pharmacy_OfficeBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.pharmacy_OfficeBindingNavigator.TabIndex = 0;
            this.pharmacy_OfficeBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // pharmacy_OfficeBindingNavigatorSaveItem
            // 
            this.pharmacy_OfficeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pharmacy_OfficeBindingNavigatorSaveItem.Enabled = false;
            this.pharmacy_OfficeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pharmacy_OfficeBindingNavigatorSaveItem.Image")));
            this.pharmacy_OfficeBindingNavigatorSaveItem.Name = "pharmacy_OfficeBindingNavigatorSaveItem";
            this.pharmacy_OfficeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.pharmacy_OfficeBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // reference_NumberLabel
            // 
            reference_NumberLabel.AutoSize = true;
            reference_NumberLabel.Location = new System.Drawing.Point(77, 55);
            reference_NumberLabel.Name = "reference_NumberLabel";
            reference_NumberLabel.Size = new System.Drawing.Size(100, 13);
            reference_NumberLabel.TabIndex = 1;
            reference_NumberLabel.Text = "Reference Number:";
            // 
            // reference_NumberTextBox
            // 
            this.reference_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Reference Number", true));
            this.reference_NumberTextBox.Location = new System.Drawing.Point(272, 52);
            this.reference_NumberTextBox.Name = "reference_NumberTextBox";
            this.reference_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.reference_NumberTextBox.TabIndex = 2;
            // 
            // patient__IDLabel
            // 
            patient__IDLabel.AutoSize = true;
            patient__IDLabel.Location = new System.Drawing.Point(77, 81);
            patient__IDLabel.Name = "patient__IDLabel";
            patient__IDLabel.Size = new System.Drawing.Size(60, 13);
            patient__IDLabel.TabIndex = 3;
            patient__IDLabel.Text = "Patient  ID:";
            // 
            // patient__IDTextBox
            // 
            this.patient__IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Patient  ID", true));
            this.patient__IDTextBox.Location = new System.Drawing.Point(272, 78);
            this.patient__IDTextBox.Name = "patient__IDTextBox";
            this.patient__IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.patient__IDTextBox.TabIndex = 4;
            // 
            // doctor_s_NHS_NoLabel
            // 
            doctor_s_NHS_NoLabel.AutoSize = true;
            doctor_s_NHS_NoLabel.Location = new System.Drawing.Point(77, 107);
            doctor_s_NHS_NoLabel.Name = "doctor_s_NHS_NoLabel";
            doctor_s_NHS_NoLabel.Size = new System.Drawing.Size(92, 13);
            doctor_s_NHS_NoLabel.TabIndex = 5;
            doctor_s_NHS_NoLabel.Text = "Doctor\'s NHS No:";
            // 
            // doctor_s_NHS_NoTextBox
            // 
            this.doctor_s_NHS_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Doctor\'s NHS No", true));
            this.doctor_s_NHS_NoTextBox.Location = new System.Drawing.Point(272, 104);
            this.doctor_s_NHS_NoTextBox.Name = "doctor_s_NHS_NoTextBox";
            this.doctor_s_NHS_NoTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctor_s_NHS_NoTextBox.TabIndex = 6;
            // 
            // medical_Centre_NameLabel
            // 
            medical_Centre_NameLabel.AutoSize = true;
            medical_Centre_NameLabel.Location = new System.Drawing.Point(77, 133);
            medical_Centre_NameLabel.Name = "medical_Centre_NameLabel";
            medical_Centre_NameLabel.Size = new System.Drawing.Size(112, 13);
            medical_Centre_NameLabel.TabIndex = 7;
            medical_Centre_NameLabel.Text = "Medical Centre Name:";
            // 
            // medical_Centre_NameTextBox
            // 
            this.medical_Centre_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Medical Centre Name", true));
            this.medical_Centre_NameTextBox.Location = new System.Drawing.Point(272, 130);
            this.medical_Centre_NameTextBox.Name = "medical_Centre_NameTextBox";
            this.medical_Centre_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.medical_Centre_NameTextBox.TabIndex = 8;
            // 
            // eMIS_NumberLabel
            // 
            eMIS_NumberLabel.AutoSize = true;
            eMIS_NumberLabel.Location = new System.Drawing.Point(77, 159);
            eMIS_NumberLabel.Name = "eMIS_NumberLabel";
            eMIS_NumberLabel.Size = new System.Drawing.Size(76, 13);
            eMIS_NumberLabel.TabIndex = 9;
            eMIS_NumberLabel.Text = "EMIS Number:";
            // 
            // eMIS_NumberTextBox
            // 
            this.eMIS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "EMIS Number", true));
            this.eMIS_NumberTextBox.Location = new System.Drawing.Point(272, 156);
            this.eMIS_NumberTextBox.Name = "eMIS_NumberTextBox";
            this.eMIS_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.eMIS_NumberTextBox.TabIndex = 10;
            // 
            // doctor_GP_Appointment_RefLabel
            // 
            doctor_GP_Appointment_RefLabel.AutoSize = true;
            doctor_GP_Appointment_RefLabel.Location = new System.Drawing.Point(77, 185);
            doctor_GP_Appointment_RefLabel.Name = "doctor_GP_Appointment_RefLabel";
            doctor_GP_Appointment_RefLabel.Size = new System.Drawing.Size(142, 13);
            doctor_GP_Appointment_RefLabel.TabIndex = 11;
            doctor_GP_Appointment_RefLabel.Text = "Doctor GP Appointment Ref:";
            // 
            // doctor_GP_Appointment_RefTextBox
            // 
            this.doctor_GP_Appointment_RefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Doctor_GP Appointment Ref", true));
            this.doctor_GP_Appointment_RefTextBox.Location = new System.Drawing.Point(272, 182);
            this.doctor_GP_Appointment_RefTextBox.Name = "doctor_GP_Appointment_RefTextBox";
            this.doctor_GP_Appointment_RefTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctor_GP_Appointment_RefTextBox.TabIndex = 12;
            // 
            // doctor_Patient_NHS_NumberLabel
            // 
            doctor_Patient_NHS_NumberLabel.AutoSize = true;
            doctor_Patient_NHS_NumberLabel.Location = new System.Drawing.Point(77, 211);
            doctor_Patient_NHS_NumberLabel.Name = "doctor_Patient_NHS_NumberLabel";
            doctor_Patient_NHS_NumberLabel.Size = new System.Drawing.Size(144, 13);
            doctor_Patient_NHS_NumberLabel.TabIndex = 13;
            doctor_Patient_NHS_NumberLabel.Text = "Doctor Patient NHS Number:";
            // 
            // doctor_Patient_NHS_NumberTextBox
            // 
            this.doctor_Patient_NHS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Doctor_Patient NHS Number", true));
            this.doctor_Patient_NHS_NumberTextBox.Location = new System.Drawing.Point(272, 208);
            this.doctor_Patient_NHS_NumberTextBox.Name = "doctor_Patient_NHS_NumberTextBox";
            this.doctor_Patient_NHS_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctor_Patient_NHS_NumberTextBox.TabIndex = 14;
            // 
            // gP_Appointment_GP_Appointment_RefLabel
            // 
            gP_Appointment_GP_Appointment_RefLabel.AutoSize = true;
            gP_Appointment_GP_Appointment_RefLabel.Location = new System.Drawing.Point(77, 237);
            gP_Appointment_GP_Appointment_RefLabel.Name = "gP_Appointment_GP_Appointment_RefLabel";
            gP_Appointment_GP_Appointment_RefLabel.Size = new System.Drawing.Size(187, 13);
            gP_Appointment_GP_Appointment_RefLabel.TabIndex = 15;
            gP_Appointment_GP_Appointment_RefLabel.Text = "GP Appointment GP Appointment Ref:";
            // 
            // gP_Appointment_GP_Appointment_RefTextBox
            // 
            this.gP_Appointment_GP_Appointment_RefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "GP Appointment_GP Appointment Ref", true));
            this.gP_Appointment_GP_Appointment_RefTextBox.Location = new System.Drawing.Point(272, 234);
            this.gP_Appointment_GP_Appointment_RefTextBox.Name = "gP_Appointment_GP_Appointment_RefTextBox";
            this.gP_Appointment_GP_Appointment_RefTextBox.Size = new System.Drawing.Size(100, 20);
            this.gP_Appointment_GP_Appointment_RefTextBox.TabIndex = 16;
            // 
            // gP_Appointment_Patient_NHS_NumberLabel
            // 
            gP_Appointment_Patient_NHS_NumberLabel.AutoSize = true;
            gP_Appointment_Patient_NHS_NumberLabel.Location = new System.Drawing.Point(77, 263);
            gP_Appointment_Patient_NHS_NumberLabel.Name = "gP_Appointment_Patient_NHS_NumberLabel";
            gP_Appointment_Patient_NHS_NumberLabel.Size = new System.Drawing.Size(189, 13);
            gP_Appointment_Patient_NHS_NumberLabel.TabIndex = 17;
            gP_Appointment_Patient_NHS_NumberLabel.Text = "GP Appointment Patient NHS Number:";
            // 
            // gP_Appointment_Patient_NHS_NumberTextBox
            // 
            this.gP_Appointment_Patient_NHS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "GP Appointment_Patient NHS Number", true));
            this.gP_Appointment_Patient_NHS_NumberTextBox.Location = new System.Drawing.Point(272, 260);
            this.gP_Appointment_Patient_NHS_NumberTextBox.Name = "gP_Appointment_Patient_NHS_NumberTextBox";
            this.gP_Appointment_Patient_NHS_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.gP_Appointment_Patient_NHS_NumberTextBox.TabIndex = 18;
            // 
            // invoice_NoLabel
            // 
            invoice_NoLabel.AutoSize = true;
            invoice_NoLabel.Location = new System.Drawing.Point(77, 289);
            invoice_NoLabel.Name = "invoice_NoLabel";
            invoice_NoLabel.Size = new System.Drawing.Size(62, 13);
            invoice_NoLabel.TabIndex = 19;
            invoice_NoLabel.Text = "Invoice No:";
            // 
            // invoice_NoTextBox
            // 
            this.invoice_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Invoice No", true));
            this.invoice_NoTextBox.Location = new System.Drawing.Point(272, 286);
            this.invoice_NoTextBox.Name = "invoice_NoTextBox";
            this.invoice_NoTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoice_NoTextBox.TabIndex = 20;
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new System.Drawing.Point(77, 315);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(55, 13);
            firstnameLabel.TabIndex = 21;
            firstnameLabel.Text = "Firstname:";
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(272, 312);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstnameTextBox.TabIndex = 22;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(77, 341);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(52, 13);
            surnameLabel.TabIndex = 23;
            surnameLabel.Text = "Surname:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(272, 338);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox.TabIndex = 24;
            // 
            // date_of_BirthLabel
            // 
            date_of_BirthLabel.AutoSize = true;
            date_of_BirthLabel.Location = new System.Drawing.Point(77, 367);
            date_of_BirthLabel.Name = "date_of_BirthLabel";
            date_of_BirthLabel.Size = new System.Drawing.Size(69, 13);
            date_of_BirthLabel.TabIndex = 25;
            date_of_BirthLabel.Text = "Date of Birth:";
            // 
            // date_of_BirthTextBox
            // 
            this.date_of_BirthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Date of Birth", true));
            this.date_of_BirthTextBox.Location = new System.Drawing.Point(272, 364);
            this.date_of_BirthTextBox.Name = "date_of_BirthTextBox";
            this.date_of_BirthTextBox.Size = new System.Drawing.Size(100, 20);
            this.date_of_BirthTextBox.TabIndex = 26;
            // 
            // billing_NameLabel
            // 
            billing_NameLabel.AutoSize = true;
            billing_NameLabel.Location = new System.Drawing.Point(77, 393);
            billing_NameLabel.Name = "billing_NameLabel";
            billing_NameLabel.Size = new System.Drawing.Size(68, 13);
            billing_NameLabel.TabIndex = 27;
            billing_NameLabel.Text = "Billing Name:";
            // 
            // billing_NameTextBox
            // 
            this.billing_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Billing Name", true));
            this.billing_NameTextBox.Location = new System.Drawing.Point(272, 390);
            this.billing_NameTextBox.Name = "billing_NameTextBox";
            this.billing_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.billing_NameTextBox.TabIndex = 28;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(77, 419);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 29;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(272, 416);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 30;
            // 
            // post_CodeLabel
            // 
            post_CodeLabel.AutoSize = true;
            post_CodeLabel.Location = new System.Drawing.Point(77, 445);
            post_CodeLabel.Name = "post_CodeLabel";
            post_CodeLabel.Size = new System.Drawing.Size(59, 13);
            post_CodeLabel.TabIndex = 31;
            post_CodeLabel.Text = "Post Code:";
            // 
            // post_CodeTextBox
            // 
            this.post_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Post Code", true));
            this.post_CodeTextBox.Location = new System.Drawing.Point(272, 442);
            this.post_CodeTextBox.Name = "post_CodeTextBox";
            this.post_CodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.post_CodeTextBox.TabIndex = 32;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(77, 471);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 33;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(272, 468);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 34;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(77, 497);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 35;
            countryLabel.Text = "Country:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(272, 494);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.countryTextBox.TabIndex = 36;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(reference_NumberLabel);
            this.Controls.Add(this.reference_NumberTextBox);
            this.Controls.Add(patient__IDLabel);
            this.Controls.Add(this.patient__IDTextBox);
            this.Controls.Add(doctor_s_NHS_NoLabel);
            this.Controls.Add(this.doctor_s_NHS_NoTextBox);
            this.Controls.Add(medical_Centre_NameLabel);
            this.Controls.Add(this.medical_Centre_NameTextBox);
            this.Controls.Add(eMIS_NumberLabel);
            this.Controls.Add(this.eMIS_NumberTextBox);
            this.Controls.Add(doctor_GP_Appointment_RefLabel);
            this.Controls.Add(this.doctor_GP_Appointment_RefTextBox);
            this.Controls.Add(doctor_Patient_NHS_NumberLabel);
            this.Controls.Add(this.doctor_Patient_NHS_NumberTextBox);
            this.Controls.Add(gP_Appointment_GP_Appointment_RefLabel);
            this.Controls.Add(this.gP_Appointment_GP_Appointment_RefTextBox);
            this.Controls.Add(gP_Appointment_Patient_NHS_NumberLabel);
            this.Controls.Add(this.gP_Appointment_Patient_NHS_NumberTextBox);
            this.Controls.Add(invoice_NoLabel);
            this.Controls.Add(this.invoice_NoTextBox);
            this.Controls.Add(firstnameLabel);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(date_of_BirthLabel);
            this.Controls.Add(this.date_of_BirthTextBox);
            this.Controls.Add(billing_NameLabel);
            this.Controls.Add(this.billing_NameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(post_CodeLabel);
            this.Controls.Add(this.post_CodeTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.pharmacy_OfficeBindingNavigator);
            this.Name = "Form7";
            this.Text = "Pharmacy Office";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_OfficeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_OfficeBindingNavigator)).EndInit();
            this.pharmacy_OfficeBindingNavigator.ResumeLayout(false);
            this.pharmacy_OfficeBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource pharmacy_OfficeBindingSource;
        private PharmacyDataSetTableAdapters.Pharmacy_OfficeTableAdapter pharmacy_OfficeTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pharmacy_OfficeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pharmacy_OfficeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox reference_NumberTextBox;
        private System.Windows.Forms.TextBox patient__IDTextBox;
        private System.Windows.Forms.TextBox doctor_s_NHS_NoTextBox;
        private System.Windows.Forms.TextBox medical_Centre_NameTextBox;
        private System.Windows.Forms.TextBox eMIS_NumberTextBox;
        private System.Windows.Forms.TextBox doctor_GP_Appointment_RefTextBox;
        private System.Windows.Forms.TextBox doctor_Patient_NHS_NumberTextBox;
        private System.Windows.Forms.TextBox gP_Appointment_GP_Appointment_RefTextBox;
        private System.Windows.Forms.TextBox gP_Appointment_Patient_NHS_NumberTextBox;
        private System.Windows.Forms.TextBox invoice_NoTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox date_of_BirthTextBox;
        private System.Windows.Forms.TextBox billing_NameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox post_CodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
    }
}