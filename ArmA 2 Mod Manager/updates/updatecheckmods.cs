using System;
//using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Security.Cryptography;

namespace ArmA_2_Mod_Manager
{
    public partial class Form1 : Form
    {
        bool downloading;
        int downloaded = 0;
        int dot = 0;
        int todownload = 0;

        protected string md5(string path)
        {
            if (!File.Exists(path))
                return "dupa :)";
            FileStream fs = new FileStream(path, FileMode.Open);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(fs);
            fs.Close();
            string checksum = BitConverter.ToString(retVal);
            return checksum;
        }

        private void checkBiKey(string webpath, string modname)
        {
            int modarray = 0;

            if (modname == "dayzinfo")
                modarray = 0;
            if (modname == "dayz")
                modarray = 1;

            string[] pbos = new string[pboFiles[modarray].Length];

            for (int x = 0; x < pboFiles[modarray].Length; x++)
                pbos[x] = pboFiles[modarray][x];

            string[] update = new string[pbos.Length];

            int pbosX = 0;
            bool updatefound = false;

            if (!Directory.Exists(txtPath.Text + "\\@" + modname + "\\Addons\\"))
                Directory.CreateDirectory(txtPath.Text + "\\@" + modname + "\\Addons\\");
            if (!Directory.Exists(txtPath.Text + "\\Keys"))
                Directory.CreateDirectory(txtPath.Text + "\\Keys");

            do
            {
                string path = txtPath.Text + "\\@" + modname + "\\Addons\\" + pbos[pbosX] + "." + modname + ".bisign";
                WebClient wc = new WebClient();
                try
                {
                    wc.DownloadFile(webpath + pbos[pbosX] + "." + modname + ".bisign", "tmp");
                    if (md5("tmp") != md5(path))
                    {
                        updatefound = true;
                        update[pbosX] = pbos[pbosX];
                        todownload++;
                    }//dupa
                    //else bangla :)
                }
                catch
                {
                    //MessageBox.Show(ex.Message, "Komunikat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                pbosX++;
            }
            while (pbosX != pbos.Length);

            todownload *= 2;

            // Sprawdz folder Keys
            WebClient wc2 = new WebClient();
            bool bikey = false;
            wc2.DownloadFile(webpath + "Keys//" + modname + ".bikey", "tmp");
            if (md5("tmp") != md5(txtPath.Text + "\\Keys\\" + modname + ".bikey"))
            {
                bikey = true;
                todownload++;
            }

            progressBar1.Maximum = todownload;
            label1.Text = "Pobrano: 0 z: " + todownload.ToString() + ".";


            File.Delete("tmp");
            if (updatefound || bikey)
            {
                DialogResult result = MessageBox.Show("Znaleziono aktualizację dla moda: " + modname + ".\nPobrać teraz? \nDotyczy tylko graczy www.dayzinfo.pl", "Komunikat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (updatefound)
                    {
                        updateDayzInfo(update, webpath, modname);
                        downloading = true;
                    }
                    if (bikey)
                    {
                        string path = txtPath.Text;
                        wc2.DownloadFile(webpath + "Keys//" + modname + ".bikey", path + "\\Keys\\" + modname + ".bikey");
                        downloaded++;
                    }
                }
            }
        }

        private void downloadFile(string pbo, string webpath, string path)
        {
            try
            {
                WebClient wc = new WebClient();
                string url = webpath;
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
                wc.DownloadFileAsync(new Uri(url), path, pbo);
            }
            catch
            {
                MessageBox.Show("Błąd przy pobieraniu: \n" + pbo, "Komunikat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateDayzInfo(string[] pbos, string web, string modname)
        {
            downloaded = 0;
            pbStart.Visible = false;
            progressBar1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;

            for (int x = 0; x < pbos.Length; x++)
            {
                if (pbos[x] == null)
                    continue;
                string path = txtPath.Text + "\\@" + modname + "\\Addons\\" + pbos[x];
                string webpath = web + pbos[x];
                downloadFile(pbos[x], webpath, path);
            }

            for (int x = 0; x < pbos.Length; x++)
            {
                if (pbos[x] == null)
                    continue;
                string path = txtPath.Text + "\\@" + modname + "\\Addons\\" + pbos[x] + "." + modname + ".bisign";
                string webpath = web + pbos[x] + "." + modname + ".bisign";
                downloadFile(pbos[x], webpath, path);
            }
        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            if (dot > 400)
            {
                label2.Text = "Pobieram";
                dot = 0;
            }
            else if (dot%10 == 0)
            {
                dot++;
                label2.Text += ".";
            }
            else
                dot++;
        }

        void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            downloaded++;
            label1.Text = "Pobrano: " + downloaded.ToString() + " z: " + todownload.ToString() + ".";
            progressBar1.Value = downloaded;
            if (downloaded == todownload)
            {
                pbStart.Visible = true;
                progressBar1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                //this.Text = version + " beta version!";
                downloading = false;
                downloaded = 0;
                dot = 0;
                todownload = 0;
                MessageBox.Show("Mod jest aktualny!");
            }
        }
    }
}