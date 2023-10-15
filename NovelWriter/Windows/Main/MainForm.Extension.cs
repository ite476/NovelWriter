using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelWriter.Windows.Main
{
    public static class MainFormExtension
    {
        public static DialogResult ShowModal<T>(this MainForm parentForm) where T : Form, new()
        {
            T form = new T();
            return form.ShowDialog(parentForm);
        }

        public static void ShowModalless<T>(this MainForm parentForm) where T : Form, new()
        {
            T form = new T();
            form.Show(parentForm);
        }
    }
}
