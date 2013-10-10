using System;
//using System.Collections.Generic;
using System.Windows.Forms;
//using System.Linq;
//using System.Text;
using System.IO;

namespace ArmA_2_Mod_Manager
{
    public partial class Form1 : Form
    {
        private void addDayzInfo()
        {
            Mods dayzinfo = new Mods();
            dayzinfo.name = "DayZInfo Expert";
            dayzinfo.param = "-mod=@dayzinfo -connect=79.173.37.58 -port=2312";
            dayzinfo.additional = "-connect=79.173.37.58 -port=2312";
            ListViewItem ditem = new ListViewItem();
            ditem.Text = dayzinfo.name;
            ditem.SubItems.Add(dayzinfo.param);
            ditem.Tag = dayzinfo;
            lvConfigurations.Items.Add(ditem);
            // 2 mod
            Mods dayzinfo2 = new Mods();
            dayzinfo2.name = "DayZInfo Veteran";
            dayzinfo2.param = "-mod=@DayZ -connect=79.173.37.58 -port=2302";
            dayzinfo2.additional = "-connect=79.173.37.58 -port=2302";
            ListViewItem ditem2 = new ListViewItem();
            ditem2.Text = dayzinfo2.name;
            ditem2.SubItems.Add(dayzinfo2.param);
            ditem2.Tag = dayzinfo2;
            lvConfigurations.Items.Add(ditem2);
        }

        private void readCfgMods()
        {
            //addDayzInfo();
            if (!File.Exists("mods.cfg"))
                return;

            StreamReader file = new StreamReader("mods.cfg");

            while (!file.EndOfStream)
            {
                string split = file.ReadLine();
                string[] splitArray = split.Split('%');
                Mods modsReader = new Mods();
                modsReader.index = Int32.Parse(splitArray[0]);
                modsReader.name = splitArray[1];
                modsReader.mods = splitArray[2];
                modsReader.additional = splitArray[3];
                modsReader.param = splitArray[4];
                //listBox2.Items.Add(modsReader);

                ListViewItem item = new ListViewItem();
                item.Text = modsReader.name;
                item.SubItems.Add(modsReader.param);
                item.Tag = modsReader;
                lvConfigurations.Items.Add(item);

                modsCount = modsReader.index;
            }
            file.Close();
        }

        private void writeCfgMods()
        {
            string paramAll = "";
            string paramWindowed = "";
            string paramServer = "";
            string paramPort = "";
            if (chbWindowed.Checked)
                paramWindowed = " -window";
            if (chbServer.Checked)
                paramServer = " -connect=" + txtServer.Text;
            if (chbPort.Checked)
                paramPort = " -port=" + txtPort.Text;
            paramAll = txtParam.Text + " " + txtAdditional.Text + paramServer + paramPort + paramWindowed;
            //textBox3.Text + " " + textBox5.Text + paramWindowed

            StreamWriter file = new StreamWriter("mods.cfg", true);
            modsCount += 1;
            string fileWriter = modsCount.ToString() + "%" + txtName.Text + "%" + txtParam.Text + "%" + txtAdditional.Text + "%" + paramAll;
            file.WriteLine(fileWriter);
            file.Close();
        }

        private void deleteCfgMods()
        {
            if (lvConfigurations.SelectedItems.Count < 1)
            {
                MessageBox.Show("Nie wybrałeś opcji/konfiguracji!", "Komunikat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Mods mods = new Mods();
            mods = (Mods)lvConfigurations.SelectedItems[0].Tag;
            lvConfigurations.SelectedItems[0].Remove();

            if (File.Exists("mods.cfg"))
            {
                StreamReader filer = new StreamReader("mods.cfg");
                StreamWriter filew = new StreamWriter("modsTemp.cfg");
                while (!filer.EndOfStream)
                {
                    string split = filer.ReadLine();
                    string[] splitArray = split.Split('%');
                    if (Int32.Parse(splitArray[0]) == mods.index)
                        continue;
                    filew.WriteLine(split);
                }

                filer.Close();
                filew.Close();
                File.Delete("mods.cfg");
                File.Move("modsTemp.cfg", "mods.cfg");
            }
            reloadMods();
            //readCfgMods();
        }
    }
}
