using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace belaarCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Hello Form"; // Mengubah teks form
            button1.Text = "KLIK DISINI"; // Mengubah teks button
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selamat Datang !!!"); // Menampilkan pesan
        }
    }
}
