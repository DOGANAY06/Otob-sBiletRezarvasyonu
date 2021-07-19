using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobüsBiletRezarvasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + " - " + 
                comboBox2.Text + " Gidiş: "+dateTimePicker1.Text+ " Saat: "
                + maskedTextBox1.Text + " Yolcu Bilgileri || Ad ve Soyad " 
                +maskedTextBox2.Text + " T.C: " +maskedTextBox3.Text +
                " Telefon: "+maskedTextBox4.Text
                );
            MessageBox.Show("Yolcu Kaydı Yapıldı");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kullanıcı nereden nereye gideceği arasında değiştirme yaparken kullanılır
            label8.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label8.Text;
        }
    }
}
