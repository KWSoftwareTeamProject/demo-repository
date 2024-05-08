namespace EnvironmentalSimulation
{
    partial class AirconController
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
            this.tempUp_btn = new System.Windows.Forms.Button();
            this.tempDown_btn = new System.Windows.Forms.Button();
            this.fanSpeed_btn = new System.Windows.Forms.Button();
            this.swing_btn = new System.Windows.Forms.Button();
            this.swingOn_btn = new System.Windows.Forms.Button();
            this.turn_btn = new System.Windows.Forms.Button();
            this.turnOn_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tempUp_btn
            // 
            this.tempUp_btn.Location = new System.Drawing.Point(41, 297);
            this.tempUp_btn.Name = "tempUp_btn";
            this.tempUp_btn.Size = new System.Drawing.Size(94, 61);
            this.tempUp_btn.TabIndex = 0;
            this.tempUp_btn.Text = "UP";
            this.tempUp_btn.UseVisualStyleBackColor = true;
            // 
            // tempDown_btn
            // 
            this.tempDown_btn.Location = new System.Drawing.Point(41, 380);
            this.tempDown_btn.Name = "tempDown_btn";
            this.tempDown_btn.Size = new System.Drawing.Size(94, 61);
            this.tempDown_btn.TabIndex = 1;
            this.tempDown_btn.Text = "DOWN";
            this.tempDown_btn.UseVisualStyleBackColor = true;
            // 
            // fanSpeed_btn
            // 
            this.fanSpeed_btn.Location = new System.Drawing.Point(166, 297);
            this.fanSpeed_btn.Name = "fanSpeed_btn";
            this.fanSpeed_btn.Size = new System.Drawing.Size(94, 61);
            this.fanSpeed_btn.TabIndex = 2;
            this.fanSpeed_btn.Text = "풍향세기";
            this.fanSpeed_btn.UseVisualStyleBackColor = true;
            // 
            // swing_btn
            // 
            this.swing_btn.Location = new System.Drawing.Point(286, 297);
            this.swing_btn.Name = "swing_btn";
            this.swing_btn.TabIndex = 3;
            this.swing_btn.Text = "회전";
            this.swing_btn.UseVisualStyleBackColor = true;
            // 
            // swingOn_btn
            // 
            this.swingOn_btn.Location = new System.Drawing.Point(286, 364);
            this.swingOn_btn.Name = "swingOn_btn";
            this.swingOn_btn.Size = new System.Drawing.Size(94, 23);
            this.swingOn_btn.TabIndex = 4;
            this.swingOn_btn.Text = "켜지면 색";
            this.swingOn_btn.UseVisualStyleBackColor = true;
            // 
            // turn_btn
            // 
            this.turn_btn.Location = new System.Drawing.Point(404, 297);
            this.turn_btn.Name = "turn_btn";
            this.turn_btn.Size = new System.Drawing.Size(94, 61);
            this.turn_btn.TabIndex = 5;
            this.turn_btn.Text = "전원";
            this.turn_btn.UseVisualStyleBackColor = true;
            // 
            // turnOn_btn
            // 
            this.turnOn_btn.Location = new System.Drawing.Point(404, 364);
            this.turnOn_btn.Name = "turnOn_btn";
            this.turnOn_btn.Size = new System.Drawing.Size(94, 23);
            this.turnOn_btn.TabIndex = 6;
            this.turnOn_btn.Text = "켜지면 색";
            this.turnOn_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 221);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 25F);
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "희망온도";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 40F);
            this.label2.Location = new System.Drawing.Point(33, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 67);
            this.label2.TabIndex = 1;
            this.label2.Text = "nn도";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15F);
            this.label3.Location = new System.Drawing.Point(245, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "풍향세기";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15F);
            this.label4.Location = new System.Drawing.Point(268, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "회전";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 15F);
            this.label5.Location = new System.Drawing.Point(363, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "약풍/강풍";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 15F);
            this.label6.Location = new System.Drawing.Point(377, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "On/Off";
            // 
            // AirconController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(527, 463);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.turnOn_btn);
            this.Controls.Add(this.turn_btn);
            this.Controls.Add(this.swingOn_btn);
            this.Controls.Add(this.swing_btn);
            this.Controls.Add(this.fanSpeed_btn);
            this.Controls.Add(this.tempDown_btn);
            this.Controls.Add(this.tempUp_btn);
            this.Name = "AirconController";
            this.Text = "AirconController";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tempUp_btn;
        private System.Windows.Forms.Button tempDown_btn;
        private System.Windows.Forms.Button fanSpeed_btn;
        private System.Windows.Forms.Button swing_btn;
        private System.Windows.Forms.Button swingOn_btn;
        private System.Windows.Forms.Button turn_btn;
        private System.Windows.Forms.Button turnOn_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}