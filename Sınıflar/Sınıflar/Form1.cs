using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sınıflar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public TextBox Doldur(string txtAdi,int x,int y)
        {
  
                TextBox txtDeneme = new TextBox();
                txtDeneme.Name = txtAdi;
                txtDeneme.Text = " ";
                txtDeneme.BackColor = Color.Black;
                txtDeneme.ForeColor = Color.White;
                txtDeneme.Location = new System.Drawing.Point(x,y);
                txtDeneme.Size = new System.Drawing.Size(30, 20);              
                return txtDeneme;

        }
        public TextBox Doldur(string txtAdi, int x, int y,int Genişlik,int Uzunluk)
        {

            TextBox txtDeneme = new TextBox();
            txtDeneme.Name = txtAdi;
            txtDeneme.Text = " ";
            txtDeneme.BackColor = Color.Black;
            txtDeneme.ForeColor = Color.White;
            txtDeneme.Location = new System.Drawing.Point(x, y);
            txtDeneme.Size = new System.Drawing.Size(Genişlik, Uzunluk);
            return txtDeneme;

        }
        public TextBox Doldur(string txtAdi, int x, int y,string metin)
        {

            TextBox txtDeneme = new TextBox();
            txtDeneme.Name = txtAdi;
            txtDeneme.Text = metin;
            txtDeneme.BackColor = Color.Black;
            txtDeneme.ForeColor = Color.White;
            txtDeneme.Location = new System.Drawing.Point(x, y);
            txtDeneme.Size = new System.Drawing.Size(30, 20);
            return txtDeneme;

        }
        public TextBox Doldur(string txtAdi, int x, int y,int Genişlik,int Uzunluk,string metin)
        {

            TextBox txtDeneme = new TextBox();
            txtDeneme.Name = txtAdi;
            txtDeneme.Text = metin;
            txtDeneme.BackColor = Color.Black;
            txtDeneme.ForeColor = Color.White;
            txtDeneme.Location = new System.Drawing.Point(x, y);
            txtDeneme.Size = new System.Drawing.Size(Genişlik, Uzunluk);
            return txtDeneme;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int Sonuc = 2;
            int Fark = 102;
            for (int i = 1; i <=10; i++)
            {
                TextBox txtSonuc = Doldur("txtMetot"+i.ToString(),Sonuc,85);
                Sonuc += Fark;
                this.Controls.Add(txtSonuc);
            }

            //int sonuc = 2;
            //int Fark = 102;
            //for (int i = 1; i <= 10; i++)
            //{
            //    TextBox txtDeneme = new TextBox();
            //    txtDeneme.Name = "txtDeneme" + i.ToString();
            //    txtDeneme.Text = i.ToString();
            //    txtDeneme.BackColor = Color.Black;
            //    txtDeneme.ForeColor = Color.White;
            //    txtDeneme.Location = new System.Drawing.Point(sonuc, 85);
            //    sonuc += Fark;
            //    this.Controls.Add(txtDeneme);
            //}
           }

        private void button2_Click(object sender, EventArgs e)
        {
            int Sonuc = 2;
            int Fark = 102;
            for (int i = 1; i <= 10; i++)
            {
                TextBox txtSonuc = Doldur("txtMetot2" + i.ToString(), Sonuc, 85, 30, 20);
                Sonuc += Fark;
                this.Controls.Add(txtSonuc);
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Sonuc = 2;
            int Fark = 102;
            for (int i = 1; i <= 10; i++)
            {
               
                TextBox txtSonuc = Doldur("txtMetot" + i.ToString(), Sonuc, 85, "OVERLOAD");
                Sonuc += Fark;
                this.Controls.Add(txtSonuc);
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Sonuc = 2;
            int Fark = 102;
            for (int i = 1; i <= 10; i++)
            {
                TextBox txtSonuc = Doldur("txtMetot" + i.ToString(), Sonuc, 85, 30, 20, "OVERLOAD2");
                Sonuc += Fark;
                this.Controls.Add(txtSonuc);
               
            }
        }
    }
}
