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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Setup is not complete.If you exit now, the programm will be not installed.\n\n You may run setup at another time to complete the installiation. \n\n Exit setup?";
            string title = "Exit Setup";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form2 = new Form6();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataDir.cb = false;
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string inform = "Destination location:\n\t";
            inform += DataDir.directory1 + "\n\n" + "Start Menu Folder:" + "\n\t" + DataDir.directory2 + "\n\n";
            richTextBox1.Text = inform;
            if (DataDir.cb) richTextBox1.Text = inform += "Additional tasks: \n\t Additional shortcuts: \n\t\t Create a desktop shortcut";
        }
    }
}
