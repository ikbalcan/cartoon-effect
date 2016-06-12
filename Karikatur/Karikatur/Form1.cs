using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Karikatur
{
    public partial class Form1 : Form
    {

    
        Point lastPoint = Point.Empty;//Point.Empty represents null for a Point object
        bool isMouseDown = new Boolean();//this is used to evaluate whether our mousebutton is down or not
        int cizim = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
            tb1.Minimum = 0;
            tb1.Maximum = 255;
            tb2.Minimum = 0;
            tb2.Maximum = 255;
            tb3.Minimum = 0;
            tb3.Maximum = 255;
            tb4.Minimum = 0;
            tb4.Maximum = 255;
            tb5.Minimum = 0;
            tb5.Maximum = 255;
            tb1.Value = 25;
            tb2.Value = 27;
            tb3.Value = 45;
            tb4.Value = 222;
            tb5.Value = 241;
            default1.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "C:\\Users\\mercan1\\Desktop\\C#";
            if (DialogResult.OK == file.ShowDialog())
            {
                this.picOrig.Image = new Bitmap(file.FileName);
            }

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "GRİ GÖRÜNTÜ")
            {
                Bitmap copy = new Bitmap((Bitmap)this.picOrig.Image);
                Class1.gri(copy);
                this.picResult.Image = copy;
            }
            if (comboBox1.Text == "THRESHOLD HESAPLAMA")
            {
                Bitmap copy = new Bitmap((Bitmap)this.picResult.Image);
                label1.Text = Class1.threshold(copy).ToString();
                this.picResult.Image = copy;

            }
            if (comboBox1.Text == "SİYAH BEYAZ")
            {
                Bitmap copy = new Bitmap((Bitmap)this.picResult.Image);
                Class1.siyahbeyaz(copy, Class1.threshold(Class1.gri(copy)));
                picResult.Image = copy;

            }
            if (comboBox1.Text == "DİKEY KENAR")
            {
                Bitmap copy = new Bitmap((Bitmap)this.picResult.Image);
                Class1.dikeykenar(copy);
                picResult.Image = copy;

            }
            if (comboBox1.Text == "YATAY KENAR")
            {

                Bitmap copy = new Bitmap((Bitmap)this.picResult.Image);
                Class1.yataykenar(copy);
                picResult.Image = copy;




            }
            if (comboBox1.Text == "KENAR GÖRÜNTÜSÜ")
            {
                Bitmap copy1 = new Bitmap((Bitmap)this.picOrig.Image);
                Bitmap copy2 = new Bitmap((Bitmap)this.picOrig.Image);
                Bitmap copy3 = new Bitmap((Bitmap)this.picOrig.Image);
                picResult.Image = Class1.kenar(Class1.dikeykenar(Class1.gri(copy1)), Class1.yataykenar(Class1.gri(copy2)), copy3);

            }
            if (comboBox1.Text == "KARINCA GİDERME")
            {
                Bitmap copy = new Bitmap((Bitmap)this.picResult.Image);
                Class1.KarincaGiderme(copy);
                picResult.Image = copy;

            }
            if (comboBox1.Text == "KARİKATURİZASYON")
            {
                Bitmap copy = new Bitmap((Bitmap)this.picOrig.Image);
                Class1.karikaturizasyon(copy);
                this.picResult.Image = copy;
            }
            if (comboBox1.Text == "TERS ÇEVİR")
            {
                Bitmap copy = new Bitmap((Bitmap)this.picResult.Image);
                Class1.ters(copy);
                this.picResult.Image = copy;
            }

            if (comboBox1.Text == "GAUSSIAN")
            {

                Bitmap copy = new Bitmap((Bitmap)this.picOrig.Image);
                Bitmap copy1 = new Bitmap((Bitmap)this.picOrig.Image);
                Bitmap copy2 = new Bitmap((Bitmap)this.picOrig.Image);
                Bitmap kenar = new Bitmap((Bitmap)this.picOrig.Image);
                Bitmap sonuc = new Bitmap((Bitmap)this.picOrig.Image);

                Class1.karikaturizasyon_G(copy);         
                this.picResult.Image = copy;
            }
            if (comboBox1.Text == "RESIZE")
            {
                picOrig.Image = Class1.resizeImage(picOrig.Image, new Size(544, 408));
            }
            if (comboBox1.Text == "YCBCR")
            {
                Bitmap copy = new Bitmap((Bitmap)this.picOrig.Image);
                Class1.YCbCr(copy, tb2.Value, tb3.Value, tb4.Value, tb5.Value);
                this.picResult.Image = copy;
            }
            if (comboBox1.Text == "DERİ BOYA")
            {
                Bitmap copy = new Bitmap((Bitmap)this.picOrig.Image);
                Class1.YCbCr(copy, tb2.Value, tb3.Value, tb4.Value, tb5.Value);
                Class1.deriboya(copy);
                this.picResult.Image = copy;
            }
            if (comboBox1.Text == "KARAKALEM")
            {
                Bitmap kenar = new Bitmap((Bitmap)this.picOrig.Image);
                Bitmap copy1 = new Bitmap((Bitmap)this.picOrig.Image);
                Bitmap copy2 = new Bitmap((Bitmap)this.picOrig.Image);

                Class1.kenar(Class1.dikeykenar(Class1.gri(copy1)), Class1.yataykenar(Class1.gri(copy2)), kenar);
                Class1.ters((Bitmap)kenar);
                this.picResult.Image = kenar;
            }
            if (comboBox1.Text == "RENK")
            {
                Bitmap copy = new Bitmap((Bitmap)this.picResult.Image);
                Class1.renklendir(copy);
                this.picResult.Image = copy;
            }
            if (comboBox1.Text == "RENKLİ KENAR")
            {
                Bitmap copy = new Bitmap((Bitmap)this.picOrig.Image);
                Bitmap copy2 = new Bitmap((Bitmap)this.picResult.Image);
                Bitmap copy3 = new Bitmap((Bitmap)this.picResult.Image);
                Class1.kenar_renk(copy, copy2, copy3);
                this.picResult.Image = copy3;
            }
            if (comboBox1.Text == "YARI/YARI")
            {

                Bitmap copy = new Bitmap((Bitmap)this.picOrig.Image);
                Bitmap copy2 = new Bitmap((Bitmap)this.picResult.Image);
                Bitmap copy3 = new Bitmap((Bitmap)this.picResult.Image);
                Class1.yarim(copy, copy2, copy3);
                this.picResult.Image = copy3;
            }
            if (comboBox1.Text == "ÇİZGİ FİLM EFEKTİ")
            {
                Bitmap copy = new Bitmap((Bitmap)this.picOrig.Image);
                Bitmap copy1 = new Bitmap((Bitmap)this.picOrig.Image);
                Bitmap copy2 = new Bitmap((Bitmap)this.picOrig.Image);
                Bitmap kenar = new Bitmap((Bitmap)this.picOrig.Image);            
                Bitmap karikatur = new Bitmap((Bitmap)this.picOrig.Image);
                Bitmap sonuc = new Bitmap((Bitmap)this.picOrig.Image); ;
                Bitmap deri = new Bitmap((Bitmap)this.picOrig.Image);


                Class1.YCbCr(deri, tb2.Value, tb3.Value, tb4.Value, tb5.Value);
                Class1.deriboya(deri);
                Class1.karikaturizasyon_G(copy);
                Class1.kenar(Class1.dikeykenar(Class1.gri(copy1)), Class1.yataykenar(Class1.gri(copy2)), kenar);
                Class1.siyahbeyaz(kenar,tb1.Value);
                Class1.cikar(copy, kenar, karikatur, tb1.Value);
                Class1.sonhali(karikatur, deri, sonuc);
                this.picResult.Image = sonuc;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPEG Dosyasi(*.jpeg)|*.jpeg";
            if (DialogResult.OK == save.ShowDialog())
            {
                this.picResult.Image.Save(save.FileName);
            }
        }

        private void tb1_Scroll(object sender, EventArgs e)
        {
            label1.Text = tb1.Value.ToString();
        }

        private void tb2_Scroll(object sender, EventArgs e)
        {
            lblcrmin.Text = "Crmin :" + tb2.Value.ToString();
        }

        private void tb4_Scroll(object sender, EventArgs e)
        {
            lblcbmin.Text = "Cbmin :" + tb4.Value.ToString();
        }

        private void tb3_Scroll(object sender, EventArgs e)
        {
            lblcrmax.Text = "Crmax :" + tb3.Value.ToString();
        }

        private void tb5_Scroll(object sender, EventArgs e)
        {
            lblcbmax.Text = "Cbmax :" + tb5.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void default1_Click(object sender, EventArgs e)
        {
            cizim = 1;
        }
        private void picResult_MouseDown(object sender, MouseEventArgs e)

        {

            lastPoint = e.Location;//we assign the lastPoint to the current mouse position: e.Location ('e' is from the MouseEventArgs passed into the MouseDown event)
            isMouseDown = true;//we set to true because our mouse button is down (clicked)

        }
        private void picResult_MouseUp(object sender, MouseEventArgs e)

        {

            isMouseDown = false;

            lastPoint = Point.Empty;

            //set the previous point back to null if the user lets go of the mouse button

        }
        private void picResult_MouseMove(object sender, MouseEventArgs e)

        {
            byte r1 = 0;
            byte g1 = 0;
            byte b1 = 0;
            if (cizim == 1) {
            if (isMouseDown == true)//check to see if the mouse button is down

            {

                if (lastPoint != null)//if our last point is not null, which in this case we have assigned above

                {

                    if (picResult.Image == null)//if no available bitmap exists on the picturebox to draw on

                    {
                        //create a new bitmap
                        Bitmap bmp = new Bitmap(picResult.Width, picResult.Height);

                        picResult.Image = bmp; //assign the picturebox.Image property to the bitmap created
                    }

                    using (Graphics g = Graphics.FromImage(picResult.Image))

                    {//we need to create a Graphics object to draw on the picture box, its our main tool

                        //when making a Pen object, you can just give it color only or give it color and pen size

                        g.DrawLine(new Pen(Color.FromArgb(r1,g1, b1), 2), lastPoint, e.Location);
                        //this is to give the drawing a more smoother, less sharper look

                    }

                    picResult.Invalidate();//refreshes the picturebox

                    lastPoint = e.Location;//keep assigning the lastPoint to the current mouse position

                }

            }
            }
        }
        private void picResult_Click(object sender, EventArgs e)
        {

        }

    }
}
