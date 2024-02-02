using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace Mecha_Gcode_Sender
{
    public partial class mainMenu : Form
    {
        public static mainMenu instance;
        public RichTextBox dt;
        public ComboBox cp;
        public TextBox fr;
        public TextBox sp;
        public SerialPort sp1;
        public TextBox ob;

        public delegate void myDelegate();

        public void updateTextBox()
        {
            data_code.AppendText(serialPort1.ReadExisting());
            data_code.ScrollToCaret();
        }

        public mainMenu()
        {
            InitializeComponent();
            baudrate_port.Items.Add(300);
            baudrate_port.Items.Add(600);
            baudrate_port.Items.Add(1200);
            baudrate_port.Items.Add(2400);
            baudrate_port.Items.Add(9600);
            baudrate_port.Items.Add(14400);
            baudrate_port.Items.Add(19200);
            baudrate_port.Items.Add(38400);
            baudrate_port.Items.Add(57600);
            baudrate_port.Items.Add(115200);
            baudrate_port.Text = baudrate_port.Items[0].ToString();
            instance = this;
            dt = data_code;
            cp = com_port;
            fr = feed_rate;
            sp = spindle_in;
            sp1 = serialPort1;
            ob = opsi_bhs;
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

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            com_port.Items.AddRange(ports);
            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(data_code_TextChanged);
            tombol_putuskan.Enabled = false;
        }

        private void atas()
        {
            try
            {
                if (ob.Text == "2")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Connect to port first");
                        com_port.Focus();
                    }

                    else if (pindah_berapa.Text == "")
                    {
                        MessageBox.Show("Input the displacement first");
                        pindah_berapa.Focus();
                    }

                    else if (feed_rate.Text == "")
                    {
                        MessageBox.Show("Input feedrate first");
                    }

                    else if (spindle_in.Text == "")
                    {
                        MessageBox.Show("Input spindle first");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 Y" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G91 G21 G1 Y" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }

                else if (ob.Text == "1")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Hubungkan port terlebih dahulu");
                        com_port.Focus();
                    }

                    else if (pindah_berapa.Text == "")
                    {
                        MessageBox.Show("Masukkan perpindahan terlebih dahulu");
                        pindah_berapa.Focus();
                    }

                    else if (feed_rate.Text == "")
                    {
                        MessageBox.Show("Masukkan feedrate terlebih dahulu");
                    }

                    else if (spindle_in.Text == "")
                    {
                        MessageBox.Show("Masukkan spindle terlebih dahulu");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 Y" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G91 G21 G1 Y" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void bawah()
        {
            try
            {
                if (ob.Text == "2")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Connect to port first");
                        com_port.Focus();
                    }

                    else if (pindah_berapa.Text == "")
                    {
                        MessageBox.Show("Input the displacement first");
                        pindah_berapa.Focus();
                    }

                    else if (feed_rate.Text == "")
                    {
                        MessageBox.Show("Input feedrate first");
                    }

                    else if (spindle_in.Text == "")
                    {
                        MessageBox.Show("Input spindle first");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 Y-" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G91 G21 G1 Y-" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }

                else if (ob.Text == "1")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Hubungkan port terlebih dahulu");
                        com_port.Focus();
                    }

                    else if (pindah_berapa.Text == "")
                    {
                        MessageBox.Show("Masukkan perpindahan terlebih dahulu");
                        pindah_berapa.Focus();
                    }

                    else if (feed_rate.Text == "")
                    {
                        MessageBox.Show("Masukkan feedrate terlebih dahulu");
                    }

                    else if (spindle_in.Text == "")
                    {
                        MessageBox.Show("Masukkan spindle terlebih dahulu");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 Y-" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G91 G21 G1 Y-" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }
            }

            catch (Exception)
            {

            }
        }

        private void kanan()
        {
            try
            {
                if (ob.Text == "2")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Connect to port first");
                        com_port.Focus();
                    }

                    else if (pindah_berapa.Text == "")
                    {
                        MessageBox.Show("Input the displacement first");
                        pindah_berapa.Focus();
                    }

                    else if (feed_rate.Text == "")
                    {
                        MessageBox.Show("Input feedrate first");
                    }

                    else if (spindle_in.Text == "")
                    {
                        MessageBox.Show("Input spindle first");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 X" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G91 G21 G1 X" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }

                else if (ob.Text == "1")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Hubungkan port terlebih dahulu");
                        com_port.Focus();
                    }

                    else if (pindah_berapa.Text == "")
                    {
                        MessageBox.Show("Masukkan perpindahan terlebih dahulu");
                        pindah_berapa.Focus();
                    }

                    else if (feed_rate.Text == "")
                    {
                        MessageBox.Show("Masukkan feedrate terlebih dahulu");
                    }

                    else if (spindle_in.Text == "")
                    {
                        MessageBox.Show("Masukkan spindle terlebih dahulu");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 X" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G91 G21 G1 X" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }
            }

            catch (Exception)
            {

            }
        }

        private void kiri()
        {
            try
            {
                if (ob.Text == "2")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Connect to port first");
                        com_port.Focus();
                    }

                    else if (pindah_berapa.Text == "")
                    {
                        MessageBox.Show("Input the displacement first");
                        pindah_berapa.Focus();
                    }

                    else if (feed_rate.Text == "")
                    {
                        MessageBox.Show("Input feedrate first");
                    }

                    else if (spindle_in.Text == "")
                    {
                        MessageBox.Show("Input spindle first");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 X-" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G91 G21 G1 X-" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }

                else if (ob.Text == "1")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Hubungkan port terlebih dahulu");
                        com_port.Focus();
                    }

                    else if (pindah_berapa.Text == "")
                    {
                        MessageBox.Show("Masukkan perpindahan terlebih dahulu");
                        pindah_berapa.Focus();
                    }

                    else if (feed_rate.Text == "")
                    {
                        MessageBox.Show("Masukkan feedrate terlebih dahulu");
                    }

                    else if (spindle_in.Text == "")
                    {
                        MessageBox.Show("Masukkan spindle terlebih dahulu");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 X-" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G91 G21 G1 X-" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }
            }

            catch (Exception)
            {

            }
        }

        private void z_atas()
        {
            try
            {
                if (ob.Text == "2")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Connect to port first");
                        com_port.Focus();
                    }

                    else if (pindah_berapa.Text == "")
                    {
                        MessageBox.Show("Input the displacement first");
                        pindah_berapa.Focus();
                    }

                    else if (feed_rate.Text == "")
                    {
                        MessageBox.Show("Input feedrate first");
                    }

                    else if (spindle_in.Text == "")
                    {
                        MessageBox.Show("Input spindle first");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 Z" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G91 G21 G1 Z" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }

                else if (ob.Text == "1")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Hubungkan port terlebih dahulu");
                        com_port.Focus();
                    }

                    else if (pindah_berapa.Text == "")
                    {
                        MessageBox.Show("Masukkan perpindahan terlebih dahulu");
                        pindah_berapa.Focus();
                    }

                    else if (feed_rate.Text == "")
                    {
                        MessageBox.Show("Masukkan feedrate terlebih dahulu");
                    }

                    else if (spindle_in.Text == "")
                    {
                        MessageBox.Show("Masukkan spindle terlebih dahulu");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 Z" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G91 G21 G1 Z" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }
            }

            catch (Exception)
            {

            }
        }

        private void z_bawah()
        {
            try
            {
                if (ob.Text == "2")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Connect to port first");
                        com_port.Focus();
                    }

                    else if (pindah_berapa.Text == "")
                    {
                        MessageBox.Show("Input the displacement first");
                        pindah_berapa.Focus();
                    }

                    else if (feed_rate.Text == "")
                    {
                        MessageBox.Show("Input feedrate first");
                    }

                    else if (spindle_in.Text == "")
                    {
                        MessageBox.Show("Input spindle first");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 Z-" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G91 G21 G1 Z-" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }

                else if (ob.Text == "1")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Hubungkan port terlebih dahulu");
                        com_port.Focus();
                    }

                    else if (pindah_berapa.Text == "")
                    {
                        MessageBox.Show("Masukkan perpindahan terlebih dahulu");
                        pindah_berapa.Focus();
                    }

                    else if (feed_rate.Text == "")
                    {
                        MessageBox.Show("Masukkan feedrate terlebih dahulu");
                    }

                    else if (spindle_in.Text == "")
                    {
                        MessageBox.Show("Masukkan spindle terlebih dahulu");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 Z-" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G91 G21 G1 Z-" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }
            }

            catch (Exception)
            {

            }
        }

        private void kananAtas()
        {
            try
            {
                if (ob.Text == "2")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Connect to port first");
                        com_port.Focus();
                    }

                    else if (pindah_berapa.Text == "")
                    {
                        MessageBox.Show("Input the displacement first");
                        pindah_berapa.Focus();
                    }

                    else if (feed_rate.Text == "")
                    {
                        MessageBox.Show("Input feedrate first");
                    }

                    else if (spindle_in.Text == "")
                    {
                        MessageBox.Show("Input spindle first");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 X" + pindah_berapa.Text + " Y" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G91 G21 G1 X" + pindah_berapa.Text + " Y" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }

                else if (ob.Text == "1")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Hubungkan port terlebih dahulu");
                        com_port.Focus();
                    }

                    else if (pindah_berapa.Text == "")
                    {
                        MessageBox.Show("Masukkan perpindahan terlebih dahulu");
                        pindah_berapa.Focus();
                    }

                    else if (feed_rate.Text == "")
                    {
                        MessageBox.Show("Masukkan feedrate terlebih dahulu");
                    }

                    else if (spindle_in.Text == "")
                    {
                        MessageBox.Show("Masukkan spindle terlebih dahulu");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 X" + pindah_berapa.Text + " Y" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G91 G21 G1 X" + pindah_berapa.Text + " Y" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }
            }

            catch (Exception)
            {

            }
        }

        private void kiriAtas()
        {
            try
            {
                if (ob.Text == "2")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Connect to port first");
                        com_port.Focus();
                    }

                    else if (pindah_berapa.Text == "")
                    {
                        MessageBox.Show("Input the displacement first");
                        pindah_berapa.Focus();
                    }

                    else if (feed_rate.Text == "")
                    {
                        MessageBox.Show("Input feedrate first");
                    }

                    else if (spindle_in.Text == "")
                    {
                        MessageBox.Show("Input spindle first");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 X-" + pindah_berapa.Text + " Y" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G91 G21 G1 X-" + pindah_berapa.Text + " Y" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }

                else if (ob.Text == "1")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Hubungkan port terlebih dahulu");
                        com_port.Focus();
                    }

                    else if (pindah_berapa.Text == "")
                    {
                        MessageBox.Show("Masukkan perpindahan terlebih dahulu");
                        pindah_berapa.Focus();
                    }

                    else if (feed_rate.Text == "")
                    {
                        MessageBox.Show("Masukkan feedrate terlebih dahulu");
                    }

                    else if (spindle_in.Text == "")
                    {
                        MessageBox.Show("Masukkan spindle terlebih dahulu");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 X-" + pindah_berapa.Text + " Y" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G91 G21 G1 X-" + pindah_berapa.Text + " Y" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }
            }

            catch (Exception)
            {

            }
        }

        private void kananBawah()
        {
            try
            {
                if (ob.Text == "2")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Connect to port first");
                        com_port.Focus();
                    }

                    else if (pindah_berapa.Text == "")
                    {
                        MessageBox.Show("Input the displacement first");
                        pindah_berapa.Focus();
                    }

                    else if (feed_rate.Text == "")
                    {
                        MessageBox.Show("Input feedrate first");
                    }

                    else if (spindle_in.Text == "")
                    {
                        MessageBox.Show("Input spindle first");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 X" + pindah_berapa.Text + " Y-" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G91 G21 G1 X" + pindah_berapa.Text + " Y-" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }

                else if (ob.Text == "1")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Hubungkan port terlebih dahulu");
                        com_port.Focus();
                    }

                    else if (pindah_berapa.Text == "")
                    {
                        MessageBox.Show("Masukkan perpindahan terlebih dahulu");
                        pindah_berapa.Focus();
                    }

                    else if (feed_rate.Text == "")
                    {
                        MessageBox.Show("Masukkan feedrate terlebih dahulu");
                    }

                    else if (spindle_in.Text == "")
                    {
                        MessageBox.Show("Masukkan spindle terlebih dahulu");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 X" + pindah_berapa.Text + " Y-" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G91 G21 G1 X" + pindah_berapa.Text + " Y-" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }
            }

            catch (Exception)
            {

            }
        }

        private void kiriBawah()
        {
            try
            {
                if (ob.Text == "2")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Connect to port first");
                        com_port.Focus();
                    }

                    else if (pindah_berapa.Text == "")
                    {
                        MessageBox.Show("Input the displacement first");
                        pindah_berapa.Focus();
                    }

                    else if (feed_rate.Text == "")
                    {
                        MessageBox.Show("Input feedrate first");
                    }

                    else if (spindle_in.Text == "")
                    {
                        MessageBox.Show("Input spindle first");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 X-" + pindah_berapa.Text + " Y-" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G91 G21 G1 X-" + pindah_berapa.Text + " Y-" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }

                else if (ob.Text == "1")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Hubungkan port terlebih dahulu");
                        com_port.Focus();
                    }

                    else if (pindah_berapa.Text == "")
                    {
                        MessageBox.Show("Masukkan perpindahan terlebih dahulu");
                        pindah_berapa.Focus();
                    }

                    else if (feed_rate.Text == "")
                    {
                        MessageBox.Show("Masukkan feedrate terlebih dahulu");
                    }

                    else if (spindle_in.Text == "")
                    {
                        MessageBox.Show("Masukkan spindle terlebih dahulu");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 X-" + pindah_berapa.Text + " Y-" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G91 G21 G1 X-" + pindah_berapa.Text + " Y-" + pindah_berapa.Text + " F" + feed_rate.Text + " S" + spindle_in.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }
            }

            catch (Exception)
            {

            }
        }

        private void tutupCode()
        {
            if (ob.Text == "2")
            {
                if (tombol_putuskan.Enabled == false)
                {
                    MessageBox.Show("Connect the port first");
                    com_port.Focus();
                }
                else
                {
                    code_load.Clear();
                }
            }

            else if (ob.Text == "1")
            {
                if (tombol_putuskan.Enabled == false)
                {
                    MessageBox.Show("Hubungkan port terlebih dahulu");
                    com_port.Focus();
                }
                else
                {
                    code_load.Clear();
                }
            }
        }

        private void bukaCode()
        {
            string fileName = "";
            if (ob.Text == "2")
            {
                if (tombol_putuskan.Enabled == false)
                {
                    MessageBox.Show("Connect the port first");
                    com_port.Focus();
                }

                else
                {
                    openFileDialog1.Filter = "Text Files (*.txt) |*txt | TAP Files (*.tap) |*.tap";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        code_load.Text = File.ReadAllText(openFileDialog1.FileName);

                        //  Nambahin bagian ini untuk mengetahui nama file yang di buka dan penambahan richtextbox untuk menampilkan file yang dalam proses pengerjaan
                        riwayatBox.Text = openFileDialog1.FileName;
                    }
                }
            }

            else if (ob.Text == "1")
            {
                if (tombol_putuskan.Enabled == false)
                {
                    MessageBox.Show("Hubungkan port terlebih dahulu");
                    com_port.Focus();
                }

                else
                {
                    openFileDialog1.Filter = "Text Files (*.txt) |*txt | TAP Files (*.tap) |*.tap";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        code_load.Text = File.ReadAllText(openFileDialog1.FileName);
                    }
                }
            }
        }

        private void setX()
        {
            try
            {
                if (ob.Text == "2")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Connect the port first");
                        com_port.Focus();
                    }

                    else
                    {
                        serialPort1.Write("G92 X0" + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G92 X0" + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }

                else if (ob.Text == "1")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Hubungkan port terlebih dahulu");
                        com_port.Focus();
                    }

                    else
                    {
                        serialPort1.Write("G92 X0" + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G92 X0" + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }
            }

            catch (Exception)
            {

            }
        }

        private void setY()
        {
            try
            {
                if (ob.Text == "2")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Connect the port first");
                        com_port.Focus();
                    }

                    else
                    {
                        serialPort1.Write("G92 Y0" + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G92 Y0" + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }

                else if (ob.Text == "1")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Hubungkan port terlebih dahulu");
                        com_port.Focus();
                    }

                    else
                    {
                        serialPort1.Write("G92 Y0" + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G92 Y0" + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }
            }

            catch (Exception)
            {

            }
        }

        private void setZ()
        {
            try
            {
                if (ob.Text == "2")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Connect the port first");
                        com_port.Focus();
                    }

                    else
                    {
                        serialPort1.Write("G92 Z0" + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G92 Z0" + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }

                else if (ob.Text == "1")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Hubungkan port terlebih dahulu");
                        com_port.Focus();
                    }

                    else
                    {
                        serialPort1.Write("G92 Z0" + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G92 Z0" + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }
            }

            catch (Exception)
            {

            }
        }

        private void setHome()
        {
            try
            {
                if (ob.Text == "2")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Connect the port first");
                        com_port.Focus();
                    }

                    else
                    {
                        serialPort1.Write("G90 X0 Y0 Z20 G28 X0 Y0 Z0" + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G90 X0 Y0 Z20 G28 X0 Y0 Z0" + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }

                else if (ob.Text == "1")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Hubungkan port terlebih dahulu");
                        com_port.Focus();
                    }

                    else
                    {
                        serialPort1.Write("G90 X0 Y0 Z20 G28 X0 Y0 Z0" + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>> G90 X0 Y0 Z20 G28 X0 Y0 Z0" + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }
            }

            catch (Exception)
            {

            }
        }

        private void com_port_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void baudrate_port_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tombol_putuskan_Click(object sender, EventArgs e)
        {
            if (ob.Text == "2")
            {
                try
                {
                    serialPort1.Close();
                    pesan.Text = serialPort1.PortName + " Disconnected.";
                    tombol_hubungkan.Enabled = true;
                    tombol_putuskan.Enabled = false;
                    tombol_putuskan.BackColor = Color.Transparent;
                    tombol_hubungkan.BackColor = Color.Lime;
                    pesan_bg.BackColor = Color.Yellow;
                }

                catch (Exception)
                {
                    MessageBox.Show("Try again");
                }
            }

            else if (ob.Text == "1")
            {
                try
                {
                    serialPort1.Close();
                    pesan.Text = serialPort1.PortName + " Terputus.";
                    tombol_hubungkan.Enabled = true;
                    tombol_putuskan.Enabled = false;
                    tombol_putuskan.BackColor = Color.Transparent;
                    tombol_hubungkan.BackColor = Color.Lime;
                    pesan_bg.BackColor = Color.Yellow;
                }

                catch (Exception)
                {
                    MessageBox.Show("Coba lagi");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tombol_hubungkan_Click(object sender, EventArgs e)
        {
            if (ob.Text == "2")
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }

                try
                {
                    serialPort1.PortName = com_port.Text;
                    serialPort1.BaudRate = Convert.ToInt32(baudrate_port.Text);
                    serialPort1.Open();
                    pesan.Text = com_port.Text + " Connected.";
                    pesan_bg.BackColor = Color.Lime;
                    tombol_hubungkan.Enabled = false;
                    tombol_putuskan.Enabled = true;
                    tombol_hubungkan.BackColor = Color.Transparent;
                    tombol_putuskan.BackColor = Color.Gold;
                    serialPort1.Write("$$" + Environment.NewLine + "$G" + Environment.NewLine);
                    data_code.SelectionColor = Color.Blue;
                    data_code.AppendText("***** Connected to " + com_port.Text + " *****" + Environment.NewLine);
                    data_code.SelectionColor = Color.Blue;
                    data_code.AppendText(">>>$$" + Environment.NewLine + ">>>$G" + Environment.NewLine);
                    data_code.ScrollToCaret();
                }

                catch (Exception)
                {
                    MessageBox.Show("Error, make sure the port correct!");
                }
            }

            else if (ob.Text == "1")
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }

                try
                {
                    serialPort1.PortName = com_port.Text;
                    serialPort1.BaudRate = Convert.ToInt32(baudrate_port.Text);
                    serialPort1.Open();
                    pesan.Text = com_port.Text + " Terhubung.";
                    pesan_bg.BackColor = Color.Lime;
                    tombol_hubungkan.Enabled = false;
                    tombol_putuskan.Enabled = true;
                    tombol_hubungkan.BackColor = Color.Transparent;
                    tombol_putuskan.BackColor = Color.Gold;
                    serialPort1.Write("$$" + Environment.NewLine + "$G" + Environment.NewLine);
                    data_code.SelectionColor = Color.Blue;
                    data_code.AppendText("***** Terhubung ke " + com_port.Text + " *****" + Environment.NewLine);
                    data_code.SelectionColor = Color.Blue;
                    data_code.AppendText(">>>$$" + Environment.NewLine + ">>>$G" + Environment.NewLine);
                    data_code.ScrollToCaret();
                }

                catch (Exception)
                {
                    MessageBox.Show("Error, Pastikan serial port benar!");
                }
            }
        }

        private void y_plus_Click(object sender, EventArgs e)
        {
            atas();
        }

        private void y_min_Click(object sender, EventArgs e)
        {
            bawah();
        }

        private void x_plus_Click(object sender, EventArgs e)
        {
            kanan();
        }

        private void x_min_Click(object sender, EventArgs e)
        {
            kiri();
        }

        private void z_plus_Click(object sender, EventArgs e)
        {
            z_atas();
        }

        private void z_min_Click(object sender, EventArgs e)
        {
            z_bawah();
        }

        private void data_code_TextChanged(object sender, EventArgs e)
        {
            data_code.BeginInvoke(new myDelegate(updateTextBox));
        }

        private void ind_x_TextChanged(object sender, EventArgs e)
        {

        }

        private void set_zero_y_button_Click(object sender, EventArgs e)
        {
            setY();
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            exit ex = new exit();
            ex.Show();
        }

        private void m_pos_x_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tombol_kirim_Click(object sender, EventArgs e)
        {
            try
            {
                if (tombol_putuskan.Enabled == false)
                {
                    MessageBox.Show("Connect the port first");
                    com_port.Focus();
                }

                else
                {
                    if (data_kirim.Text == "")
                    {
                        MessageBox.Show("Fail Data");
                    }

                    else
                    {
                        serialPort1.Write(data_kirim.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(">>>" + data_kirim.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                        data_kirim.Text = string.Empty;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void spindleSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ob.Text == "2")
            {
                if (tombol_putuskan.Enabled == false)
                {
                    MessageBox.Show("Connect the port first");
                    com_port.Focus();
                }

                else
                {
                    Spindle sp = new Spindle();
                    sp.Show();
                }
            }

            else if (ob.Text == "1")
            {
                if (tombol_putuskan.Enabled == false)
                {
                    MessageBox.Show("Hubungkan port terlebih dahulu");
                    com_port.Focus();
                }

                else
                {
                    Spindle sp = new Spindle();
                    sp.Show();
                }
            }
        }

        private void feedRateSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ob.Text == "2")
            {
                if (tombol_putuskan.Enabled == false)
                {
                    MessageBox.Show("Connect the port first");
                    com_port.Focus();
                }

                else
                {
                    Feedrate fr = new Feedrate();
                    fr.Show();
                }
            }

            else if (ob.Text == "1")
            {
                if (tombol_putuskan.Enabled == false)
                {
                    MessageBox.Show("Hubungkan port terlebih dahulu");
                    com_port.Focus();
                }

                else
                {
                    Feedrate fr = new Feedrate();
                    fr.Show();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void xAxisToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void kalibrasiPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            tutupCode();
        }

        private void machineViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit ex = new exit();
            ex.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kanan();
        }

        private void pesan_Click(object sender, EventArgs e)
        {

        }

        private void clean_button_Click(object sender, EventArgs e)
        {
            if (ob.Text == "2")
            {
                if (tombol_putuskan.Enabled == false)
                {
                    MessageBox.Show("Connect the port first");
                    com_port.Focus();
                }

                else
                {
                    data_code.Clear();
                }
            }

            else if (ob.Text == "1")
            {
                if (tombol_putuskan.Enabled == false)
                {
                    MessageBox.Show("Hubungkan port terlebih dahulu");
                    com_port.Focus();
                }

                else
                {
                    data_code.Clear();
                }
            }
        }

        private void cycle_start_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ob.Text == "2")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Connect the port first");
                        com_port.Focus();
                    }

                    else if (code_load.Text == "")
                    {
                        MessageBox.Show("Fail data");
                        cycle_start_button.Focus();
                    }

                    else
                    {
                        serialPort1.Write(code_load.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(code_load.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }

                else if (ob.Text == "1")
                {
                    if (tombol_putuskan.Enabled == false)
                    {
                        MessageBox.Show("Hubungkan port terlebih dahulu");
                        com_port.Focus();
                    }

                    else if (code_load.Text == "")
                    {
                        MessageBox.Show("Data gagal");
                        cycle_start_button.Focus();
                    }

                    else
                    {
                        serialPort1.Write(code_load.Text + Environment.NewLine);
                        data_code.SelectionColor = Color.Blue;
                        data_code.AppendText(code_load.Text + Environment.NewLine);
                        data_code.ScrollToCaret();
                    }
                }
            }

            catch (Exception)
            {
            }
        }

        private void load_code_button_Click(object sender, EventArgs e)
        {
            bukaCode();
        }

        private void set_x_button_Click(object sender, EventArgs e)
        {
            setX();
        }

        private void set_zero_z_button_Click(object sender, EventArgs e)
        {
            setZ();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            setHome();
        }

        private void kanan_atas_Click(object sender, EventArgs e)
        {
            kananAtas();
        }

        private void kanan_bawah_Click(object sender, EventArgs e)
        {
            kananBawah();
        }

        private void emg_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (tombol_putuskan.Enabled == false)
                {
                    MessageBox.Show("Connect the port first");
                    com_port.Focus();
                }

                else
                {
                    serialPort1.Write("M112" + Environment.NewLine);
                    data_code.SelectionColor = Color.Blue;
                    data_code.AppendText(">>> M112" + Environment.NewLine);
                    data_code.ScrollToCaret();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Connect the port first");
                com_port.Focus();
            }
        }

        private void data_kirim_TextChanged(object sender, EventArgs e)
        {

        }

        private void baudrate_port_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void data_code_TextChanged_1(object sender, EventArgs e)
        {
            data_code.BeginInvoke(new myDelegate(updateTextBox));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void data_kirim_KeyDown(object sender, KeyEventArgs e)
        {
            if (tombol_putuskan.Enabled == false)
            {
                MessageBox.Show("Connect the port first");
                com_port.Focus();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                serialPort1.Write(data_kirim.Text + Environment.NewLine);
                data_code.SelectionColor = Color.Blue;
                data_code.AppendText(">>>" + data_kirim.Text + Environment.NewLine);
                data_code.ScrollToCaret();
                data_kirim.Text = string.Empty;
                e.SuppressKeyPress = true;
            }
        }

        private void data_kirim_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tentangAplikasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Us ab = new About_Us();
            ab.Show();
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bukaCode();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tutupCode();
        }

        private void pindah_berapa_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kiri();
        }

        private void yToolStripMenuItem_Click(object sender, EventArgs e)
        {
            atas();
        }

        private void yToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bawah();
        }

        private void zToolStripMenuItem_Click(object sender, EventArgs e)
        {
            z_atas();
        }

        private void zToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            z_bawah();
        }

        private void x0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setX();
        }

        private void y0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setY();
        }

        private void z0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setZ();
        }

        private void posisiSemulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setHome();
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
           
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void bahasaIndonesiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void JOG_SET_Enter(object sender, EventArgs e)
        {

        }

        private void kiri_bawah_Click(object sender, EventArgs e)
        {
            kiriBawah();
        }

        private void kiri_atas_Click(object sender, EventArgs e)
        {
            kiriAtas();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void code_load_TextChanged(object sender, EventArgs e)
        {

        }
    }
}