
using System;

namespace Contact_Tracing_App
{
    partial class contact_tracing_app
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contact_tracing_app));
            this.firstname = new System.Windows.Forms.Label();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_middlename = new System.Windows.Forms.TextBox();
            this.middlename = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.contact_num = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.txt_temp = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.Label();
            this.form2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstname.Location = new System.Drawing.Point(44, 97);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(86, 20);
            this.firstname.TabIndex = 0;
            this.firstname.Text = "First Name";
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(171, 91);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(323, 27);
            this.txt_firstname.TabIndex = 1;
            // 
            // txt_middlename
            // 
            this.txt_middlename.Location = new System.Drawing.Point(171, 126);
            this.txt_middlename.Name = "txt_middlename";
            this.txt_middlename.Size = new System.Drawing.Size(323, 27);
            this.txt_middlename.TabIndex = 3;
            // 
            // middlename
            // 
            this.middlename.AutoSize = true;
            this.middlename.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.middlename.Location = new System.Drawing.Point(27, 130);
            this.middlename.Name = "middlename";
            this.middlename.Size = new System.Drawing.Size(101, 20);
            this.middlename.TabIndex = 2;
            this.middlename.Text = "Middle Initial";
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(171, 161);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(323, 27);
            this.txt_lastname.TabIndex = 5;
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastname.Location = new System.Drawing.Point(52, 163);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(84, 20);
            this.lastname.TabIndex = 4;
            this.lastname.Text = "Last Name";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(171, 195);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(323, 27);
            this.txt_age.TabIndex = 7;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.age.Location = new System.Drawing.Point(88, 196);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(37, 20);
            this.age.TabIndex = 6;
            this.age.Text = "Age";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(171, 229);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(323, 61);
            this.txt_address.TabIndex = 9;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.address.Location = new System.Drawing.Point(62, 229);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(66, 20);
            this.address.TabIndex = 8;
            this.address.Text = "Address";
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(171, 296);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(323, 27);
            this.txt_contact.TabIndex = 11;
            // 
            // contact_num
            // 
            this.contact_num.AutoSize = true;
            this.contact_num.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contact_num.Location = new System.Drawing.Point(37, 300);
            this.contact_num.Name = "contact_num";
            this.contact_num.Size = new System.Drawing.Size(92, 20);
            this.contact_num.TabIndex = 10;
            this.contact_num.Text = "Contact No.";
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(396, 460);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(98, 34);
            this.Confirm.TabIndex = 13;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 43);
            this.label1.TabIndex = 14;
            this.label1.Text = "CONTACT TRACING FORM";
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.temp.Location = new System.Drawing.Point(38, 366);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(99, 20);
            this.temp.TabIndex = 15;
            this.temp.Text = "Temperature";
            // 
            // txt_temp
            // 
            this.txt_temp.Location = new System.Drawing.Point(171, 366);
            this.txt_temp.Name = "txt_temp";
            this.txt_temp.Size = new System.Drawing.Size(322, 27);
            this.txt_temp.TabIndex = 16;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(171, 330);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(323, 27);
            this.txt_email.TabIndex = 17;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Email.Location = new System.Drawing.Point(72, 333);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(53, 20);
            this.Email.TabIndex = 18;
            this.Email.Text = "E-mail";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 404);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 3, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 27);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.date.Location = new System.Drawing.Point(83, 409);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(42, 20);
            this.date.TabIndex = 20;
            this.date.Text = "Date";
            // 
            // form2
            // 
            this.form2.Location = new System.Drawing.Point(277, 460);
            this.form2.Name = "form2";
            this.form2.Size = new System.Drawing.Size(98, 32);
            this.form2.TabIndex = 21;
            this.form2.Text = "Get Data";
            this.form2.UseVisualStyleBackColor = true;
            this.form2.Click += new System.EventHandler(this.form2_Click);
            // 
            // contact_tracing_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(552, 519);
            this.Controls.Add(this.form2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_temp);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.contact_num);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.address);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.age);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.txt_middlename);
            this.Controls.Add(this.middlename);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.firstname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "contact_tracing_app";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Registration - Sign Up Form for Contract Tracing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.TextBox txt_middlename;
        private System.Windows.Forms.Label middlename;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label contact_num;
        private System.Windows.Forms.Button Confirm;
        private readonly EventHandler label1_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.TextBox txt_temp;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Button form2;
    }
}

