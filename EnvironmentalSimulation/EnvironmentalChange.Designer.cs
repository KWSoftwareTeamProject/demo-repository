namespace EnvironmentalSimulation
{
    partial class EnvironmentalChange
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
            this.year = new System.Windows.Forms.Label();
            this.currenTime = new System.Windows.Forms.Label();
            this.setbtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.season = new System.Windows.Forms.Label();
            this.timeCb = new System.Windows.Forms.ComboBox();
            this.seasonCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(31, 35);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(0, 15);
            this.year.TabIndex = 0;
            // 
            // currenTime
            // 
            this.currenTime.AutoSize = true;
            this.currenTime.Location = new System.Drawing.Point(31, 70);
            this.currenTime.Name = "currenTime";
            this.currenTime.Size = new System.Drawing.Size(37, 15);
            this.currenTime.TabIndex = 1;
            this.currenTime.Text = "시간";
            // 
            // setbtn
            // 
            this.setbtn.Location = new System.Drawing.Point(34, 125);
            this.setbtn.Name = "setbtn";
            this.setbtn.Size = new System.Drawing.Size(75, 30);
            this.setbtn.TabIndex = 6;
            this.setbtn.Text = "적용";
            this.setbtn.UseVisualStyleBackColor = true;
            this.setbtn.Click += new System.EventHandler(this.setbtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(189, 125);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(75, 30);
            this.closebtn.TabIndex = 7;
            this.closebtn.Text = "나가기";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // season
            // 
            this.season.AutoSize = true;
            this.season.Location = new System.Drawing.Point(31, 32);
            this.season.Name = "season";
            this.season.Size = new System.Drawing.Size(37, 15);
            this.season.TabIndex = 8;
            this.season.Text = "계절";
            // 
            // timeCb
            // 
            this.timeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeCb.FormattingEnabled = true;
            this.timeCb.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.timeCb.Location = new System.Drawing.Point(143, 67);
            this.timeCb.Name = "timeCb";
            this.timeCb.Size = new System.Drawing.Size(121, 23);
            this.timeCb.TabIndex = 10;
            // 
            // seasonCb
            // 
            this.seasonCb.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.seasonCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seasonCb.FormattingEnabled = true;
            this.seasonCb.Items.AddRange(new object[] {
            "봄",
            "여름",
            "가을",
            "겨울"});
            this.seasonCb.Location = new System.Drawing.Point(143, 29);
            this.seasonCb.Name = "seasonCb";
            this.seasonCb.Size = new System.Drawing.Size(121, 23);
            this.seasonCb.TabIndex = 11;
            // 
            // EnvironmentalChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 184);
            this.Controls.Add(this.seasonCb);
            this.Controls.Add(this.timeCb);
            this.Controls.Add(this.season);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.setbtn);
            this.Controls.Add(this.currenTime);
            this.Controls.Add(this.year);
            this.Name = "EnvironmentalChange";
            this.Text = "EnvironmentalChange";
            this.Load += new System.EventHandler(this.EnvironmentalChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label currenTime;
        private System.Windows.Forms.Button setbtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Label season;
        private System.Windows.Forms.ComboBox timeCb;
        private System.Windows.Forms.ComboBox seasonCb;
    }
}