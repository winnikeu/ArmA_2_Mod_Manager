using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
//using Ini;
using System.Xml;

namespace ArmA_2_Mod_Manager
{
    public partial class Form1 : Form
    {
        int modsCount = 0;

        public Form1()
        {
            InitializeComponent();
            //if (File.Exists("mods.cfg"))
                readCfgMods();
            //if (File.Exists("settings.cfg"))
                //readIni();
            readMods(textBox1.Text);
        }

        private void readMods(string path)
        {
            var folders = Directory.GetDirectories(path, "@*", SearchOption.TopDirectoryOnly).Select(Path.GetFileName);
            foreach (var folder in folders)
            {
                checkedListBox1.Items.Add(folder);
            }
        }

        /*public void readIni()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\settings.ini";
            IniFile fini = new IniFile(path);

            textBox1.Text = fini.IniReadValue("Konfiguracja programu - ArmA 2 Lanczer:", "Ścieżka");
            checkBox1.Checked = bool.Parse(fini.IniReadValue("Konfiguracja programu - ArmA 2 Lanczer:", "Beta"));
            checkBox2.Checked = bool.Parse(fini.IniReadValue("Konfiguracja programu - ArmA 2 Lanczer:", "noSplash"));
            checkBox3.Checked = bool.Parse(fini.IniReadValue("Konfiguracja programu - ArmA 2 Lanczer:", "worldEmpty"));
            checkBox4.Checked = bool.Parse(fini.IniReadValue("Konfiguracja programu - ArmA 2 Lanczer:", "skipIntro"));

            modsCount = int.Parse(fini.IniReadValue("Konfiguracja programu - ArmA 2 Lanczer:", "Ilość"));

            //MessageBox.Show(modsCount.ToString());

            ListMods newListMods = new ListMods(modsCount+1);

            for (int x = 1; x <= modsCount; x++)
            {
                newListMods.name[x] = fini.IniReadValue("Mody:", "Nazwa" + x.ToString());
                newListMods.mods[x] = fini.IniReadValue("Mody:", "Mody" + x.ToString());
                listBox2.Items.Add(newListMods.name[x] + ": " + newListMods.mods[x]);
            }
        }

        private void writeIni()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\settings.ini";
            IniFile fini = new IniFile(path); //tworzymy plik INI

            modsCount++;

            //w tym miejscu nastąpi zapis wartości textBox'a
            fini.IniWriteValue("Konfiguracja programu - ArmA 2 Lanczer:", "Ścieżka", textBox1.Text);
            fini.IniWriteValue("Konfiguracja programu - ArmA 2 Lanczer:", "Beta", checkBox1.Checked.ToString());
            fini.IniWriteValue("Konfiguracja programu - ArmA 2 Lanczer:", "noSplash", checkBox2.Checked.ToString());
            fini.IniWriteValue("Konfiguracja programu - ArmA 2 Lanczer:", "worldEmpty", checkBox3.Checked.ToString());
            fini.IniWriteValue("Konfiguracja programu - ArmA 2 Lanczer:", "skipIntro", checkBox4.Checked.ToString());
            // Pola modów
            fini.IniWriteValue("Konfiguracja programu - ArmA 2 Lanczer:", "Ilość", modsCount.ToString());

            fini.IniWriteValue("Mody:", "Nazwa" + modsCount.ToString(), textBox2.Text);
            fini.IniWriteValue("Mody:", "Mody" + modsCount.ToString(), textBox5.Text + " " + textBox3.Text);

        }*/

        private void readCfgMods()
        {
            System.IO.StreamReader file = new System.IO.StreamReader("mods.cfg");

            Mods modsReader = new Mods();

            while (!file.EndOfStream)
            {
                string split = file.ReadLine();
                string[] splitArray = split.Split(';');
                modsReader.index = Int32.Parse(splitArray[0]);
                modsReader.name = splitArray[1];
                modsReader.mods = splitArray[2];
                modsReader.additional = splitArray[3];
                modsReader.param = splitArray[4];
                listBox2.Items.Add(modsReader);
            }
        }

        private void writeCfgMods()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //writeIni();
        }

        private void gameProcess(string param)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Brak ściezki do gry!", "Komunikat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Process game = new Process();

            if (checkBox1.Checked)
            {
                //if (!File.Exists(textBox1.Text + "\\ArmA2OABETA.exe"))
                File.Delete(textBox1.Text + "\\Arma2OABETA.exe");
                File.Copy(textBox1.Text + "\\Expansion\\beta\\Arma2OA.exe", textBox1.Text + "\\Arma2OABETA.exe");

                game.StartInfo.FileName = textBox1.Text + "\\ArmA2OABETA.exe";
                game.StartInfo.Arguments = "-beta=Expansion\\beta;Expansion\\beta\\Expansion " + param;
            }
            else
            {
                game.StartInfo.FileName = textBox1.Text + "\\ArmA2OA.exe";
                game.StartInfo.Arguments = param;
            }

            if (checkBox2.Checked)
                game.StartInfo.Arguments += "-noSplash ";
            if (checkBox3.Checked)
                game.StartInfo.Arguments += "-world=empty ";
            if (checkBox4.Checked)
                game.StartInfo.Arguments += "-skipIntro";

            try
            {
                game.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Komunikat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkedListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = "-mod=";
            var items = checkedListBox1.CheckedItems;
            foreach (var item in items)
            {
                textBox3.Text += item.ToString();
                textBox3.Text += ";";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameProcess("");
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {

        }

    }
    public class Mods
    {
        public int index;
        public string name;
        public string mods;
        public string additional;
        public string param;

        public string FullName
        {
            get { return name + " - " + param; }
        }
    }
}