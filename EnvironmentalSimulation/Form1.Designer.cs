﻿namespace EnvironmentalSimulation
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.방4 = new System.Windows.Forms.GroupBox();
            this.방3 = new System.Windows.Forms.GroupBox();
            this.방2 = new System.Windows.Forms.GroupBox();
            this.방1 = new System.Windows.Forms.GroupBox();
            this.방1공기청정기 = new System.Windows.Forms.Button();
            this.방1전등 = new System.Windows.Forms.Button();
            this.방1난방 = new System.Windows.Forms.Button();
            this.방1에어컨 = new System.Windows.Forms.Button();
            this.cld = new System.Windows.Forms.ColorDialog();
            this.방1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 방4
            // 
            this.방4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.방4.Location = new System.Drawing.Point(305, 263);
            this.방4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방4.Name = "방4";
            this.방4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방4.Size = new System.Drawing.Size(262, 240);
            this.방4.TabIndex = 7;
            this.방4.TabStop = false;
            this.방4.Text = "방4";
            // 
            // 방3
            // 
            this.방3.Location = new System.Drawing.Point(29, 263);
            this.방3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방3.Name = "방3";
            this.방3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방3.Size = new System.Drawing.Size(262, 240);
            this.방3.TabIndex = 6;
            this.방3.TabStop = false;
            this.방3.Text = "방3";
            // 
            // 방2
            // 
            this.방2.Location = new System.Drawing.Point(305, 18);
            this.방2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방2.Name = "방2";
            this.방2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방2.Size = new System.Drawing.Size(262, 240);
            this.방2.TabIndex = 5;
            this.방2.TabStop = false;
            this.방2.Text = "방2";
            // 
            // 방1
            // 
            this.방1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.방1.Controls.Add(this.방1공기청정기);
            this.방1.Controls.Add(this.방1전등);
            this.방1.Controls.Add(this.방1난방);
            this.방1.Controls.Add(this.방1에어컨);
            this.방1.Location = new System.Drawing.Point(30, 18);
            this.방1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방1.Name = "방1";
            this.방1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방1.Size = new System.Drawing.Size(262, 240);
            this.방1.TabIndex = 4;
            this.방1.TabStop = false;
            this.방1.Text = "방1";
            // 
            // 방1공기청정기
            // 
            this.방1공기청정기.BackColor = System.Drawing.Color.Lime;
            this.방1공기청정기.Location = new System.Drawing.Point(170, 75);
            this.방1공기청정기.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방1공기청정기.Name = "방1공기청정기";
            this.방1공기청정기.Size = new System.Drawing.Size(88, 160);
            this.방1공기청정기.TabIndex = 3;
            this.방1공기청정기.Text = "공기청정기";
            this.방1공기청정기.UseVisualStyleBackColor = false;
            // 
            // 방1전등
            // 
            this.방1전등.BackColor = System.Drawing.Color.Yellow;
            this.방1전등.Location = new System.Drawing.Point(5, 114);
            this.방1전등.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방1전등.Name = "방1전등";
            this.방1전등.Size = new System.Drawing.Size(22, 56);
            this.방1전등.TabIndex = 2;
            this.방1전등.Text = "전등";
            this.방1전등.UseVisualStyleBackColor = false;
            // 
            // 방1난방
            // 
            this.방1난방.BackColor = System.Drawing.Color.Red;
            this.방1난방.Location = new System.Drawing.Point(5, 174);
            this.방1난방.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방1난방.Name = "방1난방";
            this.방1난방.Size = new System.Drawing.Size(22, 56);
            this.방1난방.TabIndex = 1;
            this.방1난방.Text = "난방";
            this.방1난방.UseVisualStyleBackColor = false;
            // 
            // 방1에어컨
            // 
            this.방1에어컨.BackColor = System.Drawing.Color.Blue;
            this.방1에어컨.Location = new System.Drawing.Point(5, 19);
            this.방1에어컨.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방1에어컨.Name = "방1에어컨";
            this.방1에어컨.Size = new System.Drawing.Size(131, 40);
            this.방1에어컨.TabIndex = 0;
            this.방1에어컨.Text = "에어컨";
            this.방1에어컨.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 522);
            this.Controls.Add(this.방4);
            this.Controls.Add(this.방3);
            this.Controls.Add(this.방2);
            this.Controls.Add(this.방1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.방1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox 방4;
        private System.Windows.Forms.GroupBox 방3;
        private System.Windows.Forms.GroupBox 방2;
        private System.Windows.Forms.GroupBox 방1;
        private System.Windows.Forms.Button 방1공기청정기;
        private System.Windows.Forms.Button 방1전등;
        private System.Windows.Forms.Button 방1난방;
        private System.Windows.Forms.Button 방1에어컨;
        private System.Windows.Forms.ColorDialog cld;
    }
}

