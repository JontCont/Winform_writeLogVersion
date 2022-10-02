
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
            this.lbl_version_new = new System.Windows.Forms.Label();
            this.version_new = new System.Windows.Forms.TextBox();
            this.bt_open = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_rush = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GridArea = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textArea_02 = new System.Windows.Forms.TextBox();
            this.bt_chosen_01 = new System.Windows.Forms.Button();
            this.bt_chosen_02 = new System.Windows.Forms.Button();
            this.lblText02 = new System.Windows.Forms.Label();
            this.textArea_01 = new System.Windows.Forms.TextBox();
            this.lblText01 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bt_folder = new System.Windows.Forms.Button();
            this.txt_folder = new System.Windows.Forms.TextBox();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.bt_return = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridArea)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(209, 484);
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
            this.bt_Setting.Location = new System.Drawing.Point(426, 21);
            this.bt_Setting.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Setting.Name = "bt_Setting";
            this.bt_Setting.Size = new System.Drawing.Size(90, 38);
            this.bt_Setting.TabIndex = 2;
            this.bt_Setting.Text = "設定";
            this.bt_Setting.UseVisualStyleBackColor = true;
            this.bt_Setting.Click += new System.EventHandler(this.bt_Setting_Click);
            // 
            // version_now
            // 
            this.version_now.Enabled = false;
            this.version_now.Location = new System.Drawing.Point(88, 26);
            this.version_now.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.version_now.Name = "version_now";
            this.version_now.Size = new System.Drawing.Size(286, 25);
            this.version_now.TabIndex = 4;
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(13, 29);
            this.lbl_version.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(60, 17);
            this.lbl_version.TabIndex = 5;
            this.lbl_version.Text = "目前版本";
            // 
            // lbl_version_new
            // 
            this.lbl_version_new.AutoSize = true;
            this.lbl_version_new.Location = new System.Drawing.Point(13, 57);
            this.lbl_version_new.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_version_new.Name = "lbl_version_new";
            this.lbl_version_new.Size = new System.Drawing.Size(60, 17);
            this.lbl_version_new.TabIndex = 8;
            this.lbl_version_new.Text = "最新版本";
            // 
            // version_new
            // 
            this.version_new.Enabled = false;
            this.version_new.Location = new System.Drawing.Point(88, 57);
            this.version_new.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.version_new.Name = "version_new";
            this.version_new.Size = new System.Drawing.Size(286, 25);
            this.version_new.TabIndex = 7;
            // 
            // bt_open
            // 
            this.bt_open.Location = new System.Drawing.Point(66, 484);
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
            this.bt_exit.Location = new System.Drawing.Point(348, 484);
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
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.bt_open);
            this.panel2.Controls.Add(this.bt_rush);
            this.panel2.Controls.Add(this.bt_exit);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.bt_save);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.bt_Setting);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 600);
            this.panel2.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(516, 146);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "內容設定";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(294, 34);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(205, 94);
            this.textBox4.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 25);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(88, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 25);
            this.textBox3.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(88, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 25);
            this.textBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "內容";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "項目";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "修改類別";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "修改人員";
            // 
            // bt_rush
            // 
            this.bt_rush.Location = new System.Drawing.Point(426, 73);
            this.bt_rush.Margin = new System.Windows.Forms.Padding(4);
            this.bt_rush.Name = "bt_rush";
            this.bt_rush.Size = new System.Drawing.Size(90, 38);
            this.bt_rush.TabIndex = 10;
            this.bt_rush.Text = "刷新";
            this.bt_rush.UseVisualStyleBackColor = true;
            this.bt_rush.Click += new System.EventHandler(this.bt_rush_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.version_now);
            this.groupBox2.Controls.Add(this.version_new);
            this.groupBox2.Controls.Add(this.lbl_version);
            this.groupBox2.Controls.Add(this.lbl_version_new);
            this.groupBox2.Location = new System.Drawing.Point(14, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "版本";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridArea);
            this.groupBox1.Location = new System.Drawing.Point(14, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 185);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "記錄內容";
            // 
            // GridArea
            // 
            this.GridArea.AllowUserToOrderColumns = true;
            this.GridArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Type,
            this.Item,
            this.Desc});
            this.GridArea.Location = new System.Drawing.Point(14, 24);
            this.GridArea.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GridArea.Name = "GridArea";
            this.GridArea.RowHeadersWidth = 51;
            this.GridArea.RowTemplate.Height = 24;
            this.GridArea.Size = new System.Drawing.Size(483, 139);
            this.GridArea.TabIndex = 9;
            this.GridArea.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GridArea_RowPostPaint);
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Edit Name";
            this.UserName.Items.AddRange(new object[] {
            "cont",
            "iospoplp",
            "jenny040yang",
            "Nick84111",
            "huang40001854",
            "GaoShengYuan",
            "QuiffCloud2",
            "唐銘",
            "admin",
            "other"});
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
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textArea_02);
            this.groupBox4.Controls.Add(this.bt_chosen_01);
            this.groupBox4.Controls.Add(this.bt_chosen_02);
            this.groupBox4.Controls.Add(this.lblText02);
            this.groupBox4.Controls.Add(this.textArea_01);
            this.groupBox4.Controls.Add(this.lblText01);
            this.groupBox4.Location = new System.Drawing.Point(556, 179);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 185);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "自訂路徑(非必填)";
            // 
            // textArea_02
            // 
            this.textArea_02.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textArea_02.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textArea_02.Location = new System.Drawing.Point(18, 129);
            this.textArea_02.Margin = new System.Windows.Forms.Padding(5);
            this.textArea_02.Name = "textArea_02";
            this.textArea_02.Size = new System.Drawing.Size(185, 29);
            this.textArea_02.TabIndex = 5;
            // 
            // bt_chosen_01
            // 
            this.bt_chosen_01.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_chosen_01.Location = new System.Drawing.Point(226, 59);
            this.bt_chosen_01.Name = "bt_chosen_01";
            this.bt_chosen_01.Size = new System.Drawing.Size(72, 36);
            this.bt_chosen_01.TabIndex = 4;
            this.bt_chosen_01.Text = "選擇檔案";
            this.bt_chosen_01.UseVisualStyleBackColor = true;
            // 
            // bt_chosen_02
            // 
            this.bt_chosen_02.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_chosen_02.Location = new System.Drawing.Point(226, 124);
            this.bt_chosen_02.Name = "bt_chosen_02";
            this.bt_chosen_02.Size = new System.Drawing.Size(72, 38);
            this.bt_chosen_02.TabIndex = 6;
            this.bt_chosen_02.Text = "選擇檔案";
            this.bt_chosen_02.UseVisualStyleBackColor = true;
            // 
            // lblText02
            // 
            this.lblText02.AutoSize = true;
            this.lblText02.Location = new System.Drawing.Point(4, 101);
            this.lblText02.Name = "lblText02";
            this.lblText02.Size = new System.Drawing.Size(73, 17);
            this.lblText02.TabIndex = 8;
            this.lblText02.Text = "記錄檔路徑";
            // 
            // textArea_01
            // 
            this.textArea_01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textArea_01.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textArea_01.Location = new System.Drawing.Point(18, 63);
            this.textArea_01.Margin = new System.Windows.Forms.Padding(5);
            this.textArea_01.Name = "textArea_01";
            this.textArea_01.Size = new System.Drawing.Size(185, 29);
            this.textArea_01.TabIndex = 0;
            // 
            // lblText01
            // 
            this.lblText01.AutoSize = true;
            this.lblText01.Location = new System.Drawing.Point(6, 32);
            this.lblText01.Name = "lblText01";
            this.lblText01.Size = new System.Drawing.Size(86, 17);
            this.lblText01.TabIndex = 7;
            this.lblText01.Text = "最新檔案路徑";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bt_folder);
            this.groupBox5.Controls.Add(this.txt_folder);
            this.groupBox5.Controls.Add(this.lbl_desc);
            this.groupBox5.Location = new System.Drawing.Point(556, 69);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(310, 95);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "設定檔";
            // 
            // bt_folder
            // 
            this.bt_folder.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_folder.Location = new System.Drawing.Point(226, 47);
            this.bt_folder.Name = "bt_folder";
            this.bt_folder.Size = new System.Drawing.Size(72, 36);
            this.bt_folder.TabIndex = 11;
            this.bt_folder.Text = "選擇檔案";
            this.bt_folder.UseVisualStyleBackColor = true;
            // 
            // txt_folder
            // 
            this.txt_folder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_folder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_folder.Location = new System.Drawing.Point(21, 50);
            this.txt_folder.Margin = new System.Windows.Forms.Padding(5);
            this.txt_folder.Name = "txt_folder";
            this.txt_folder.Size = new System.Drawing.Size(182, 29);
            this.txt_folder.TabIndex = 10;
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Location = new System.Drawing.Point(14, 25);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(73, 17);
            this.lbl_desc.TabIndex = 9;
            this.lbl_desc.Text = "專案資料夾";
            // 
            // bt_return
            // 
            this.bt_return.Location = new System.Drawing.Point(558, 20);
            this.bt_return.Name = "bt_return";
            this.bt_return.Size = new System.Drawing.Size(90, 38);
            this.bt_return.TabIndex = 13;
            this.bt_return.Text = "返回";
            this.bt_return.UseVisualStyleBackColor = true;
            this.bt_return.Click += new System.EventHandler(this.bt_return_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.button1.Location = new System.Drawing.Point(777, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "存檔";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 527);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.bt_return);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG 工具";
            this.Load += new System.EventHandler(this.LogForm_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridArea)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_Setting;
        private System.Windows.Forms.TextBox version_now;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label lbl_version_new;
        private System.Windows.Forms.TextBox version_new;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.DataGridView GridArea;
        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.Button bt_rush;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewComboBoxColumn UserName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textArea_02;
        private System.Windows.Forms.Button bt_chosen_01;
        private System.Windows.Forms.Button bt_chosen_02;
        private System.Windows.Forms.Label lblText02;
        private System.Windows.Forms.TextBox textArea_01;
        private System.Windows.Forms.Label lblText01;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button bt_folder;
        private System.Windows.Forms.TextBox txt_folder;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Button bt_return;
        private System.Windows.Forms.Button button1;
    }
}

