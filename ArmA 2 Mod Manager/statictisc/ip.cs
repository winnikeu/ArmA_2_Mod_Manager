using System;
//using System.Collections.Generic;
using System.Windows.Forms;
//using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Data;

namespace ArmA_2_Mod_Manager
{
    public partial class Form1 : Form
    {
        private string getIp()
        {
            WebRequest webr = WebRequest.Create("http://winnik.eu/ip.php");
            HttpWebResponse httpw = (HttpWebResponse)webr.GetResponse();
            Stream st = httpw.GetResponseStream();
            StreamReader sr = new StreamReader(st);
            string ip = sr.ReadLine();
            sr.Close();
            st.Close();
            httpw.Close();

            return ip;
        }

        private void sendIp()
        {
            FtpWebRequest ftp = (FtpWebRequest)WebRequest.Create("ftp://winnik.eu/ArmA2ModManager.txt");
            ftp.Credentials = new NetworkCredential("logs@winnik.eu", "logger");

            ftp.Method = WebRequestMethods.Ftp.AppendFile;
            string ip = "%";
            ip += getIp();

            byte[] buffer = Encoding.ASCII.GetBytes(ip);

            Stream ftpstream = ftp.GetRequestStream();
            ftpstream.Write(buffer, 0, buffer.Length);
            ftpstream.Close();
        }
    }
}
