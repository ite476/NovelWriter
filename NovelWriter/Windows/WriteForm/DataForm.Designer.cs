namespace NovelWriter.Windows.WriteForm
{
    partial class DataForm
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
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button_Close = new Button();
            button_Save = new Button();
            button_Find = new Button();
            panel2 = new Panel();
            textBox_Data = new TextBox();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 421);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 29);
            panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button_Close);
            flowLayoutPanel1.Controls.Add(button_Save);
            flowLayoutPanel1.Controls.Add(button_Find);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 29);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button_Close
            // 
            button_Close.Location = new Point(722, 3);
            button_Close.Name = "button_Close";
            button_Close.Size = new Size(75, 23);
            button_Close.TabIndex = 0;
            button_Close.Text = "닫기(&Q)";
            button_Close.UseVisualStyleBackColor = true;
            button_Close.Click += button_Close_Click;
            // 
            // button_Save
            // 
            button_Save.Location = new Point(617, 3);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(99, 23);
            button_Save.TabIndex = 2;
            button_Save.Text = "저장(Ctrl + S)";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            // 
            // button_Find
            // 
            button_Find.Location = new Point(524, 3);
            button_Find.Name = "button_Find";
            button_Find.Size = new Size(87, 23);
            button_Find.TabIndex = 1;
            button_Find.Text = "폴더 찾기(&F)";
            button_Find.UseVisualStyleBackColor = true;
            button_Find.Click += button_Find_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox_Data);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 421);
            panel2.TabIndex = 2;
            // 
            // textBox_Data
            // 
            textBox_Data.Dock = DockStyle.Fill;
            textBox_Data.Location = new Point(0, 0);
            textBox_Data.Multiline = true;
            textBox_Data.Name = "textBox_Data";
            textBox_Data.ReadOnly = true;
            textBox_Data.Size = new Size(800, 421);
            textBox_Data.TabIndex = 0;
            // 
            // DataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "DataForm";
            Text = "DataForm";
            KeyDown += DataForm_KeyDown;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button_Close;
        private Panel panel2;
        private TextBox textBox_Data;
        private Button button_Save;
        private Button button_Find;
    }
}