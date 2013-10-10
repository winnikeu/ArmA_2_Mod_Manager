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
        private void readCfgSettings()
        {
            if (!File.Exists("settings.cfg"))
                return;

            StreamReader file = new StreamReader("settings.cfg");
            // Zakładka Ustawienia
            txtPath.Text = file.ReadLine();
            // Checkboxy Start
            string[] splitArray = file.ReadLine().Split('%');
            chbBetaPatch.Checked = bool.Parse(splitArray[0]);
            chbNoSplash.Checked = bool.Parse(splitArray[1]);
            chbSkipIntro.Checked = bool.Parse(splitArray[2]);
            chbWorldEmpty.Checked = bool.Parse(splitArray[3]);
            // Checkboxy Ustawienia
            string[] splitArray2 = file.ReadLine().Split('%');
            chbCpuCount.Checked = bool.Parse(splitArray2[0]);
            chbMaxMem.Checked = bool.Parse(splitArray2[1]);
            chbMaxVRAM.Checked = bool.Parse(splitArray2[2]);
            chbExThreads.Checked = bool.Parse(splitArray2[3]);
            chbWinXp.Checked = bool.Parse(splitArray2[4]);
            // Wartości z comboboxosow
            string[] splitArray3 = file.ReadLine().Split('%');
            cbCpuCount.Text = splitArray3[0];
            cbMaxMem.Text = splitArray3[1];
            cbMaxVRAM.Text = splitArray3[2];
            cbExThreads.Text = splitArray3[3];
            // Ustawienia listview
            string[] splitArray4 = file.ReadLine().Split('%');
            lvConfigurations.Columns[0].Width = Int32.Parse(splitArray4[0]);
            lvConfigurations.Columns[1].Width = Int32.Parse(splitArray4[1]);

            file.Close();
        }

        private void writeCfgSettings()
        {
            StreamWriter file = new StreamWriter("settings.cfg");
            // Zakładka Ustawienia
            file.WriteLine(txtPath.Text);
            // Checkboxy Start
            file.WriteLine(chbBetaPatch.Checked.ToString() + "%" +
                            chbNoSplash.Checked.ToString() + "%" +
                            chbSkipIntro.Checked.ToString() + "%" +
                            chbWorldEmpty.Checked.ToString());
            // Checkboxy Ustawienia
            file.WriteLine(chbCpuCount.Checked.ToString() + "%" +
                            chbMaxMem.Checked.ToString() + "%" +
                            chbMaxVRAM.Checked.ToString() + "%" +
                            chbExThreads.Checked.ToString() + "%" +
                            chbWinXp.Checked.ToString());
            // Wartości z comboboxosow
            file.WriteLine(cbCpuCount.Text + "%" +
                            cbMaxMem.Text + "%" +
                            cbMaxVRAM.Text + "%" +
                            cbExThreads.Text);
            // Ustawienia listview
            file.WriteLine(lvConfigurations.Columns[0].Width + "%" +
                            lvConfigurations.Columns[1].Width);

            file.Close();
        }
    }
}