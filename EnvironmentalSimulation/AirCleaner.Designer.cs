namespace EnvironmentalSimulation
{
    partial class AirCleaner
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
            this.btnNight = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(210, 394);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(27, 26);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(267, 394);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(27, 26);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(325, 394);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(27, 26);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(121, 100);
            this.button5.Margin = new System.Windows.Forms.Padding(6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(319, 52);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // AirCleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 590);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnNight);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AirCleaner";
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button5;
    }
}