using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPN
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog openFileDlg = new System.Windows.Forms.FolderBrowserDialog();
            var result = openFileDlg.ShowDialog();
            if (result.ToString() != string.Empty)
            {
                this.textBox1.Text = openFileDlg.SelectedPath + @"\VPN Unlimited";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataDir.directory2 = textBox1.Text + @"\VPN Unlimited";

            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.button2.Enabled = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Text = @"VPN Unlimited";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Setup is not complete.If you exit now, the programm will be not installed.\n\n You may run setup at another time to complete the installiation. \n\n Exit setup ?";
            string title = "Exit Setup";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form2 = new Form3();
            form2.Show();
        }
    }
}
