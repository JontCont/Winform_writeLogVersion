
namespace LogApp
{
    partial class LogForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_Setting = new System.Windows.Forms.Button();
            this.version_now = new System.Windows.Forms.TextBox();
            this.lbl_version = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_version_new = new System.Windows.Forms.Label();
            this.version_new = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_open = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_rush = new System.Windows.Forms.Button();
            this.GridArea = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mES_CloudDataSet = new LogApp.MES_CloudDataSet();
            this.bDP080000BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDP08_0000TableAdapter = new LogApp.MES_CloudDataSetTableAdapters.BDP08_0000TableAdapter();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mES_CloudDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDP080000BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(180, 7);
            this.bt_save.Margin = new System.Windows.Forms.Padding(4);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(131, 33);
            this.bt_save.TabIndex = 0;
            this.bt_save.Text = "存檔";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_Setting
            // 
            this.bt_Setting.Location = new System.Drawing.Point(372, 9);
            this.bt_Setting.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Setting.Name = "bt_Setting";
            this.bt_Setting.Size = new System.Drawing.Size(104, 29);
            this.bt_Setting.TabIndex = 2;
            this.bt_Setting.Text = "設定";
            this.bt_Setting.UseVisualStyleBackColor = true;
            this.bt_Setting.Click += new System.EventHandler(this.bt_Setting_Click);
            // 
            // version_now
            // 
            this.version_now.Enabled = false;
            this.version_now.Location = new System.Drawing.Point(14, 29);
            this.version_now.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.version_now.Name = "version_now";
            this.version_now.Size = new System.Drawing.Size(152, 25);
            this.version_now.TabIndex = 4;
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(11, 9);
            this.lbl_version.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(60, 17);
            this.lbl_version.TabIndex = 5;
            this.lbl_version.Text = "目前版本";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "文字內容";
            // 
            // lbl_version_new
            // 
            this.lbl_version_new.AutoSize = true;
            this.lbl_version_new.Location = new System.Drawing.Point(179, 9);
            this.lbl_version_new.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_version_new.Name = "lbl_version_new";
            this.lbl_version_new.Size = new System.Drawing.Size(60, 17);
            this.lbl_version_new.TabIndex = 8;
            this.lbl_version_new.Text = "最新版本";
            // 
            // version_new
            // 
            this.version_new.Enabled = false;
            this.version_new.Location = new System.Drawing.Point(179, 31);
            this.version_new.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.version_new.Name = "version_new";
            this.version_new.Size = new System.Drawing.Size(169, 25);
            this.version_new.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.bt_open);
            this.panel1.Controls.Add(this.bt_exit);
            this.panel1.Controls.Add(this.bt_save);
            this.panel1.Location = new System.Drawing.Point(0, 252);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 48);
            this.panel1.TabIndex = 10;
            // 
            // bt_open
            // 
            this.bt_open.Location = new System.Drawing.Point(37, 7);
            this.bt_open.Margin = new System.Windows.Forms.Padding(4);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(131, 33);
            this.bt_open.TabIndex = 11;
            this.bt_open.Text = "打開記錄檔";
            this.bt_open.UseVisualStyleBackColor = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(319, 7);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(4);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(131, 33);
            this.bt_exit.TabIndex = 10;
            this.bt_exit.Text = "離開";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.bt_rush);
            this.panel2.Controls.Add(this.GridArea);
            this.panel2.Controls.Add(this.version_now);
            this.panel2.Controls.Add(this.bt_Setting);
            this.panel2.Controls.Add(this.lbl_version_new);
            this.panel2.Controls.Add(this.lbl_version);
            this.panel2.Controls.Add(this.version_new);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 252);
            this.panel2.TabIndex = 11;
            // 
            // bt_rush
            // 
            this.bt_rush.Location = new System.Drawing.Point(373, 44);
            this.bt_rush.Margin = new System.Windows.Forms.Padding(4);
            this.bt_rush.Name = "bt_rush";
            this.bt_rush.Size = new System.Drawing.Size(104, 29);
            this.bt_rush.TabIndex = 10;
            this.bt_rush.Text = "刷新";
            this.bt_rush.UseVisualStyleBackColor = true;
            this.bt_rush.Click += new System.EventHandler(this.bt_rush_Click);
            // 
            // GridArea
            // 
            this.GridArea.AllowUserToOrderColumns = true;
            this.GridArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.UserName,
            this.Type,
            this.Item,
            this.Desc});
            this.GridArea.Location = new System.Drawing.Point(11, 80);
            this.GridArea.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GridArea.Name = "GridArea";
            this.GridArea.RowHeadersWidth = 51;
            this.GridArea.RowTemplate.Height = 24;
            this.GridArea.Size = new System.Drawing.Size(466, 166);
            this.GridArea.TabIndex = 9;
            this.GridArea.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GridArea_RowPostPaint);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mES_CloudDataSet
            // 
            this.mES_CloudDataSet.DataSetName = "MES_CloudDataSet";
            this.mES_CloudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDP080000BindingSource
            // 
            this.bDP080000BindingSource.DataMember = "BDP08_0000";
            this.bDP080000BindingSource.DataSource = this.mES_CloudDataSet;
            // 
            // bDP08_0000TableAdapter
            // 
            this.bDP08_0000TableAdapter.ClearBeforeFill = true;
            // 
            // Check
            // 
            this.Check.HeaderText = "Check";
            this.Check.MinimumWidth = 6;
            this.Check.Name = "Check";
            this.Check.Width = 50;
            // 
            // UserName
            // 
            this.UserName.DataSource = this.bDP080000BindingSource;
            this.UserName.DisplayMember = "usr_name";
            this.UserName.HeaderText = "Edit Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UserName.Width = 110;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Items.AddRange(new object[] {
            "修改",
            "更新",
            "新增",
            "刪除"});
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Type.Width = 70;
            // 
            // Item
            // 
            this.Item.HeaderText = "item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 50;
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Desc Content";
            this.Desc.MinimumWidth = 6;
            this.Desc.Name = "Desc";
            this.Desc.Width = 200;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 300);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG 工具";
            this.Load += new System.EventHandler(this.LogForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mES_CloudDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDP080000BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_Setting;
        private System.Windows.Forms.TextBox version_now;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_version_new;
        private System.Windows.Forms.TextBox version_new;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.DataGridView GridArea;
        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.Button bt_rush;
        private System.Windows.Forms.Timer timer1;
        private MES_CloudDataSet mES_CloudDataSet;
        private System.Windows.Forms.BindingSource bDP080000BindingSource;
        private MES_CloudDataSetTableAdapters.BDP08_0000TableAdapter bDP08_0000TableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewComboBoxColumn UserName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
    }
}

