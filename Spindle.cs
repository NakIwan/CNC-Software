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
    public partial class Spindle : Form
    {
        public static Spindle instance;
        public RadioButton cw;
        public RadioButton ccw;
        public RadioButton stop;
        public TextBox iS;

        public Spindle()
        {
            InitializeComponent();
            instance = this;
            cw = cw_button;
            ccw = ccw_button;
            stop = stop_spindle_button;
            iS = input_spindle;
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
                    if (input_spindle.Text == " ")
                    {
                        MessageBox.Show("Input spindle first");
                        input_spindle.Focus();
                    }

                    else if (stop_spindle_button.Checked == true)
                    {
                        mainMenu.instance.sp1.Write("M5" + Environment.NewLine);
                        mainMenu.instance.dt.SelectionColor = Color.Blue;
                        mainMenu.instance.dt.AppendText(">>>M5" + Environment.NewLine);
                        mainMenu.instance.dt.ScrollToCaret();
                        mainMenu.instance.sp.Text = input_spindle.Text;
                        this.Close();
                    }

                    else if (cw_button.Checked == true)
                    {
                        mainMenu.instance.dt.SelectionColor = Color.Blue;
                        mainMenu.instance.dt.AppendText(">>>M3" + Environment.NewLine);
                        mainMenu.instance.dt.ScrollToCaret();
                        mainMenu.instance.sp1.Write("M3" + Environment.NewLine);
                        mainMenu.instance.sp.Text = input_spindle.Text;
                        this.Close();
                    }

                    else if (ccw_button.Checked == true)
                    {
                        mainMenu.instance.sp1.Write("M4" + Environment.NewLine);
                        mainMenu.instance.dt.SelectionColor = Color.Blue;
                        mainMenu.instance.dt.AppendText(">>>M4" + Environment.NewLine);
                        mainMenu.instance.dt.ScrollToCaret();
                        mainMenu.instance.sp.Text = input_spindle.Text;
                        this.Close();
                    }
                }

                else if (mainMenu.instance.ob.Text == "1")
                {
                    if (input_spindle.Text == " ")
                    {
                        MessageBox.Show("Masukkan spindle terlebih dahulu");
                        input_spindle.Focus();
                    }

                    else if (stop_spindle_button.Checked == true)
                    {
                        mainMenu.instance.sp1.Write("M5" + Environment.NewLine);
                        mainMenu.instance.dt.SelectionColor = Color.Blue;
                        mainMenu.instance.dt.AppendText(">>>M5" + Environment.NewLine);
                        mainMenu.instance.dt.ScrollToCaret();
                        mainMenu.instance.sp.Text = input_spindle.Text;
                        this.Close();
                    }

                    else if (cw_button.Checked == true)
                    {
                        mainMenu.instance.dt.SelectionColor = Color.Blue;
                        mainMenu.instance.dt.AppendText(">>>M3" + Environment.NewLine);
                        mainMenu.instance.dt.ScrollToCaret();
                        mainMenu.instance.sp1.Write("M3" + Environment.NewLine);
                        mainMenu.instance.sp.Text = input_spindle.Text;
                        this.Close();
                    }

                    else if (ccw_button.Checked == true)
                    {
                        mainMenu.instance.sp1.Write("M4" + Environment.NewLine);
                        mainMenu.instance.dt.SelectionColor = Color.Blue;
                        mainMenu.instance.dt.AppendText(">>>M4" + Environment.NewLine);
                        mainMenu.instance.dt.ScrollToCaret();
                        mainMenu.instance.sp.Text = input_spindle.Text;
                        this.Close();
                    }
                }
            }

            catch (Exception)
            {

            }
        }

        private void stop_spindle_button_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cw_button_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ccw_button_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void input_feedrate_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_spindle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void Spindle_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Spindle_Load(object sender, EventArgs e)
        {

        }
    }
}
