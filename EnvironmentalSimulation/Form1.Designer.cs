namespace EnvironmentalSimulation
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
            this.components = new System.ComponentModel.Container();
            this.방4 = new System.Windows.Forms.GroupBox();
            this.방4공기청정기 = new System.Windows.Forms.Button();
            this.방4난방 = new System.Windows.Forms.Button();
            this.방4전등 = new System.Windows.Forms.Button();
            this.방4에어컨 = new System.Windows.Forms.Button();
            this.방3 = new System.Windows.Forms.GroupBox();
            this.방3전등 = new System.Windows.Forms.Button();
            this.방3난방 = new System.Windows.Forms.Button();
            this.방3에어컨 = new System.Windows.Forms.Button();
            this.방3공기청정기 = new System.Windows.Forms.Button();
            this.방2 = new System.Windows.Forms.GroupBox();
            this.방1 = new System.Windows.Forms.GroupBox();
            this.방1공기청정기 = new System.Windows.Forms.Button();
            this.방1전등 = new System.Windows.Forms.Button();
            this.방1난방 = new System.Windows.Forms.Button();
            this.방1에어컨 = new System.Windows.Forms.Button();
            this.cld = new System.Windows.Forms.ColorDialog();
            this.setTime = new System.Windows.Forms.Timer(this.components);
            this.방4.SuspendLayout();
            this.방3.SuspendLayout();
            this.방1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 방4
            // 
            this.방4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.방4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.방4.Controls.Add(this.방4공기청정기);
            this.방4.Controls.Add(this.방4난방);
            this.방4.Controls.Add(this.방4전등);
            this.방4.Controls.Add(this.방4에어컨);
            this.방4.Location = new System.Drawing.Point(567, 526);
            this.방4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.방4.Name = "방4";
            this.방4.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.방4.Size = new System.Drawing.Size(486, 480);
            this.방4.TabIndex = 7;
            this.방4.TabStop = false;
            this.방4.Text = "방4";
            // 
            // 방4공기청정기
            // 
            this.방4공기청정기.BackColor = System.Drawing.Color.Lime;
            this.방4공기청정기.Location = new System.Drawing.Point(10, 35);
            this.방4공기청정기.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.방4공기청정기.Name = "방4공기청정기";
            this.방4공기청정기.Size = new System.Drawing.Size(164, 320);
            this.방4공기청정기.TabIndex = 4;
            this.방4공기청정기.Text = "공기청정기";
            this.방4공기청정기.UseVisualStyleBackColor = false;
            // 
            // 방4난방
            // 
            this.방4난방.BackColor = System.Drawing.Color.Red;
            this.방4난방.Location = new System.Drawing.Point(436, 154);
            this.방4난방.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.방4난방.Name = "방4난방";
            this.방4난방.Size = new System.Drawing.Size(41, 112);
            this.방4난방.TabIndex = 4;
            this.방4난방.Text = "난방";
            this.방4난방.UseVisualStyleBackColor = false;
            // 
            // 방4전등
            // 
            this.방4전등.BackColor = System.Drawing.Color.Yellow;
            this.방4전등.Location = new System.Drawing.Point(436, 35);
            this.방4전등.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.방4전등.Name = "방4전등";
            this.방4전등.Size = new System.Drawing.Size(41, 112);
            this.방4전등.TabIndex = 4;
            this.방4전등.Text = "전등";
            this.방4전등.UseVisualStyleBackColor = false;
            // 
            // 방4에어컨
            // 
            this.방4에어컨.BackColor = System.Drawing.Color.Blue;
            this.방4에어컨.Location = new System.Drawing.Point(232, 394);
            this.방4에어컨.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.방4에어컨.Name = "방4에어컨";
            this.방4에어컨.Size = new System.Drawing.Size(244, 80);
            this.방4에어컨.TabIndex = 4;
            this.방4에어컨.Text = "에어컨";
            this.방4에어컨.UseVisualStyleBackColor = false;
            // 
            // 방3
            // 
            this.방3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.방3.Controls.Add(this.방3전등);
            this.방3.Controls.Add(this.방3난방);
            this.방3.Controls.Add(this.방3에어컨);
            this.방3.Controls.Add(this.방3공기청정기);
            this.방3.Location = new System.Drawing.Point(88, 842);
            this.방3.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.방3.Name = "방3";
            this.방3.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.방3.Size = new System.Drawing.Size(486, 480);
            this.방3.TabIndex = 6;
            this.방3.TabStop = false;
            this.방3.Text = "방3";
            // 
            // 방3전등
            // 
            this.방3전등.BackColor = System.Drawing.Color.Yellow;
            this.방3전등.Location = new System.Drawing.Point(18, 56);
            this.방3전등.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.방3전등.Name = "방3전등";
            this.방3전등.Size = new System.Drawing.Size(67, 179);
            this.방3전등.TabIndex = 8;
            this.방3전등.Text = "전등";
            this.방3전등.UseVisualStyleBackColor = false;
            // 
            // 방3난방
            // 
            this.방3난방.BackColor = System.Drawing.Color.Red;
            this.방3난방.Location = new System.Drawing.Point(18, 246);
            this.방3난방.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.방3난방.Name = "방3난방";
            this.방3난방.Size = new System.Drawing.Size(67, 179);
            this.방3난방.TabIndex = 7;
            this.방3난방.Text = "난방";
            this.방3난방.UseVisualStyleBackColor = false;
            // 
            // 방3에어컨
            // 
            this.방3에어컨.BackColor = System.Drawing.Color.Blue;
            this.방3에어컨.Location = new System.Drawing.Point(18, 630);
            this.방3에어컨.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.방3에어컨.Name = "방3에어컨";
            this.방3에어컨.Size = new System.Drawing.Size(396, 128);
            this.방3에어컨.TabIndex = 6;
            this.방3에어컨.Text = "에어컨";
            this.방3에어컨.UseVisualStyleBackColor = false;
            // 
            // 방3공기청정기
            // 
            this.방3공기청정기.BackColor = System.Drawing.Color.Lime;
            this.방3공기청정기.Location = new System.Drawing.Point(514, 56);
            this.방3공기청정기.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.방3공기청정기.Name = "방3공기청정기";
            this.방3공기청정기.Size = new System.Drawing.Size(266, 512);
            this.방3공기청정기.TabIndex = 5;
            this.방3공기청정기.Text = "공기청정기";
            this.방3공기청정기.UseVisualStyleBackColor = false;
            this.방3공기청정기.Click += new System.EventHandler(this.방3공기청정기_Click);
            // 
            // 방2
            // 
            this.방2.Location = new System.Drawing.Point(567, 35);
            this.방2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.방2.Name = "방2";
            this.방2.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.방2.Size = new System.Drawing.Size(486, 480);
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
            this.방1.Location = new System.Drawing.Point(55, 35);
            this.방1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.방1.Name = "방1";
            this.방1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.방1.Size = new System.Drawing.Size(486, 480);
            this.방1.TabIndex = 4;
            this.방1.TabStop = false;
            this.방1.Text = "방1";
            // 
            // 방1공기청정기
            // 
            this.방1공기청정기.BackColor = System.Drawing.Color.Lime;
            this.방1공기청정기.Location = new System.Drawing.Point(315, 150);
            this.방1공기청정기.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.방1공기청정기.Name = "방1공기청정기";
            this.방1공기청정기.Size = new System.Drawing.Size(164, 320);
            this.방1공기청정기.TabIndex = 3;
            this.방1공기청정기.Text = "공기청정기";
            this.방1공기청정기.UseVisualStyleBackColor = false;
            // 
            // 방1전등
            // 
            this.방1전등.BackColor = System.Drawing.Color.Yellow;
            this.방1전등.Location = new System.Drawing.Point(10, 227);
            this.방1전등.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.방1전등.Name = "방1전등";
            this.방1전등.Size = new System.Drawing.Size(41, 112);
            this.방1전등.TabIndex = 2;
            this.방1전등.Text = "전등";
            this.방1전등.UseVisualStyleBackColor = false;
            this.방1전등.Click += new System.EventHandler(this.방1전등_Click);
            // 
            // 방1난방
            // 
            this.방1난방.BackColor = System.Drawing.Color.Red;
            this.방1난방.Location = new System.Drawing.Point(10, 349);
            this.방1난방.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.방1난방.Name = "방1난방";
            this.방1난방.Size = new System.Drawing.Size(41, 112);
            this.방1난방.TabIndex = 1;
            this.방1난방.Text = "난방";
            this.방1난방.UseVisualStyleBackColor = false;
            // 
            // 방1에어컨
            // 
            this.방1에어컨.BackColor = System.Drawing.Color.Blue;
            this.방1에어컨.Location = new System.Drawing.Point(10, 38);
            this.방1에어컨.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.방1에어컨.Name = "방1에어컨";
            this.방1에어컨.Size = new System.Drawing.Size(244, 80);
            this.방1에어컨.TabIndex = 0;
            this.방1에어컨.Text = "에어컨";
            this.방1에어컨.UseVisualStyleBackColor = false;
            // 
            // setTime
            // 
            this.setTime.Tick += new System.EventHandler(this.setTime_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 1043);
            this.Controls.Add(this.방4);
            this.Controls.Add(this.방3);
            this.Controls.Add(this.방2);
            this.Controls.Add(this.방1);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.방4.ResumeLayout(false);
            this.방3.ResumeLayout(false);
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
        private System.Windows.Forms.Button 방4난방;
        private System.Windows.Forms.Button 방4전등;
        private System.Windows.Forms.Button 방4에어컨;
        private System.Windows.Forms.Button 방4공기청정기;
        private System.Windows.Forms.Button 방3전등;
        private System.Windows.Forms.Button 방3난방;
        private System.Windows.Forms.Button 방3에어컨;
        private System.Windows.Forms.Button 방3공기청정기;
        private System.Windows.Forms.Timer setTime;
    }
}

