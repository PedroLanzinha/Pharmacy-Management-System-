using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoctor_click(object sender, EventArgs e)
        {
            Form2 Doctor = new Form2();
            Doctor.Show();
        }

        private void btnGP_click(object sender, EventArgs e)
        {
            Form3 GP = new Form3();
            GP.Show();
        }

        private void btnPatient_click(object sender, EventArgs e)
        {
            Form4 Patient = new Form4();
            Patient.Show();
        }

        private void btnPayment_click(object sender, EventArgs e)
        {
            Form5 Payment = new Form5();
            Payment.Show();
        }

        private void btnPharmacy_click(object sender, EventArgs e)
        {
            Form6 Pharmacy = new Form6();
            Pharmacy.Show();
        }

        private void btnPharmacy_Office_Click(object sender, EventArgs e)
        {
            Form7 Pharmacy_Office = new Form7();
            Pharmacy_Office.Show();
        }

        private void btnExit_click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm if you want to exit", "Pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClear(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();

            btnGP.Enabled = false;
            btnPatient.Enabled = false;
            btnDoctor.Enabled = false;
            btnPatient.Enabled = false;
            btnPayment.Enabled = false;
            btnPharmacy.Enabled = false;
            btnPharmacy_Office.Enabled = false;

            btnSurgery.Enabled = false;
            btnHospital.Enabled = false;
            btnSpecialist.Enabled = false;
            btnConsultant.Enabled = false;
            btnPharmacist.Enabled = false;
            btnPharma.Enabled = false;
        }

        private void btnLogin(object sender, EventArgs e)
        {
            if (txtUsername.Text == "q1" && txtPassword.Text == "sq1")
            {
                btnGP.Enabled = true;
                btnPatient.Enabled = true;
                btnDoctor.Enabled = true;
                btnPatient.Enabled = true;
                btnPayment.Enabled = true;
                btnPharmacy.Enabled = true;
                btnPharmacy_Office.Enabled = true;

                btnSurgery.Enabled = true;
                btnHospital.Enabled = true;
                btnSpecialist.Enabled = true;
                btnConsultant.Enabled = true;
                btnPharmacist.Enabled = true;
                btnPharma.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please enter the correct Username or Password", "Pharmacy Management System");
                txtUsername.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGP.Enabled = false;
            btnPatient.Enabled = false;
            btnDoctor.Enabled = false;
            btnPatient.Enabled = false;
            btnPayment.Enabled = false;
            btnPharmacy.Enabled = false;
            btnPharmacy_Office.Enabled = false;

            btnSurgery.Enabled = false;
            btnHospital.Enabled = false;
            btnSpecialist.Enabled = false;
            btnConsultant.Enabled = false;
            btnPharmacist.Enabled = false;
            btnPharma.Enabled = false;

        }

    }
}
