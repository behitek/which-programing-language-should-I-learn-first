namespace Which_Programing_Should_I_Learn
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lbTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new DevComponents.DotNetBar.ButtonX();
            this.gpQuestion = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rd6 = new System.Windows.Forms.RadioButton();
            this.rd9 = new System.Windows.Forms.RadioButton();
            this.rd5 = new System.Windows.Forms.RadioButton();
            this.rd8 = new System.Windows.Forms.RadioButton();
            this.rd4 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd7 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.btnNext = new DevComponents.DotNetBar.ButtonX();
            this.btnBack = new DevComponents.DotNetBar.ButtonX();
            this.btnReset = new DevComponents.DotNetBar.ButtonX();
            this.lbQuestion = new DevComponents.DotNetBar.LabelX();
            this.gpQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(69, 132);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(610, 24);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "WHICH PROGRAMING LANGUAGE SHOULD I LEARN FIRST?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Copyright (c) 2017 - by Nguyễn Văn Hiếu(1481310027) - GVHD: TS. Nguyễn Thị Thanh " +
    "Tân";
            // 
            // btnStart
            // 
            this.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(306, 203);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 54);
            this.btnStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gpQuestion
            // 
            this.gpQuestion.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpQuestion.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpQuestion.Controls.Add(this.rd6);
            this.gpQuestion.Controls.Add(this.rd9);
            this.gpQuestion.Controls.Add(this.rd5);
            this.gpQuestion.Controls.Add(this.rd8);
            this.gpQuestion.Controls.Add(this.rd4);
            this.gpQuestion.Controls.Add(this.rd3);
            this.gpQuestion.Controls.Add(this.rd7);
            this.gpQuestion.Controls.Add(this.rd2);
            this.gpQuestion.Controls.Add(this.rd1);
            this.gpQuestion.Controls.Add(this.btnNext);
            this.gpQuestion.Controls.Add(this.btnBack);
            this.gpQuestion.Controls.Add(this.btnReset);
            this.gpQuestion.Controls.Add(this.lbQuestion);
            this.gpQuestion.Location = new System.Drawing.Point(12, 49);
            this.gpQuestion.Name = "gpQuestion";
            this.gpQuestion.Size = new System.Drawing.Size(711, 288);
            // 
            // 
            // 
            this.gpQuestion.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpQuestion.Style.BackColorGradientAngle = 90;
            this.gpQuestion.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpQuestion.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpQuestion.Style.BorderBottomWidth = 1;
            this.gpQuestion.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpQuestion.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpQuestion.Style.BorderLeftWidth = 1;
            this.gpQuestion.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpQuestion.Style.BorderRightWidth = 1;
            this.gpQuestion.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpQuestion.Style.BorderTopWidth = 1;
            this.gpQuestion.Style.CornerDiameter = 4;
            this.gpQuestion.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpQuestion.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpQuestion.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpQuestion.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpQuestion.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpQuestion.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpQuestion.TabIndex = 7;
            this.gpQuestion.Text = "Question";
            this.gpQuestion.Visible = false;
            // 
            // rd6
            // 
            this.rd6.AutoSize = true;
            this.rd6.BackColor = System.Drawing.Color.Transparent;
            this.rd6.Location = new System.Drawing.Point(291, 154);
            this.rd6.Name = "rd6";
            this.rd6.Size = new System.Drawing.Size(85, 17);
            this.rd6.TabIndex = 4;
            this.rd6.TabStop = true;
            this.rd6.Text = "radioButton3";
            this.rd6.UseVisualStyleBackColor = false;
            this.rd6.Visible = false;
            // 
            // rd9
            // 
            this.rd9.AutoSize = true;
            this.rd9.BackColor = System.Drawing.Color.Transparent;
            this.rd9.Location = new System.Drawing.Point(507, 154);
            this.rd9.Name = "rd9";
            this.rd9.Size = new System.Drawing.Size(85, 17);
            this.rd9.TabIndex = 4;
            this.rd9.TabStop = true;
            this.rd9.Text = "radioButton3";
            this.rd9.UseVisualStyleBackColor = false;
            this.rd9.Visible = false;
            // 
            // rd5
            // 
            this.rd5.AutoSize = true;
            this.rd5.BackColor = System.Drawing.Color.Transparent;
            this.rd5.Location = new System.Drawing.Point(291, 101);
            this.rd5.Name = "rd5";
            this.rd5.Size = new System.Drawing.Size(85, 17);
            this.rd5.TabIndex = 3;
            this.rd5.TabStop = true;
            this.rd5.Text = "radioButton2";
            this.rd5.UseVisualStyleBackColor = false;
            this.rd5.Visible = false;
            // 
            // rd8
            // 
            this.rd8.AutoSize = true;
            this.rd8.BackColor = System.Drawing.Color.Transparent;
            this.rd8.Location = new System.Drawing.Point(507, 101);
            this.rd8.Name = "rd8";
            this.rd8.Size = new System.Drawing.Size(85, 17);
            this.rd8.TabIndex = 3;
            this.rd8.TabStop = true;
            this.rd8.Text = "radioButton2";
            this.rd8.UseVisualStyleBackColor = false;
            this.rd8.Visible = false;
            // 
            // rd4
            // 
            this.rd4.AutoSize = true;
            this.rd4.BackColor = System.Drawing.Color.Transparent;
            this.rd4.Location = new System.Drawing.Point(291, 45);
            this.rd4.Name = "rd4";
            this.rd4.Size = new System.Drawing.Size(85, 17);
            this.rd4.TabIndex = 2;
            this.rd4.TabStop = true;
            this.rd4.Text = "radioButton1";
            this.rd4.UseVisualStyleBackColor = false;
            this.rd4.Visible = false;
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.BackColor = System.Drawing.Color.Transparent;
            this.rd3.Location = new System.Drawing.Point(91, 154);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(85, 17);
            this.rd3.TabIndex = 4;
            this.rd3.TabStop = true;
            this.rd3.Text = "radioButton3";
            this.rd3.UseVisualStyleBackColor = false;
            this.rd3.Visible = false;
            // 
            // rd7
            // 
            this.rd7.AutoSize = true;
            this.rd7.BackColor = System.Drawing.Color.Transparent;
            this.rd7.Location = new System.Drawing.Point(507, 45);
            this.rd7.Name = "rd7";
            this.rd7.Size = new System.Drawing.Size(85, 17);
            this.rd7.TabIndex = 2;
            this.rd7.TabStop = true;
            this.rd7.Text = "radioButton1";
            this.rd7.UseVisualStyleBackColor = false;
            this.rd7.Visible = false;
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.BackColor = System.Drawing.Color.Transparent;
            this.rd2.Location = new System.Drawing.Point(91, 101);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(85, 17);
            this.rd2.TabIndex = 3;
            this.rd2.TabStop = true;
            this.rd2.Text = "radioButton2";
            this.rd2.UseVisualStyleBackColor = false;
            this.rd2.Visible = false;
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.BackColor = System.Drawing.Color.Transparent;
            this.rd1.Location = new System.Drawing.Point(91, 45);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(85, 17);
            this.rd1.TabIndex = 2;
            this.rd1.TabStop = true;
            this.rd1.Text = "radioButton1";
            this.rd1.UseVisualStyleBackColor = false;
            this.rd1.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnNext.ImageTextSpacing = 5;
            this.btnNext.Location = new System.Drawing.Point(506, 210);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(82, 35);
            this.btnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "&Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageTextSpacing = 5;
            this.btnBack.Location = new System.Drawing.Point(317, 210);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 35);
            this.btnBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "&Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnReset.Location = new System.Drawing.Point(123, 210);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 35);
            this.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Restart";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbQuestion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbQuestion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestion.Location = new System.Drawing.Point(58, 13);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(371, 20);
            this.lbQuestion.TabIndex = 0;
            this.lbQuestion.Text = "Which programing language should i learn first?";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 387);
            this.Controls.Add(this.gpQuestion);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Name = "frmMain";
            this.Text = "Expert System Demo Application";
            this.gpQuestion.ResumeLayout(false);
            this.gpQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnStart;
        private DevComponents.DotNetBar.Controls.GroupPanel gpQuestion;
        private System.Windows.Forms.RadioButton rd6;
        private System.Windows.Forms.RadioButton rd9;
        private System.Windows.Forms.RadioButton rd5;
        private System.Windows.Forms.RadioButton rd8;
        private System.Windows.Forms.RadioButton rd4;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.RadioButton rd7;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd1;
        private DevComponents.DotNetBar.ButtonX btnNext;
        private DevComponents.DotNetBar.ButtonX btnBack;
        private DevComponents.DotNetBar.ButtonX btnReset;
        private DevComponents.DotNetBar.LabelX lbQuestion;
    }
}