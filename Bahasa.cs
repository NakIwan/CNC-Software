using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Mecha_Gcode_Sender
{
    public partial class Bahasa : Form
    {
        public static Bahasa instance;
        public TextBox op1;
        public TextBox op2;

        public Bahasa()
        {
            InitializeComponent();
            instance = this;
            op1 = opsi_1;
            op2 = opsi_2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("id-ID");
                    mainMenu mn = new mainMenu();
                    mn.Show();
                    mainMenu.instance.ob.Text = opsi_1.Text;
                    this.Hide();
                }

                else if (radioButton2.Checked == true)
                {
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-GB");
                    mainMenu mn = new mainMenu();
                    mn.Show();
                    mainMenu.instance.ob.Text = opsi_2.Text;
                    this.Hide();
                }
            }

            catch (Exception)
            {
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Bahasa_Deactivate(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Bahasa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
