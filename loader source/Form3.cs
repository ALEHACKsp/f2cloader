using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ManualMapInjection.Injection;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Security.Cryptography;
using System.Net;

namespace Loader
{
    public partial class Form3 : MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
            metroLabel5.Text = "Welcome " + Properties.Settings.Default.Username + "!";

            string updater = "aHR0cHM6Ly9lZmZleC54eXovYXV0aA==";

            byte[] data = Convert.FromBase64String(updater);
            string updatar = Encoding.UTF8.GetString(data);

            webBrowser1.Navigate(updatar + "/" + "ch" + "ec" + "k.p" + "hp?" + "u" + "se" + "r" + "na" + "me=" + Properties.Settings.Default.Username + "&pas" + "sword" + "=0&h" + "wid" + "=0");
            webBrowser3.Navigate(updatar + "/" + "ui" + "dgr" + "ab.ph" + "p?u" + "se" + "rna" + "me=" + Properties.Settings.Default.Username);
            webBrowser4.Navigate(updatar + "/" + "de" + "te" + "c" + "ti" + "on.p" + "hp?" + "ch" + "ea" + "t_nam" + "e=st" + "ack" + "gloc" + "k");
            //get away i dont wnat you here :/
        }
        
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.DocumentText.Contains("g4"))
            {
                listBox1.Items.Add("Osiris - Legit");
                listBox1.Items.Add("Mirror - HvH");
                listBox1.Items.Add("StrickRpg by jugiboy - HvH");
            }
            /*else if (webBrowser1.DocumentText.Contains("g9"))
            {

            }
            else if (webBrowser1.DocumentText.Contains("g8"))
            {

            }*/
            else if (webBrowser1.DocumentText.Contains("g8"))
            {
                listBox1.Items.Add("Osiris - Legit");
                listBox1.Items.Add("Mirror - HvH");
                listBox1.Items.Add("StrickRpg by jugiboy - HvH");
            }
        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string allText = webBrowser3.DocumentText;
        }
        private void metroLabel4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to restart the loader", "EffeX.XYZ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to restart the loader", "EffeX.XYZ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var name = "csgo";
            var target = Process.GetProcessesByName(name).FirstOrDefault();

            if (listBox1.SelectedIndex == 0)
            {
                if (target != null)
                {

                    string dllr = "https://effex.xyz/auth/dll/osiris.p";
                    WebClient wb = new WebClient(); // we create a new webclient
                    byte[] file = wb.DownloadData(dllr); // we download the dll to a byte array, much more secure than saving to the disk unlike most loaders
                    
                    var injector = new ManualMapInjector(target) { AsyncInjection = true };
                    metroLabel6.Text = $"hmodule = 0x{injector.Inject(file).ToInt64():x8}";

                    if (metroCheckBox1.Checked == true)
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Error: CS:GO is not open!", "EffeX.XYZ");
                }
            }
            else if (listBox1.SelectedIndex == 1) 
            {
                string dllr = "https://effex.xyz/auth/dll/mirror.trap";
                WebClient wb = new WebClient(); // we create a new webclient
                byte[] file = wb.DownloadData(dllr); // we download the dll to a byte array, much more secure than saving to the disk unlike most loaders

                var injector = new ManualMapInjector(target) { AsyncInjection = true };
                metroLabel6.Text = $"hmodule = 0x{injector.Inject(file).ToInt64():x8}";

                if (metroCheckBox1.Checked == true)
                {
                    Application.Exit();
                }
            
                else
                {
                    MessageBox.Show("Error: CS:GO is not open!", "EffeX.XYZ");
                }
            }
            else if (listBox1.SelectedIndex == 2) 
            {
                string dllr = "https://effex.xyz/auth/dll/stick.pp";
                WebClient wb = new WebClient(); // we create a new webclient
                byte[] file = wb.DownloadData(dllr); // we download the dll to a byte array, much more secure than saving to the disk unlike most loaders

                var injector = new ManualMapInjector(target) { AsyncInjection = true };
                metroLabel6.Text = $"hmodule = 0x{injector.Inject(file).ToInt64():x8}";

                if (metroCheckBox1.Checked == true)
                {
                    Application.Exit();
                }
            
                else
                {
                    MessageBox.Show("Error: CS:GO is not open!", "EffeX.XYZ");
                }
            }
            else if (listBox1.SelectedIndex == -1) 
            {
                MessageBox.Show("Nothing selected", "Error");
            }
        }
        
        public bool overwriteifExist(string outName)
        {
            if (File.Exists(outName))
            {
                return true;
            }
            return true;
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                webBrowser4.Navigate("https://effex.xyz/auth/detection.php?cheat_name=" + "osiris");
            }
            else if (listBox1.SelectedIndex == 1)
            {
                webBrowser4.Navigate("https://effex.xyz/auth/detection.php?cheat_name=" + "mirror");
            }
            else if (listBox1.SelectedIndex == 2)
            {
                webBrowser4.Navigate("https://effex.xyz/auth/detection.php?cheat_name=" + "stickbyjugi");
            }
        }
        int expire = 120;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (expire > 0)
            {
                expire--;
                metroLabel8.Text = "Session expires in " + expire + " seconds";
            }
            else
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Application.Exit();
            timer2.Stop();
        }
    }
}