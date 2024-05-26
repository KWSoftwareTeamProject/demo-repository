namespace EnvironmentalSimulation
{
    partial class HeaterController
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
            this.gBox = new System.Windows.Forms.GroupBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.gBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox
            // 
            this.gBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gBox.Controls.Add(this.lblTemp);
            this.gBox.Location = new System.Drawing.Point(12, 12);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(410, 218);
            this.gBox.TabIndex = 0;
            this.gBox.TabStop = false;
            // 
            // lblTemp
            // 
            this.lblTemp.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTemp.Location = new System.Drawing.Point(0, 39);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(410, 141);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.Text = "10";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(68, 252);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 50);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(68, 319);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 50);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(279, 252);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(75, 50);
            this.btnPower.TabIndex = 3;
            this.btnPower.Text = "POWER";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(279, 319);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(75, 50);
            this.btnAuto.TabIndex = 4;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            // 
            // HeaterController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 381);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.gBox);
            this.Name = "HeaterController";
            this.Text = "HeaterController";
            this.Load += new System.EventHandler(this.HeaterController_Load);
            this.gBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnAuto;
    }
}