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
using System.Threading;

namespace AsyncFormExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountCharacters()
        {
            int count = 0;
            string dataPath = "C:/Users/MERT/source/repos/AsyncFormExample/AsyncFormExample/Data/data.txt";
            using (StreamReader reader = new StreamReader(dataPath))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(2000);
            }
            return count;
        }


        private void btnTestClick_Click(object sender, EventArgs e)
        {
            lblTest.Text = "";
            lblTest.Text = "Test Butonu Çalıştı";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                lblRenk.Text = "Siyah Seçildi";
                lblRenk.ForeColor = Color.Black;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblRenk.Text = "Kırmızı Seçildi";
            lblRenk.ForeColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblRenk.Text = "Mavi Seçildi";
            lblRenk.ForeColor = Color.Blue;
        }

        private void btnProccessFile_Click(object sender, EventArgs e)
        {
            lblCount.Text = "Dosya İşleniyor. Lütfen Bekleyiniz...";
            int count = CountCharacters();
            lblCount.Text = "Dosyadaki Karakter Sayısı: " + count.ToString();

        }

        private async void btnProccessFileAsync_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();

            lblCount.Text = "Dosya İşleniyor. Lütfen Bekleyiniz...";
            int count = await task;
            lblCount.Text = "Dosyadaki Karakter Sayısı: " + count.ToString();

        }

        private void btnProccessFile_MouseDown(object sender, MouseEventArgs e)
        {
            lblCount.Text = "";
        }

        private void btnProccessFileAsync_MouseDown(object sender, MouseEventArgs e)
        {
            lblCount.Text = "";
        }
    }
}
