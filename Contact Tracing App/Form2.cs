using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing_App
{
    public partial class user_info : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        string line = "";

        public user_info()
        {
            InitializeComponent();
        }

        private void open_file_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFile.FileName);
                while(line !=null)
                {
                    line = sr.ReadLine();
                    if(line != null)
                    {
                        listBox1.Items.Add(line);
                    }    
                }
                sr.Close();
            }    
        }
    }
}
