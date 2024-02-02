using System.IO;
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
    public partial class Form2 : Form
    {
        int num1;
        int conv2;
        int conv3;
        int conv4;
        int conv5;
        int conv6;
        int conv7;
        int result;
        string option;

        public delegate void myDelegate();

        public void updateTextBox()
        {
            data_terima.AppendText(serialPort1.ReadExisting());
            data_terima.ScrollToCaret();
        }

        public Form2()
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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(data_terima_TextChanged);
            tombol_putuskan.Enabled = false;
        }

        private void tombol_hubungkan_Click(object sender, EventArgs e)
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
                tombol_hubungkan.Enabled = false;
                tombol_putuskan.Enabled = true;
            }

            catch (Exception)
            {
                MessageBox.Show("Error, Pastikan Serial Port Yang Digunakan Benar!");
            }
        }

        private void tombol_kirim_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = int.Parse(pindah_berapa.Text);
                conv2 = int.Parse(ind_x.Text);
                conv4 = int.Parse(ind_y.Text);
                conv6 = int.Parse(ind_z.Text);

                if (tombol_putuskan.Enabled == false)
                {
                    MessageBox.Show("Hubungkan Port Terlebih Dahulu");
                    com_port.Focus();
                }

                else if (input_feedrate.Text == "")
                {
                    MessageBox.Show("Masukkan FeedRate Terdahulu");
                    input_feedrate.Focus();
                }

                else if (input_spindle.Text == "")
                {
                    MessageBox.Show("Masukkan Spindle Speed Terdahulu");
                    input_spindle.Focus();
                }

                else if (input_panjang.Text == "")
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                    tabPage4.Focus();
                    input_panjang.Focus();
                }

                else if (input_panjang.Text == null)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (int.Parse(input_panjang.Text) == 0)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_lebar.Text == "")
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_lebar.Text == null)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (int.Parse(input_lebar.Text) == 0)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_ketebalan.Text == "")
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_ketebalan.Text == null)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (int.Parse(input_ketebalan.Text) == 0)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else
                {
                    if (data_kirim.Text == "")
                    {
                        MessageBox.Show("Data Gagal");
                    }

                    else
                    {
                        serialPort1.Write(data_kirim.Text + Environment.NewLine);
                        data_terima.AppendText(">>> CODE INPUT <<<" + Environment.NewLine + Environment.NewLine);
                        data_terima.SelectionColor = Color.Blue;
                        data_terima.AppendText(data_kirim.Text + Environment.NewLine);
                        data_terima.AppendText(Environment.NewLine + ">>> RESULT <<<" + Environment.NewLine);
                        data_terima.ScrollToCaret();
                        data_kirim.Text = string.Empty;
                    }
                }
            }

            catch (Exception)
            {
            }
        }

        private void data_terima_TextChanged(object sender, EventArgs e)
        {
            data_terima.BeginInvoke(new myDelegate(updateTextBox));
        }

        private void tombol_putuskan_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                pesan.Text = serialPort1.PortName + " Terputus.";
                tombol_hubungkan.Enabled = true;
                tombol_putuskan.Enabled = false;
            }

            catch (Exception)
            {
                MessageBox.Show("Coba Lagi");
            }
        }

        private void com_port_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void emg_button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("M112" + Environment.NewLine);
                data_terima.AppendText(Environment.NewLine + ">>> CODE INPUT <<<" + Environment.NewLine + Environment.NewLine);
                data_terima.SelectionColor = Color.Blue;
                data_terima.AppendText("M112" + Environment.NewLine);
                data_terima.AppendText(Environment.NewLine + ">>> RESULT <<<" + Environment.NewLine); 
                data_terima.ScrollToCaret();
            }

            catch (Exception)
            {
                MessageBox.Show("Hubungkan Port Terlebih Dahulu");
                com_port.Focus();
            }
        }

        private void data_kirim_TextChanged(object sender, EventArgs e)
        {

        }

        private void z_plus_Click(object sender, EventArgs e)
        {
            try
            {
                conv6 = int.Parse(ind_z.Text);
                conv7 = int.Parse(input_ketebalan.Text) / 2;

                if (tombol_putuskan.Enabled == false)
                {
                    MessageBox.Show("Hubungkan Port Terlebih Dahulu");
                    com_port.Focus();
                }

                else if (pindah_berapa.Text == "")
                {
                    MessageBox.Show("Masukkan Perpindahan Terdahulu");
                    pindah_berapa.Focus();
                }

                else if (input_feedrate.Text == "")
                {
                    MessageBox.Show("Masukkan FeedRate Terdahulu");
                    input_feedrate.Focus();
                }

                else if (input_spindle.Text == "")
                {
                    MessageBox.Show("Masukkan Spindle Speed Terdahulu");
                    input_spindle.Focus();
                }

                else if (input_panjang.Text == "")
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_panjang.Text == null)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (int.Parse(input_panjang.Text) == 0)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_lebar.Text == "")
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_lebar.Text == null)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (int.Parse(input_lebar.Text) == 0)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_ketebalan.Text == "")
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_ketebalan.Text == null)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (int.Parse(input_ketebalan.Text) == 0)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                    else if ((conv7 - 200) <= conv6)
                    {

                        MessageBox.Show("Z Melebihi Ketebalan Benda Kerja");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 Z" + pindah_berapa.Text + " " + feedrate.Text + input_feedrate.Text + spindle.Text + input_spindle.Text + Environment.NewLine);
                        data_terima.AppendText(Environment.NewLine + ">>> CODE INPUT <<<" + Environment.NewLine + Environment.NewLine);
                        data_terima.SelectionColor = Color.Blue;
                        data_terima.AppendText("G91 G21 G1 Z" + pindah_berapa.Text + " " + feedrate.Text + input_feedrate.Text + spindle.Text + input_spindle.Text + Environment.NewLine);
                        data_terima.AppendText(Environment.NewLine + ">>> RESULT <<<" + Environment.NewLine);
                        data_terima.ScrollToCaret();

                        option = "z plus";
                        num1 = int.Parse(pindah_berapa.Text);

                        if (option.Equals("z plus"))
                            result = num1 + conv6;

                        ind_z.Text = result + "";
                    }
            }

            catch (Exception)
            {
            }
        }

        private void y_plus_Click(object sender, EventArgs e)
        {
            try
            {
                conv4 = int.Parse(ind_y.Text);
                conv5 = int.Parse(input_lebar.Text) / 2;

                if (tombol_putuskan.Enabled == false)
                {
                    MessageBox.Show("Hubungkan Port Terlebih Dahulu");
                    com_port.Focus();
                }

                else if (pindah_berapa.Text == "")
                {
                    MessageBox.Show("Masukkan Perpindahan Terdahulu");
                    pindah_berapa.Focus();
                }

                else if (input_feedrate.Text == "")
                {
                    MessageBox.Show("Masukkan FeedRate Terdahulu");
                    input_feedrate.Focus();
                }

                else if (input_spindle.Text == "")
                {
                    MessageBox.Show("Masukkan Spindle Speed Terdahulu");
                    input_spindle.Focus();
                }

                else if (input_panjang.Text == "")
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_panjang.Text == null)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (int.Parse(input_panjang.Text) == 0)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_lebar.Text == "")
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_lebar.Text == null)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (int.Parse(input_lebar.Text) == 0)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_ketebalan.Text == "")
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_ketebalan.Text == null)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (int.Parse(input_ketebalan.Text) == 0)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                    else if ((conv5 - 200) <= conv4)
                    {

                        MessageBox.Show("Y Melebihi Lebar Benda Kerja");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 Y" + pindah_berapa.Text + " " + feedrate.Text + input_feedrate.Text + spindle.Text + input_spindle.Text + Environment.NewLine);
                        data_terima.AppendText(Environment.NewLine + ">>> CODE INPUT <<<" + Environment.NewLine + Environment.NewLine);
                        data_terima.SelectionColor = Color.Blue;
                        data_terima.AppendText("G91 G21 G1 Y" + pindah_berapa.Text + " " + feedrate.Text + input_feedrate.Text + spindle.Text + input_spindle.Text + Environment.NewLine);
                        data_terima.AppendText(Environment.NewLine + ">>> RESULT <<<" + Environment.NewLine);
                        data_terima.ScrollToCaret();

                        option = "y plus";
                        num1 = int.Parse(pindah_berapa.Text);

                        if (option.Equals("y plus"))
                            result = num1 + conv4;
                        ind_y.Text = result + "";
                    }
                }
 
            catch (Exception)
            {
            }
        }

        private void y_min_Click(object sender, EventArgs e)
        {
            try
            {
                conv4 = int.Parse(ind_y.Text);
                conv5 = int.Parse(input_lebar.Text) / 2;

                if (tombol_putuskan.Enabled == false)
                {
                    MessageBox.Show("Hubungkan Port Terlebih Dahulu");
                    com_port.Focus();
                }

                else if (pindah_berapa.Text == "")
                {
                    MessageBox.Show("Masukkan Perpindahan Terdahulu");
                    pindah_berapa.Focus();
                }

                else if (input_feedrate.Text == "")
                {
                    MessageBox.Show("Masukkan FeedRate Terdahulu");
                    input_feedrate.Focus();
                }

                else if (input_spindle.Text == "")
                {
                    MessageBox.Show("Masukkan Spindle Speed Terdahulu");
                    input_spindle.Focus();
                }

                else if (input_panjang.Text == "")
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_panjang.Text == null)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (int.Parse(input_panjang.Text) == 0)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_lebar.Text == "")
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_lebar.Text == null)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (int.Parse(input_lebar.Text) == 0)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_ketebalan.Text == "")
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_ketebalan.Text == null)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (int.Parse(input_ketebalan.Text) == 0)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                    else if (-(conv5 - 200) >= conv4)
                    {

                        MessageBox.Show("Y Melebihi Lebar Benda Kerja");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 Y-" + pindah_berapa.Text + " " + feedrate.Text + input_feedrate.Text + spindle.Text + input_spindle.Text + Environment.NewLine);
                        data_terima.AppendText(Environment.NewLine + ">>> CODE INPUT <<<" + Environment.NewLine + Environment.NewLine);
                        data_terima.SelectionColor = Color.Blue;
                        data_terima.AppendText("G91 G21 G1 Y-" + pindah_berapa.Text + " " + feedrate.Text + input_feedrate.Text + spindle.Text + input_spindle.Text + Environment.NewLine);
                        data_terima.AppendText(Environment.NewLine + ">>> RESULT <<<" + Environment.NewLine);
                        data_terima.ScrollToCaret();

                        option = "y min";
                        num1 = int.Parse(pindah_berapa.Text);

                        if (option.Equals("y min"))
                            result = conv4 - num1;

                        ind_y.Text = result + "";
                    }
            }

            catch (Exception)
            {
            }
        }

        private void x_min_Click(object sender, EventArgs e)
        {
            
            try
            {
                conv2 = int.Parse(ind_x.Text);
                conv3 = int.Parse(input_panjang.Text) / 2;

                if (tombol_putuskan.Enabled == false)
                {
                    MessageBox.Show("Hubungkan Port Terlebih Dahulu");
                    com_port.Focus();
                }

                else if (pindah_berapa.Text == "")
                {
                    MessageBox.Show("Masukkan Perpindahan Terdahulu");
                    pindah_berapa.Focus();
                }

                else if (input_feedrate.Text == "")
                {
                    MessageBox.Show("Masukkan FeedRate Terdahulu");
                    input_feedrate.Focus();
                }

                else if (input_spindle.Text == "")
                {
                    MessageBox.Show("Masukkan Spindle Speed Terdahulu");
                    input_spindle.Focus();
                }

                else if (input_panjang.Text == "")
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_panjang.Text == null)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (int.Parse(input_panjang.Text) == 0)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_lebar.Text == "")
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_lebar.Text == null)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (int.Parse(input_lebar.Text) == 0)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_ketebalan.Text == "")
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_ketebalan.Text == null)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (int.Parse(input_ketebalan.Text) == 0)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (-(conv3 - 200) >= conv2)
                {

                    MessageBox.Show("X Melebihi Panjang Benda Kerja");
                }

                else
                {
                        serialPort1.Write("G91 G21 G1 X-" + pindah_berapa.Text + " " + feedrate.Text + input_feedrate.Text + spindle.Text + input_spindle.Text + Environment.NewLine);
                        data_terima.AppendText(Environment.NewLine + ">>> CODE INPUT <<<" + Environment.NewLine + Environment.NewLine);
                        data_terima.SelectionColor = Color.Blue;
                        data_terima.AppendText("G91 G21 G1 X-" + pindah_berapa.Text + " " + feedrate.Text + input_feedrate.Text + spindle.Text + input_spindle.Text + Environment.NewLine);
                        data_terima.AppendText(Environment.NewLine + ">>> RESULT <<<" + Environment.NewLine);
                        data_terima.ScrollToCaret();

                        option = "x min";
                        num1 = int.Parse(pindah_berapa.Text);

                        if (option.Equals("x min"))
                            result = conv2 - num1;

                        ind_x.Text = result + "";
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
            }
        }

        private void x_plus_Click(object sender, EventArgs e)
        {
            try
            {
                conv2 = int.Parse(ind_x.Text);
                conv3 = int.Parse(input_panjang.Text) / 2;

                if (tombol_putuskan.Enabled == false)
                {
                    MessageBox.Show("Hubungkan Port Terlebih Dahulu");
                    com_port.Focus();
                }

                else if (pindah_berapa.Text == "")
                {
                    MessageBox.Show("Masukkan Perpindahan Terdahulu");
                    pindah_berapa.Focus();
                }

                else if (input_feedrate.Text == "")
                {
                    MessageBox.Show("Masukkan FeedRate Terdahulu");
                    input_feedrate.Focus();
                }

                else if (input_spindle.Text == "")
                {
                    MessageBox.Show("Masukkan Spindle Speed Terdahulu");
                    input_spindle.Focus();
                }

                else if (input_panjang.Text == "")
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_panjang.Text == null)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (int.Parse(input_panjang.Text) == 0)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_lebar.Text == "")
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_lebar.Text == null)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (int.Parse(input_lebar.Text) == 0)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_ketebalan.Text == "")
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_ketebalan.Text == null)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (int.Parse(input_ketebalan.Text) == 0)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if ((conv3 - 200) <= conv2)
                {

                    MessageBox.Show("X Melebihi Panjang Benda Kerja");
                }

                else
                {
                    serialPort1.Write("G91 G21 G1 X" + pindah_berapa.Text + " " + feedrate.Text + input_feedrate.Text + spindle.Text + input_spindle.Text + Environment.NewLine);
                    data_terima.AppendText(Environment.NewLine + ">>> CODE INPUT <<<" + Environment.NewLine + Environment.NewLine);
                    data_terima.SelectionColor = Color.Blue;
                    data_terima.AppendText("G91 G21 G1 X" + pindah_berapa.Text + " " + feedrate.Text + input_feedrate.Text + spindle.Text + input_spindle.Text + Environment.NewLine);
                    data_terima.AppendText(Environment.NewLine + ">>> RESULT <<<" + Environment.NewLine);
                    data_terima.ScrollToCaret();

                    option = "x plus";
                    num1 = int.Parse(pindah_berapa.Text);

                    if (option.Equals("x plus"))
                        result = num1 + conv2;

                    ind_x.Text = result + "";
                }
            }

            catch (Exception)
            {

            }
        }

        private void z_min_Click(object sender, EventArgs e)
        {
            try
            {
                conv6 = int.Parse(ind_z.Text);
                conv7 = int.Parse(input_ketebalan.Text) / 2;

                if (tombol_putuskan.Enabled == false)
                {
                    MessageBox.Show("Hubungkan Port Terlebih Dahulu");
                    com_port.Focus();
                }

                else if (pindah_berapa.Text == "")
                {
                    MessageBox.Show("Masukkan Perpindahan Terdahulu");
                    pindah_berapa.Focus();
                }

                else if (input_feedrate.Text == "")
                {
                    MessageBox.Show("Masukkan FeedRate Terdahulu");
                    input_feedrate.Focus();
                }

                else if (input_spindle.Text == "")
                {
                    MessageBox.Show("Masukkan Spindle Speed Terdahulu");
                    input_spindle.Focus();
                }

                else if (input_panjang.Text == "")
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_panjang.Text == null)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (int.Parse(input_panjang.Text) == 0)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_lebar.Text == "")
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_lebar.Text == null)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (int.Parse(input_lebar.Text) == 0)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_ketebalan.Text == "")
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (input_ketebalan.Text == null)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                else if (int.Parse(input_ketebalan.Text) == 0)
                {
                    MessageBox.Show("Masuk Ke Setting Dan Atur Dimensi Benda Kerja Terlebih Dahulu");
                }

                    else if (-(conv7 - 200) >= conv6)
                    {

                        MessageBox.Show("Z Melebihi Panjang Workpiece");
                    }

                    else
                    {
                        serialPort1.Write("G91 G21 G1 Z-" + pindah_berapa.Text + " " + feedrate.Text + input_feedrate.Text + spindle.Text + input_spindle.Text + Environment.NewLine);
                        data_terima.AppendText(Environment.NewLine + ">>> CODE INPUT <<<" + Environment.NewLine + Environment.NewLine);
                        data_terima.SelectionColor = Color.Blue;
                        data_terima.AppendText("G91 G21 G1 Z-" + pindah_berapa.Text + " " + feedrate.Text + input_feedrate.Text + spindle.Text + input_spindle.Text + Environment.NewLine);
                        data_terima.AppendText(Environment.NewLine + ">>> RESULT <<<" + Environment.NewLine);
                        data_terima.ScrollToCaret();

                        option = "z min";
                        num1 = int.Parse(pindah_berapa.Text);

                        if (option.Equals("z min"))
                            result = conv6 - num1;

                        ind_z.Text = result + "";
                    }
            }

            catch (Exception)
            {
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("G90 X0 Y0 Z20 G28 X0 Y0 Z0" + Environment.NewLine);
                data_terima.AppendText(Environment.NewLine + ">>> CODE INPUT <<<" + Environment.NewLine + Environment.NewLine);
                data_terima.SelectionColor = Color.Blue;
                data_terima.AppendText("G90 X0 Y0 Z20 G28 X0 Y0 Z0" + Environment.NewLine);
                data_terima.AppendText(Environment.NewLine + ">>> RESULT <<<" + Environment.NewLine); 
                data_terima.ScrollToCaret();

                ind_x.Clear();
                ind_x.AppendText("0");
                ind_y.Clear();
                ind_y.AppendText("0");
                ind_z.Clear();
                ind_z.AppendText("0");
            }

            catch (Exception)
            {
                MessageBox.Show("Hubungkan Port Terlebih Dahulu");
                com_port.Focus();
            }
        }

        private void pindah_berapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("G92 X0" + Environment.NewLine);
                data_terima.AppendText(Environment.NewLine + ">>> CODE INPUT <<<" + Environment.NewLine + Environment.NewLine);
                data_terima.SelectionColor = Color.Blue;
                data_terima.AppendText("G92 X0" + Environment.NewLine);
                data_terima.AppendText(Environment.NewLine + ">>> RESULT <<<" + Environment.NewLine); 
                data_terima.ScrollToCaret();

                ind_x.Clear();
                ind_x.AppendText("0");
            }

            catch (Exception)
            {
                MessageBox.Show("Hubungkan Port Terlebih Dahulu");
                com_port.Focus();
            }
        }

        private void set_zero_y_button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("G92 Y0" + Environment.NewLine);
                data_terima.AppendText(Environment.NewLine + ">>> CODE INPUT <<<" + Environment.NewLine + Environment.NewLine);
                data_terima.SelectionColor = Color.Blue;
                data_terima.AppendText("G92 Y0" + Environment.NewLine);
                data_terima.AppendText(Environment.NewLine + ">>> RESULT <<<" + Environment.NewLine); 
                data_terima.ScrollToCaret();

                ind_y.Clear();
                ind_y.AppendText("0");
            }

            catch (Exception)
            {
                MessageBox.Show("Hubungkan Port Terlebih Dahulu");
                com_port.Focus();
            }
        }

        private void set_zero_z_button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("G92 Z0" + Environment.NewLine);
                data_terima.AppendText(Environment.NewLine + ">>> CODE INPUT <<<" + Environment.NewLine + Environment.NewLine);
                data_terima.SelectionColor = Color.Blue;
                data_terima.AppendText("G92 Z0" + Environment.NewLine);
                data_terima.AppendText(Environment.NewLine + ">>> RESULT <<<" + Environment.NewLine); 
                data_terima.ScrollToCaret();

                ind_z.Clear();
                ind_z.AppendText("0");
            }

            catch (Exception)
            {
                MessageBox.Show("Hubungkan Port Terlebih Dahulu");
                com_port.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_feedrate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void input_spindle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void input_panjang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void input_lebar_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_lebar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void input_ketebalan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.TopLevel = false;
            TabPage tp1 = new TabPage(f1.Text);

            if (checkBox2.Checked == true)
            {
                jog_setting.Show(); 
            }

            else
            {
                jog_setting.Hide();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.TopLevel = false;
            TabPage tp1 = new TabPage(f1.Text);

            if (checkBox3.Checked == true)
            {
                spindle_setting.Show();
            }

            else
            {
                spindle_setting.Hide();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.TopLevel = false;
            TabPage tp1 = new TabPage(f1.Text);

            if (checkBox4.Checked == true)
            {
                spindle_speed_setting.Show();
            }

            else
            {
                spindle_speed_setting.Hide();
            }
        }

        private void clean_button_Click(object sender, EventArgs e)
        {
            data_terima.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ind_x_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cw_button_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("M3" + Environment.NewLine);
                data_terima.AppendText(Environment.NewLine + ">>> CODE INPUT <<<" + Environment.NewLine + Environment.NewLine);
                data_terima.SelectionColor = Color.Blue;
                data_terima.AppendText("M3" + Environment.NewLine);
                data_terima.AppendText(Environment.NewLine + ">>> RESULT <<<" + Environment.NewLine);
                data_terima.ScrollToCaret();
            }

            catch (Exception)
            {
                MessageBox.Show("Hubungkan Port Terlebih Dahulu");
                com_port.Focus();
            }
        }

        private void ccw_button_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("M4" + Environment.NewLine);
                data_terima.AppendText(Environment.NewLine + ">>> CODE INPUT <<<" + Environment.NewLine + Environment.NewLine);
                data_terima.SelectionColor = Color.Blue;
                data_terima.AppendText("M4" + Environment.NewLine);
                data_terima.AppendText(Environment.NewLine + ">>> RESULT <<<" + Environment.NewLine);
                data_terima.ScrollToCaret();
            }

            catch (Exception)
            {
                MessageBox.Show("Hubungkan Port Terlebih Dahulu");
                com_port.Focus();
            }
        }

        private void stop_spindle_button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("M5" + Environment.NewLine);
                data_terima.AppendText(Environment.NewLine + ">>> CODE INPUT <<<" + Environment.NewLine + Environment.NewLine);
                data_terima.SelectionColor = Color.Blue;
                data_terima.AppendText("M5" + Environment.NewLine);
                data_terima.AppendText(Environment.NewLine + ">>> RESULT <<<" + Environment.NewLine);
                data_terima.ScrollToCaret();
            }

            catch (Exception)
            {
                MessageBox.Show("Hubungkan Port Terlebih Dahulu");
                com_port.Focus();
            }
        }

        private void load_code_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt) |*txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                data_kirim.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void com_port_TextChanged(object sender, EventArgs e)
        {

        }

        private void data_kirim_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.TopLevel = false;
            TabPage tp1 = new TabPage(f1.Text);

            if (checkBox1.Checked == true)
            {
                indikator.Show();
            }

            else
            {
                indikator.Hide();
            }
        }

        private void pesan_Click(object sender, EventArgs e)
        {

        }

        private void baudrate_port_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pesan_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_feedrate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
