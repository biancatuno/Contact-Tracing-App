using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing_App
{
    public partial class contact_tracing_app : Form
    {
        public contact_tracing_app()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to submit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                using (StreamWriter stream = File.AppendText("ContactForm.txt"))
                {
                    stream.Write(" \n");
                    stream.Write("DETAILS\n");
                    stream.WriteLine(txt_firstname.Text);
                    stream.WriteLine(txt_middlename.Text);
                    stream.WriteLine(txt_lastname.Text);
                    stream.WriteLine(txt_age.Text);
                    stream.WriteLine(txt_address.Text);
                    stream.WriteLine(txt_contact.Text);
                    stream.WriteLine(txt_email.Text);
                    stream.WriteLine(txt_temp.Text);
                    stream.WriteLine(dateTimePicker1.Value);
                    stream.Close();
                    DialogResult submission = MessageBox.Show("Thank you for filling out the form! Have a nice day!", "Success!");

                    if (submission == DialogResult.OK)
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                    else if (result == DialogResult.No)
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                }
            }
        }

        private void form2_Click(object sender, EventArgs e)
        {
            user_info f2 = new user_info();
            f2.Show();
        }
    }
}
