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
        public string GetPurpose{get;set;} = "\\bin\\App_global.asax.dll";
        public string GetOrigin { get;set;} = "\\versiondesc.txt";
        public string _PATH = new PathInfor()._PATH;
        public int times_init = 0;
        public Setting()
        {
            MaximizeBox = false;
            //MinimizeBox = false;
            InitializeComponent();
        }
        private void bt_return_Click(object sender, EventArgs e) => this.Hide();
        private void bt_Save_Click(object sender, EventArgs e)
        {
            StringBuilder reader = new StringBuilder();
            reader.Append(txt_folder.Text + "\n" + textArea_01.Text + "\n" + textArea_02.Text + "\n" );
            reader.Append(txt_area_1.Text + "\n" + txt_area_2.Text + "\n" );

            File.WriteAllText(_PATH, reader.ToString());
            MessageBox.Show("存檔成功", "✔訊息", MessageBoxButtons.OK);
            LogForm form = new LogForm();
            form.LogForm_Load(null, null);
            this.Hide();
        }


        private void Setting_Load(object sender, EventArgs e)
        {
            Form.CheckForIllegalCrossThreadCalls = false;
            textArea_01.Text = new PathInfor().Origin;
            textArea_02.Text = new PathInfor().Purpose;
            txt_folder.Text  = new PathInfor().Folder;
            txt_area_1.Text  = new PathInfor().Origin_Folder;
            txt_area_2.Text  = new PathInfor().Purpose_Folder;
        }

        private void bt_chosen_Click(object sender, EventArgs e)
        {

            LogApp.Expansion.FolderBrowserDialog dialog = new LogApp.Expansion.FolderBrowserDialog()
            {
                DirectoryPath = "c:\\"
            };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                this.Text = dialog.DirectoryPath;
            }
            //OpenFileDialog dialog = new OpenFileDialog()
            //{
            //    // 設定OpenFileDialog屬性
            //    Title = "選擇要開啟的文字檔案",
            //    Filter = "All Files (*.*)|*.*|Text Files (.txt)|*.txt",
            //    FilterIndex = 1,
            //    Multiselect = true
            //};
            //if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    textArea_01.Text = dialog.FileName;
            //}
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
                textArea_02.Text = dialog.FileName;
            }
        }

        private void bt_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_folder.Text = dialog.SelectedPath;
                textArea_01.Text = txt_folder.Text + GetOrigin;
                textArea_02.Text = txt_folder.Text + GetPurpose; 
            }
        }

        private void bt_asny_Click(object sender, EventArgs e)
        {
            if (Width < 816)
            {
                bt_asny.Text = "同步檔案<<";
                Size = new Size(816, 399);
            }
            else
            {
                bt_asny.Text = "同步檔案>>";
                Size = new Size(412, 399);
            }
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            PathInfor PathInfo = new PathInfor();
            string Purpose = txt_area_1.Text;
            string Orgin = txt_area_2.Text;
            if (Purpose=="" && Orgin ==""){
                MessageBox.Show("尚未填入相關路徑", "✔訊息", MessageBoxButtons.OK);
                return;
            }
            if(!Directory.Exists(Purpose)|| !Directory.Exists(Orgin)) {
                MessageBox.Show("路徑有誤或是不存在", "✔訊息", MessageBoxButtons.OK);
                return;
            }
            DialogResult result =  MessageBox.Show("此功能會將所有檔案覆蓋掉，確定是否要執行?", "✔訊息", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                timer1.Start();
                PathInfo.DirectoryFileCopy(Purpose , Orgin , true);
                MessageBox.Show("同步成功\n"+ "完成時間 :" + PathInfo.Run_Timer + "秒", "✔訊息", MessageBoxButtons.OK);
                timer1.Stop();
            }
        }

        private void bt_chosen_1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_area_1.Text = dialog.SelectedPath;
            }
        }

        private void bt_chosen_2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_area_2.Text = dialog.SelectedPath;
            }
        }

        private void bt_switch_Click(object sender, EventArgs e)
        {
            string temp = "";
            temp = txt_area_1.Text;
            txt_area_1.Text = txt_area_2.Text;
            txt_area_2.Text = temp;
        }
    }
}
