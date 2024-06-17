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
            this.rm4degree = new System.Windows.Forms.Label();
            this.rm4finedust = new System.Windows.Forms.Label();
            this.방4공기청정기 = new System.Windows.Forms.Button();
            this.rm4fddata = new System.Windows.Forms.Label();
            this.방4난방 = new System.Windows.Forms.Button();
            this.rm4dgdata = new System.Windows.Forms.Label();
            this.방4전등 = new System.Windows.Forms.Button();
            this.방4에어컨 = new System.Windows.Forms.Button();
            this.방3 = new System.Windows.Forms.GroupBox();
            this.rm3degree = new System.Windows.Forms.Label();
            this.rm3finedust = new System.Windows.Forms.Label();
            this.방3에어컨 = new System.Windows.Forms.Button();
            this.rm3fddata = new System.Windows.Forms.Label();
            this.방3난방 = new System.Windows.Forms.Button();
            this.rm3dgdata = new System.Windows.Forms.Label();
            this.방3전등 = new System.Windows.Forms.Button();
            this.방3공기청정기 = new System.Windows.Forms.Button();
            this.방2 = new System.Windows.Forms.GroupBox();
            this.방2난방 = new System.Windows.Forms.Button();
            this.방2전등 = new System.Windows.Forms.Button();
            this.방2에어컨 = new System.Windows.Forms.Button();
            this.방2공기청정기 = new System.Windows.Forms.Button();
            this.rm2degree = new System.Windows.Forms.Label();
            this.rm2finedust = new System.Windows.Forms.Label();
            this.rm2dgdata = new System.Windows.Forms.Label();
            this.rm2fddata = new System.Windows.Forms.Label();
            this.방1 = new System.Windows.Forms.GroupBox();
            this.rm1degree = new System.Windows.Forms.Label();
            this.rm1finedust = new System.Windows.Forms.Label();
            this.rm1fddata = new System.Windows.Forms.Label();
            this.rm1dgdata = new System.Windows.Forms.Label();
            this.방1공기청정기 = new System.Windows.Forms.Button();
            this.방1전등 = new System.Windows.Forms.Button();
            this.방1난방 = new System.Windows.Forms.Button();
            this.방1에어컨 = new System.Windows.Forms.Button();
            this.cld = new System.Windows.Forms.ColorDialog();
            this.setTime = new System.Windows.Forms.Timer(this.components);
            this.SettingData = new System.Windows.Forms.Button();
            this.seasonlb = new System.Windows.Forms.Label();
            this.timelb = new System.Windows.Forms.Label();
            this.seasondatalb = new System.Windows.Forms.Label();
            this.timedatalb = new System.Windows.Forms.Label();
            this.timestartbt = new System.Windows.Forms.Button();
            this.time1second = new System.Windows.Forms.Timer(this.components);
            this.timeaccel = new System.Windows.Forms.Button();
            this.templb = new System.Windows.Forms.Label();
            this.tempdatalb = new System.Windows.Forms.Label();
            this.방4.SuspendLayout();
            this.방3.SuspendLayout();
            this.방2.SuspendLayout();
            this.방1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 방4
            // 
            this.방4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.방4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.방4.Controls.Add(this.rm4degree);
            this.방4.Controls.Add(this.rm4finedust);
            this.방4.Controls.Add(this.방4공기청정기);
            this.방4.Controls.Add(this.rm4fddata);
            this.방4.Controls.Add(this.방4난방);
            this.방4.Controls.Add(this.rm4dgdata);
            this.방4.Controls.Add(this.방4전등);
            this.방4.Controls.Add(this.방4에어컨);
            this.방4.Location = new System.Drawing.Point(305, 358);
            this.방4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방4.Name = "방4";
            this.방4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방4.Size = new System.Drawing.Size(262, 240);
            this.방4.TabIndex = 7;
            this.방4.TabStop = false;
            this.방4.Text = "방4";
            // 
            // rm4degree
            // 
            this.rm4degree.AutoSize = true;
            this.rm4degree.ForeColor = System.Drawing.Color.Red;
            this.rm4degree.Location = new System.Drawing.Point(32, 197);
            this.rm4degree.Name = "rm4degree";
            this.rm4degree.Size = new System.Drawing.Size(29, 12);
            this.rm4degree.TabIndex = 15;
            this.rm4degree.Text = "온도";
            // 
            // rm4finedust
            // 
            this.rm4finedust.AutoSize = true;
            this.rm4finedust.ForeColor = System.Drawing.Color.Red;
            this.rm4finedust.Location = new System.Drawing.Point(12, 214);
            this.rm4finedust.Name = "rm4finedust";
            this.rm4finedust.Size = new System.Drawing.Size(53, 12);
            this.rm4finedust.TabIndex = 14;
            this.rm4finedust.Text = "미세먼지";
            // 
            // 방4공기청정기
            // 
            this.방4공기청정기.BackColor = System.Drawing.Color.Lime;
            this.방4공기청정기.Location = new System.Drawing.Point(5, 18);
            this.방4공기청정기.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방4공기청정기.Name = "방4공기청정기";
            this.방4공기청정기.Size = new System.Drawing.Size(88, 160);
            this.방4공기청정기.TabIndex = 4;
            this.방4공기청정기.Text = "공기청정기";
            this.방4공기청정기.UseVisualStyleBackColor = false;
            this.방4공기청정기.Click += new System.EventHandler(this.공기청정기_Click);
            // 
            // rm4fddata
            // 
            this.rm4fddata.AutoSize = true;
            this.rm4fddata.ForeColor = System.Drawing.Color.Red;
            this.rm4fddata.Location = new System.Drawing.Point(94, 214);
            this.rm4fddata.Name = "rm4fddata";
            this.rm4fddata.Size = new System.Drawing.Size(11, 12);
            this.rm4fddata.TabIndex = 13;
            this.rm4fddata.Text = "0";
            // 
            // 방4난방
            // 
            this.방4난방.BackColor = System.Drawing.Color.Red;
            this.방4난방.Location = new System.Drawing.Point(234, 77);
            this.방4난방.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방4난방.Name = "방4난방";
            this.방4난방.Size = new System.Drawing.Size(22, 56);
            this.방4난방.TabIndex = 4;
            this.방4난방.Text = "난방";
            this.방4난방.UseVisualStyleBackColor = false;
            this.방4난방.Click += new System.EventHandler(this.난방_Click);
            // 
            // rm4dgdata
            // 
            this.rm4dgdata.AutoSize = true;
            this.rm4dgdata.ForeColor = System.Drawing.Color.Red;
            this.rm4dgdata.Location = new System.Drawing.Point(94, 197);
            this.rm4dgdata.Name = "rm4dgdata";
            this.rm4dgdata.Size = new System.Drawing.Size(11, 12);
            this.rm4dgdata.TabIndex = 12;
            this.rm4dgdata.Text = "0";
            // 
            // 방4전등
            // 
            this.방4전등.BackColor = System.Drawing.Color.Yellow;
            this.방4전등.Location = new System.Drawing.Point(234, 18);
            this.방4전등.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방4전등.Name = "방4전등";
            this.방4전등.Size = new System.Drawing.Size(22, 56);
            this.방4전등.TabIndex = 4;
            this.방4전등.Text = "전등";
            this.방4전등.UseVisualStyleBackColor = false;
            this.방4전등.Click += new System.EventHandler(this.방전등_Click);
            // 
            // 방4에어컨
            // 
            this.방4에어컨.BackColor = System.Drawing.Color.Blue;
            this.방4에어컨.Location = new System.Drawing.Point(125, 197);
            this.방4에어컨.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방4에어컨.Name = "방4에어컨";
            this.방4에어컨.Size = new System.Drawing.Size(131, 40);
            this.방4에어컨.TabIndex = 4;
            this.방4에어컨.Text = "에어컨";
            this.방4에어컨.UseVisualStyleBackColor = false;
            this.방4에어컨.Click += new System.EventHandler(this.방4에어컨_Click);
            // 
            // 방3
            // 
            this.방3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.방3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.방3.Controls.Add(this.rm3degree);
            this.방3.Controls.Add(this.rm3finedust);
            this.방3.Controls.Add(this.방3에어컨);
            this.방3.Controls.Add(this.rm3fddata);
            this.방3.Controls.Add(this.방3난방);
            this.방3.Controls.Add(this.rm3dgdata);
            this.방3.Controls.Add(this.방3전등);
            this.방3.Controls.Add(this.방3공기청정기);
            this.방3.Location = new System.Drawing.Point(30, 358);
            this.방3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.방3.Name = "방3";
            this.방3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방3.Size = new System.Drawing.Size(262, 240);
            this.방3.TabIndex = 6;
            this.방3.TabStop = false;
            this.방3.Text = "방3";
            // 
            // rm3degree
            // 
            this.rm3degree.AutoSize = true;
            this.rm3degree.ForeColor = System.Drawing.Color.Red;
            this.rm3degree.Location = new System.Drawing.Point(178, 197);
            this.rm3degree.Name = "rm3degree";
            this.rm3degree.Size = new System.Drawing.Size(29, 12);
            this.rm3degree.TabIndex = 11;
            this.rm3degree.Text = "온도";
            // 
            // rm3finedust
            // 
            this.rm3finedust.AutoSize = true;
            this.rm3finedust.ForeColor = System.Drawing.Color.Red;
            this.rm3finedust.Location = new System.Drawing.Point(159, 214);
            this.rm3finedust.Name = "rm3finedust";
            this.rm3finedust.Size = new System.Drawing.Size(53, 12);
            this.rm3finedust.TabIndex = 10;
            this.rm3finedust.Text = "미세먼지";
            // 
            // 방3에어컨
            // 
            this.방3에어컨.BackColor = System.Drawing.Color.Blue;
            this.방3에어컨.Location = new System.Drawing.Point(5, 197);
            this.방3에어컨.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.방3에어컨.Name = "방3에어컨";
            this.방3에어컨.Size = new System.Drawing.Size(131, 40);
            this.방3에어컨.TabIndex = 8;
            this.방3에어컨.Text = "에어컨";
            this.방3에어컨.UseVisualStyleBackColor = false;
            this.방3에어컨.Click += new System.EventHandler(this.방3에어컨_Click);
            // 
            // rm3fddata
            // 
            this.rm3fddata.AutoSize = true;
            this.rm3fddata.ForeColor = System.Drawing.Color.Red;
            this.rm3fddata.Location = new System.Drawing.Point(234, 214);
            this.rm3fddata.Name = "rm3fddata";
            this.rm3fddata.Size = new System.Drawing.Size(11, 12);
            this.rm3fddata.TabIndex = 9;
            this.rm3fddata.Text = "0";
            // 
            // 방3난방
            // 
            this.방3난방.BackColor = System.Drawing.Color.Red;
            this.방3난방.Location = new System.Drawing.Point(5, 77);
            this.방3난방.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.방3난방.Name = "방3난방";
            this.방3난방.Size = new System.Drawing.Size(22, 56);
            this.방3난방.TabIndex = 7;
            this.방3난방.Text = "난방";
            this.방3난방.UseVisualStyleBackColor = false;
            this.방3난방.Click += new System.EventHandler(this.난방_Click);
            // 
            // rm3dgdata
            // 
            this.rm3dgdata.AutoSize = true;
            this.rm3dgdata.ForeColor = System.Drawing.Color.Red;
            this.rm3dgdata.Location = new System.Drawing.Point(234, 197);
            this.rm3dgdata.Name = "rm3dgdata";
            this.rm3dgdata.Size = new System.Drawing.Size(11, 12);
            this.rm3dgdata.TabIndex = 8;
            this.rm3dgdata.Text = "0";
            // 
            // 방3전등
            // 
            this.방3전등.BackColor = System.Drawing.Color.Yellow;
            this.방3전등.Location = new System.Drawing.Point(5, 18);
            this.방3전등.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.방3전등.Name = "방3전등";
            this.방3전등.Size = new System.Drawing.Size(22, 56);
            this.방3전등.TabIndex = 6;
            this.방3전등.Text = "전등";
            this.방3전등.UseVisualStyleBackColor = false;
            this.방3전등.Click += new System.EventHandler(this.방전등_Click);
            // 
            // 방3공기청정기
            // 
            this.방3공기청정기.BackColor = System.Drawing.Color.Lime;
            this.방3공기청정기.Location = new System.Drawing.Point(170, 18);
            this.방3공기청정기.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.방3공기청정기.Name = "방3공기청정기";
            this.방3공기청정기.Size = new System.Drawing.Size(88, 160);
            this.방3공기청정기.TabIndex = 5;
            this.방3공기청정기.Text = "공기청정기";
            this.방3공기청정기.UseVisualStyleBackColor = false;
            this.방3공기청정기.Click += new System.EventHandler(this.공기청정기_Click);
            // 
            // 방2
            // 
            this.방2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.방2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.방2.Controls.Add(this.방2난방);
            this.방2.Controls.Add(this.방2전등);
            this.방2.Controls.Add(this.방2에어컨);
            this.방2.Controls.Add(this.방2공기청정기);
            this.방2.Controls.Add(this.rm2degree);
            this.방2.Controls.Add(this.rm2finedust);
            this.방2.Controls.Add(this.rm2dgdata);
            this.방2.Controls.Add(this.rm2fddata);
            this.방2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.방2.Location = new System.Drawing.Point(305, 108);
            this.방2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방2.Name = "방2";
            this.방2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방2.Size = new System.Drawing.Size(262, 240);
            this.방2.TabIndex = 5;
            this.방2.TabStop = false;
            this.방2.Text = "방2";
            // 
            // 방2난방
            // 
            this.방2난방.BackColor = System.Drawing.Color.Red;
            this.방2난방.Location = new System.Drawing.Point(234, 174);
            this.방2난방.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방2난방.Name = "방2난방";
            this.방2난방.Size = new System.Drawing.Size(22, 56);
            this.방2난방.TabIndex = 8;
            this.방2난방.Text = "난방";
            this.방2난방.UseVisualStyleBackColor = false;
            this.방2난방.Click += new System.EventHandler(this.난방_Click);
            // 
            // 방2전등
            // 
            this.방2전등.BackColor = System.Drawing.Color.Yellow;
            this.방2전등.Location = new System.Drawing.Point(234, 114);
            this.방2전등.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방2전등.Name = "방2전등";
            this.방2전등.Size = new System.Drawing.Size(22, 56);
            this.방2전등.TabIndex = 8;
            this.방2전등.Text = "전등";
            this.방2전등.UseVisualStyleBackColor = false;
            this.방2전등.Click += new System.EventHandler(this.방전등_Click);
            // 
            // 방2에어컨
            // 
            this.방2에어컨.BackColor = System.Drawing.Color.Blue;
            this.방2에어컨.Location = new System.Drawing.Point(125, 19);
            this.방2에어컨.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방2에어컨.Name = "방2에어컨";
            this.방2에어컨.Size = new System.Drawing.Size(131, 40);
            this.방2에어컨.TabIndex = 8;
            this.방2에어컨.Text = "에어컨";
            this.방2에어컨.UseVisualStyleBackColor = false;
            this.방2에어컨.Click += new System.EventHandler(this.방2에어컨_Click);
            // 
            // 방2공기청정기
            // 
            this.방2공기청정기.BackColor = System.Drawing.Color.Lime;
            this.방2공기청정기.Location = new System.Drawing.Point(6, 76);
            this.방2공기청정기.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방2공기청정기.Name = "방2공기청정기";
            this.방2공기청정기.Size = new System.Drawing.Size(88, 160);
            this.방2공기청정기.TabIndex = 8;
            this.방2공기청정기.Text = "공기청정기";
            this.방2공기청정기.UseVisualStyleBackColor = false;
            this.방2공기청정기.Click += new System.EventHandler(this.공기청정기_Click);
            // 
            // rm2degree
            // 
            this.rm2degree.AutoSize = true;
            this.rm2degree.ForeColor = System.Drawing.Color.Red;
            this.rm2degree.Location = new System.Drawing.Point(32, 16);
            this.rm2degree.Name = "rm2degree";
            this.rm2degree.Size = new System.Drawing.Size(29, 12);
            this.rm2degree.TabIndex = 15;
            this.rm2degree.Text = "온도";
            // 
            // rm2finedust
            // 
            this.rm2finedust.AutoSize = true;
            this.rm2finedust.ForeColor = System.Drawing.Color.Red;
            this.rm2finedust.Location = new System.Drawing.Point(12, 34);
            this.rm2finedust.Name = "rm2finedust";
            this.rm2finedust.Size = new System.Drawing.Size(53, 12);
            this.rm2finedust.TabIndex = 14;
            this.rm2finedust.Text = "미세먼지";
            // 
            // rm2dgdata
            // 
            this.rm2dgdata.AutoSize = true;
            this.rm2dgdata.ForeColor = System.Drawing.Color.Red;
            this.rm2dgdata.Location = new System.Drawing.Point(94, 16);
            this.rm2dgdata.Name = "rm2dgdata";
            this.rm2dgdata.Size = new System.Drawing.Size(11, 12);
            this.rm2dgdata.TabIndex = 12;
            this.rm2dgdata.Text = "0";
            // 
            // rm2fddata
            // 
            this.rm2fddata.AutoSize = true;
            this.rm2fddata.ForeColor = System.Drawing.Color.Red;
            this.rm2fddata.Location = new System.Drawing.Point(94, 34);
            this.rm2fddata.Name = "rm2fddata";
            this.rm2fddata.Size = new System.Drawing.Size(11, 12);
            this.rm2fddata.TabIndex = 13;
            this.rm2fddata.Text = "0";
            // 
            // 방1
            // 
            this.방1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.방1.Controls.Add(this.rm1degree);
            this.방1.Controls.Add(this.rm1finedust);
            this.방1.Controls.Add(this.rm1fddata);
            this.방1.Controls.Add(this.rm1dgdata);
            this.방1.Controls.Add(this.방1공기청정기);
            this.방1.Controls.Add(this.방1전등);
            this.방1.Controls.Add(this.방1난방);
            this.방1.Controls.Add(this.방1에어컨);
            this.방1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.방1.Location = new System.Drawing.Point(30, 108);
            this.방1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방1.Name = "방1";
            this.방1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.방1.Size = new System.Drawing.Size(262, 240);
            this.방1.TabIndex = 4;
            this.방1.TabStop = false;
            this.방1.Text = "방1";
            // 
            // rm1degree
            // 
            this.rm1degree.AutoSize = true;
            this.rm1degree.ForeColor = System.Drawing.Color.Red;
            this.rm1degree.Location = new System.Drawing.Point(172, 16);
            this.rm1degree.Name = "rm1degree";
            this.rm1degree.Size = new System.Drawing.Size(29, 12);
            this.rm1degree.TabIndex = 7;
            this.rm1degree.Text = "온도";
            // 
            // rm1finedust
            // 
            this.rm1finedust.AutoSize = true;
            this.rm1finedust.ForeColor = System.Drawing.Color.Red;
            this.rm1finedust.Location = new System.Drawing.Point(152, 34);
            this.rm1finedust.Name = "rm1finedust";
            this.rm1finedust.Size = new System.Drawing.Size(53, 12);
            this.rm1finedust.TabIndex = 6;
            this.rm1finedust.Text = "미세먼지";
            // 
            // rm1fddata
            // 
            this.rm1fddata.AutoSize = true;
            this.rm1fddata.ForeColor = System.Drawing.Color.Red;
            this.rm1fddata.Location = new System.Drawing.Point(234, 34);
            this.rm1fddata.Name = "rm1fddata";
            this.rm1fddata.Size = new System.Drawing.Size(11, 12);
            this.rm1fddata.TabIndex = 5;
            this.rm1fddata.Text = "0";
            // 
            // rm1dgdata
            // 
            this.rm1dgdata.AutoSize = true;
            this.rm1dgdata.ForeColor = System.Drawing.Color.Red;
            this.rm1dgdata.Location = new System.Drawing.Point(234, 16);
            this.rm1dgdata.Name = "rm1dgdata";
            this.rm1dgdata.Size = new System.Drawing.Size(11, 12);
            this.rm1dgdata.TabIndex = 4;
            this.rm1dgdata.Text = "0";
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
            this.방1공기청정기.Click += new System.EventHandler(this.공기청정기_Click);
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
            this.방1전등.Click += new System.EventHandler(this.방전등_Click);
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
            this.방1난방.Click += new System.EventHandler(this.난방_Click);
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
            this.방1에어컨.Click += new System.EventHandler(this.방1에어컨_Click);
            // 
            // setTime
            // 
            this.setTime.Tick += new System.EventHandler(this.setTime_Tick);
            // 
            // SettingData
            // 
            this.SettingData.Location = new System.Drawing.Point(30, 10);
            this.SettingData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SettingData.Name = "SettingData";
            this.SettingData.Size = new System.Drawing.Size(262, 81);
            this.SettingData.TabIndex = 8;
            this.SettingData.Text = "환경변수 설정";
            this.SettingData.UseVisualStyleBackColor = true;
            this.SettingData.Click += new System.EventHandler(this.SettingData_Click);
            // 
            // seasonlb
            // 
            this.seasonlb.AutoSize = true;
            this.seasonlb.Location = new System.Drawing.Point(308, 18);
            this.seasonlb.Name = "seasonlb";
            this.seasonlb.Size = new System.Drawing.Size(29, 12);
            this.seasonlb.TabIndex = 9;
            this.seasonlb.Text = "계절";
            // 
            // timelb
            // 
            this.timelb.AutoSize = true;
            this.timelb.Location = new System.Drawing.Point(308, 46);
            this.timelb.Name = "timelb";
            this.timelb.Size = new System.Drawing.Size(29, 12);
            this.timelb.TabIndex = 10;
            this.timelb.Text = "시간";
            // 
            // seasondatalb
            // 
            this.seasondatalb.AutoSize = true;
            this.seasondatalb.Location = new System.Drawing.Point(400, 18);
            this.seasondatalb.Name = "seasondatalb";
            this.seasondatalb.Size = new System.Drawing.Size(17, 12);
            this.seasondatalb.TabIndex = 11;
            this.seasondatalb.Text = "봄";
            // 
            // timedatalb
            // 
            this.timedatalb.AutoSize = true;
            this.timedatalb.Location = new System.Drawing.Point(400, 46);
            this.timedatalb.Name = "timedatalb";
            this.timedatalb.Size = new System.Drawing.Size(11, 12);
            this.timedatalb.TabIndex = 12;
            this.timedatalb.Text = "0";
            // 
            // timestartbt
            // 
            this.timestartbt.Location = new System.Drawing.Point(479, 10);
            this.timestartbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timestartbt.Name = "timestartbt";
            this.timestartbt.Size = new System.Drawing.Size(88, 50);
            this.timestartbt.TabIndex = 14;
            this.timestartbt.Text = "시작/정지";
            this.timestartbt.UseVisualStyleBackColor = true;
            this.timestartbt.Click += new System.EventHandler(this.timestartbt_Click);
            // 
            // time1second
            // 
            this.time1second.Interval = 1000;
            this.time1second.Tick += new System.EventHandler(this.time1second_Tick);
            // 
            // timeaccel
            // 
            this.timeaccel.Location = new System.Drawing.Point(479, 64);
            this.timeaccel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeaccel.Name = "timeaccel";
            this.timeaccel.Size = new System.Drawing.Size(88, 27);
            this.timeaccel.TabIndex = 15;
            this.timeaccel.Text = "시간 가속";
            this.timeaccel.UseVisualStyleBackColor = true;
            this.timeaccel.Click += new System.EventHandler(this.timeaccel_Click);
            // 
            // templb
            // 
            this.templb.AutoSize = true;
            this.templb.Location = new System.Drawing.Point(308, 73);
            this.templb.Name = "templb";
            this.templb.Size = new System.Drawing.Size(29, 12);
            this.templb.TabIndex = 16;
            this.templb.Text = "온도";
            // 
            // tempdatalb
            // 
            this.tempdatalb.AutoSize = true;
            this.tempdatalb.Location = new System.Drawing.Point(400, 73);
            this.tempdatalb.Name = "tempdatalb";
            this.tempdatalb.Size = new System.Drawing.Size(11, 12);
            this.tempdatalb.TabIndex = 17;
            this.tempdatalb.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 643);
            this.Controls.Add(this.tempdatalb);
            this.Controls.Add(this.templb);
            this.Controls.Add(this.timeaccel);
            this.Controls.Add(this.timestartbt);
            this.Controls.Add(this.timedatalb);
            this.Controls.Add(this.seasondatalb);
            this.Controls.Add(this.timelb);
            this.Controls.Add(this.seasonlb);
            this.Controls.Add(this.SettingData);
            this.Controls.Add(this.방4);
            this.Controls.Add(this.방3);
            this.Controls.Add(this.방2);
            this.Controls.Add(this.방1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.방4.ResumeLayout(false);
            this.방4.PerformLayout();
            this.방3.ResumeLayout(false);
            this.방3.PerformLayout();
            this.방2.ResumeLayout(false);
            this.방2.PerformLayout();
            this.방1.ResumeLayout(false);
            this.방1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button SettingData;
        private System.Windows.Forms.Label seasonlb;
        private System.Windows.Forms.Label timelb;
        private System.Windows.Forms.Label seasondatalb;
        private System.Windows.Forms.Label timedatalb;
        private System.Windows.Forms.Button timestartbt;
        private System.Windows.Forms.Label rm1degree;
        private System.Windows.Forms.Label rm1finedust;
        private System.Windows.Forms.Label rm1fddata;
        private System.Windows.Forms.Label rm1dgdata;
        private System.Windows.Forms.Label rm4degree;
        private System.Windows.Forms.Label rm4finedust;
        private System.Windows.Forms.Label rm4fddata;
        private System.Windows.Forms.Label rm4dgdata;
        private System.Windows.Forms.Label rm3degree;
        private System.Windows.Forms.Label rm3finedust;
        private System.Windows.Forms.Label rm3fddata;
        private System.Windows.Forms.Label rm3dgdata;
        private System.Windows.Forms.Label rm2degree;
        private System.Windows.Forms.Label rm2finedust;
        private System.Windows.Forms.Label rm2dgdata;
        private System.Windows.Forms.Label rm2fddata;
        private System.Windows.Forms.Button 방2난방;
        private System.Windows.Forms.Button 방2전등;
        private System.Windows.Forms.Button 방2에어컨;
        private System.Windows.Forms.Button 방2공기청정기;
        private System.Windows.Forms.Timer time1second;
        private System.Windows.Forms.Button timeaccel;
        private System.Windows.Forms.Label templb;
        private System.Windows.Forms.Label tempdatalb;
    }
}

