﻿namespace EnvironmentalSimulation
{
    partial class LightController
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
            this.BackGround1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lightturn = new System.Windows.Forms.Button();
            this.cld = new System.Windows.Forms.ColorDialog();
            this.currentTime = new System.Windows.Forms.Timer(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BackGround1
            // 
            this.BackGround1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackGround1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGround1.Location = new System.Drawing.Point(0, 0);
            this.BackGround1.Multiline = true;
            this.BackGround1.Name = "BackGround1";
            this.BackGround1.ReadOnly = true;
            this.BackGround1.Size = new System.Drawing.Size(482, 653);
            this.BackGround1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(458, 629);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 27);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(430, 230);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lightturn
            // 
            this.lightturn.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lightturn.Location = new System.Drawing.Point(25, 263);
            this.lightturn.Name = "lightturn";
            this.lightturn.Size = new System.Drawing.Size(431, 92);
            this.lightturn.TabIndex = 4;
            this.lightturn.Text = "Turn On/Off";
            this.lightturn.UseVisualStyleBackColor = true;
            this.lightturn.Click += new System.EventHandler(this.lightturn_Click);
            // 
            // currentTime
            // 
            this.currentTime.Tick += new System.EventHandler(this.currentTime_Tick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(25, 361);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(431, 60);
            this.textBox3.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(26, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 201);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // LightController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lightturn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BackGround1);
            this.Name = "LightController";
            this.Text = "Light";
            this.Load += new System.EventHandler(this.LightController_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BackGround1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button lightturn;
        private System.Windows.Forms.ColorDialog cld;
        private System.Windows.Forms.Timer currentTime;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
    }
}