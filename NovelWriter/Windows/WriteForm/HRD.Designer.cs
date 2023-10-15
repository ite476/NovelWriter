namespace NovelWriter.Windows.WriteForm
{
    partial class HRD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_Base = new Panel();
            panel13 = new Panel();
            vScrollBar1 = new VScrollBar();
            button_Quit = new Button();
            button_SaveFile = new Button();
            panel_Base.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Base
            // 
            panel_Base.AutoScroll = true;
            panel_Base.Controls.Add(panel13);
            panel_Base.Controls.Add(vScrollBar1);
            panel_Base.Dock = DockStyle.Fill;
            panel_Base.Location = new Point(0, 0);
            panel_Base.Name = "panel_Base";
            panel_Base.Size = new Size(1169, 492);
            panel_Base.TabIndex = 0;
            // 
            // panel13
            // 
            panel13.Dock = DockStyle.Bottom;
            panel13.Location = new Point(0, 459);
            panel13.Name = "panel13";
            panel13.Size = new Size(1152, 33);
            panel13.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Location = new Point(1152, 0);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 492);
            vScrollBar1.TabIndex = 0;
            // 
            // button_Quit
            // 
            button_Quit.Location = new Point(1054, 6);
            button_Quit.Name = "button_Quit";
            button_Quit.RightToLeft = RightToLeft.Yes;
            button_Quit.Size = new Size(83, 20);
            button_Quit.TabIndex = 1;
            button_Quit.Text = "닫기(&Q)";
            button_Quit.UseVisualStyleBackColor = true;
            // 
            // button_SaveFile
            // 
            button_SaveFile.Location = new Point(965, 6);
            button_SaveFile.Name = "button_SaveFile";
            button_SaveFile.RightToLeft = RightToLeft.Yes;
            button_SaveFile.Size = new Size(83, 20);
            button_SaveFile.TabIndex = 0;
            button_SaveFile.Text = "저장(Ctrl+S)";
            button_SaveFile.UseVisualStyleBackColor = true;
            // 
            // HRD
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1169, 492);
            Font = new Font("메이플스토리", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "HRD";
            Text = "Form1";
            panel_Base.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Base;
        private VScrollBar vScrollBar1;
        private Panel panel13;
        private Button button_SaveFile;
        private Button button_Quit;
    }
}