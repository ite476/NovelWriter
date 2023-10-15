namespace NovelWriter.Windows.Main
{
    partial class MainForm
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
            pageSetupDialog1 = new PageSetupDialog();
            panel_Base = new Panel();
            panel_MenuButtons = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            button_Neople = new Button();
            panel2 = new Panel();
            button_NexonGames = new Button();
            panel1 = new Panel();
            button_Nexon = new Button();
            panel_Controls = new Panel();
            button_OpenFolder = new Button();
            button_Quit = new Button();
            button_HRD = new Button();
            panel_Base.SuspendLayout();
            panel_MenuButtons.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel_Controls.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Base
            // 
            panel_Base.Controls.Add(panel_MenuButtons);
            panel_Base.Controls.Add(panel_Controls);
            panel_Base.Dock = DockStyle.Fill;
            panel_Base.Location = new Point(0, 0);
            panel_Base.Name = "panel_Base";
            panel_Base.Size = new Size(800, 390);
            panel_Base.TabIndex = 0;
            // 
            // panel_MenuButtons
            // 
            panel_MenuButtons.Controls.Add(tableLayoutPanel1);
            panel_MenuButtons.Dock = DockStyle.Fill;
            panel_MenuButtons.Location = new Point(0, 0);
            panel_MenuButtons.Name = "panel_MenuButtons";
            panel_MenuButtons.Size = new Size(800, 354);
            panel_MenuButtons.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 354);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(button_Neople);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(535, 3);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 17, 20, 17);
            panel3.Size = new Size(262, 348);
            panel3.TabIndex = 2;
            // 
            // button_Neople
            // 
            button_Neople.Dock = DockStyle.Fill;
            button_Neople.Location = new Point(20, 17);
            button_Neople.Name = "button_Neople";
            button_Neople.Size = new Size(222, 314);
            button_Neople.TabIndex = 2;
            button_Neople.Text = "Neople(&E)";
            button_Neople.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(button_NexonGames);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(269, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 17, 20, 17);
            panel2.Size = new Size(260, 348);
            panel2.TabIndex = 1;
            // 
            // button_NexonGames
            // 
            button_NexonGames.Dock = DockStyle.Fill;
            button_NexonGames.Location = new Point(20, 17);
            button_NexonGames.Name = "button_NexonGames";
            button_NexonGames.Size = new Size(220, 314);
            button_NexonGames.TabIndex = 1;
            button_NexonGames.Text = "NexonGames(&G)";
            button_NexonGames.UseVisualStyleBackColor = true;
            button_NexonGames.Click += button_NexonGames_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Nexon);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 17, 20, 17);
            panel1.Size = new Size(260, 348);
            panel1.TabIndex = 0;
            // 
            // button_Nexon
            // 
            button_Nexon.Dock = DockStyle.Fill;
            button_Nexon.Location = new Point(20, 17);
            button_Nexon.Name = "button_Nexon";
            button_Nexon.Size = new Size(220, 314);
            button_Nexon.TabIndex = 0;
            button_Nexon.Text = "Nexon(&N)";
            button_Nexon.UseVisualStyleBackColor = true;
            button_Nexon.Click += button_Nexon_Click;
            // 
            // panel_Controls
            // 
            panel_Controls.Controls.Add(button_HRD);
            panel_Controls.Controls.Add(button_OpenFolder);
            panel_Controls.Controls.Add(button_Quit);
            panel_Controls.Dock = DockStyle.Bottom;
            panel_Controls.Location = new Point(0, 354);
            panel_Controls.Name = "panel_Controls";
            panel_Controls.Size = new Size(800, 36);
            panel_Controls.TabIndex = 0;
            // 
            // button_OpenFolder
            // 
            button_OpenFolder.Location = new Point(560, 6);
            button_OpenFolder.Name = "button_OpenFolder";
            button_OpenFolder.Size = new Size(111, 23);
            button_OpenFolder.TabIndex = 1;
            button_OpenFolder.Text = "폴더 열기(&O)";
            button_OpenFolder.UseVisualStyleBackColor = true;
            button_OpenFolder.Click += button_OpenFolder_Click;
            // 
            // button_Quit
            // 
            button_Quit.Location = new Point(677, 6);
            button_Quit.Name = "button_Quit";
            button_Quit.Size = new Size(111, 23);
            button_Quit.TabIndex = 0;
            button_Quit.Text = "종료(&Q)";
            button_Quit.UseVisualStyleBackColor = true;
            button_Quit.Click += button_Quit_Click;
            // 
            // button_HRD
            // 
            button_HRD.Location = new Point(3, 6);
            button_HRD.Name = "button_HRD";
            button_HRD.Size = new Size(111, 23);
            button_HRD.TabIndex = 3;
            button_HRD.Text = "HRD(&H)";
            button_HRD.UseVisualStyleBackColor = true;
            button_HRD.Click += button_HRD_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 390);
            Controls.Add(panel_Base);
            Font = new Font("메이플스토리", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            KeyPreview = true;
            Name = "MainForm";
            Text = "MainForm";
            panel_Base.ResumeLayout(false);
            panel_MenuButtons.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel_Controls.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PageSetupDialog pageSetupDialog1;
        private Panel panel_Base;
        private Panel panel_MenuButtons;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Button button_Neople;
        private Panel panel2;
        private Button button_NexonGames;
        private Panel panel1;
        private Button button_Nexon;
        private Panel panel_Controls;
        private Button button_Quit;
        private Button button_OpenFolder;
        private Button button_HRD;
    }
}