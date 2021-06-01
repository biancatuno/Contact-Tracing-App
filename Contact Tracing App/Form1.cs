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
            StreamWriter A = new StreamWriter(Application.StartupPath + "\\form\\" + "Details.txt");

            A.WriteLine(firstname.Text + ":" + " " + txt_firstname.Text);
            A.WriteLine(middlename.Text + ":" + " " + txt_middlename.Text);
            A.WriteLine(lastname.Text + ":" + " " + txt_lastname.Text);
            A.WriteLine(age.Text + ":" + " " + txt_age.Text);
            A.WriteLine(address.Text + ":" + " " + txt_address.Text);
            A.WriteLine(contact_num.Text + ":" + " " + txt_contact.Text);

            A.Close();

        }
    }
}
