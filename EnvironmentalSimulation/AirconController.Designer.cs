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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setToTemp_lbl = new System.Windows.Forms.Label();
            this.fanSpeed_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.swing_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tempUp_btn = new System.Windows.Forms.Button();
            this.tempDown_btn = new System.Windows.Forms.Button();
            this.fanSpeed_btn = new System.Windows.Forms.Button();
            this.swing_btn = new System.Windows.Forms.Button();
            this.turnOnLight_btn = new System.Windows.Forms.Button();
            this.swingOnLight_btn = new System.Windows.Forms.Button();
            this.turnOn_btn = new System.Windows.Forms.Button();
            this.ACtimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.setToTemp_lbl);
            this.groupBox1.Controls.Add(this.fanSpeed_lbl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.swing_lbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // setToTemp_lbl
            // 
            this.setToTemp_lbl.AutoSize = true;
            this.setToTemp_lbl.Font = new System.Drawing.Font("굴림", 40F);
            this.setToTemp_lbl.Location = new System.Drawing.Point(33, 99);
            this.setToTemp_lbl.Name = "setToTemp_lbl";
            this.setToTemp_lbl.Size = new System.Drawing.Size(174, 67);
            this.setToTemp_lbl.TabIndex = 13;
            this.setToTemp_lbl.Text = "nn도";
            // 
            // fanSpeed_lbl
            // 
            this.fanSpeed_lbl.AutoSize = true;
            this.fanSpeed_lbl.Font = new System.Drawing.Font("굴림", 15F);
            this.fanSpeed_lbl.Location = new System.Drawing.Point(363, 62);
            this.fanSpeed_lbl.Name = "fanSpeed_lbl";
            this.fanSpeed_lbl.Size = new System.Drawing.Size(120, 25);
            this.fanSpeed_lbl.TabIndex = 12;
            this.fanSpeed_lbl.Text = "약풍,강풍";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 15F);
            this.label5.Location = new System.Drawing.Point(245, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "풍향세기";
            // 
            // swing_lbl
            // 
            this.swing_lbl.AutoSize = true;
            this.swing_lbl.Font = new System.Drawing.Font("굴림", 15F);
            this.swing_lbl.Location = new System.Drawing.Point(363, 136);
            this.swing_lbl.Name = "swing_lbl";
            this.swing_lbl.Size = new System.Drawing.Size(90, 25);
            this.swing_lbl.TabIndex = 10;
            this.swing_lbl.Text = "On/Off";
            this.swing_lbl.Click += new System.EventHandler(this.swing_lbl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15F);
            this.label3.Location = new System.Drawing.Point(268, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "회전";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 25F);
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "희망온도";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "온도";
            // 
            // tempUp_btn
            // 
            this.tempUp_btn.Location = new System.Drawing.Point(41, 297);
            this.tempUp_btn.Name = "tempUp_btn";
            this.tempUp_btn.Size = new System.Drawing.Size(94, 61);
            this.tempUp_btn.TabIndex = 1;
            this.tempUp_btn.Text = "UP";
            this.tempUp_btn.UseVisualStyleBackColor = true;
            this.tempUp_btn.Click += new System.EventHandler(this.tempUp_btn_Click);
            // 
            // tempDown_btn
            // 
            this.tempDown_btn.Location = new System.Drawing.Point(41, 380);
            this.tempDown_btn.Name = "tempDown_btn";
            this.tempDown_btn.Size = new System.Drawing.Size(94, 61);
            this.tempDown_btn.TabIndex = 2;
            this.tempDown_btn.Text = "DOWN";
            this.tempDown_btn.UseVisualStyleBackColor = true;
            this.tempDown_btn.Click += new System.EventHandler(this.tempDown_btn_Click);
            // 
            // fanSpeed_btn
            // 
            this.fanSpeed_btn.Location = new System.Drawing.Point(166, 297);
            this.fanSpeed_btn.Name = "fanSpeed_btn";
            this.fanSpeed_btn.Size = new System.Drawing.Size(94, 61);
            this.fanSpeed_btn.TabIndex = 3;
            this.fanSpeed_btn.Text = "풍향세기";
            this.fanSpeed_btn.UseVisualStyleBackColor = true;
            this.fanSpeed_btn.Click += new System.EventHandler(this.fanSpeed_btn_Click);
            // 
            // swing_btn
            // 
            this.swing_btn.Location = new System.Drawing.Point(286, 297);
            this.swing_btn.Name = "swing_btn";
            this.swing_btn.Size = new System.Drawing.Size(94, 61);
            this.swing_btn.TabIndex = 4;
            this.swing_btn.Text = "회전";
            this.swing_btn.UseVisualStyleBackColor = true;
            this.swing_btn.Click += new System.EventHandler(this.swing_btn_Click);
            // 
            // turnOnLight_btn
            // 
            this.turnOnLight_btn.Location = new System.Drawing.Point(404, 364);
            this.turnOnLight_btn.Name = "turnOnLight_btn";
            this.turnOnLight_btn.Size = new System.Drawing.Size(94, 23);
            this.turnOnLight_btn.TabIndex = 5;
            this.turnOnLight_btn.UseVisualStyleBackColor = true;
            // 
            // swingOnLight_btn
            // 
            this.swingOnLight_btn.Location = new System.Drawing.Point(286, 364);
            this.swingOnLight_btn.Name = "swingOnLight_btn";
            this.swingOnLight_btn.Size = new System.Drawing.Size(94, 23);
            this.swingOnLight_btn.TabIndex = 6;
            this.swingOnLight_btn.UseVisualStyleBackColor = true;
            // 
            // turnOn_btn
            // 
            this.turnOn_btn.Location = new System.Drawing.Point(404, 297);
            this.turnOn_btn.Name = "turnOn_btn";
            this.turnOn_btn.Size = new System.Drawing.Size(94, 61);
            this.turnOn_btn.TabIndex = 7;
            this.turnOn_btn.Text = "전원";
            this.turnOn_btn.UseVisualStyleBackColor = true;
            this.turnOn_btn.Click += new System.EventHandler(this.turnOn_btn_Click);
            // 
            // ACtimer
            // 
            this.ACtimer.Tick += new System.EventHandler(this.ACtimer_Tick);
            // 
            // AirconController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(527, 463);
            this.Controls.Add(this.turnOn_btn);
            this.Controls.Add(this.swingOnLight_btn);
            this.Controls.Add(this.turnOnLight_btn);
            this.Controls.Add(this.swing_btn);
            this.Controls.Add(this.fanSpeed_btn);
            this.Controls.Add(this.tempDown_btn);
            this.Controls.Add(this.tempUp_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AirconController";
            this.Text = "AirconController";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AirconController_FormClosed);
            this.Load += new System.EventHandler(this.AirconController_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tempUp_btn;
        private System.Windows.Forms.Button tempDown_btn;
        private System.Windows.Forms.Button fanSpeed_btn;
        private System.Windows.Forms.Button swing_btn;
        private System.Windows.Forms.Button turnOnLight_btn;
        private System.Windows.Forms.Button swingOnLight_btn;
        private System.Windows.Forms.Button turnOn_btn;
        private System.Windows.Forms.Label setToTemp_lbl;
        private System.Windows.Forms.Label fanSpeed_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label swing_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer ACtimer;
    }
}