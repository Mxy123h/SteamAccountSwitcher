using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SteamSwitchAccount
{
    class Class_utils
    {
        public static Boolean check_process()
        {
            Process[] app = Process.GetProcessesByName(@"Steam");
            if (app.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void killProcess()
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (p.ProcessName == @"Steam")
                {
                    p.Kill();
                }
            }
        }


        public static String read_Registry()
        {
            string strKeyName = string.Empty;
            string softPath = @"SOFTWARE\Valve\Steam\";
            RegistryKey regKey = Registry.CurrentUser;
            RegistryKey regSubKey = regKey.OpenSubKey(softPath, true);
            object objResult = regSubKey.GetValue(@"SteamPath");
            return objResult.ToString().Replace("/", "\\");
        }


    }
}
