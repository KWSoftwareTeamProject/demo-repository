namespace EnvironmentalSimulation
{
    partial class AirCleanerController
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
            this.btnNight = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.rdoLow = new System.Windows.Forms.RadioButton();
            this.rdoMid = new System.Windows.Forms.RadioButton();
            this.rdoHigh = new System.Windows.Forms.RadioButton();
            this.PMSensor = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnNight
            // 
            this.btnNight.BackgroundImage = global::EnvironmentalSimulation.Properties.Resources.moon;
            this.btnNight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNight.Location = new System.Drawing.Point(78, 208);
            this.btnNight.Margin = new System.Windows.Forms.Padding(6);
            this.btnNight.Name = "btnNight";
            this.btnNight.Size = new System.Drawing.Size(111, 120);
            this.btnNight.TabIndex = 0;
            this.btnNight.UseVisualStyleBackColor = true;
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(368, 208);
            this.btnAuto.Margin = new System.Windows.Forms.Padding(6);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(111, 120);
            this.btnAuto.TabIndex = 1;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(227, 208);
            this.btnTimer.Margin = new System.Windows.Forms.Padding(6);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(111, 120);
            this.btnTimer.TabIndex = 2;
            this.btnTimer.Text = "00:00";
            this.btnTimer.UseVisualStyleBackColor = true;
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(193, 432);
            this.btnPower.Margin = new System.Windows.Forms.Padding(6);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(175, 84);
            this.btnPower.TabIndex = 3;
            this.btnPower.Text = "Power";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // rdoLow
            // 
            this.rdoLow.AutoSize = true;
            this.rdoLow.Location = new System.Drawing.Point(210, 394);
            this.rdoLow.Margin = new System.Windows.Forms.Padding(6);
            this.rdoLow.Name = "rdoLow";
            this.rdoLow.Size = new System.Drawing.Size(27, 26);
            this.rdoLow.TabIndex = 4;
            this.rdoLow.TabStop = true;
            this.rdoLow.UseVisualStyleBackColor = true;
            // 
            // rdoMid
            // 
            this.rdoMid.AutoSize = true;
            this.rdoMid.Location = new System.Drawing.Point(267, 394);
            this.rdoMid.Margin = new System.Windows.Forms.Padding(6);
            this.rdoMid.Name = "rdoMid";
            this.rdoMid.Size = new System.Drawing.Size(27, 26);
            this.rdoMid.TabIndex = 5;
            this.rdoMid.TabStop = true;
            this.rdoMid.UseVisualStyleBackColor = true;
            // 
            // rdoHigh
            // 
            this.rdoHigh.AutoSize = true;
            this.rdoHigh.Location = new System.Drawing.Point(325, 394);
            this.rdoHigh.Margin = new System.Windows.Forms.Padding(6);
            this.rdoHigh.Name = "rdoHigh";
            this.rdoHigh.Size = new System.Drawing.Size(27, 26);
            this.rdoHigh.TabIndex = 6;
            this.rdoHigh.TabStop = true;
            this.rdoHigh.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.PMSensor.Enabled = false;
            this.PMSensor.Location = new System.Drawing.Point(74, 62);
            this.PMSensor.Margin = new System.Windows.Forms.Padding(4);
            this.PMSensor.Name = "PMSensor";
            this.PMSensor.Size = new System.Drawing.Size(196, 32);
            this.PMSensor.TabIndex = 7;
            this.PMSensor.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AirCleanerController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 590);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.rdoHigh);
            this.Controls.Add(this.rdoMid);
            this.Controls.Add(this.rdoLow);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnNight);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AirCleanerController";
            this.Text = "AirCleaner";
            this.Shown += new System.EventHandler(this.AirCleaner_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNight;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.RadioButton rdoLow;
        private System.Windows.Forms.RadioButton rdoMid;
        private System.Windows.Forms.RadioButton rdoHigh;
        private System.Windows.Forms.Button PMSensor;
        private System.Windows.Forms.Timer timer1;
    }
}