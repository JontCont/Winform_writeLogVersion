using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogApp;

namespace LogApp
{
    public partial class Setting : Form
    {
        public string _PATH = new PathInfor()._PATH;
        public Setting()=> InitializeComponent();
        private void bt_return_Click(object sender, EventArgs e)=> this.Hide();
        private void bt_Save_Click(object sender, EventArgs e)
        {
            File.WriteAllText(_PATH, textArea_01.Text + "\n" + textArea_02.Text);
            MessageBox.Show("存檔成功", "✔訊息", MessageBoxButtons.OK);
            LogForm form = new LogForm();
            form.LogForm_Load(null,null);
            this.Hide();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
                textArea_01.Text = new PathInfor().Purpose;
                textArea_02.Text = new PathInfor().origin;
        }

        private void bt_chosen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                // 設定OpenFileDialog屬性
                Title = "選擇要開啟的文字檔案",
                Filter = "All Files (*.*)|*.*|Text Files (.txt)|*.txt",
                FilterIndex = 1,
                Multiselect = true
            };
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textArea_01.Text= dialog.FileName;
            }
        }

        private void bt_chosen_02_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                // 設定OpenFileDialog屬性
                Title = "選擇要開啟的文字檔案",
                Filter = "All Files (*.*)|*.*|Text Files (.txt)|*.txt",
                FilterIndex = 1,
                Multiselect = true
            };
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textArea_02.Text= dialog.FileName;
            }
        }
    }
}
