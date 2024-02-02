namespace Mecha_Gcode_Sender
{
    partial class Spindle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spindle));
            this.label1 = new System.Windows.Forms.Label();
            this.input_spindle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.stop_spindle_button = new System.Windows.Forms.RadioButton();
            this.cw_button = new System.Windows.Forms.RadioButton();
            this.ccw_button = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // input_spindle
            // 
            resources.ApplyResources(this.input_spindle, "input_spindle");
            this.input_spindle.Name = "input_spindle";
            this.input_spindle.TextChanged += new System.EventHandler(this.input_feedrate_TextChanged);
            this.input_spindle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_spindle_KeyPress);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stop_spindle_button
            // 
            resources.ApplyResources(this.stop_spindle_button, "stop_spindle_button");
            this.stop_spindle_button.Name = "stop_spindle_button";
            this.stop_spindle_button.TabStop = true;
            this.stop_spindle_button.UseVisualStyleBackColor = true;
            this.stop_spindle_button.CheckedChanged += new System.EventHandler(this.stop_spindle_button_CheckedChanged);
            // 
            // cw_button
            // 
            resources.ApplyResources(this.cw_button, "cw_button");
            this.cw_button.Name = "cw_button";
            this.cw_button.TabStop = true;
            this.cw_button.UseVisualStyleBackColor = true;
            this.cw_button.CheckedChanged += new System.EventHandler(this.cw_button_CheckedChanged);
            // 
            // ccw_button
            // 
            resources.ApplyResources(this.ccw_button, "ccw_button");
            this.ccw_button.Name = "ccw_button";
            this.ccw_button.TabStop = true;
            this.ccw_button.UseVisualStyleBackColor = true;
            this.ccw_button.CheckedChanged += new System.EventHandler(this.ccw_button_CheckedChanged);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.ccw_button);
            this.panel1.Controls.Add(this.cw_button);
            this.panel1.Controls.Add(this.stop_spindle_button);
            this.panel1.Name = "panel1";
            // 
            // Spindle
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_spindle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Spindle";
            this.Deactivate += new System.EventHandler(this.Spindle_Deactivate);
            this.Load += new System.EventHandler(this.Spindle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_spindle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton stop_spindle_button;
        private System.Windows.Forms.RadioButton cw_button;
        private System.Windows.Forms.RadioButton ccw_button;
        private System.Windows.Forms.Panel panel1;
    }
}