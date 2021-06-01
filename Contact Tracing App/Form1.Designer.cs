
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
            this.add_details = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Location = new System.Drawing.Point(79, 49);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(80, 20);
            this.firstname.TabIndex = 0;
            this.firstname.Text = "First Name";
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(222, 42);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(323, 27);
            this.txt_firstname.TabIndex = 1;
            // 
            // txt_middlename
            // 
            this.txt_middlename.Location = new System.Drawing.Point(222, 96);
            this.txt_middlename.Name = "txt_middlename";
            this.txt_middlename.Size = new System.Drawing.Size(323, 27);
            this.txt_middlename.TabIndex = 3;
            // 
            // middlename
            // 
            this.middlename.AutoSize = true;
            this.middlename.Location = new System.Drawing.Point(79, 103);
            this.middlename.Name = "middlename";
            this.middlename.Size = new System.Drawing.Size(104, 20);
            this.middlename.TabIndex = 2;
            this.middlename.Text = "Middle Name ";
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(222, 151);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(323, 27);
            this.txt_lastname.TabIndex = 5;
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(79, 158);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(79, 20);
            this.lastname.TabIndex = 4;
            this.lastname.Text = "Last Name";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(222, 203);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(323, 27);
            this.txt_age.TabIndex = 7;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(79, 206);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(36, 20);
            this.age.TabIndex = 6;
            this.age.Text = "Age";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(222, 248);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(323, 61);
            this.txt_address.TabIndex = 9;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(79, 262);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(62, 20);
            this.address.TabIndex = 8;
            this.address.Text = "Address";
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(222, 328);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(323, 27);
            this.txt_contact.TabIndex = 11;
            // 
            // contact_num
            // 
            this.contact_num.AutoSize = true;
            this.contact_num.Location = new System.Drawing.Point(79, 335);
            this.contact_num.Name = "contact_num";
            this.contact_num.Size = new System.Drawing.Size(118, 20);
            this.contact_num.TabIndex = 10;
            this.contact_num.Text = "Contact Number";
            // 
            // add_details
            // 
            this.add_details.Location = new System.Drawing.Point(370, 382);
            this.add_details.Name = "add_details";
            this.add_details.Size = new System.Drawing.Size(175, 29);
            this.add_details.TabIndex = 12;
            this.add_details.Text = "Add more details";
            this.add_details.UseVisualStyleBackColor = true;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(567, 382);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(94, 29);
            this.confirm.TabIndex = 13;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(551, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(551, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(551, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(551, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(551, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "*";
            // 
            // contact_tracing_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.add_details);
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
            this.MaximizeBox = false;
            this.Name = "contact_tracing_app";
            this.ShowIcon = false;
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
        private System.Windows.Forms.Button add_details;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private readonly EventHandler label1_Click;
    }
}

