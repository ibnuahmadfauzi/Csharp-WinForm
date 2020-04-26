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
            
            // Membuat list item comboBox
            comboBox1.Items.Add("Minggu");
            comboBox1.Items.Add("Senin");
            comboBox1.Items.Add("Selasa");
            comboBox1.Items.Add("Rabu");
            comboBox1.Items.Add("Kamis");
            comboBox1.Items.Add("Jum'at");
            comboBox1.Items.Add("Sabtu");

            comboBox1.Text = "Pilih Hari"; // Memasukan teks sementara di combo box
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown; // Memilih style dropdown

        }
    }
}
