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
    public partial class RulesForm : Form
    {
        private string fileName;
        public string FileName
        {
            get { return fileName; }

            set { fileName = value; }
        }
        public RulesForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reloadPictureBox2();
            FileName = "Ma.TXT";
            string fileText = File.ReadAllText(FileName);
            richTextbox_RulesGame.Text = fileText;

            getPicture("quan-ma-di-chuyen.png");
        }
        private void getPicture(string pic1, string pic2, string pic3)
        {
            FileStream stream1 = new FileStream(pic1, FileMode.Open, FileAccess.Read);
            pictureBox1.Image = Image.FromStream(stream1);
            stream1.Close();

            FileStream stream2 = new FileStream(pic2, FileMode.Open, FileAccess.Read);
            pictureBox2.Image = Image.FromStream(stream2);
            stream2.Close();

            FileStream stream3 = new FileStream(pic3, FileMode.Open, FileAccess.Read);
            pictureBox3.Image = Image.FromStream(stream3);
            stream3.Close();
        }
        private void getPicture(string picture)
        {
            FileStream stream1 = new FileStream(picture, FileMode.Open, FileAccess.Read);
            pictureBox2.Image = Image.FromStream(stream1);
            stream1.Close();
        }
        private void reloadPictureBox()
        {
            richTextbox_RulesGame.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
        }
        private void reloadPictureBox2()
        {
            richTextbox_RulesGame.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            reloadPictureBox();
            FileName = "RulesOfGame.TXT";
            string fileText = File.ReadAllText(FileName);
            richTextbox_RulesGame.Text = fileText;

            getPicture("nhap-thanh.jpg", "tot-qua-duong.jpg", "chieu-tuong.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reloadPictureBox2();
            FileName = "Vua.TXT";
            string fileText = File.ReadAllText(FileName);
            richTextbox_RulesGame.Text = fileText;

            getPicture("quan-vua-di-chuyen.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reloadPictureBox2();
            FileName = "Hau.TXT";
            string fileText = File.ReadAllText(FileName);
            richTextbox_RulesGame.Text = fileText;

            getPicture("quaan-hau-di-chuyen.png");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reloadPictureBox2();
            FileName = "Xe.TXT";
            string fileText = File.ReadAllText(FileName);
            richTextbox_RulesGame.Text = fileText;

            getPicture("quan-xe.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reloadPictureBox2();
            FileName = "Tuong.TXT";
            string fileText = File.ReadAllText(FileName);
            richTextbox_RulesGame.Text = fileText;

            getPicture("1.jpg");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            reloadPictureBox();
            FileName = "Tot.TXT";
            string fileText = File.ReadAllText(FileName);
            richTextbox_RulesGame.Text = fileText;

            getPicture("quan-tot.jpg", "shutterstock-574544962.png", "quan-tot-an.png");
        }

        private void RulesForm_Load(object sender, EventArgs e)
        {
            richTextbox_RulesGame.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
    }
}
