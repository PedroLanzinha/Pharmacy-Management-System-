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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Doctor = new Form2();
            Doctor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 GP = new Form3();
            GP.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Patient = new Form4();
            Patient.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 Payment = new Form5();
            Payment.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 Pharmacy  = new Form6();
            Pharmacy.Show();
        }

        private void btnPharmacy_Office_Click(object sender, EventArgs e)
        {
            Form7 Pharmacy_Office = new Form7();
            Pharmacy_Office.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm if you want to Exit", "Pharmacy Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "q1" && txtPassword.Text == "sq1")
            {
                btnPharmacy_Office.Enabled = true;
            }
        }


    }
}
