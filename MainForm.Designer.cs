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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            resources.ApplyResources(this.groupBox_operation, "groupBox_operation");
            this.groupBox_operation.Name = "groupBox_operation";
            this.groupBox_operation.TabStop = false;
            // 
            // button_SelectSteamPath
            // 
            resources.ApplyResources(this.button_SelectSteamPath, "button_SelectSteamPath");
            this.button_SelectSteamPath.Name = "button_SelectSteamPath";
            this.button_SelectSteamPath.UseVisualStyleBackColor = true;
            this.button_SelectSteamPath.Click += new System.EventHandler(this.button_SelectSteamPath_Click);
            // 
            // textBox_SteamPath
            // 
            resources.ApplyResources(this.textBox_SteamPath, "textBox_SteamPath");
            this.textBox_SteamPath.Name = "textBox_SteamPath";
            this.textBox_SteamPath.ReadOnly = true;
            this.textBox_SteamPath.TextChanged += new System.EventHandler(this.textBox_SteamPath_TextChanged);
            // 
            // button_Chenge
            // 
            resources.ApplyResources(this.button_Chenge, "button_Chenge");
            this.button_Chenge.Name = "button_Chenge";
            this.button_Chenge.UseVisualStyleBackColor = true;
            this.button_Chenge.Click += new System.EventHandler(this.button_Chenge_Click);
            // 
            // comboBox_Account
            // 
            this.comboBox_Account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Account.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox_Account, "comboBox_Account");
            this.comboBox_Account.Name = "comboBox_Account";
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
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // button_copy2
            // 
            resources.ApplyResources(this.button_copy2, "button_copy2");
            this.button_copy2.Name = "button_copy2";
            this.button_copy2.UseVisualStyleBackColor = true;
            this.button_copy2.Click += new System.EventHandler(this.button_copy2_Click);
            // 
            // button_copy1
            // 
            resources.ApplyResources(this.button_copy1, "button_copy1");
            this.button_copy1.Name = "button_copy1";
            this.button_copy1.UseVisualStyleBackColor = true;
            this.button_copy1.Click += new System.EventHandler(this.button_copy1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox_PersonaName
            // 
            resources.ApplyResources(this.textBox_PersonaName, "textBox_PersonaName");
            this.textBox_PersonaName.Name = "textBox_PersonaName";
            // 
            // textBox_steamid64
            // 
            resources.ApplyResources(this.textBox_steamid64, "textBox_steamid64");
            this.textBox_steamid64.Name = "textBox_steamid64";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_operation);
            this.Name = "MainForm";
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

