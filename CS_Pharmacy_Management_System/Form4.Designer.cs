namespace CS_Pharmacy_Management_System
{
    partial class Form4
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
            System.Windows.Forms.Label nI_NumberLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label date_of_BirthLabel;
            System.Windows.Forms.Label billing_NameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label post_CodeLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label home_PhoneLabel;
            System.Windows.Forms.Label mobile_PhoneLabel;
            System.Windows.Forms.Label fax_PhoneLabel;
            System.Windows.Forms.Label menoLabel;
            System.Windows.Forms.Label patient__IDLabel;
            System.Windows.Forms.Label patient_NHS_NumberLabel;
            System.Windows.Forms.Label eMIS_NumberLabel;
            System.Windows.Forms.Label gP_Appointment_RefLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pharmacyDataSet = new CS_Pharmacy_Management_System.PharmacyDataSet();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new CS_Pharmacy_Management_System.PharmacyDataSetTableAdapters.PatientTableAdapter();
            this.tableAdapterManager = new CS_Pharmacy_Management_System.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.patientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.patientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nI_NumberTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.date_of_BirthTextBox = new System.Windows.Forms.TextBox();
            this.billing_NameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.post_CodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.home_PhoneTextBox = new System.Windows.Forms.TextBox();
            this.mobile_PhoneTextBox = new System.Windows.Forms.TextBox();
            this.fax_PhoneTextBox = new System.Windows.Forms.TextBox();
            this.menoTextBox = new System.Windows.Forms.TextBox();
            this.patient__IDTextBox = new System.Windows.Forms.TextBox();
            this.patient_NHS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.eMIS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.gP_Appointment_RefTextBox = new System.Windows.Forms.TextBox();
            nI_NumberLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            date_of_BirthLabel = new System.Windows.Forms.Label();
            billing_NameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            post_CodeLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            home_PhoneLabel = new System.Windows.Forms.Label();
            mobile_PhoneLabel = new System.Windows.Forms.Label();
            fax_PhoneLabel = new System.Windows.Forms.Label();
            menoLabel = new System.Windows.Forms.Label();
            patient__IDLabel = new System.Windows.Forms.Label();
            patient_NHS_NumberLabel = new System.Windows.Forms.Label();
            eMIS_NumberLabel = new System.Windows.Forms.Label();
            gP_Appointment_RefLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingNavigator)).BeginInit();
            this.patientBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nI_NumberLabel
            // 
            nI_NumberLabel.AutoSize = true;
            nI_NumberLabel.Location = new System.Drawing.Point(325, 54);
            nI_NumberLabel.Name = "nI_NumberLabel";
            nI_NumberLabel.Size = new System.Drawing.Size(61, 13);
            nI_NumberLabel.TabIndex = 1;
            nI_NumberLabel.Text = "NI Number:";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new System.Drawing.Point(325, 80);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(55, 13);
            firstnameLabel.TabIndex = 3;
            firstnameLabel.Text = "Firstname:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(325, 106);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(52, 13);
            surnameLabel.TabIndex = 5;
            surnameLabel.Text = "Surname:";
            // 
            // date_of_BirthLabel
            // 
            date_of_BirthLabel.AutoSize = true;
            date_of_BirthLabel.Location = new System.Drawing.Point(325, 132);
            date_of_BirthLabel.Name = "date_of_BirthLabel";
            date_of_BirthLabel.Size = new System.Drawing.Size(69, 13);
            date_of_BirthLabel.TabIndex = 7;
            date_of_BirthLabel.Text = "Date of Birth:";
            // 
            // billing_NameLabel
            // 
            billing_NameLabel.AutoSize = true;
            billing_NameLabel.Location = new System.Drawing.Point(325, 158);
            billing_NameLabel.Name = "billing_NameLabel";
            billing_NameLabel.Size = new System.Drawing.Size(68, 13);
            billing_NameLabel.TabIndex = 9;
            billing_NameLabel.Text = "Billing Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(325, 184);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 11;
            addressLabel.Text = "Address:";
            // 
            // post_CodeLabel
            // 
            post_CodeLabel.AutoSize = true;
            post_CodeLabel.Location = new System.Drawing.Point(325, 210);
            post_CodeLabel.Name = "post_CodeLabel";
            post_CodeLabel.Size = new System.Drawing.Size(59, 13);
            post_CodeLabel.TabIndex = 13;
            post_CodeLabel.Text = "Post Code:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(325, 236);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 15;
            cityLabel.Text = "City:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(325, 262);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 17;
            countryLabel.Text = "Country:";
            // 
            // home_PhoneLabel
            // 
            home_PhoneLabel.AutoSize = true;
            home_PhoneLabel.Location = new System.Drawing.Point(325, 288);
            home_PhoneLabel.Name = "home_PhoneLabel";
            home_PhoneLabel.Size = new System.Drawing.Size(72, 13);
            home_PhoneLabel.TabIndex = 19;
            home_PhoneLabel.Text = "Home Phone:";
            // 
            // mobile_PhoneLabel
            // 
            mobile_PhoneLabel.AutoSize = true;
            mobile_PhoneLabel.Location = new System.Drawing.Point(325, 314);
            mobile_PhoneLabel.Name = "mobile_PhoneLabel";
            mobile_PhoneLabel.Size = new System.Drawing.Size(75, 13);
            mobile_PhoneLabel.TabIndex = 21;
            mobile_PhoneLabel.Text = "Mobile Phone:";
            // 
            // fax_PhoneLabel
            // 
            fax_PhoneLabel.AutoSize = true;
            fax_PhoneLabel.Location = new System.Drawing.Point(325, 340);
            fax_PhoneLabel.Name = "fax_PhoneLabel";
            fax_PhoneLabel.Size = new System.Drawing.Size(61, 13);
            fax_PhoneLabel.TabIndex = 23;
            fax_PhoneLabel.Text = "Fax Phone:";
            // 
            // menoLabel
            // 
            menoLabel.AutoSize = true;
            menoLabel.Location = new System.Drawing.Point(325, 366);
            menoLabel.Name = "menoLabel";
            menoLabel.Size = new System.Drawing.Size(37, 13);
            menoLabel.TabIndex = 25;
            menoLabel.Text = "Meno:";
            // 
            // patient__IDLabel
            // 
            patient__IDLabel.AutoSize = true;
            patient__IDLabel.Location = new System.Drawing.Point(325, 392);
            patient__IDLabel.Name = "patient__IDLabel";
            patient__IDLabel.Size = new System.Drawing.Size(60, 13);
            patient__IDLabel.TabIndex = 27;
            patient__IDLabel.Text = "Patient  ID:";
            // 
            // patient_NHS_NumberLabel
            // 
            patient_NHS_NumberLabel.AutoSize = true;
            patient_NHS_NumberLabel.Location = new System.Drawing.Point(325, 418);
            patient_NHS_NumberLabel.Name = "patient_NHS_NumberLabel";
            patient_NHS_NumberLabel.Size = new System.Drawing.Size(109, 13);
            patient_NHS_NumberLabel.TabIndex = 29;
            patient_NHS_NumberLabel.Text = "Patient NHS Number:";
            // 
            // eMIS_NumberLabel
            // 
            eMIS_NumberLabel.AutoSize = true;
            eMIS_NumberLabel.Location = new System.Drawing.Point(325, 444);
            eMIS_NumberLabel.Name = "eMIS_NumberLabel";
            eMIS_NumberLabel.Size = new System.Drawing.Size(76, 13);
            eMIS_NumberLabel.TabIndex = 31;
            eMIS_NumberLabel.Text = "EMIS Number:";
            // 
            // gP_Appointment_RefLabel
            // 
            gP_Appointment_RefLabel.AutoSize = true;
            gP_Appointment_RefLabel.Location = new System.Drawing.Point(325, 470);
            gP_Appointment_RefLabel.Name = "gP_Appointment_RefLabel";
            gP_Appointment_RefLabel.Size = new System.Drawing.Size(107, 13);
            gP_Appointment_RefLabel.TabIndex = 33;
            gP_Appointment_RefLabel.Text = "GP Appointment Ref:";
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.GP_AppointmentTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = this.patientTableAdapter;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CS_Pharmacy_Management_System.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // patientBindingNavigator
            // 
            this.patientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientBindingNavigator.BindingSource = this.patientBindingSource;
            this.patientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.patientBindingNavigatorSaveItem});
            this.patientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientBindingNavigator.Name = "patientBindingNavigator";
            this.patientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientBindingNavigator.Size = new System.Drawing.Size(884, 25);
            this.patientBindingNavigator.TabIndex = 0;
            this.patientBindingNavigator.Text = "bindingNavigator1";
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
            // patientBindingNavigatorSaveItem
            // 
            this.patientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientBindingNavigatorSaveItem.Image")));
            this.patientBindingNavigatorSaveItem.Name = "patientBindingNavigatorSaveItem";
            this.patientBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.patientBindingNavigatorSaveItem.Text = "Save Data";
            this.patientBindingNavigatorSaveItem.Click += new System.EventHandler(this.patientBindingNavigatorSaveItem_Click);
            // 
            // nI_NumberTextBox
            // 
            this.nI_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "NI Number", true));
            this.nI_NumberTextBox.Location = new System.Drawing.Point(440, 51);
            this.nI_NumberTextBox.Name = "nI_NumberTextBox";
            this.nI_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.nI_NumberTextBox.TabIndex = 2;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(440, 77);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstnameTextBox.TabIndex = 4;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(440, 103);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox.TabIndex = 6;
            // 
            // date_of_BirthTextBox
            // 
            this.date_of_BirthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Date of Birth", true));
            this.date_of_BirthTextBox.Location = new System.Drawing.Point(440, 129);
            this.date_of_BirthTextBox.Name = "date_of_BirthTextBox";
            this.date_of_BirthTextBox.Size = new System.Drawing.Size(100, 20);
            this.date_of_BirthTextBox.TabIndex = 8;
            // 
            // billing_NameTextBox
            // 
            this.billing_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Billing Name", true));
            this.billing_NameTextBox.Location = new System.Drawing.Point(440, 155);
            this.billing_NameTextBox.Name = "billing_NameTextBox";
            this.billing_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.billing_NameTextBox.TabIndex = 10;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(440, 181);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 12;
            // 
            // post_CodeTextBox
            // 
            this.post_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Post Code", true));
            this.post_CodeTextBox.Location = new System.Drawing.Point(440, 207);
            this.post_CodeTextBox.Name = "post_CodeTextBox";
            this.post_CodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.post_CodeTextBox.TabIndex = 14;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(440, 233);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 16;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(440, 259);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.countryTextBox.TabIndex = 18;
            // 
            // home_PhoneTextBox
            // 
            this.home_PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Home Phone", true));
            this.home_PhoneTextBox.Location = new System.Drawing.Point(440, 285);
            this.home_PhoneTextBox.Name = "home_PhoneTextBox";
            this.home_PhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.home_PhoneTextBox.TabIndex = 20;
            // 
            // mobile_PhoneTextBox
            // 
            this.mobile_PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Mobile Phone", true));
            this.mobile_PhoneTextBox.Location = new System.Drawing.Point(440, 311);
            this.mobile_PhoneTextBox.Name = "mobile_PhoneTextBox";
            this.mobile_PhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.mobile_PhoneTextBox.TabIndex = 22;
            // 
            // fax_PhoneTextBox
            // 
            this.fax_PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Fax Phone", true));
            this.fax_PhoneTextBox.Location = new System.Drawing.Point(440, 337);
            this.fax_PhoneTextBox.Name = "fax_PhoneTextBox";
            this.fax_PhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.fax_PhoneTextBox.TabIndex = 24;
            // 
            // menoTextBox
            // 
            this.menoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Meno", true));
            this.menoTextBox.Location = new System.Drawing.Point(440, 363);
            this.menoTextBox.Name = "menoTextBox";
            this.menoTextBox.Size = new System.Drawing.Size(100, 20);
            this.menoTextBox.TabIndex = 26;
            // 
            // patient__IDTextBox
            // 
            this.patient__IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Patient  ID", true));
            this.patient__IDTextBox.Location = new System.Drawing.Point(440, 389);
            this.patient__IDTextBox.Name = "patient__IDTextBox";
            this.patient__IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.patient__IDTextBox.TabIndex = 28;
            // 
            // patient_NHS_NumberTextBox
            // 
            this.patient_NHS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Patient NHS Number", true));
            this.patient_NHS_NumberTextBox.Location = new System.Drawing.Point(440, 415);
            this.patient_NHS_NumberTextBox.Name = "patient_NHS_NumberTextBox";
            this.patient_NHS_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.patient_NHS_NumberTextBox.TabIndex = 30;
            // 
            // eMIS_NumberTextBox
            // 
            this.eMIS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "EMIS Number", true));
            this.eMIS_NumberTextBox.Location = new System.Drawing.Point(440, 441);
            this.eMIS_NumberTextBox.Name = "eMIS_NumberTextBox";
            this.eMIS_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.eMIS_NumberTextBox.TabIndex = 32;
            // 
            // gP_Appointment_RefTextBox
            // 
            this.gP_Appointment_RefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "GP Appointment Ref", true));
            this.gP_Appointment_RefTextBox.Location = new System.Drawing.Point(440, 467);
            this.gP_Appointment_RefTextBox.Name = "gP_Appointment_RefTextBox";
            this.gP_Appointment_RefTextBox.Size = new System.Drawing.Size(100, 20);
            this.gP_Appointment_RefTextBox.TabIndex = 34;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 545);
            this.Controls.Add(nI_NumberLabel);
            this.Controls.Add(this.nI_NumberTextBox);
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
            this.Controls.Add(home_PhoneLabel);
            this.Controls.Add(this.home_PhoneTextBox);
            this.Controls.Add(mobile_PhoneLabel);
            this.Controls.Add(this.mobile_PhoneTextBox);
            this.Controls.Add(fax_PhoneLabel);
            this.Controls.Add(this.fax_PhoneTextBox);
            this.Controls.Add(menoLabel);
            this.Controls.Add(this.menoTextBox);
            this.Controls.Add(patient__IDLabel);
            this.Controls.Add(this.patient__IDTextBox);
            this.Controls.Add(patient_NHS_NumberLabel);
            this.Controls.Add(this.patient_NHS_NumberTextBox);
            this.Controls.Add(eMIS_NumberLabel);
            this.Controls.Add(this.eMIS_NumberTextBox);
            this.Controls.Add(gP_Appointment_RefLabel);
            this.Controls.Add(this.gP_Appointment_RefTextBox);
            this.Controls.Add(this.patientBindingNavigator);
            this.Name = "Form4";
            this.Text = " Patients ";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingNavigator)).EndInit();
            this.patientBindingNavigator.ResumeLayout(false);
            this.patientBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private PharmacyDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patientBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton patientBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nI_NumberTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox date_of_BirthTextBox;
        private System.Windows.Forms.TextBox billing_NameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox post_CodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox home_PhoneTextBox;
        private System.Windows.Forms.TextBox mobile_PhoneTextBox;
        private System.Windows.Forms.TextBox fax_PhoneTextBox;
        private System.Windows.Forms.TextBox menoTextBox;
        private System.Windows.Forms.TextBox patient__IDTextBox;
        private System.Windows.Forms.TextBox patient_NHS_NumberTextBox;
        private System.Windows.Forms.TextBox eMIS_NumberTextBox;
        private System.Windows.Forms.TextBox gP_Appointment_RefTextBox;
    }
}