using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VdfConverter;

namespace SteamSwitchAccount
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBox_SteamPath.Text = Class_utils.read_Registry();
        }

        private void button_Chenge_Click(object sender, EventArgs e)
        {
            String steam_user = comboBox_Account.SelectedItem.ToString();
            Console.WriteLine(comboBox_Account.SelectedItem.ToString());
            if (!steam_user.Equals("") && steam_user != null)
            {
                if (Class_utils.check_process())
                    Class_utils.killProcess();

                string strKeyName = string.Empty;
                string softPath = @"SOFTWARE\Valve\Steam\";
                RegistryKey regKey = Registry.CurrentUser;
                RegistryKey regSubKey = regKey.OpenSubKey(softPath, true);
                regSubKey.SetValue(@"AutoLoginUser", steam_user);
                Process app = Process.Start(textBox_SteamPath.Text + @"\steam.exe");
            }
            else
            {
                MessageBox.Show("Can't find steam account");
            }
        }


        List<String> steam_user_list = new List<String>();
        List<String> steamid64_user_list = new List<String>();
        List<String> PersonaName = new List<String>();
        String steam_user;

        public void flush_steam_user()
        {
            comboBox_Account.Items.Clear();
            textBox_steamid64.Text = "";
            if (steam_user_list.Count != 0)
            {
                for (int i = 0; i < steam_user_list.Count; i++)
                {
                    Console.WriteLine(steam_user_list[i]);
                    comboBox_Account.Items.Add(steam_user_list[i]);
                }
                textBox_steamid64.Text = steamid64_user_list[0];
                textBox_PersonaName.Text=PersonaName[0];
                comboBox_Account.SelectedIndex = 0;
            }
        }

        private void textBox_SteamPath_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(textBox_SteamPath.Text + @"\steam.exe"))
            {



                FileStream sharedConfig = File.OpenRead(textBox_SteamPath.Text + @"\config\loginusers.vdf");
                VdfDeserializer parser = new VdfDeserializer();
                dynamic result = parser.Deserialize(sharedConfig);
                var users = result.users as IDictionary<string, dynamic>;
                foreach (var user in users)
                {
                    steamid64_user_list.Add(user.Key);
                    var u = user.Value as IDictionary<string, dynamic>;
                    steam_user_list.Add(u["AccountName"]);
                    PersonaName.Add(u["PersonaName"]);
                }
                flush_steam_user();
            }
        }

        private void button_SelectSteamPath_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "Choice you Steam folder";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Console.WriteLine(dialog.SelectedPath);
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show("Steam folder Can't be null");
                    return;
                }
                else if (File.Exists(dialog.SelectedPath + @"\steam.exe"))
                {
                    textBox_SteamPath.Text = dialog.SelectedPath + @"\steam.exe";
                }
                else
                {
                    MessageBox.Show("Can't find steam.exe");
                    return;
                }

            }
        }

        private void comboBox_Account_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_steamid64.Text = steamid64_user_list[comboBox_Account.SelectedIndex];
            textBox_PersonaName.Text = PersonaName[comboBox_Account.SelectedIndex];
        }

        private void button_copy1_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox_steamid64.Text);
        }

        private void button_copy2_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox_PersonaName.Text);
        }

    }
}
