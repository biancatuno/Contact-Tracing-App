
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.middlename = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.contact_num = new System.Windows.Forms.Label();
            this.add_details = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
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
            this.firstname.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 27);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(207, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(323, 27);
            this.textBox2.TabIndex = 3;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(207, 151);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(323, 27);
            this.textBox3.TabIndex = 5;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(207, 203);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(323, 27);
            this.textBox4.TabIndex = 7;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(207, 255);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(323, 27);
            this.textBox5.TabIndex = 9;
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
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(207, 310);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(323, 27);
            this.textBox6.TabIndex = 11;
            // 
            // contact_num
            // 
            this.contact_num.AutoSize = true;
            this.contact_num.Location = new System.Drawing.Point(79, 317);
            this.contact_num.Name = "contact_num";
            this.contact_num.Size = new System.Drawing.Size(118, 20);
            this.contact_num.TabIndex = 10;
            this.contact_num.Text = "Contact Number";
            // 
            // add_details
            // 
            this.add_details.Location = new System.Drawing.Point(355, 382);
            this.add_details.Name = "add_details";
            this.add_details.Size = new System.Drawing.Size(175, 29);
            this.add_details.TabIndex = 12;
            this.add_details.Text = "Add more details";
            this.add_details.UseVisualStyleBackColor = true;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(556, 382);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(94, 29);
            this.confirm.TabIndex = 13;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            // 
            // contact_tracing_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.add_details);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.contact_num);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.address);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.age);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.middlename);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label middlename;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label contact_num;
        private System.Windows.Forms.Button add_details;
        private System.Windows.Forms.Button confirm;
    }
}

