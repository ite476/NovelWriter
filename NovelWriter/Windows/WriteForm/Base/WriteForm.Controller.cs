using NovelWriter.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelWriter.Windows.WriteForm
{
    partial class WriteForm
    {
        private void WriteFile()
        {
            string[] stories = new string[]
            {
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                textBox4.Text
            };

            if (App.Instance.File.WriteJson(stories, NovelReciever))
            {
                MessageBox.Show("저장 성공");
            }
            else
            {
                MessageBox.Show("저장에 실패했습니다..");
            }
        }
    }
}
