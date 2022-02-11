using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace VPN
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        void PB()
        {
            double counter = 0;
            progressBar1.Maximum = 1000;
            while (progressBar1.Value < 1000)
            {
                counter += 0.003;
                if (Math.Floor(counter) % 5 == 0)
                {
                    progressBar1.Value += 1;
                }

            }
            label3.Text = "Succsessfully installed!";
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            button2.Enabled = false;
            PB();
            button2.Visible = true;
            button2.Enabled = true;
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
            Form7 form2 = new Form7();
            form2.Show();
        }
    }
}
