﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Pharmacy_Management_System
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.pharmacyDataSet.Patient);

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
            this.patientBindingSource.AddNew();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.patientBindingSource.RemoveCurrent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.patientBindingSource.MoveNext();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.patientBindingSource.MovePrevious();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);
        }
    }

}
