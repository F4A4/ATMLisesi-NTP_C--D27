using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextBoxlarlaCalisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yer = 2;
            int fark = 32;

            for (int i = 1; i <= 10; i++)
            {
                TextBox txtYeniGelen = TextBoxOlustur("txtNot" + i.ToString(), yer, 85);
                yer += fark;
                this.Controls.Add(txtYeniGelen);
            }
        }

        public TextBox TextBoxOlustur(string txtAdi, int x, int y)
        {
            TextBox txt = new TextBox();
            txt.Name = txtAdi;
            txt.Text = "";
            txt.Location = new System.Drawing.Point(x, y);
            txt.Size = new System.Drawing.Size(30, 20);

            return txt;
        }

        public TextBox TextBoxOlustur(string txtAdi, int x, int y, string txtText)
        {
            TextBox txt = new TextBox();
            txt.Name = txtAdi;
            txt.Text = txtText;
            txt.Location = new System.Drawing.Point(x, y);
            txt.Size = new System.Drawing.Size(30, 20);

            return txt;
        }

        public TextBox TextBoxOlustur(string txtAdi, int x, int y, int txtUzunluk)
        {
            TextBox txt = new TextBox();
            txt.Name = txtAdi;
            txt.Text = "";
            txt.Location = new System.Drawing.Point(x, y);
            txt.Size = new System.Drawing.Size(txtUzunluk, 20);

            return txt;
        }

        public TextBox TextBoxOlustur(string txtAdi, int x, int y, string txtText, int txtUzunluk)
        {
            TextBox txt = new TextBox();
            txt.Name = txtAdi;
            txt.Text = txtText;
            txt.Location = new System.Drawing.Point(x, y);
            txt.Size = new System.Drawing.Size(txtUzunluk, 20);

            return txt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int yer = 2;
            int fark = 32;

            for (int i = 1; i <= 10; i++)
            {
                TextBox txtYeniGelen = TextBoxOlustur("txtNot" + i.ToString(), yer, 85, 10);
                yer += fark;
                this.Controls.Add(txtYeniGelen);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int yer = 2;
            int fark = 32;

            for (int i = 1; i <= 10; i++)
            {
                TextBox txtYeniGelen = TextBoxOlustur("txtNot" + i.ToString(), yer, 85,i.ToString());
                yer += fark;
                this.Controls.Add(txtYeniGelen);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int yer = 2;
            int fark = 32;

            for (int i = 1; i <= 10; i++)
            {
                TextBox txtYeniGelen = TextBoxOlustur("txtNot" + i.ToString(), yer, 85,i.ToString(),15);
                yer += fark;
                this.Controls.Add(txtYeniGelen);
            }
        }
    }
}
