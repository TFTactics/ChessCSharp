using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Chess
{
    public partial class MusicMediaPlayer : Form
    {
        DirectoryInfo fileMusic = new DirectoryInfo(@"MusicList");
        FileInfo[] fileName;
        public MusicMediaPlayer()
        {
            InitializeComponent();
            useNotifyIcon();
        }

        private void button_selectMusic_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox_Music_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_Music.SelectedIndex != -1)
            {
                // choose index music file
                int choose = listBox_Music.SelectedIndex;
                // play music URL
                axWindowsMediaPlayer1.URL = fileName[choose].FullName;
                this.textBox_MusicPlaying.Text = fileName[choose].Name;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                axWindowsMediaPlayer1.URL = "";
                this.Close();
            }
        }

        private void MusicMediaPlayer_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.notifyIcon1.BalloonTipText = "Music program is running...";
                this.notifyIcon1.BalloonTipTitle = "Shutdown Timer";
                notifyIcon1.Icon = new System.Drawing.Icon(@".\Music.Ico");
                notifyIcon1.Text = "ShutDown Timer";
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }
        private void useNotifyIcon()
        {
            menuItem1.Click += new System.EventHandler(this.menuItem1_Click);   
            menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void MusicMediaPlayer_Load(object sender, EventArgs e)
        {
            fileName = fileMusic.GetFiles();
            foreach (FileInfo item in fileName)
            {
                this.listBox_Music.Items.Add(item.Name);
            }
        }
    }
}
