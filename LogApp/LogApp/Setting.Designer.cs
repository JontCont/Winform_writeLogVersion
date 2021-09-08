
namespace LogApp
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.textArea_01 = new System.Windows.Forms.TextBox();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_return = new System.Windows.Forms.Button();
            this.bt_chosen_01 = new System.Windows.Forms.Button();
            this.bt_chosen_02 = new System.Windows.Forms.Button();
            this.textArea_02 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblText02 = new System.Windows.Forms.Label();
            this.lblText01 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textArea_01
            // 
            this.textArea_01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textArea_01.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textArea_01.Location = new System.Drawing.Point(14, 58);
            this.textArea_01.Margin = new System.Windows.Forms.Padding(5);
            this.textArea_01.Name = "textArea_01";
            this.textArea_01.Size = new System.Drawing.Size(251, 29);
            this.textArea_01.TabIndex = 0;
            // 
            // bt_Save
            // 
            this.bt_Save.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.bt_Save.Location = new System.Drawing.Point(96, 194);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(84, 30);
            this.bt_Save.TabIndex = 2;
            this.bt_Save.Text = "存檔";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_return
            // 
            this.bt_return.Location = new System.Drawing.Point(207, 194);
            this.bt_return.Name = "bt_return";
            this.bt_return.Size = new System.Drawing.Size(84, 30);
            this.bt_return.TabIndex = 3;
            this.bt_return.Text = "返回";
            this.bt_return.UseVisualStyleBackColor = true;
            this.bt_return.Click += new System.EventHandler(this.bt_return_Click);
            // 
            // bt_chosen_01
            // 
            this.bt_chosen_01.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_chosen_01.Location = new System.Drawing.Point(287, 54);
            this.bt_chosen_01.Name = "bt_chosen_01";
            this.bt_chosen_01.Size = new System.Drawing.Size(72, 36);
            this.bt_chosen_01.TabIndex = 4;
            this.bt_chosen_01.Text = "選擇檔案";
            this.bt_chosen_01.UseVisualStyleBackColor = true;
            this.bt_chosen_01.Click += new System.EventHandler(this.bt_chosen_Click);
            // 
            // bt_chosen_02
            // 
            this.bt_chosen_02.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_chosen_02.Location = new System.Drawing.Point(287, 119);
            this.bt_chosen_02.Name = "bt_chosen_02";
            this.bt_chosen_02.Size = new System.Drawing.Size(72, 38);
            this.bt_chosen_02.TabIndex = 6;
            this.bt_chosen_02.Text = "選擇檔案";
            this.bt_chosen_02.UseVisualStyleBackColor = true;
            this.bt_chosen_02.Click += new System.EventHandler(this.bt_chosen_02_Click);
            // 
            // textArea_02
            // 
            this.textArea_02.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textArea_02.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textArea_02.Location = new System.Drawing.Point(14, 124);
            this.textArea_02.Margin = new System.Windows.Forms.Padding(5);
            this.textArea_02.Name = "textArea_02";
            this.textArea_02.Size = new System.Drawing.Size(251, 29);
            this.textArea_02.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblText02);
            this.groupBox1.Controls.Add(this.lblText01);
            this.groupBox1.Controls.Add(this.textArea_01);
            this.groupBox1.Controls.Add(this.bt_chosen_02);
            this.groupBox1.Controls.Add(this.bt_chosen_01);
            this.groupBox1.Controls.Add(this.textArea_02);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 170);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "設定檔";
            // 
            // lblText02
            // 
            this.lblText02.AutoSize = true;
            this.lblText02.Location = new System.Drawing.Point(10, 99);
            this.lblText02.Name = "lblText02";
            this.lblText02.Size = new System.Drawing.Size(89, 20);
            this.lblText02.TabIndex = 8;
            this.lblText02.Text = "記錄檔路徑";
            // 
            // lblText01
            // 
            this.lblText01.AutoSize = true;
            this.lblText01.Location = new System.Drawing.Point(10, 31);
            this.lblText01.Name = "lblText01";
            this.lblText01.Size = new System.Drawing.Size(105, 20);
            this.lblText01.TabIndex = 7;
            this.lblText01.Text = "最新檔案路徑";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(400, 236);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_return);
            this.Controls.Add(this.bt_Save);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "設定";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textArea_01;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button bt_return;
        private System.Windows.Forms.Button bt_chosen_01;
        private System.Windows.Forms.Button bt_chosen_02;
        private System.Windows.Forms.TextBox textArea_02;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblText02;
        private System.Windows.Forms.Label lblText01;
    }
}