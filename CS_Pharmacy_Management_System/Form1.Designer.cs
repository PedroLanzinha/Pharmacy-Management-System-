﻿namespace CS_Pharmacy_Management_System
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnGP = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnPharmacy = new System.Windows.Forms.Button();
            this.btnPharmacy_Office = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnPharma = new System.Windows.Forms.Button();
            this.btnPharmacist = new System.Windows.Forms.Button();
            this.btnConsultant = new System.Windows.Forms.Button();
            this.btnSpecialist = new System.Windows.Forms.Button();
            this.btnHospital = new System.Windows.Forms.Button();
            this.btnSurgery = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Location = new System.Drawing.Point(394, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 281);
            this.panel1.TabIndex = 1;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(342, 203);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(142, 35);
            this.button9.TabIndex = 2;
            this.button9.Text = "Clear";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnClear);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(72, 203);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(142, 35);
            this.button8.TabIndex = 2;
            this.button8.Text = "Login";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnLogin);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(248, 83);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(179, 35);
            this.txtPassword.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(248, 33);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(179, 35);
            this.txtUsername.TabIndex = 0;
            // 
            // btnDoctor
            // 
            this.btnDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.Location = new System.Drawing.Point(190, 197);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(142, 35);
            this.btnDoctor.TabIndex = 0;
            this.btnDoctor.Text = "Doctor";
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_click);
            // 
            // btnGP
            // 
            this.btnGP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGP.Location = new System.Drawing.Point(190, 238);
            this.btnGP.Name = "btnGP";
            this.btnGP.Size = new System.Drawing.Size(142, 35);
            this.btnGP.TabIndex = 0;
            this.btnGP.Text = "GP Appointment";
            this.btnGP.UseVisualStyleBackColor = true;
            this.btnGP.Click += new System.EventHandler(this.btnGP_click);
            // 
            // btnPatient
            // 
            this.btnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.Location = new System.Drawing.Point(190, 279);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(142, 35);
            this.btnPatient.TabIndex = 0;
            this.btnPatient.Text = "Patients";
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_click);
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(190, 320);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(142, 35);
            this.btnPayment.TabIndex = 0;
            this.btnPayment.Text = "Payments";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_click);
            // 
            // btnPharmacy
            // 
            this.btnPharmacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPharmacy.Location = new System.Drawing.Point(190, 361);
            this.btnPharmacy.Name = "btnPharmacy";
            this.btnPharmacy.Size = new System.Drawing.Size(142, 35);
            this.btnPharmacy.TabIndex = 0;
            this.btnPharmacy.Text = "Pharmacy";
            this.btnPharmacy.UseVisualStyleBackColor = true;
            this.btnPharmacy.Click += new System.EventHandler(this.btnPharmacy_click);
            // 
            // btnPharmacy_Office
            // 
            this.btnPharmacy_Office.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPharmacy_Office.Location = new System.Drawing.Point(190, 402);
            this.btnPharmacy_Office.Name = "btnPharmacy_Office";
            this.btnPharmacy_Office.Size = new System.Drawing.Size(142, 35);
            this.btnPharmacy_Office.TabIndex = 0;
            this.btnPharmacy_Office.Text = "Pharmacy Office";
            this.btnPharmacy_Office.UseVisualStyleBackColor = true;
            this.btnPharmacy_Office.Click += new System.EventHandler(this.btnPharmacy_Office_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(190, 443);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 35);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(162, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 108);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(945, 73);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pharmacy Management System";
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(1018, 443);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(142, 35);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnPharma
            // 
            this.btnPharma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPharma.Location = new System.Drawing.Point(1018, 402);
            this.btnPharma.Name = "btnPharma";
            this.btnPharma.Size = new System.Drawing.Size(142, 35);
            this.btnPharma.TabIndex = 4;
            this.btnPharma.Text = "Pharma Firms";
            this.btnPharma.UseVisualStyleBackColor = true;
            // 
            // btnPharmacist
            // 
            this.btnPharmacist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPharmacist.Location = new System.Drawing.Point(1018, 361);
            this.btnPharmacist.Name = "btnPharmacist";
            this.btnPharmacist.Size = new System.Drawing.Size(142, 35);
            this.btnPharmacist.TabIndex = 5;
            this.btnPharmacist.Text = "Pharmacist";
            this.btnPharmacist.UseVisualStyleBackColor = true;
            // 
            // btnConsultant
            // 
            this.btnConsultant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultant.Location = new System.Drawing.Point(1018, 320);
            this.btnConsultant.Name = "btnConsultant";
            this.btnConsultant.Size = new System.Drawing.Size(142, 35);
            this.btnConsultant.TabIndex = 6;
            this.btnConsultant.Text = "Consultant";
            this.btnConsultant.UseVisualStyleBackColor = true;
            // 
            // btnSpecialist
            // 
            this.btnSpecialist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecialist.Location = new System.Drawing.Point(1018, 279);
            this.btnSpecialist.Name = "btnSpecialist";
            this.btnSpecialist.Size = new System.Drawing.Size(142, 35);
            this.btnSpecialist.TabIndex = 7;
            this.btnSpecialist.Text = "Specialist";
            this.btnSpecialist.UseVisualStyleBackColor = true;
            // 
            // btnHospital
            // 
            this.btnHospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospital.Location = new System.Drawing.Point(1018, 238);
            this.btnHospital.Name = "btnHospital";
            this.btnHospital.Size = new System.Drawing.Size(142, 35);
            this.btnHospital.TabIndex = 8;
            this.btnHospital.Text = "Hospital";
            this.btnHospital.UseVisualStyleBackColor = true;
            // 
            // btnSurgery
            // 
            this.btnSurgery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurgery.Location = new System.Drawing.Point(1018, 197);
            this.btnSurgery.Name = "btnSurgery";
            this.btnSurgery.Size = new System.Drawing.Size(142, 35);
            this.btnSurgery.TabIndex = 9;
            this.btnSurgery.Text = "Surgery";
            this.btnSurgery.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 729);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnPharma);
            this.Controls.Add(this.btnPharmacist);
            this.Controls.Add(this.btnConsultant);
            this.Controls.Add(this.btnSpecialist);
            this.Controls.Add(this.btnHospital);
            this.Controls.Add(this.btnSurgery);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPharmacy_Office);
            this.Controls.Add(this.btnPharmacy);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnPatient);
            this.Controls.Add(this.btnGP);
            this.Controls.Add(this.btnDoctor);
            this.Name = "Form1";
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnGP;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnPharmacy;
        private System.Windows.Forms.Button btnPharmacy_Office;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnPharma;
        private System.Windows.Forms.Button btnPharmacist;
        private System.Windows.Forms.Button btnConsultant;
        private System.Windows.Forms.Button btnSpecialist;
        private System.Windows.Forms.Button btnHospital;
        private System.Windows.Forms.Button btnSurgery;
    }
}

