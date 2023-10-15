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
    public partial class DataForm : Form
    {
        public DataForm(string Info)
        {
            InitializeComponent();
            textBox_Data.Text = Info;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button_Find_Click(object sender, EventArgs e)
        {
            string folderDirectory = ShowFolderBrowserDialog();
            if (folderDirectory != string.Empty)
            {
                textBox_Data.Text = folderDirectory;
            }
        }

        private string ShowFolderBrowserDialog()
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // 다이얼로그의 제목 설정
                folderBrowserDialog.Description = "폴더 선택";
                // 초기 디렉토리 설정 (선택적)
                folderBrowserDialog.SelectedPath = @"C:\";

                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    return folderBrowserDialog.SelectedPath;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveData();
            MessageBox.Show("저장 완료");
        }

        private void SaveData() => App.Instance.Settings.ChangeDirectory(textBox_Data.Text);

        private void DataForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveData();
                e.Handled = true;
                MessageBox.Show("저장 완료");
            }
        }
    }
}
