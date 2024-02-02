namespace Mecha_Gcode_Sender
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.spindle_speed_setting = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.input_spindle = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.spindle = new System.Windows.Forms.TextBox();
            this.cp_setting = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spindle_setting = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cw_button = new System.Windows.Forms.Button();
            this.ccw_button = new System.Windows.Forms.Button();
            this.stop_spindle_button = new System.Windows.Forms.Button();
            this.input_ketebalan = new System.Windows.Forms.TextBox();
            this.input_lebar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.input_panjang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.jog_setting = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.input_feedrate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.feedrate = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.baudrate_port = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.load_code_button = new System.Windows.Forms.Button();
            this.data_kirim = new System.Windows.Forms.RichTextBox();
            this.pindah_berapa = new System.Windows.Forms.TextBox();
            this.com_port = new System.Windows.Forms.TextBox();
            this.data_terima = new System.Windows.Forms.RichTextBox();
            this.pesan = new System.Windows.Forms.RichTextBox();
            this.x_plus = new System.Windows.Forms.Button();
            this.indikator = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.ind_z = new System.Windows.Forms.TextBox();
            this.ind_y = new System.Windows.Forms.TextBox();
            this.ind_x = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.clean_button = new System.Windows.Forms.Button();
            this.set_zero_z_button = new System.Windows.Forms.Button();
            this.set_zero_y_button = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.tombol_putuskan = new System.Windows.Forms.Button();
            this.tombol_kirim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tombol_hubungkan = new System.Windows.Forms.Button();
            this.x_min = new System.Windows.Forms.Button();
            this.y_min = new System.Windows.Forms.Button();
            this.z_min = new System.Windows.Forms.Button();
            this.z_plus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emg_button = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.y_plus = new System.Windows.Forms.Button();
            this.set_x_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            this.spindle_speed_setting.SuspendLayout();
            this.cp_setting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.spindle_setting.SuspendLayout();
            this.jog_setting.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.indikator.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "serialport";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "\"Text Files (*.txt) |*txt |Text Files (*.txt) |*Text Document |Tap Files  (*.tap)" +
                " |*.TAP |Gcode Files  (*.gcode) |*.gcode\"";
            this.openFileDialog1.FilterIndex = 10;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.spindle_speed_setting);
            this.tabPage4.Controls.Add(this.cp_setting);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.jog_setting);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(981, 583);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Setting ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // spindle_speed_setting
            // 
            this.spindle_speed_setting.BackColor = System.Drawing.Color.WhiteSmoke;
            this.spindle_speed_setting.Controls.Add(this.label26);
            this.spindle_speed_setting.Controls.Add(this.input_spindle);
            this.spindle_speed_setting.Controls.Add(this.label27);
            this.spindle_speed_setting.Controls.Add(this.spindle);
            this.spindle_speed_setting.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spindle_speed_setting.Location = new System.Drawing.Point(679, 384);
            this.spindle_speed_setting.Name = "spindle_speed_setting";
            this.spindle_speed_setting.Size = new System.Drawing.Size(254, 142);
            this.spindle_speed_setting.TabIndex = 25;
            this.spindle_speed_setting.TabStop = false;
            this.spindle_speed_setting.Text = "Spindle Konfigurasi";
            this.spindle_speed_setting.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(11, 46);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(48, 16);
            this.label26.TabIndex = 22;
            this.label26.Text = "Speed";
            // 
            // input_spindle
            // 
            this.input_spindle.Location = new System.Drawing.Point(13, 70);
            this.input_spindle.Name = "input_spindle";
            this.input_spindle.Size = new System.Drawing.Size(218, 21);
            this.input_spindle.TabIndex = 23;
            this.input_spindle.Text = "100";
            this.input_spindle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_spindle_KeyPress);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Cambria Math", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(5, 79);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(150, 61);
            this.label27.TabIndex = 24;
            this.label27.Text = "Kecepatan Putaran Spindle";
            // 
            // spindle
            // 
            this.spindle.Location = new System.Drawing.Point(14, 99);
            this.spindle.Name = "spindle";
            this.spindle.ReadOnly = true;
            this.spindle.Size = new System.Drawing.Size(100, 21);
            this.spindle.TabIndex = 26;
            this.spindle.Text = " S";
            // 
            // cp_setting
            // 
            this.cp_setting.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cp_setting.Controls.Add(this.checkBox1);
            this.cp_setting.Controls.Add(this.checkBox4);
            this.cp_setting.Controls.Add(this.checkBox3);
            this.cp_setting.Controls.Add(this.checkBox2);
            this.cp_setting.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cp_setting.Location = new System.Drawing.Point(679, 31);
            this.cp_setting.Name = "cp_setting";
            this.cp_setting.Size = new System.Drawing.Size(254, 184);
            this.cp_setting.TabIndex = 25;
            this.cp_setting.TabStop = false;
            this.cp_setting.Text = "Control Panel Setting";
            this.cp_setting.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 146);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 18);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Tampilkan Indikator";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(12, 67);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(229, 18);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Tampilkan Spindle Konfigurasi";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 106);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(201, 18);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Tampilkan Spindle Setting";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 31);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(173, 18);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Tampilkan Jog Setting";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckStateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.spindle_setting);
            this.groupBox1.Controls.Add(this.input_ketebalan);
            this.groupBox1.Controls.Add(this.input_lebar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.input_panjang);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 495);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dimensi Benda Kerja";
            // 
            // spindle_setting
            // 
            this.spindle_setting.BackColor = System.Drawing.Color.WhiteSmoke;
            this.spindle_setting.Controls.Add(this.label22);
            this.spindle_setting.Controls.Add(this.label21);
            this.spindle_setting.Controls.Add(this.label23);
            this.spindle_setting.Controls.Add(this.cw_button);
            this.spindle_setting.Controls.Add(this.ccw_button);
            this.spindle_setting.Controls.Add(this.stop_spindle_button);
            this.spindle_setting.Font = new System.Drawing.Font("Monospac821 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spindle_setting.Location = new System.Drawing.Point(33, 269);
            this.spindle_setting.Name = "spindle_setting";
            this.spindle_setting.Size = new System.Drawing.Size(529, 216);
            this.spindle_setting.TabIndex = 28;
            this.spindle_setting.TabStop = false;
            this.spindle_setting.Text = "Spindle Setting";
            this.spindle_setting.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(76, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(312, 73);
            this.label22.TabIndex = 29;
            this.label22.Text = "Spindle Akan Berputar Berlawanan Arah Jarum Jam";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(76, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(254, 73);
            this.label21.TabIndex = 28;
            this.label21.Text = "Spindle Akan Berputar Searah Jarum Jam";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(76, 135);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(160, 73);
            this.label23.TabIndex = 30;
            this.label23.Text = "Spindle Mesin Berhenti";
            // 
            // cw_button
            // 
            this.cw_button.Image = ((System.Drawing.Image)(resources.GetObject("cw_button.Image")));
            this.cw_button.Location = new System.Drawing.Point(15, 28);
            this.cw_button.Name = "cw_button";
            this.cw_button.Size = new System.Drawing.Size(60, 54);
            this.cw_button.TabIndex = 4;
            this.cw_button.UseVisualStyleBackColor = true;
            this.cw_button.Click += new System.EventHandler(this.cw_button_Click_1);
            // 
            // ccw_button
            // 
            this.ccw_button.Image = ((System.Drawing.Image)(resources.GetObject("ccw_button.Image")));
            this.ccw_button.Location = new System.Drawing.Point(15, 89);
            this.ccw_button.Name = "ccw_button";
            this.ccw_button.Size = new System.Drawing.Size(60, 54);
            this.ccw_button.TabIndex = 5;
            this.ccw_button.UseVisualStyleBackColor = true;
            this.ccw_button.Click += new System.EventHandler(this.ccw_button_Click_1);
            // 
            // stop_spindle_button
            // 
            this.stop_spindle_button.Image = ((System.Drawing.Image)(resources.GetObject("stop_spindle_button.Image")));
            this.stop_spindle_button.Location = new System.Drawing.Point(15, 149);
            this.stop_spindle_button.Name = "stop_spindle_button";
            this.stop_spindle_button.Size = new System.Drawing.Size(60, 54);
            this.stop_spindle_button.TabIndex = 6;
            this.stop_spindle_button.UseVisualStyleBackColor = true;
            this.stop_spindle_button.Click += new System.EventHandler(this.stop_spindle_button_Click);
            // 
            // input_ketebalan
            // 
            this.input_ketebalan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_ketebalan.Location = new System.Drawing.Point(124, 198);
            this.input_ketebalan.Name = "input_ketebalan";
            this.input_ketebalan.Size = new System.Drawing.Size(438, 22);
            this.input_ketebalan.TabIndex = 18;
            this.input_ketebalan.Text = "10000";
            this.input_ketebalan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_ketebalan_KeyPress);
            // 
            // input_lebar
            // 
            this.input_lebar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_lebar.Location = new System.Drawing.Point(124, 120);
            this.input_lebar.Name = "input_lebar";
            this.input_lebar.Size = new System.Drawing.Size(438, 22);
            this.input_lebar.TabIndex = 17;
            this.input_lebar.Text = "10000";
            this.input_lebar.TextChanged += new System.EventHandler(this.input_lebar_TextChanged);
            this.input_lebar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_lebar_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ketebalan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Lebar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Panjang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria Math", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(114, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 61);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ukuran lebar benda kerja dalam satuan milimeter";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria Math", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(114, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(276, 61);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ukuran ketebalan benda kerja dalam satuan milimeter";
            // 
            // input_panjang
            // 
            this.input_panjang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_panjang.Location = new System.Drawing.Point(124, 52);
            this.input_panjang.Name = "input_panjang";
            this.input_panjang.Size = new System.Drawing.Size(438, 22);
            this.input_panjang.TabIndex = 16;
            this.input_panjang.Text = "10000";
            this.input_panjang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_panjang_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria Math", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 61);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ukuran panjang benda kerja dalam satuan milimeter";
            // 
            // jog_setting
            // 
            this.jog_setting.BackColor = System.Drawing.Color.WhiteSmoke;
            this.jog_setting.Controls.Add(this.label10);
            this.jog_setting.Controls.Add(this.input_feedrate);
            this.jog_setting.Controls.Add(this.label12);
            this.jog_setting.Controls.Add(this.feedrate);
            this.jog_setting.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jog_setting.Location = new System.Drawing.Point(679, 221);
            this.jog_setting.Name = "jog_setting";
            this.jog_setting.Size = new System.Drawing.Size(254, 157);
            this.jog_setting.TabIndex = 1;
            this.jog_setting.TabStop = false;
            this.jog_setting.Text = "Jog Setting";
            this.jog_setting.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Feedrate";
            // 
            // input_feedrate
            // 
            this.input_feedrate.Location = new System.Drawing.Point(13, 70);
            this.input_feedrate.Name = "input_feedrate";
            this.input_feedrate.Size = new System.Drawing.Size(218, 21);
            this.input_feedrate.TabIndex = 23;
            this.input_feedrate.Text = "100";
            this.input_feedrate.TextChanged += new System.EventHandler(this.input_feedrate_TextChanged);
            this.input_feedrate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_feedrate_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria Math", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 61);
            this.label12.TabIndex = 24;
            this.label12.Text = "Kecepatan pemakanan mesin";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // feedrate
            // 
            this.feedrate.Location = new System.Drawing.Point(16, 99);
            this.feedrate.Name = "feedrate";
            this.feedrate.ReadOnly = true;
            this.feedrate.Size = new System.Drawing.Size(100, 21);
            this.feedrate.TabIndex = 25;
            this.feedrate.Text = "F";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.baudrate_port);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.load_code_button);
            this.tabPage2.Controls.Add(this.data_kirim);
            this.tabPage2.Controls.Add(this.pindah_berapa);
            this.tabPage2.Controls.Add(this.com_port);
            this.tabPage2.Controls.Add(this.data_terima);
            this.tabPage2.Controls.Add(this.pesan);
            this.tabPage2.Controls.Add(this.x_plus);
            this.tabPage2.Controls.Add(this.indikator);
            this.tabPage2.Controls.Add(this.clean_button);
            this.tabPage2.Controls.Add(this.set_zero_z_button);
            this.tabPage2.Controls.Add(this.set_zero_y_button);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.tombol_putuskan);
            this.tabPage2.Controls.Add(this.tombol_kirim);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tombol_hubungkan);
            this.tabPage2.Controls.Add(this.x_min);
            this.tabPage2.Controls.Add(this.y_min);
            this.tabPage2.Controls.Add(this.z_min);
            this.tabPage2.Controls.Add(this.z_plus);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.emg_button);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.y_plus);
            this.tabPage2.Controls.Add(this.set_x_button);
            this.tabPage2.Controls.Add(this.home_button);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(981, 583);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Control Panel";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // baudrate_port
            // 
            this.baudrate_port.BackColor = System.Drawing.SystemColors.MenuBar;
            this.baudrate_port.FormattingEnabled = true;
            this.baudrate_port.Location = new System.Drawing.Point(692, 63);
            this.baudrate_port.Name = "baudrate_port";
            this.baudrate_port.Size = new System.Drawing.Size(148, 21);
            this.baudrate_port.TabIndex = 43;
            this.baudrate_port.SelectedIndexChanged += new System.EventHandler(this.baudrate_port_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Montserrat Alternates", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label24.Location = new System.Drawing.Point(609, 66);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 18);
            this.label24.TabIndex = 42;
            this.label24.Text = "Baudrate";
            // 
            // load_code_button
            // 
            this.load_code_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_code_button.Image = ((System.Drawing.Image)(resources.GetObject("load_code_button.Image")));
            this.load_code_button.Location = new System.Drawing.Point(783, 526);
            this.load_code_button.Name = "load_code_button";
            this.load_code_button.Size = new System.Drawing.Size(128, 27);
            this.load_code_button.TabIndex = 40;
            this.load_code_button.UseVisualStyleBackColor = true;
            this.load_code_button.Click += new System.EventHandler(this.load_code_button_Click);
            // 
            // data_kirim
            // 
            this.data_kirim.BackColor = System.Drawing.SystemColors.Menu;
            this.data_kirim.Location = new System.Drawing.Point(486, 495);
            this.data_kirim.Name = "data_kirim";
            this.data_kirim.Size = new System.Drawing.Size(291, 58);
            this.data_kirim.TabIndex = 39;
            this.data_kirim.Text = "";
            this.data_kirim.TextChanged += new System.EventHandler(this.data_kirim_TextChanged_1);
            // 
            // pindah_berapa
            // 
            this.pindah_berapa.Location = new System.Drawing.Point(173, 486);
            this.pindah_berapa.Name = "pindah_berapa";
            this.pindah_berapa.Size = new System.Drawing.Size(241, 20);
            this.pindah_berapa.TabIndex = 18;
            this.pindah_berapa.Text = "10";
            this.pindah_berapa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pindah_berapa_KeyPress);
            // 
            // com_port
            // 
            this.com_port.BackColor = System.Drawing.SystemColors.MenuBar;
            this.com_port.Location = new System.Drawing.Point(692, 32);
            this.com_port.Name = "com_port";
            this.com_port.Size = new System.Drawing.Size(148, 20);
            this.com_port.TabIndex = 16;
            this.com_port.Text = "COM";
            this.com_port.TextChanged += new System.EventHandler(this.com_port_TextChanged);
            // 
            // data_terima
            // 
            this.data_terima.BackColor = System.Drawing.SystemColors.MenuBar;
            this.data_terima.Location = new System.Drawing.Point(486, 110);
            this.data_terima.Name = "data_terima";
            this.data_terima.ReadOnly = true;
            this.data_terima.Size = new System.Drawing.Size(425, 375);
            this.data_terima.TabIndex = 9;
            this.data_terima.Text = "";
            this.data_terima.TextChanged += new System.EventHandler(this.data_terima_TextChanged);
            // 
            // pesan
            // 
            this.pesan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pesan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesan.Location = new System.Drawing.Point(486, 89);
            this.pesan.Name = "pesan";
            this.pesan.Size = new System.Drawing.Size(117, 96);
            this.pesan.TabIndex = 44;
            this.pesan.Text = "Status Port";
            this.pesan.TextChanged += new System.EventHandler(this.pesan_TextChanged);
            // 
            // x_plus
            // 
            this.x_plus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.x_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x_plus.Image = ((System.Drawing.Image)(resources.GetObject("x_plus.Image")));
            this.x_plus.Location = new System.Drawing.Point(157, 330);
            this.x_plus.Name = "x_plus";
            this.x_plus.Size = new System.Drawing.Size(45, 38);
            this.x_plus.TabIndex = 8;
            this.x_plus.UseVisualStyleBackColor = false;
            this.x_plus.Click += new System.EventHandler(this.x_plus_Click);
            // 
            // indikator
            // 
            this.indikator.BackColor = System.Drawing.Color.DimGray;
            this.indikator.Controls.Add(this.label30);
            this.indikator.Controls.Add(this.label29);
            this.indikator.Controls.Add(this.ind_z);
            this.indikator.Controls.Add(this.ind_y);
            this.indikator.Controls.Add(this.ind_x);
            this.indikator.Controls.Add(this.label28);
            this.indikator.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indikator.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.indikator.Location = new System.Drawing.Point(216, 110);
            this.indikator.Name = "indikator";
            this.indikator.Size = new System.Drawing.Size(244, 184);
            this.indikator.TabIndex = 38;
            this.indikator.TabStop = false;
            this.indikator.Text = "INDIKATOR";
            this.indikator.Visible = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(188, 139);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(43, 15);
            this.label30.TabIndex = 43;
            this.label30.Text = "Axis Z";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(188, 88);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(43, 15);
            this.label29.TabIndex = 42;
            this.label29.Text = "Axis Y";
            // 
            // ind_z
            // 
            this.ind_z.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ind_z.Location = new System.Drawing.Point(18, 136);
            this.ind_z.Name = "ind_z";
            this.ind_z.ReadOnly = true;
            this.ind_z.Size = new System.Drawing.Size(164, 21);
            this.ind_z.TabIndex = 41;
            this.ind_z.Text = "0";
            this.ind_z.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ind_y
            // 
            this.ind_y.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ind_y.Location = new System.Drawing.Point(18, 85);
            this.ind_y.Name = "ind_y";
            this.ind_y.ReadOnly = true;
            this.ind_y.Size = new System.Drawing.Size(164, 21);
            this.ind_y.TabIndex = 40;
            this.ind_y.Text = "0";
            // 
            // ind_x
            // 
            this.ind_x.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ind_x.Location = new System.Drawing.Point(18, 30);
            this.ind_x.Name = "ind_x";
            this.ind_x.ReadOnly = true;
            this.ind_x.Size = new System.Drawing.Size(164, 21);
            this.ind_x.TabIndex = 39;
            this.ind_x.Text = "0";
            this.ind_x.TextChanged += new System.EventHandler(this.ind_x_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(188, 31);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 15);
            this.label28.TabIndex = 39;
            this.label28.Text = "Axis X";
            // 
            // clean_button
            // 
            this.clean_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clean_button.Image = ((System.Drawing.Image)(resources.GetObject("clean_button.Image")));
            this.clean_button.Location = new System.Drawing.Point(846, 494);
            this.clean_button.Name = "clean_button";
            this.clean_button.Size = new System.Drawing.Size(65, 26);
            this.clean_button.TabIndex = 37;
            this.clean_button.UseVisualStyleBackColor = true;
            this.clean_button.Click += new System.EventHandler(this.clean_button_Click);
            // 
            // set_zero_z_button
            // 
            this.set_zero_z_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_zero_z_button.Image = ((System.Drawing.Image)(resources.GetObject("set_zero_z_button.Image")));
            this.set_zero_z_button.Location = new System.Drawing.Point(370, 340);
            this.set_zero_z_button.Name = "set_zero_z_button";
            this.set_zero_z_button.Size = new System.Drawing.Size(45, 38);
            this.set_zero_z_button.TabIndex = 34;
            this.set_zero_z_button.UseVisualStyleBackColor = true;
            this.set_zero_z_button.Click += new System.EventHandler(this.set_zero_z_button_Click);
            // 
            // set_zero_y_button
            // 
            this.set_zero_y_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_zero_y_button.Image = ((System.Drawing.Image)(resources.GetObject("set_zero_y_button.Image")));
            this.set_zero_y_button.Location = new System.Drawing.Point(314, 340);
            this.set_zero_y_button.Name = "set_zero_y_button";
            this.set_zero_y_button.Size = new System.Drawing.Size(45, 38);
            this.set_zero_y_button.TabIndex = 33;
            this.set_zero_y_button.UseVisualStyleBackColor = true;
            this.set_zero_y_button.Click += new System.EventHandler(this.set_zero_y_button_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(57, 487);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 16);
            this.label19.TabIndex = 19;
            this.label19.Text = "Pindah Berapa";
            // 
            // tombol_putuskan
            // 
            this.tombol_putuskan.AutoSize = true;
            this.tombol_putuskan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tombol_putuskan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombol_putuskan.Image = ((System.Drawing.Image)(resources.GetObject("tombol_putuskan.Image")));
            this.tombol_putuskan.Location = new System.Drawing.Point(846, 61);
            this.tombol_putuskan.Name = "tombol_putuskan";
            this.tombol_putuskan.Size = new System.Drawing.Size(60, 24);
            this.tombol_putuskan.TabIndex = 15;
            this.tombol_putuskan.UseVisualStyleBackColor = false;
            this.tombol_putuskan.Click += new System.EventHandler(this.tombol_putuskan_Click);
            // 
            // tombol_kirim
            // 
            this.tombol_kirim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombol_kirim.Image = ((System.Drawing.Image)(resources.GetObject("tombol_kirim.Image")));
            this.tombol_kirim.Location = new System.Drawing.Point(783, 494);
            this.tombol_kirim.Name = "tombol_kirim";
            this.tombol_kirim.Size = new System.Drawing.Size(57, 26);
            this.tombol_kirim.TabIndex = 14;
            this.tombol_kirim.UseVisualStyleBackColor = true;
            this.tombol_kirim.Click += new System.EventHandler(this.tombol_kirim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Alternates", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(561, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pilih Port CNC";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tombol_hubungkan
            // 
            this.tombol_hubungkan.AutoSize = true;
            this.tombol_hubungkan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tombol_hubungkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombol_hubungkan.Image = ((System.Drawing.Image)(resources.GetObject("tombol_hubungkan.Image")));
            this.tombol_hubungkan.Location = new System.Drawing.Point(846, 31);
            this.tombol_hubungkan.Name = "tombol_hubungkan";
            this.tombol_hubungkan.Size = new System.Drawing.Size(60, 24);
            this.tombol_hubungkan.TabIndex = 11;
            this.tombol_hubungkan.UseVisualStyleBackColor = false;
            this.tombol_hubungkan.Click += new System.EventHandler(this.tombol_hubungkan_Click);
            // 
            // x_min
            // 
            this.x_min.BackColor = System.Drawing.SystemColors.ControlDark;
            this.x_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x_min.Image = ((System.Drawing.Image)(resources.GetObject("x_min.Image")));
            this.x_min.Location = new System.Drawing.Point(86, 330);
            this.x_min.Name = "x_min";
            this.x_min.Size = new System.Drawing.Size(45, 38);
            this.x_min.TabIndex = 7;
            this.x_min.UseVisualStyleBackColor = false;
            this.x_min.Click += new System.EventHandler(this.x_min_Click);
            // 
            // y_min
            // 
            this.y_min.BackColor = System.Drawing.SystemColors.ControlDark;
            this.y_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.y_min.Image = ((System.Drawing.Image)(resources.GetObject("y_min.Image")));
            this.y_min.Location = new System.Drawing.Point(122, 378);
            this.y_min.Name = "y_min";
            this.y_min.Size = new System.Drawing.Size(45, 38);
            this.y_min.TabIndex = 6;
            this.y_min.UseVisualStyleBackColor = false;
            this.y_min.Click += new System.EventHandler(this.y_min_Click);
            // 
            // z_min
            // 
            this.z_min.BackColor = System.Drawing.SystemColors.ControlDark;
            this.z_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.z_min.Location = new System.Drawing.Point(28, 352);
            this.z_min.Name = "z_min";
            this.z_min.Size = new System.Drawing.Size(45, 38);
            this.z_min.TabIndex = 4;
            this.z_min.Text = "Z -";
            this.z_min.UseVisualStyleBackColor = false;
            this.z_min.Click += new System.EventHandler(this.z_min_Click);
            // 
            // z_plus
            // 
            this.z_plus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.z_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.z_plus.Location = new System.Drawing.Point(28, 308);
            this.z_plus.Name = "z_plus";
            this.z_plus.Size = new System.Drawing.Size(45, 38);
            this.z_plus.TabIndex = 3;
            this.z_plus.Text = "Z +";
            this.z_plus.UseVisualStyleBackColor = false;
            this.z_plus.Click += new System.EventHandler(this.z_plus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Alternates", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(64, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jog Control";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat Alternates", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(27, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emergency Stop";
            // 
            // emg_button
            // 
            this.emg_button.AutoSize = true;
            this.emg_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emg_button.Image = ((System.Drawing.Image)(resources.GetObject("emg_button.Image")));
            this.emg_button.Location = new System.Drawing.Point(33, 96);
            this.emg_button.Name = "emg_button";
            this.emg_button.Size = new System.Drawing.Size(168, 143);
            this.emg_button.TabIndex = 0;
            this.emg_button.UseVisualStyleBackColor = true;
            this.emg_button.Click += new System.EventHandler(this.emg_button_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(160, 483);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(300, 73);
            this.label20.TabIndex = 20;
            this.label20.Text = "Jarak Yang Berpindah Ketika Axis Di Tekan (mm)";
            // 
            // y_plus
            // 
            this.y_plus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.y_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.y_plus.Image = ((System.Drawing.Image)(resources.GetObject("y_plus.Image")));
            this.y_plus.Location = new System.Drawing.Point(122, 282);
            this.y_plus.Name = "y_plus";
            this.y_plus.Size = new System.Drawing.Size(45, 38);
            this.y_plus.TabIndex = 5;
            this.y_plus.UseVisualStyleBackColor = false;
            this.y_plus.Click += new System.EventHandler(this.y_plus_Click);
            // 
            // set_x_button
            // 
            this.set_x_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_x_button.Image = ((System.Drawing.Image)(resources.GetObject("set_x_button.Image")));
            this.set_x_button.Location = new System.Drawing.Point(259, 340);
            this.set_x_button.Name = "set_x_button";
            this.set_x_button.Size = new System.Drawing.Size(45, 38);
            this.set_x_button.TabIndex = 32;
            this.set_x_button.UseVisualStyleBackColor = true;
            this.set_x_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // home_button
            // 
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_button.Image = ((System.Drawing.Image)(resources.GetObject("home_button.Image")));
            this.home_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.home_button.Location = new System.Drawing.Point(259, 395);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(155, 48);
            this.home_button.TabIndex = 30;
            this.home_button.Text = "Home Position";
            this.home_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(989, 609);
            this.tabControl1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(989, 609);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mecha-One";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabPage4.ResumeLayout(false);
            this.spindle_speed_setting.ResumeLayout(false);
            this.spindle_speed_setting.PerformLayout();
            this.cp_setting.ResumeLayout(false);
            this.cp_setting.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.spindle_setting.ResumeLayout(false);
            this.spindle_setting.PerformLayout();
            this.jog_setting.ResumeLayout(false);
            this.jog_setting.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.indikator.ResumeLayout(false);
            this.indikator.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox spindle_speed_setting;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox input_spindle;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox spindle;
        private System.Windows.Forms.GroupBox cp_setting;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox spindle_setting;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button stop_spindle_button;
        private System.Windows.Forms.Button ccw_button;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button cw_button;
        private System.Windows.Forms.TextBox input_ketebalan;
        private System.Windows.Forms.TextBox input_lebar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox input_panjang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox jog_setting;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox input_feedrate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox feedrate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox baudrate_port;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button load_code_button;
        private System.Windows.Forms.RichTextBox data_kirim;
        private System.Windows.Forms.TextBox pindah_berapa;
        private System.Windows.Forms.TextBox com_port;
        private System.Windows.Forms.RichTextBox data_terima;
        private System.Windows.Forms.RichTextBox pesan;
        private System.Windows.Forms.Button x_plus;
        private System.Windows.Forms.GroupBox indikator;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox ind_z;
        private System.Windows.Forms.TextBox ind_y;
        private System.Windows.Forms.TextBox ind_x;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button clean_button;
        private System.Windows.Forms.Button set_zero_z_button;
        private System.Windows.Forms.Button set_zero_y_button;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button tombol_putuskan;
        private System.Windows.Forms.Button tombol_kirim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tombol_hubungkan;
        private System.Windows.Forms.Button x_min;
        private System.Windows.Forms.Button y_min;
        private System.Windows.Forms.Button z_min;
        private System.Windows.Forms.Button z_plus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button emg_button;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button y_plus;
        private System.Windows.Forms.Button set_x_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

