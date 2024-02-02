using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mecha_Gcode_Sender
{
    public partial class Feedrate : Form
    {
        public static Feedrate instance;
        public TextBox iF;

        public Feedrate()
        {
            InitializeComponent();
            instance = this;
            iF = input_feedrate;
        }

        private const int dropshadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = dropshadow;
                return cp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (mainMenu.instance.ob.Text == "2")
                {
                    if (input_feedrate.Text == " ")
                    {
                        MessageBox.Show("Input feedrate first");
                        input_feedrate.Focus();
                    }

                    else
                    {
                        mainMenu.instance.fr.Text = input_feedrate.Text;
                        this.Close();
                    }
                }

                else if (mainMenu.instance.ob.Text == "1")
                {
                    if (input_feedrate.Text == " ")
                    {
                        MessageBox.Show("Masukkan feedrate terlebih dahulu");
                        input_feedrate.Focus();
                    }

                    else
                    {
                        mainMenu.instance.fr.Text = input_feedrate.Text;
                        this.Close();
                    }
                }
            }

            catch (Exception)
            {
                
            }
        }

        private void input_feedrate_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_feedrate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void Feedrate_Load(object sender, EventArgs e)
        {

        }

        private void Feedrate_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Feedrate_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
