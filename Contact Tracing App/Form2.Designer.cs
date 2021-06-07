
namespace Contact_Tracing_App
{
    partial class user_info
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
            this.Header = new System.Windows.Forms.Label();
            this.open_file = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Franklin Gothic Heavy", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Header.Location = new System.Drawing.Point(39, 31);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(462, 54);
            this.Header.TabIndex = 15;
            this.Header.Text = "USER INFORMATION";
            // 
            // open_file
            // 
            this.open_file.Location = new System.Drawing.Point(197, 99);
            this.open_file.Name = "open_file";
            this.open_file.Size = new System.Drawing.Size(125, 34);
            this.open_file.TabIndex = 16;
            this.open_file.Text = "Open File";
            this.open_file.UseVisualStyleBackColor = true;
            this.open_file.Click += new System.EventHandler(this.open_file_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(28, 159);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(497, 324);
            this.listBox1.TabIndex = 17;
            // 
            // user_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(550, 520);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.open_file);
            this.Controls.Add(this.Header);
            this.MaximizeBox = false;
            this.Name = "user_info";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Button open_file;
        private System.Windows.Forms.ListBox listBox1;
    }
}