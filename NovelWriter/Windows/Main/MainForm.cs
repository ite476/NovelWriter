using NovelWriter.Module;
using NovelWriter.Windows.WriteForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovelWriter.Windows.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Nexon_Click(object sender, EventArgs e)
        {
            this.ShowModalless<Nexon>();
        }

        private void button_Quit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("종료하시겠습니까?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button_NexonGames_Click(object sender, EventArgs e)
        {
            this.ShowModalless<NexonGames>();
        }

        private void button_OpenFolder_Click(object sender, EventArgs e)
        {
            var dataPopup = new DataForm(App.Instance.File.SaveFolder);
            dataPopup.ShowDialog(this);
        }

        private void button_HRD_Click(object sender, EventArgs e)
        {
            this.ShowModalless<HRD>();
        }
    }



}
