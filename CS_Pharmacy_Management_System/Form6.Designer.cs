namespace CS_Pharmacy_Management_System
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            System.Windows.Forms.Label reference_NumberLabel;
            System.Windows.Forms.Label name_of_TabletsLabel;
            System.Windows.Forms.Label dose__mg_Label;
            System.Windows.Forms.Label number_of_TabletsLabel;
            System.Windows.Forms.Label lOTLabel;
            System.Windows.Forms.Label issued_DateLabel;
            System.Windows.Forms.Label exp_DateLabel;
            System.Windows.Forms.Label daily_DoseLabel;
            System.Windows.Forms.Label possible_Side_EffectsLabel;
            System.Windows.Forms.Label further_InformationLabel;
            System.Windows.Forms.Label storage_AdviceLabel;
            System.Windows.Forms.Label administrationLabel;
            System.Windows.Forms.Label driving_and_Using_MachinesLabel;
            System.Windows.Forms.Label how_to_Use_MedicationLabel;
            System.Windows.Forms.Label patient__IDLabel;
            System.Windows.Forms.Label doctor_s_NHS_NoLabel;
            this.pharmacyDataSet = new CS_Pharmacy_Management_System.PharmacyDataSet();
            this.pharmacyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyTableAdapter = new CS_Pharmacy_Management_System.PharmacyDataSetTableAdapters.PharmacyTableAdapter();
            this.tableAdapterManager = new CS_Pharmacy_Management_System.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.pharmacyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pharmacyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.reference_NumberTextBox = new System.Windows.Forms.TextBox();
            this.name_of_TabletsTextBox = new System.Windows.Forms.TextBox();
            this.dose__mg_TextBox = new System.Windows.Forms.TextBox();
            this.number_of_TabletsTextBox = new System.Windows.Forms.TextBox();
            this.lOTTextBox = new System.Windows.Forms.TextBox();
            this.issued_DateTextBox = new System.Windows.Forms.TextBox();
            this.exp_DateTextBox = new System.Windows.Forms.TextBox();
            this.daily_DoseTextBox = new System.Windows.Forms.TextBox();
            this.possible_Side_EffectsTextBox = new System.Windows.Forms.TextBox();
            this.further_InformationTextBox = new System.Windows.Forms.TextBox();
            this.storage_AdviceTextBox = new System.Windows.Forms.TextBox();
            this.administrationTextBox = new System.Windows.Forms.TextBox();
            this.driving_and_Using_MachinesTextBox = new System.Windows.Forms.TextBox();
            this.how_to_Use_MedicationTextBox = new System.Windows.Forms.TextBox();
            this.patient__IDTextBox = new System.Windows.Forms.TextBox();
            this.doctor_s_NHS_NoTextBox = new System.Windows.Forms.TextBox();
            reference_NumberLabel = new System.Windows.Forms.Label();
            name_of_TabletsLabel = new System.Windows.Forms.Label();
            dose__mg_Label = new System.Windows.Forms.Label();
            number_of_TabletsLabel = new System.Windows.Forms.Label();
            lOTLabel = new System.Windows.Forms.Label();
            issued_DateLabel = new System.Windows.Forms.Label();
            exp_DateLabel = new System.Windows.Forms.Label();
            daily_DoseLabel = new System.Windows.Forms.Label();
            possible_Side_EffectsLabel = new System.Windows.Forms.Label();
            further_InformationLabel = new System.Windows.Forms.Label();
            storage_AdviceLabel = new System.Windows.Forms.Label();
            administrationLabel = new System.Windows.Forms.Label();
            driving_and_Using_MachinesLabel = new System.Windows.Forms.Label();
            how_to_Use_MedicationLabel = new System.Windows.Forms.Label();
            patient__IDLabel = new System.Windows.Forms.Label();
            doctor_s_NHS_NoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingNavigator)).BeginInit();
            this.pharmacyBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pharmacyBindingSource
            // 
            this.pharmacyBindingSource.DataMember = "Pharmacy";
            this.pharmacyBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacyTableAdapter
            // 
            this.pharmacyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.GP_AppointmentTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = this.pharmacyTableAdapter;
            this.tableAdapterManager.UpdateOrder = CS_Pharmacy_Management_System.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pharmacyBindingNavigator
            // 
            this.pharmacyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pharmacyBindingNavigator.BindingSource = this.pharmacyBindingSource;
            this.pharmacyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pharmacyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pharmacyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pharmacyBindingNavigatorSaveItem});
            this.pharmacyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pharmacyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pharmacyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pharmacyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pharmacyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pharmacyBindingNavigator.Name = "pharmacyBindingNavigator";
            this.pharmacyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pharmacyBindingNavigator.Size = new System.Drawing.Size(884, 25);
            this.pharmacyBindingNavigator.TabIndex = 0;
            this.pharmacyBindingNavigator.Text = "bindingNavigator1";
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
            // pharmacyBindingNavigatorSaveItem
            // 
            this.pharmacyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pharmacyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pharmacyBindingNavigatorSaveItem.Image")));
            this.pharmacyBindingNavigatorSaveItem.Name = "pharmacyBindingNavigatorSaveItem";
            this.pharmacyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pharmacyBindingNavigatorSaveItem.Text = "Save Data";
            this.pharmacyBindingNavigatorSaveItem.Click += new System.EventHandler(this.pharmacyBindingNavigatorSaveItem_Click);
            // 
            // reference_NumberLabel
            // 
            reference_NumberLabel.AutoSize = true;
            reference_NumberLabel.Location = new System.Drawing.Point(64, 60);
            reference_NumberLabel.Name = "reference_NumberLabel";
            reference_NumberLabel.Size = new System.Drawing.Size(100, 13);
            reference_NumberLabel.TabIndex = 1;
            reference_NumberLabel.Text = "Reference Number:";
            // 
            // reference_NumberTextBox
            // 
            this.reference_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "Reference Number", true));
            this.reference_NumberTextBox.Location = new System.Drawing.Point(213, 57);
            this.reference_NumberTextBox.Name = "reference_NumberTextBox";
            this.reference_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.reference_NumberTextBox.TabIndex = 2;
            // 
            // name_of_TabletsLabel
            // 
            name_of_TabletsLabel.AutoSize = true;
            name_of_TabletsLabel.Location = new System.Drawing.Point(64, 86);
            name_of_TabletsLabel.Name = "name_of_TabletsLabel";
            name_of_TabletsLabel.Size = new System.Drawing.Size(88, 13);
            name_of_TabletsLabel.TabIndex = 3;
            name_of_TabletsLabel.Text = "Name of Tablets:";
            // 
            // name_of_TabletsTextBox
            // 
            this.name_of_TabletsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "Name of Tablets", true));
            this.name_of_TabletsTextBox.Location = new System.Drawing.Point(213, 83);
            this.name_of_TabletsTextBox.Name = "name_of_TabletsTextBox";
            this.name_of_TabletsTextBox.Size = new System.Drawing.Size(100, 20);
            this.name_of_TabletsTextBox.TabIndex = 4;
            // 
            // dose__mg_Label
            // 
            dose__mg_Label.AutoSize = true;
            dose__mg_Label.Location = new System.Drawing.Point(64, 112);
            dose__mg_Label.Name = "dose__mg_Label";
            dose__mg_Label.Size = new System.Drawing.Size(58, 13);
            dose__mg_Label.TabIndex = 5;
            dose__mg_Label.Text = "Dose (mg):";
            // 
            // dose__mg_TextBox
            // 
            this.dose__mg_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "Dose (mg)", true));
            this.dose__mg_TextBox.Location = new System.Drawing.Point(213, 109);
            this.dose__mg_TextBox.Name = "dose__mg_TextBox";
            this.dose__mg_TextBox.Size = new System.Drawing.Size(100, 20);
            this.dose__mg_TextBox.TabIndex = 6;
            // 
            // number_of_TabletsLabel
            // 
            number_of_TabletsLabel.AutoSize = true;
            number_of_TabletsLabel.Location = new System.Drawing.Point(64, 138);
            number_of_TabletsLabel.Name = "number_of_TabletsLabel";
            number_of_TabletsLabel.Size = new System.Drawing.Size(97, 13);
            number_of_TabletsLabel.TabIndex = 7;
            number_of_TabletsLabel.Text = "Number of Tablets:";
            // 
            // number_of_TabletsTextBox
            // 
            this.number_of_TabletsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "Number of Tablets", true));
            this.number_of_TabletsTextBox.Location = new System.Drawing.Point(213, 135);
            this.number_of_TabletsTextBox.Name = "number_of_TabletsTextBox";
            this.number_of_TabletsTextBox.Size = new System.Drawing.Size(100, 20);
            this.number_of_TabletsTextBox.TabIndex = 8;
            // 
            // lOTLabel
            // 
            lOTLabel.AutoSize = true;
            lOTLabel.Location = new System.Drawing.Point(64, 164);
            lOTLabel.Name = "lOTLabel";
            lOTLabel.Size = new System.Drawing.Size(31, 13);
            lOTLabel.TabIndex = 9;
            lOTLabel.Text = "LOT:";
            // 
            // lOTTextBox
            // 
            this.lOTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "LOT", true));
            this.lOTTextBox.Location = new System.Drawing.Point(213, 161);
            this.lOTTextBox.Name = "lOTTextBox";
            this.lOTTextBox.Size = new System.Drawing.Size(100, 20);
            this.lOTTextBox.TabIndex = 10;
            // 
            // issued_DateLabel
            // 
            issued_DateLabel.AutoSize = true;
            issued_DateLabel.Location = new System.Drawing.Point(64, 190);
            issued_DateLabel.Name = "issued_DateLabel";
            issued_DateLabel.Size = new System.Drawing.Size(67, 13);
            issued_DateLabel.TabIndex = 11;
            issued_DateLabel.Text = "Issued Date:";
            // 
            // issued_DateTextBox
            // 
            this.issued_DateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "Issued Date", true));
            this.issued_DateTextBox.Location = new System.Drawing.Point(213, 187);
            this.issued_DateTextBox.Name = "issued_DateTextBox";
            this.issued_DateTextBox.Size = new System.Drawing.Size(100, 20);
            this.issued_DateTextBox.TabIndex = 12;
            // 
            // exp_DateLabel
            // 
            exp_DateLabel.AutoSize = true;
            exp_DateLabel.Location = new System.Drawing.Point(64, 216);
            exp_DateLabel.Name = "exp_DateLabel";
            exp_DateLabel.Size = new System.Drawing.Size(54, 13);
            exp_DateLabel.TabIndex = 13;
            exp_DateLabel.Text = "Exp Date:";
            // 
            // exp_DateTextBox
            // 
            this.exp_DateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "Exp Date", true));
            this.exp_DateTextBox.Location = new System.Drawing.Point(213, 213);
            this.exp_DateTextBox.Name = "exp_DateTextBox";
            this.exp_DateTextBox.Size = new System.Drawing.Size(100, 20);
            this.exp_DateTextBox.TabIndex = 14;
            // 
            // daily_DoseLabel
            // 
            daily_DoseLabel.AutoSize = true;
            daily_DoseLabel.Location = new System.Drawing.Point(64, 242);
            daily_DoseLabel.Name = "daily_DoseLabel";
            daily_DoseLabel.Size = new System.Drawing.Size(61, 13);
            daily_DoseLabel.TabIndex = 15;
            daily_DoseLabel.Text = "Daily Dose:";
            // 
            // daily_DoseTextBox
            // 
            this.daily_DoseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "Daily Dose", true));
            this.daily_DoseTextBox.Location = new System.Drawing.Point(213, 239);
            this.daily_DoseTextBox.Name = "daily_DoseTextBox";
            this.daily_DoseTextBox.Size = new System.Drawing.Size(100, 20);
            this.daily_DoseTextBox.TabIndex = 16;
            // 
            // possible_Side_EffectsLabel
            // 
            possible_Side_EffectsLabel.AutoSize = true;
            possible_Side_EffectsLabel.Location = new System.Drawing.Point(64, 268);
            possible_Side_EffectsLabel.Name = "possible_Side_EffectsLabel";
            possible_Side_EffectsLabel.Size = new System.Drawing.Size(109, 13);
            possible_Side_EffectsLabel.TabIndex = 17;
            possible_Side_EffectsLabel.Text = "Possible Side Effects:";
            // 
            // possible_Side_EffectsTextBox
            // 
            this.possible_Side_EffectsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "Possible Side Effects", true));
            this.possible_Side_EffectsTextBox.Location = new System.Drawing.Point(213, 265);
            this.possible_Side_EffectsTextBox.Name = "possible_Side_EffectsTextBox";
            this.possible_Side_EffectsTextBox.Size = new System.Drawing.Size(100, 20);
            this.possible_Side_EffectsTextBox.TabIndex = 18;
            // 
            // further_InformationLabel
            // 
            further_InformationLabel.AutoSize = true;
            further_InformationLabel.Location = new System.Drawing.Point(64, 294);
            further_InformationLabel.Name = "further_InformationLabel";
            further_InformationLabel.Size = new System.Drawing.Size(98, 13);
            further_InformationLabel.TabIndex = 19;
            further_InformationLabel.Text = "Further Information:";
            // 
            // further_InformationTextBox
            // 
            this.further_InformationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "Further Information", true));
            this.further_InformationTextBox.Location = new System.Drawing.Point(213, 291);
            this.further_InformationTextBox.Name = "further_InformationTextBox";
            this.further_InformationTextBox.Size = new System.Drawing.Size(100, 20);
            this.further_InformationTextBox.TabIndex = 20;
            // 
            // storage_AdviceLabel
            // 
            storage_AdviceLabel.AutoSize = true;
            storage_AdviceLabel.Location = new System.Drawing.Point(64, 320);
            storage_AdviceLabel.Name = "storage_AdviceLabel";
            storage_AdviceLabel.Size = new System.Drawing.Size(83, 13);
            storage_AdviceLabel.TabIndex = 21;
            storage_AdviceLabel.Text = "Storage Advice:";
            // 
            // storage_AdviceTextBox
            // 
            this.storage_AdviceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "Storage Advice", true));
            this.storage_AdviceTextBox.Location = new System.Drawing.Point(213, 317);
            this.storage_AdviceTextBox.Name = "storage_AdviceTextBox";
            this.storage_AdviceTextBox.Size = new System.Drawing.Size(100, 20);
            this.storage_AdviceTextBox.TabIndex = 22;
            // 
            // administrationLabel
            // 
            administrationLabel.AutoSize = true;
            administrationLabel.Location = new System.Drawing.Point(64, 346);
            administrationLabel.Name = "administrationLabel";
            administrationLabel.Size = new System.Drawing.Size(75, 13);
            administrationLabel.TabIndex = 23;
            administrationLabel.Text = "Administration:";
            // 
            // administrationTextBox
            // 
            this.administrationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "Administration", true));
            this.administrationTextBox.Location = new System.Drawing.Point(213, 343);
            this.administrationTextBox.Name = "administrationTextBox";
            this.administrationTextBox.Size = new System.Drawing.Size(100, 20);
            this.administrationTextBox.TabIndex = 24;
            // 
            // driving_and_Using_MachinesLabel
            // 
            driving_and_Using_MachinesLabel.AutoSize = true;
            driving_and_Using_MachinesLabel.Location = new System.Drawing.Point(64, 372);
            driving_and_Using_MachinesLabel.Name = "driving_and_Using_MachinesLabel";
            driving_and_Using_MachinesLabel.Size = new System.Drawing.Size(143, 13);
            driving_and_Using_MachinesLabel.TabIndex = 25;
            driving_and_Using_MachinesLabel.Text = "Driving and Using Machines:";
            // 
            // driving_and_Using_MachinesTextBox
            // 
            this.driving_and_Using_MachinesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "Driving and Using Machines", true));
            this.driving_and_Using_MachinesTextBox.Location = new System.Drawing.Point(213, 369);
            this.driving_and_Using_MachinesTextBox.Name = "driving_and_Using_MachinesTextBox";
            this.driving_and_Using_MachinesTextBox.Size = new System.Drawing.Size(100, 20);
            this.driving_and_Using_MachinesTextBox.TabIndex = 26;
            // 
            // how_to_Use_MedicationLabel
            // 
            how_to_Use_MedicationLabel.AutoSize = true;
            how_to_Use_MedicationLabel.Location = new System.Drawing.Point(64, 398);
            how_to_Use_MedicationLabel.Name = "how_to_Use_MedicationLabel";
            how_to_Use_MedicationLabel.Size = new System.Drawing.Size(121, 13);
            how_to_Use_MedicationLabel.TabIndex = 27;
            how_to_Use_MedicationLabel.Text = "How to Use Medication:";
            // 
            // how_to_Use_MedicationTextBox
            // 
            this.how_to_Use_MedicationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "How to Use Medication", true));
            this.how_to_Use_MedicationTextBox.Location = new System.Drawing.Point(213, 395);
            this.how_to_Use_MedicationTextBox.Name = "how_to_Use_MedicationTextBox";
            this.how_to_Use_MedicationTextBox.Size = new System.Drawing.Size(100, 20);
            this.how_to_Use_MedicationTextBox.TabIndex = 28;
            // 
            // patient__IDLabel
            // 
            patient__IDLabel.AutoSize = true;
            patient__IDLabel.Location = new System.Drawing.Point(64, 424);
            patient__IDLabel.Name = "patient__IDLabel";
            patient__IDLabel.Size = new System.Drawing.Size(60, 13);
            patient__IDLabel.TabIndex = 29;
            patient__IDLabel.Text = "Patient  ID:";
            // 
            // patient__IDTextBox
            // 
            this.patient__IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "Patient  ID", true));
            this.patient__IDTextBox.Location = new System.Drawing.Point(213, 421);
            this.patient__IDTextBox.Name = "patient__IDTextBox";
            this.patient__IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.patient__IDTextBox.TabIndex = 30;
            // 
            // doctor_s_NHS_NoLabel
            // 
            doctor_s_NHS_NoLabel.AutoSize = true;
            doctor_s_NHS_NoLabel.Location = new System.Drawing.Point(64, 450);
            doctor_s_NHS_NoLabel.Name = "doctor_s_NHS_NoLabel";
            doctor_s_NHS_NoLabel.Size = new System.Drawing.Size(92, 13);
            doctor_s_NHS_NoLabel.TabIndex = 31;
            doctor_s_NHS_NoLabel.Text = "Doctor\'s NHS No:";
            // 
            // doctor_s_NHS_NoTextBox
            // 
            this.doctor_s_NHS_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "Doctor\'s NHS No", true));
            this.doctor_s_NHS_NoTextBox.Location = new System.Drawing.Point(213, 447);
            this.doctor_s_NHS_NoTextBox.Name = "doctor_s_NHS_NoTextBox";
            this.doctor_s_NHS_NoTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctor_s_NHS_NoTextBox.TabIndex = 32;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 498);
            this.Controls.Add(reference_NumberLabel);
            this.Controls.Add(this.reference_NumberTextBox);
            this.Controls.Add(name_of_TabletsLabel);
            this.Controls.Add(this.name_of_TabletsTextBox);
            this.Controls.Add(dose__mg_Label);
            this.Controls.Add(this.dose__mg_TextBox);
            this.Controls.Add(number_of_TabletsLabel);
            this.Controls.Add(this.number_of_TabletsTextBox);
            this.Controls.Add(lOTLabel);
            this.Controls.Add(this.lOTTextBox);
            this.Controls.Add(issued_DateLabel);
            this.Controls.Add(this.issued_DateTextBox);
            this.Controls.Add(exp_DateLabel);
            this.Controls.Add(this.exp_DateTextBox);
            this.Controls.Add(daily_DoseLabel);
            this.Controls.Add(this.daily_DoseTextBox);
            this.Controls.Add(possible_Side_EffectsLabel);
            this.Controls.Add(this.possible_Side_EffectsTextBox);
            this.Controls.Add(further_InformationLabel);
            this.Controls.Add(this.further_InformationTextBox);
            this.Controls.Add(storage_AdviceLabel);
            this.Controls.Add(this.storage_AdviceTextBox);
            this.Controls.Add(administrationLabel);
            this.Controls.Add(this.administrationTextBox);
            this.Controls.Add(driving_and_Using_MachinesLabel);
            this.Controls.Add(this.driving_and_Using_MachinesTextBox);
            this.Controls.Add(how_to_Use_MedicationLabel);
            this.Controls.Add(this.how_to_Use_MedicationTextBox);
            this.Controls.Add(patient__IDLabel);
            this.Controls.Add(this.patient__IDTextBox);
            this.Controls.Add(doctor_s_NHS_NoLabel);
            this.Controls.Add(this.doctor_s_NHS_NoTextBox);
            this.Controls.Add(this.pharmacyBindingNavigator);
            this.Name = "Form6";
            this.Text = "Pharmacy";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingNavigator)).EndInit();
            this.pharmacyBindingNavigator.ResumeLayout(false);
            this.pharmacyBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource pharmacyBindingSource;
        private PharmacyDataSetTableAdapters.PharmacyTableAdapter pharmacyTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pharmacyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pharmacyBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox reference_NumberTextBox;
        private System.Windows.Forms.TextBox name_of_TabletsTextBox;
        private System.Windows.Forms.TextBox dose__mg_TextBox;
        private System.Windows.Forms.TextBox number_of_TabletsTextBox;
        private System.Windows.Forms.TextBox lOTTextBox;
        private System.Windows.Forms.TextBox issued_DateTextBox;
        private System.Windows.Forms.TextBox exp_DateTextBox;
        private System.Windows.Forms.TextBox daily_DoseTextBox;
        private System.Windows.Forms.TextBox possible_Side_EffectsTextBox;
        private System.Windows.Forms.TextBox further_InformationTextBox;
        private System.Windows.Forms.TextBox storage_AdviceTextBox;
        private System.Windows.Forms.TextBox administrationTextBox;
        private System.Windows.Forms.TextBox driving_and_Using_MachinesTextBox;
        private System.Windows.Forms.TextBox how_to_Use_MedicationTextBox;
        private System.Windows.Forms.TextBox patient__IDTextBox;
        private System.Windows.Forms.TextBox doctor_s_NHS_NoTextBox;
    }
}