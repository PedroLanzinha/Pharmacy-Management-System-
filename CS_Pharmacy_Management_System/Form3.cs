using System;
using System.Windows.Forms;

namespace CS_Pharmacy_Management_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void gP_AppointmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gP_AppointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.GP_Appointment' table. You can move, or remove it, as needed.
            this.gP_AppointmentTableAdapter.Fill(this.pharmacyDataSet.GP_Appointment);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm if you want to exit", "Pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCloseClick(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm if you want to exit doctor's report", "Pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.gP_AppointmentBindingSource.AddNew();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.gP_AppointmentBindingSource.RemoveCurrent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.gP_AppointmentBindingSource.MoveNext();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.gP_AppointmentBindingSource.MovePrevious();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gP_AppointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);
        }
    }
}
