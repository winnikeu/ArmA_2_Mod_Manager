using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using Microsoft.Win32;

namespace ArmA_2_Mod_Manager
{
    public partial class Form1 : Form
    {
        public string[][] pboFiles = new string[2][];

        private void SHUTDOWN()
        {
            var kill = Process.GetCurrentProcess();
            kill.Kill();
        }

        private void checkHTTP()
        {
            WebRequest webr = WebRequest.Create(CONFIGURATION);
            HttpWebResponse httpw = (HttpWebResponse)webr.GetResponse();
            Stream st = httpw.GetResponseStream();
            StreamReader sr = new StreamReader(st);

            string webversion = sr.ReadLine();
            string news = sr.ReadLine();
            string webprogram = sr.ReadLine();
            string webbannername = sr.ReadLine();
            string webbanner = sr.ReadLine();
            string[] temp;

            temp = sr.ReadLine().Split('%');
            dayzinfourl = temp[0];
            pboFiles[0] = new string[temp.Length];
            for (int x = 1; x < temp.Length; x++)
                pboFiles[0][x - 1] = temp[x];

            temp = sr.ReadLine().Split('%');
            dayzurl = temp[0];
            pboFiles[1] = new string[temp.Length];
            for (int x = 1; x < temp.Length; x++)
                pboFiles[1][x-1] = temp[x];

            httpw.Close();
            st.Close();
            sr.Close();

            if (webversion != version)
            {
                lblUpdate.Text = "Nie aktualny!";
                downloadProgram(webprogram, webversion, news);
            }
            else
            {
                lblUpdate.Text = "Aktualny!";
            }
        }

        private void createBat()
        {
            if (File.Exists("update.bat"))
                File.Delete("update.bat");
            StreamWriter file = new StreamWriter("update.bat");
            file.WriteLine("@echo on");
            file.WriteLine("timeout 1");
            file.WriteLine("del " + Process.GetCurrentProcess().ProcessName + ".exe");
            file.WriteLine("rename new.exe ArmA2ModManager.exe");
            file.WriteLine("start ArmA2ModManager.exe");
            file.WriteLine("del update.bat");
            file.Close();
        }

        private void downloadProgram(string url, string newversion, string news)
        {
            DialogResult result = MessageBox.Show("Nowa wersja dostępna! " + newversion + " \nChcesz pobrać? (zalecane)\n" + news, "Komunikat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;

            WebClient webc2 = new WebClient();
            try
            {
                webc2.DownloadFile(url, "new.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            createBat();

            Process bat = new Process();
            bat.StartInfo.FileName = "update.bat";
            bat.Start();
            SHUTDOWN();
        }

        private void findPath()
        {
            if (txtPath.Text != "")
                return;
            DialogResult result = MessageBox.Show("Pusta ścieżka! \nUżyć auto-wykrywania?", "Komunikat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;

            RegistryKey registry = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Bohemia Interactive Studio\\ArmA 2 OA");
            if (registry == null)
                registry = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Bohemia Interactive Studio\\ArmA 2 OA");
            try
            {
                txtPath.Text = registry.GetValue("MAIN").ToString();
            }
            catch
            {
                MessageBox.Show("Nie byłem w stanie wykryć ścieżki! \nDodaj ją ręcznie w Ustawieniach.", "Komunikat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                registry.Close();
            }
        }
    }
}