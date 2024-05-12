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
            this.lblPMSensor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnNight
            // 
            this.btnNight.BackgroundImage = global::EnvironmentalSimulation.Properties.Resources.moon;
            this.btnNight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNight.Location = new System.Drawing.Point(48, 130);
            this.btnNight.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNight.Name = "btnNight";
            this.btnNight.Size = new System.Drawing.Size(69, 75);
            this.btnNight.TabIndex = 0;
            this.btnNight.UseVisualStyleBackColor = true;
            this.btnNight.Click += new System.EventHandler(this.btnNight_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(226, 130);
            this.btnAuto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(69, 75);
            this.btnAuto.TabIndex = 1;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(139, 130);
            this.btnTimer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(69, 75);
            this.btnTimer.TabIndex = 2;
            this.btnTimer.Text = "00:00";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(119, 270);
            this.btnPower.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(107, 52);
            this.btnPower.TabIndex = 3;
            this.btnPower.Text = "Power";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // rdoLow
            // 
            this.rdoLow.AutoSize = true;
            this.rdoLow.Location = new System.Drawing.Point(129, 246);
            this.rdoLow.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdoLow.Name = "rdoLow";
            this.rdoLow.Size = new System.Drawing.Size(17, 16);
            this.rdoLow.TabIndex = 4;
            this.rdoLow.TabStop = true;
            this.rdoLow.UseVisualStyleBackColor = true;
            // 
            // rdoMid
            // 
            this.rdoMid.AutoSize = true;
            this.rdoMid.Location = new System.Drawing.Point(165, 246);
            this.rdoMid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdoMid.Name = "rdoMid";
            this.rdoMid.Size = new System.Drawing.Size(17, 16);
            this.rdoMid.TabIndex = 5;
            this.rdoMid.TabStop = true;
            this.rdoMid.UseVisualStyleBackColor = true;
            // 
            // rdoHigh
            // 
            this.rdoHigh.AutoSize = true;
            this.rdoHigh.Location = new System.Drawing.Point(200, 246);
            this.rdoHigh.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdoHigh.Name = "rdoHigh";
            this.rdoHigh.Size = new System.Drawing.Size(17, 16);
            this.rdoHigh.TabIndex = 6;
            this.rdoHigh.TabStop = true;
            this.rdoHigh.UseVisualStyleBackColor = true;
            // 
            // lblPMSensor
            // 
            this.lblPMSensor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPMSensor.Location = new System.Drawing.Point(74, 62);
            this.lblPMSensor.Name = "lblPMSensor";
            this.lblPMSensor.Size = new System.Drawing.Size(197, 32);
            this.lblPMSensor.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AirCleanerController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 369);
            this.Controls.Add(this.lblPMSensor);
            this.Controls.Add(this.rdoHigh);
            this.Controls.Add(this.rdoMid);
            this.Controls.Add(this.rdoLow);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnNight);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AirCleanerController";
            this.Text = "AirCleaner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AirCleanerController_FormClosing);
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
        private System.Windows.Forms.Label lblPMSensor;
        private System.Windows.Forms.Timer timer1;
    }
}