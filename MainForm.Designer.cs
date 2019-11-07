namespace SteamSwitchAccount
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_operation = new System.Windows.Forms.GroupBox();
            this.button_SelectSteamPath = new System.Windows.Forms.Button();
            this.textBox_SteamPath = new System.Windows.Forms.TextBox();
            this.button_Chenge = new System.Windows.Forms.Button();
            this.comboBox_Account = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_copy2 = new System.Windows.Forms.Button();
            this.button_copy1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_PersonaName = new System.Windows.Forms.TextBox();
            this.textBox_steamid64 = new System.Windows.Forms.TextBox();
            this.groupBox_operation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_operation
            // 
            this.groupBox_operation.Controls.Add(this.button_SelectSteamPath);
            this.groupBox_operation.Controls.Add(this.textBox_SteamPath);
            this.groupBox_operation.Controls.Add(this.button_Chenge);
            this.groupBox_operation.Controls.Add(this.comboBox_Account);
            this.groupBox_operation.Location = new System.Drawing.Point(12, 8);
            this.groupBox_operation.Name = "groupBox_operation";
            this.groupBox_operation.Size = new System.Drawing.Size(457, 84);
            this.groupBox_operation.TabIndex = 17;
            this.groupBox_operation.TabStop = false;
            this.groupBox_operation.Text = "Operation";
            // 
            // button_SelectSteamPath
            // 
            this.button_SelectSteamPath.Location = new System.Drawing.Point(349, 19);
            this.button_SelectSteamPath.Name = "button_SelectSteamPath";
            this.button_SelectSteamPath.Size = new System.Drawing.Size(95, 23);
            this.button_SelectSteamPath.TabIndex = 15;
            this.button_SelectSteamPath.Text = "FindSteamPath";
            this.button_SelectSteamPath.UseVisualStyleBackColor = true;
            this.button_SelectSteamPath.Click += new System.EventHandler(this.button_SelectSteamPath_Click);
            // 
            // textBox_SteamPath
            // 
            this.textBox_SteamPath.Location = new System.Drawing.Point(6, 19);
            this.textBox_SteamPath.Name = "textBox_SteamPath";
            this.textBox_SteamPath.ReadOnly = true;
            this.textBox_SteamPath.Size = new System.Drawing.Size(337, 21);
            this.textBox_SteamPath.TabIndex = 14;
            this.textBox_SteamPath.TextChanged += new System.EventHandler(this.textBox_SteamPath_TextChanged);
            // 
            // button_Chenge
            // 
            this.button_Chenge.Location = new System.Drawing.Point(349, 46);
            this.button_Chenge.Name = "button_Chenge";
            this.button_Chenge.Size = new System.Drawing.Size(95, 23);
            this.button_Chenge.TabIndex = 13;
            this.button_Chenge.Text = "ChengeAccount";
            this.button_Chenge.UseVisualStyleBackColor = true;
            this.button_Chenge.Click += new System.EventHandler(this.button_Chenge_Click);
            // 
            // comboBox_Account
            // 
            this.comboBox_Account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Account.FormattingEnabled = true;
            this.comboBox_Account.Location = new System.Drawing.Point(6, 46);
            this.comboBox_Account.Name = "comboBox_Account";
            this.comboBox_Account.Size = new System.Drawing.Size(337, 20);
            this.comboBox_Account.TabIndex = 12;
            this.comboBox_Account.SelectedIndexChanged += new System.EventHandler(this.comboBox_Account_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_copy2);
            this.groupBox2.Controls.Add(this.button_copy1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_PersonaName);
            this.groupBox2.Controls.Add(this.textBox_steamid64);
            this.groupBox2.Location = new System.Drawing.Point(13, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 77);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AccountInfo";
            // 
            // button_copy2
            // 
            this.button_copy2.Location = new System.Drawing.Point(348, 45);
            this.button_copy2.Name = "button_copy2";
            this.button_copy2.Size = new System.Drawing.Size(95, 23);
            this.button_copy2.TabIndex = 22;
            this.button_copy2.Text = "Copy";
            this.button_copy2.UseVisualStyleBackColor = true;
            this.button_copy2.Click += new System.EventHandler(this.button_copy2_Click);
            // 
            // button_copy1
            // 
            this.button_copy1.Location = new System.Drawing.Point(348, 20);
            this.button_copy1.Name = "button_copy1";
            this.button_copy1.Size = new System.Drawing.Size(95, 23);
            this.button_copy1.TabIndex = 21;
            this.button_copy1.Text = "Copy";
            this.button_copy1.UseVisualStyleBackColor = true;
            this.button_copy1.Click += new System.EventHandler(this.button_copy1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "Id64:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "PersonaName:";
            // 
            // textBox_PersonaName
            // 
            this.textBox_PersonaName.Location = new System.Drawing.Point(86, 45);
            this.textBox_PersonaName.Name = "textBox_PersonaName";
            this.textBox_PersonaName.Size = new System.Drawing.Size(256, 21);
            this.textBox_PersonaName.TabIndex = 18;
            // 
            // textBox_steamid64
            // 
            this.textBox_steamid64.Location = new System.Drawing.Point(86, 20);
            this.textBox_steamid64.Name = "textBox_steamid64";
            this.textBox_steamid64.Size = new System.Drawing.Size(256, 21);
            this.textBox_steamid64.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 191);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_operation);
            this.Name = "MainForm";
            this.Text = "SteamSwitchAccount      By:BANALALA";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox_operation.ResumeLayout(false);
            this.groupBox_operation.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_operation;
        private System.Windows.Forms.Button button_SelectSteamPath;
        private System.Windows.Forms.TextBox textBox_SteamPath;
        private System.Windows.Forms.Button button_Chenge;
        private System.Windows.Forms.ComboBox comboBox_Account;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_PersonaName;
        private System.Windows.Forms.TextBox textBox_steamid64;
        private System.Windows.Forms.Button button_copy2;
        private System.Windows.Forms.Button button_copy1;
    }
}

