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
    public partial class exit : Form
    {
        public exit()
        {
            InitializeComponent();
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
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void exit_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_Load(object sender, EventArgs e)
        {

        }
    }
}
