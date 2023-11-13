using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SiniflarDevam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region açıklama
            Button btn = new Button();//örneklemek türetmek.
            //static olmayan class lar içine her şey yazılır.
            #endregion

            Math.Pow(15, 2);//static class lar böyle kullanılır.
            //static class lar içine sadece 
            //static nesneler yada const(sabitler)
            //yazılabilir.

            MyClass mc = new MyClass();
            mc.i = 15;
            mc.a = 20;
            MyClass.b = 34;
            MessageBox.Show(MyClass.c.ToString());
            //mc.Deneme(); erişilemez
            MyClass.Deneme();//bu şekilde erişilebilir.
            mc.Deneme2();
            //MyClass2.c=....; şeklinde değer değiştirilemez
            //çünkü c bir sabittir(const)
            MessageBox.Show(MyClass2.c.ToString());
            //MyClass2.i = 3;  i ye ulaşamayız.çünkü static değil
            MyClass2.Deneme();
            //MyClass2.Deneme2(); erişilemez
        }
    }

    public class MyClass
    {
        public int i = 3;
        public int a;
        public const int c = 13; //bu const dışarıda kullanılamaz
        public static void Deneme()
        {}
        public void Deneme2()
        {}
        public static int b = 0;
    }
    public static class MyClass2
    {
        //public int i; tanımlayamayız
        public const int c = 13;
        //public const int c; şeklinde c değişkeni boş bırakılamaz
        //çünkü c bir sabittir(const)
        //const alanlar(değişkenler) yalnızca static classlar
        //ile kullanılabilir.
        public static void Deneme()
        {}
        //public void Deneme2() tanımlayamayız
        //{}
    }
}
