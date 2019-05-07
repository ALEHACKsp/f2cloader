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
using HWIDGrabber;

namespace Loader
{
    public partial class Form4 : MetroForm
    {
        public Form4()
        {
            InitializeComponent();
        }

        string hwid;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Username = metroTextBox1.Text;
            Properties.Settings.Default.Password = metroTextBox2.Text;
            Properties.Settings.Default.InviteCode = metroTextBox3.Text;
            Properties.Settings.Default.Save();

            webBrowser1.Navigate("https://effex.xyz/forums/member.php?action=register&username=" + metroTextBox1.Text + "&password=" + metroTextBox2.Text + "&hwid=" + hwid + "&code=" + metroTextBox1.Text);

        }
    }
}