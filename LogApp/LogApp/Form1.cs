using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogApp
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
            LoadForm();
        }
        public void LoadForm()
        {
            version_new.Text = new PathInfor().Get_Version("New");
            version_now.Text = new PathInfor().Get_Version("Now");
        }

        public void LogForm_Load(object sender, EventArgs e)
        {
            Form.CheckForIllegalCrossThreadCalls = false;
            timer1.Start();
            this.Width = 556;//910
        }

        private void bt_Setting_Click(object sender, EventArgs e)
        {
            while (this.Width < 910)
            {
                this.Width += 4;
            }
        }
        private void bt_return_Click(object sender, EventArgs e)
        {
            while (this.Width > 556)
            {
                this.Width -= 2;
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (GridArea.Rows.Count <= 0 || GridArea.Rows[0].Cells[1].Value == null) { MessageBox.Show("尚未輸入資料", "提示視窗", MessageBoxButtons.OK); return; }
            if (GridArea.Rows.Count > 0)
            {
                //取得來源路徑
                string path = new PathInfor().Origin;
                if (!File.Exists(path)) File.WriteAllText(path, "");
                //取得目前檔案內容
                StringBuilder strData = new StringBuilder("").Append(File.ReadAllText(path));
                //宣告要設定得資料
                StringBuilder strDefault = new StringBuilder("");
                strDefault.Append(version_new.Text + "\n\n" + Get_ColumsStr());
                strDefault.Append("----------------------------------------------------------------------------\n");
                foreach (DataGridViewRow dr in GridArea.Rows)
                {
                    string Check = dr.Cells[0].Value != null && (bool)dr.Cells[0].Value == true ? "OK" : "";
                    string strFormat = string.Format("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}"
                        , Check, dr.Cells[1].Value, dr.Cells[2].Value, dr.Cells[3].Value, dr.Cells[4].Value);
                    strDefault.Append(strFormat + "\n");
                }
                strDefault.Append("----------------------------------------------------------------------------\n\n\n");
                if (MessageBox.Show("是否確定存檔", "訊息", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        timer1.Stop();
                        File.WriteAllText(path, strDefault.ToString() + strData.ToString());
                        MessageBox.Show("存檔成功", "訊息", MessageBoxButtons.OK);
                        GridArea.Rows.Clear();
                        timer1.Start();
                    }
                    catch (Exception ex) { throw ex; }

                }
            }
        }

        private void GridArea_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (GridArea.Rows[e.RowIndex].Cells[1].Value != null)
            {
                GridArea.Rows[e.RowIndex].Cells[2].Value = e.RowIndex + 1;
            }
        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            if (File.Exists(new PathInfor().Origin))
            {
                System.Diagnostics.Process.Start(new PathInfor().Origin);
            }
            else
            {
                MessageBox.Show("無此檔案", "訊息", MessageBoxButtons.OK);
            }
        }
        private void bt_exit_Click(object sender, EventArgs e) => Application.Exit();

        private string Get_ColumsStr()
        {
            string str = "";
            foreach (DataGridViewColumn dr in GridArea.Columns)
            {

                str += string.Format("{0,-15}", dr.HeaderText);
            }
            return str + "\n";
        }

        private void bt_rush_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bt_rush_Click(sender, e);
        }

        private void btn_edit_save_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)GridArea.Rows[0].Clone();
            var User = cbb_edit_name.SelectedItem ?? "";
            var Type = cbb_edit_type.SelectedItem ?? "";
            row.Cells[0].Value = User.ToString();
            row.Cells[1].Value = Type.ToString();
            row.Cells[2].Value = GridArea.Rows.Count;
            row.Cells[3].Value = txt_desc.Text;
            GridArea.Rows.Add(row);
        }


        private void GridArea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = GridArea.Rows[index];
            cbb_edit_name.Text = row.Cells[0].Value.ToString();
            cbb_edit_type.Text = row.Cells[1].Value.ToString();
            txt_edit_item.Text = row.Cells[2].Value.ToString();
            txt_desc.Text = row.Cells[3].Value.ToString();
        }

        private void txt_desc_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                btn_edit_save_Click(null,null);
            }
        }

        private void txt_folder_Click(object sender, EventArgs e)
        {
            LogApp.Expansion.FolderBrowserDialog dialog = new LogApp.Expansion.FolderBrowserDialog()
            {
                DirectoryPath = "c:\\"
            };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                txt_folder.Text = dialog.DirectoryPath;
            }
        }

        private void bt_folder_Click(object sender, EventArgs e)
        {
            LogApp.Expansion.FolderBrowserDialog dialog = new LogApp.Expansion.FolderBrowserDialog()
            {
                DirectoryPath = "c:\\"
            };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                txt_folder.Text = dialog.DirectoryPath;
            }
        }
    }
}
