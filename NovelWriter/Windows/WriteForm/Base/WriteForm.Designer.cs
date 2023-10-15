namespace NovelWriter.Windows.WriteForm
{
    partial class WriteForm
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            panel_Base = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel11 = new Panel();
            panel17 = new Panel();
            textBox4 = new TextBox();
            label_Count4 = new Label();
            panel12 = new Panel();
            label_Title4 = new Label();
            panel3 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel9 = new Panel();
            panel16 = new Panel();
            textBox3 = new TextBox();
            label_Count3 = new Label();
            panel10 = new Panel();
            label_Title3 = new Label();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel7 = new Panel();
            panel15 = new Panel();
            textBox2 = new TextBox();
            label_Count2 = new Label();
            panel8 = new Panel();
            label_Title2 = new Label();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel6 = new Panel();
            panel14 = new Panel();
            textBox1 = new TextBox();
            label_Count1 = new Label();
            panel5 = new Panel();
            label_Title1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button_Quit = new Button();
            button_SaveFile = new Button();
            panel_Base.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel11.SuspendLayout();
            panel17.SuspendLayout();
            panel12.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel9.SuspendLayout();
            panel16.SuspendLayout();
            panel10.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel7.SuspendLayout();
            panel15.SuspendLayout();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel6.SuspendLayout();
            panel14.SuspendLayout();
            panel5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Base
            // 
            panel_Base.AutoScroll = true;
            panel_Base.Controls.Add(tableLayoutPanel1);
            panel_Base.Controls.Add(flowLayoutPanel1);
            panel_Base.Dock = DockStyle.Fill;
            panel_Base.Location = new Point(0, 0);
            panel_Base.Name = "panel_Base";
            panel_Base.Size = new Size(1169, 492);
            panel_Base.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel4, 1, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1169, 453);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(587, 229);
            panel4.Name = "panel4";
            panel4.Size = new Size(579, 221);
            panel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(panel11, 0, 1);
            tableLayoutPanel5.Controls.Add(panel12, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 18.6885242F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 81.31148F));
            tableLayoutPanel5.Size = new Size(579, 221);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel17);
            panel11.Controls.Add(label_Count4);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(3, 44);
            panel11.Name = "panel11";
            panel11.Size = new Size(573, 174);
            panel11.TabIndex = 1;
            // 
            // panel17
            // 
            panel17.Controls.Add(textBox4);
            panel17.Dock = DockStyle.Fill;
            panel17.Location = new Point(0, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(573, 159);
            panel17.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Dock = DockStyle.Fill;
            textBox4.Location = new Point(0, 0);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ScrollBars = ScrollBars.Vertical;
            textBox4.Size = new Size(573, 159);
            textBox4.TabIndex = 2;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label_Count4
            // 
            label_Count4.BackColor = Color.Transparent;
            label_Count4.Dock = DockStyle.Bottom;
            label_Count4.Location = new Point(0, 159);
            label_Count4.Name = "label_Count4";
            label_Count4.Size = new Size(573, 15);
            label_Count4.TabIndex = 3;
            label_Count4.Text = "0/4000";
            label_Count4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel12
            // 
            panel12.Controls.Add(label_Title4);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(3, 3);
            panel12.Name = "panel12";
            panel12.Size = new Size(573, 35);
            panel12.TabIndex = 0;
            // 
            // label_Title4
            // 
            label_Title4.Dock = DockStyle.Fill;
            label_Title4.Location = new Point(0, 0);
            label_Title4.Name = "label_Title4";
            label_Title4.Size = new Size(573, 35);
            label_Title4.TabIndex = 0;
            label_Title4.Text = "label4";
            label_Title4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 229);
            panel3.Name = "panel3";
            panel3.Size = new Size(578, 221);
            panel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(panel9, 0, 1);
            tableLayoutPanel4.Controls.Add(panel10, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 18.6885242F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 81.31148F));
            tableLayoutPanel4.Size = new Size(578, 221);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel16);
            panel9.Controls.Add(label_Count3);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(3, 44);
            panel9.Name = "panel9";
            panel9.Size = new Size(572, 174);
            panel9.TabIndex = 1;
            // 
            // panel16
            // 
            panel16.Controls.Add(textBox3);
            panel16.Dock = DockStyle.Fill;
            panel16.Location = new Point(0, 0);
            panel16.Name = "panel16";
            panel16.Size = new Size(572, 159);
            panel16.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(0, 0);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Vertical;
            textBox3.Size = new Size(572, 159);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label_Count3
            // 
            label_Count3.BackColor = Color.Transparent;
            label_Count3.Dock = DockStyle.Bottom;
            label_Count3.Location = new Point(0, 159);
            label_Count3.Name = "label_Count3";
            label_Count3.Size = new Size(572, 15);
            label_Count3.TabIndex = 3;
            label_Count3.Text = "0/4000";
            label_Count3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel10
            // 
            panel10.Controls.Add(label_Title3);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(3, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(572, 35);
            panel10.TabIndex = 0;
            // 
            // label_Title3
            // 
            label_Title3.Dock = DockStyle.Fill;
            label_Title3.Location = new Point(0, 0);
            label_Title3.Name = "label_Title3";
            label_Title3.Size = new Size(572, 35);
            label_Title3.TabIndex = 0;
            label_Title3.Text = "label3";
            label_Title3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(587, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 220);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel7, 0, 1);
            tableLayoutPanel3.Controls.Add(panel8, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 18.6885242F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 81.31148F));
            tableLayoutPanel3.Size = new Size(579, 220);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel15);
            panel7.Controls.Add(label_Count2);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 44);
            panel7.Name = "panel7";
            panel7.Size = new Size(573, 173);
            panel7.TabIndex = 1;
            // 
            // panel15
            // 
            panel15.Controls.Add(textBox2);
            panel15.Dock = DockStyle.Fill;
            panel15.Location = new Point(0, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(573, 158);
            panel15.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(0, 0);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(573, 158);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label_Count2
            // 
            label_Count2.BackColor = Color.Transparent;
            label_Count2.Dock = DockStyle.Bottom;
            label_Count2.Location = new Point(0, 158);
            label_Count2.Name = "label_Count2";
            label_Count2.Size = new Size(573, 15);
            label_Count2.TabIndex = 3;
            label_Count2.Text = "0/4000";
            label_Count2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel8
            // 
            panel8.Controls.Add(label_Title2);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(573, 35);
            panel8.TabIndex = 0;
            // 
            // label_Title2
            // 
            label_Title2.Dock = DockStyle.Fill;
            label_Title2.Location = new Point(0, 0);
            label_Title2.Name = "label_Title2";
            label_Title2.Size = new Size(573, 35);
            label_Title2.TabIndex = 0;
            label_Title2.Text = "label2";
            label_Title2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 220);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel6, 0, 1);
            tableLayoutPanel2.Controls.Add(panel5, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 18.6885242F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 81.31148F));
            tableLayoutPanel2.Size = new Size(578, 220);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel14);
            panel6.Controls.Add(label_Count1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 44);
            panel6.Name = "panel6";
            panel6.Size = new Size(572, 173);
            panel6.TabIndex = 1;
            // 
            // panel14
            // 
            panel14.Controls.Add(textBox1);
            panel14.Dock = DockStyle.Fill;
            panel14.Location = new Point(0, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(572, 158);
            panel14.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(572, 158);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label_Count1
            // 
            label_Count1.BackColor = Color.Transparent;
            label_Count1.Dock = DockStyle.Bottom;
            label_Count1.FlatStyle = FlatStyle.Flat;
            label_Count1.Location = new Point(0, 158);
            label_Count1.Name = "label_Count1";
            label_Count1.Size = new Size(572, 15);
            label_Count1.TabIndex = 3;
            label_Count1.Text = "0/4000";
            label_Count1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            panel5.Controls.Add(label_Title1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(572, 35);
            panel5.TabIndex = 0;
            // 
            // label_Title1
            // 
            label_Title1.Dock = DockStyle.Fill;
            label_Title1.Location = new Point(0, 0);
            label_Title1.Name = "label_Title1";
            label_Title1.Size = new Size(572, 35);
            label_Title1.TabIndex = 0;
            label_Title1.Text = "label1";
            label_Title1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button_Quit);
            flowLayoutPanel1.Controls.Add(button_SaveFile);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 453);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1169, 39);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // button_Quit
            // 
            button_Quit.Location = new Point(1083, 3);
            button_Quit.Name = "button_Quit";
            button_Quit.RightToLeft = RightToLeft.Yes;
            button_Quit.Size = new Size(83, 33);
            button_Quit.TabIndex = 1;
            button_Quit.Text = "닫기(&Q)";
            button_Quit.UseVisualStyleBackColor = true;
            button_Quit.Click += button_Quit_Click;
            // 
            // button_SaveFile
            // 
            button_SaveFile.Location = new Point(994, 3);
            button_SaveFile.Name = "button_SaveFile";
            button_SaveFile.RightToLeft = RightToLeft.Yes;
            button_SaveFile.Size = new Size(83, 33);
            button_SaveFile.TabIndex = 0;
            button_SaveFile.Text = "저장(Ctrl+S)";
            button_SaveFile.UseVisualStyleBackColor = true;
            button_SaveFile.Click += button_SaveFile_Click;
            // 
            // WriteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 492);
            Controls.Add(panel_Base);
            KeyPreview = true;
            Name = "WriteForm";
            KeyDown += WriteForm_KeyDown;
            panel_Base.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel12.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel10.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel8.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel5.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Base;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button_Quit;
        private Button button_SaveFile;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel11;
        private Panel panel17;
        private TextBox textBox4;
        private Label label_Count4;
        private Panel panel12;
        private Label label_Title4;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel9;
        private Panel panel16;
        private TextBox textBox3;
        private Label label_Count3;
        private Panel panel10;
        private Label label_Title3;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel7;
        private Panel panel15;
        private TextBox textBox2;
        private Label label_Count2;
        private Panel panel8;
        private Label label_Title2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel6;
        private Panel panel14;
        private TextBox textBox1;
        private Label label_Count1;
        private Panel panel5;
        private Label label_Title1;
    }
}
