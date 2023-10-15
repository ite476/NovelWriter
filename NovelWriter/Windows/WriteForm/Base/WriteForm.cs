using NovelWriter.Module.Extensions;
using NovelWriter.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovelWriter.Windows.WriteForm
{
    public partial class WriteForm : Form
    {
        protected string NovelReciever { get; set; } = string.Empty;
        protected bool IsInitialized { get { return NovelReciever != string.Empty; } }

        public WriteForm()
        {
            InitializeComponent();
        }

        public void InitializeEditor(string targetName, (int, string)[] titlesAndLimits)
        {
            NovelReciever = targetName;

            textBox1.SetTags_Init((label_Count1, GetLengthLimit(0), label_Title1, GetTitle(0)));//.TextChange_Dynamic();
            textBox2.SetTags_Init((label_Count2, GetLengthLimit(1), label_Title2, GetTitle(1)));//.TextChange_Dynamic();
            textBox3.SetTags_Init((label_Count3, GetLengthLimit(2), label_Title3, GetTitle(2)));//.TextChange_Dynamic();
            textBox4.SetTags_Init((label_Count4, GetLengthLimit(3), label_Title4, GetTitle(3)));//.TextChange_Dynamic();

            string[]? madeStories = App.Instance.File.ReadFile<string[]>(NovelReciever);
            if (madeStories != null)
            {
                textBox1.Text = madeStories[0];
                textBox2.Text = madeStories[1];
                textBox3.Text = madeStories[2];
                textBox4.Text = madeStories[3];
            }

            int GetLengthLimit(int index) => titlesAndLimits[index].Item1;
            string GetTitle(int index) => titlesAndLimits[index].Item2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).TextChange_Dynamic();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).TextChange_Dynamic();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).TextChange_Dynamic();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).TextChange_Dynamic();
        }

        private void button_SaveFile_Click(object sender, EventArgs e)
        {
            WriteFile();
        }

        private void button_Quit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void WriteForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                WriteFile();
            }
        }
    }
}
