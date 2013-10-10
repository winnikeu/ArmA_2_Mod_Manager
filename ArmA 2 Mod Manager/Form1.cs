using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ArmA_2_Mod_Manager
{
    public partial class Form1 : Form
    {
                                        //----------------------//
                                        //                      //
                                        //                      //
                                        //   USTAWIENIA RELEASE //
                                        //                      //
                                        //                      //
                                        //----------------------//

        int modsCount = 0;
        const string CONFIGURATION = "http://winnik.eu/programs/arma2modmanager/settings.txt";
        const string version = "0.8.1";
        const string bannername = "";
        string dayzinfourl;
        string dayzurl;
        
        public Form1()
        {
            this.Text = version + " Arma 2 Mod Manager";

            InitializeComponent();

            threadIp.RunWorkerAsync();
            readCfgSettings();
            findPath();
            readCfgMods();
            readMods(txtPath.Text);

            loadImage();
            lblUpdate.Text = "Sprawdzanie aktualizacji!";
            this.Show();
            checkHTTP();
        }

        public static bool Contains(string source, string toCheck, StringComparison comp)
        {
            return source.IndexOf(toCheck, comp) >= 0;
        }

        private void loadImage()
        {
            pbStart.Image = Properties.Resources.logo;
            pbSettings.Image = Properties.Resources.logo;
        }

        private void readMods(string path)
        {
            if (path == "")
            {
                MessageBox.Show("Pusta ścieżka!", "Komunikat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Directory.Exists(path))
            {
                MessageBox.Show("Nie ma takiej ścieżki!", "Komunikat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lbMods.Items.Clear();
            var folders = Directory.GetDirectories(path, "@*", SearchOption.TopDirectoryOnly).Select(Path.GetFileName);
            foreach (var folder in folders)
            {
                lbMods.Items.Add(folder);
            }
        }

        private void reloadMods()
        {
            //listBox2.Items.Clear();
            lvConfigurations.Items.Clear();
            readCfgMods();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Podaj nazwę konfiguracji!", "Komunikat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            writeCfgMods();
            reloadMods();
            clearTabMods();
            lbMods.SelectedIndex = -1;
        }

        private void clearTabMods()
        {
            txtName.Text = "";
            txtParam.Text = "";
            txtAdditional.Text = "";
            chbWindowed.Checked = false;
        }

        private void gameProcess(string param)
        {
            if (txtPath.Text == "")
            {
                MessageBox.Show("Brak ściezki do gry!", "Komunikat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!File.Exists(txtPath.Text + "\\ArmA2OA.exe"))
            {
                MessageBox.Show("Błędna ścieżka do gry!", "Komunikat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Process game = new Process();
            game.StartInfo.Arguments = "";

            if (chbNoSplash.Checked)
                game.StartInfo.Arguments += "-noSplash ";
            if (chbWorldEmpty.Checked)
                game.StartInfo.Arguments += "-world=empty ";
            if (chbSkipIntro.Checked)
                game.StartInfo.Arguments += "-skipIntro ";
            if (chbCpuCount.Checked)
                game.StartInfo.Arguments += "-cpuCount=" + cbCpuCount.Text + " ";
            if (chbMaxMem.Checked)
                game.StartInfo.Arguments += "-maxMem=" + cbMaxMem.Text + " ";
            if (chbMaxVRAM.Checked)
                game.StartInfo.Arguments += "-maxVRAM=" + cbMaxVRAM.Text + " ";
            if (chbExThreads.Checked)
                game.StartInfo.Arguments += "-exThreads=" + cbExThreads.Text + " ";
            if (chbWinXp.Checked)
                game.StartInfo.Arguments += "-winxp ";

            if (chbBetaPatch.Checked || lvConfigurations.SelectedItems[0].Index == 0 || lvConfigurations.SelectedItems[0].Index == 1)
            {
                //if (!File.Exists(textBox1.Text + "\\ArmA2OABETA.exe"))
                try
                {
                    if (File.Exists(txtPath.Text + "\\Arma2OABETA.exe"))
                        File.Delete(txtPath.Text + "\\Arma2OABETA.exe");
                }
                catch
                {
                    MessageBox.Show("Nie można uruchomić! Albo gra jest uruchomiona, albo nie posiadasz praw do otwarcia pliku!", "Komunikat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!File.Exists(txtPath.Text + "\\Expansion\\beta\\Arma2OA.exe"))
                {
                    MessageBox.Show("Nie posiadasz beta patcha! \nPobierz z: http://www.arma2.com/beta-patch.php", "Komunikat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                File.Copy(txtPath.Text + "\\Expansion\\beta\\Arma2OA.exe", txtPath.Text + "\\Arma2OABETA.exe");

                game.StartInfo.FileName = txtPath.Text + "\\ArmA2OABETA.exe";
                game.StartInfo.Arguments += "-beta=Expansion\\beta;Expansion\\beta\\Expansion " + param;
            }
            else
            {
                game.StartInfo.FileName = txtPath.Text + "\\ArmA2OA.exe";
                game.StartInfo.Arguments += param;
            }

            try
            {
                game.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Komunikat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateListBox()
        {
            txtParam.Text = "-mod=";
            var items = lbMods.SelectedItems;
            foreach (var item in items)
            {
                txtParam.Text += item.ToString();
                txtParam.Text += ";";
            }
        }

        private void runMod()
        {
            /*if (listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Nie wybrałeś opcji!", "Komunikat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
            }*/

            if (lvConfigurations.SelectedItems.Count < 1)
            {
                MessageBox.Show("Nie wybrałeś opcji/konfiguracji!", "Komunikat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Mods mods = (Mods)listBox2.SelectedItem;
            Mods mods = new Mods();
            mods = (Mods)lvConfigurations.SelectedItems[0].Tag;
            if (downloading)
            {
                MessageBox.Show("Pobieranie w toku!", "Komunikat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            /*else if (Contains(mods.param, "dayzinfo", StringComparison.OrdinalIgnoreCase))
            {
                checkBiKey(dayzinfourl, "dayzinfo");
                if (downloading)
                    return;
            }
            else if (Contains(mods.param, "dayz", StringComparison.OrdinalIgnoreCase))
            {
                checkBiKey(dayzurl, "dayz");
                if (downloading)
                    return;
            }*/
            gameProcess(mods.param);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            runMod();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            deleteCfgMods();
            reloadMods();
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno usunąć?", "Komunikat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            readMods(txtPath.Text);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            readMods(txtPath.Text);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtPath.Text = folderBrowserDialog1.SelectedPath;
            readMods(txtPath.Text);
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            updateListBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbMods.SelectedItems.Clear();
            txtParam.Text = "";
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
                return;
            if (txtName.Text != "" || txtParam.Text != "" || txtAdditional.Text != "")
            {
                DialogResult result = MessageBox.Show("Pozostawiono, niezachowane zmiany, porzucić?", "Komunikat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    clearTabMods();
                    return;
                }
                tabControl1.SelectTab(1);
            }
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            writeCfgSettings();
            readMods(txtPath.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (downloading)
            {
                DialogResult result = MessageBox.Show("Pobieranie w toku! Na pewno przerwać?", "Komunikat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    e.Cancel = true;
            }
            writeCfgSettings();
        }

        private void chbCpuCount_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCpuCount.Checked)
                cbCpuCount.Enabled = true;
            else
                cbCpuCount.Enabled = false;
        }

        private void cbCpuCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbExThreads_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void chbMaxMem_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMaxMem.Checked)
                cbMaxMem.Enabled = true;
            else
                cbMaxMem.Enabled = false;
        }

        private void chbMaxVRAM_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMaxVRAM.Checked)
                cbMaxVRAM.Enabled = true;
            else
                cbMaxVRAM.Enabled = false;
        }

        private void chbExThreads_CheckedChanged(object sender, EventArgs e)
        {
            if (chbExThreads.Checked)
                cbExThreads.Enabled = true;
            else
                cbExThreads.Enabled = false;
        }

        private void lvConfigurations_DoubleClick(object sender, EventArgs e)
        {
            runMod();
        }

        private void chbServer_CheckedChanged(object sender, EventArgs e)
        {
            if (chbServer.Checked)
                txtServer.Enabled = true;
            else
                txtServer.Enabled = false;
        }

        private void chbPort_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPort.Checked)
                txtPort.Enabled = true;
            else
                txtPort.Enabled = false;
        }

        private void threadIp_DoWork(object sender, DoWorkEventArgs e)
        {
            sendIp();
        }

    }
    public class Mods
    {
        public int index;
        public string name;
        public string mods;
        public string additional;
        public string param;
        public string x;
        public string y;

        public override string ToString()
        {
            return name + ": " + param;
        }
    }
}