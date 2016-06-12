using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;



namespace Karikatur
{
    class Class1
    {
        public Class1()
        {

        }

        public static Bitmap gri(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color cl = b.GetPixel(i, j);


                    int r1 = cl.R;
                    int b1 = cl.B;
                    int g1 = cl.G;

                    int a = (byte)((r1 + b1 + g1) / 3);
                    b.SetPixel(i, j, Color.FromArgb(a, a, a));
                }
            }
            return b;
        }
        public static int threshold(Bitmap b)
        {
            int t = 0, m = 0;
            int[] a = new int[256];

            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    t = b.GetPixel(i, j).R;
                    a[t] = a[t] + 1;
                }
            }
            t = 0;
            for (int i = 0; i < 255; i++)
            {
                t += a[i] * i;
                m += a[i];
            }
            t = t / m;

            return t+35;
        }
        public static void siyahbeyaz(Bitmap b, int th)
        {
            int a;
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    a = b.GetPixel(i, j).R;
                    if (a < th)
                    {
                        a = 0;
                    }
                    else a = 255;
                    b.SetPixel(i, j, Color.FromArgb(a, a, a));
                }
            }
        }
        public static Bitmap dikeykenar(Bitmap b)
        {
            int[,] a = { { 1, 1, 1 }, { 0, 0, 0 }, { -1, -1, -1 } };
            int s = 0;
            for (int i = 1; i < b.Width - 1; i++)
            {
                for (int j = 1; j < b.Height - 1; j++)
                {
                    for (int k = -1; k < 2; k++)
                    {
                        for (int n = -1; n < 2; n++)
                        {
                            s += b.GetPixel(i + k, j + n).R * a[k + 1, n + 1];
                        }
                    }
                    s = Math.Abs(s / 3);
                    b.SetPixel(i - 1, j - 1, Color.FromArgb(s, s, s));
                    s = 0;
                }
            }
            return b;
        }
        public static Bitmap yataykenar(Bitmap b)
        {
            int[,] a = { { 1, 0, -1 }, { 1, 0, -1 }, { 1, 0, -1 } };
            int s = 0;
            for (int i = 1; i < b.Width - 1; i++)
            {
                for (int j = 1; j < b.Height - 1; j++)
                {
                    for (int k = -1; k < 2; k++)
                    {
                        for (int n = -1; n < 2; n++)
                        {
                            s += b.GetPixel(i + k, j + n).R * a[k + 1, n + 1];
                        }
                    }
                    s = Math.Abs(s / 3);
                    b.SetPixel(i - 1, j - 1, Color.FromArgb(s, s, s));
                    s = 0;
                }
            }
            return b;
        }
        public static Bitmap kenar(Bitmap b1, Bitmap b2, Bitmap c)
        {
            int a = 0;
            for (int i = 0; i < c.Width; i++)
            {
                for (int j = 0; j < c.Height; j++)
                {
                    a = b1.GetPixel(i, j).R + b2.GetPixel(i, j).R;
                    if (a > 255) a = 255;
                    c.SetPixel(i, j, Color.FromArgb(a, a, a));
                }
            }
            return c;
        }
        public static Bitmap cikar(Bitmap resim, Bitmap kenar, Bitmap c, int th)
        {
            int a = 0;
            int r = 0;
            int g = 0;
            int b = 0;
            for (int i = 0; i < c.Width; i++)
            {
                for (int j = 0; j < c.Height; j++)
                {
                    a = kenar.GetPixel(i, j).R;
                    if (a > th) { a = 255; }
                    else a = 0;
                    r = resim.GetPixel(i, j).R - a;
                    g = resim.GetPixel(i, j).G - a;
                    b = resim.GetPixel(i, j).B - a;
                    if (r < 0) r = 0;
                    if (g < 0) g = 0;
                    if (b < 0) b = 0;

                    c.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            return c;
        }
        public static Bitmap ters(Bitmap b)
        {
            int red, green, blue;
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    red = 255 - b.GetPixel(i, j).R;
                    green = 255 - b.GetPixel(i, j).G;
                    blue = 255 - b.GetPixel(i, j).B;

                    b.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            }
            return b;
        }
        public static Bitmap KarincaGiderme(Bitmap b)
        {
            int[] m_R = new int[9];
            int[] m_G = new int[9];
            int[] m_B = new int[9];

            int[,] n_R = new int[3, 3];
            int[,] n_G = new int[3, 3];
            int[,] n_B = new int[3, 3];
            int a1 = 0;
            for (int i = 0; i < b.Width - 2; i++)
            {
                for (int j = 0; j < b.Height - 2; j++)
                {
                    for (int a = 0; a < 3; a++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            n_R[a, k] = b.GetPixel(i + a, j + k).R;
                            n_G[a, k] = b.GetPixel(i + a, j + k).G;
                            n_B[a, k] = b.GetPixel(i + a, j + k).B;

                        }
                    }
                    for (int i1 = 0; i1 < 3; i1++)
                    {
                        for (int i2 = 0; i2 < 3; i2++)
                        {
                            m_R[a1] = n_R[i1, i2];
                            m_G[a1] = n_G[i1, i2];
                            m_B[a1] = n_B[i1, i2];
                            a1++;
                        }
                    }
                    a1 = 0;
                    sirala(m_R);
                    sirala(m_G);
                    sirala(m_B);

                    b.SetPixel(i + 1, j + 1, Color.FromArgb(m_R[4], m_G[4], m_B[4]));
                }
            }


            return b;
        }
        public static void sirala(int[] dizi)
        {

            for (int i = 0; i < dizi.Length - 1; i++)
            {
                for (int j = 1; j < dizi.Length - i; j++)
                {
                    if (dizi[j] < dizi[j - 1])
                    {
                        int gecici = dizi[j - 1];
                        dizi[j - 1] = dizi[j];
                        dizi[j] = gecici;
                    }
                }
            }

        }
        public static void karikaturizasyon(Bitmap b)
        {

            for (int i = 1; i < b.Width - 2; i++)
            {
                for (int j = 1; j < b.Height - 2; j++)
                {

                    int R = b.GetPixel(i, j).R;
                    int G = b.GetPixel(i, j).G;
                    int B = b.GetPixel(i, j).B;


                    if (R <= 50) R = 20;
                    if (G <= 50) G = 20;
                    if (B <= 50) B = 20;
                    if (R > 50 && R <= 100) R = 75;
                    if (G > 50 && G <= 100) G = 75;
                    if (B > 50 && B <= 100) B = 75;
                    if (R > 100 && R <= 150) R = 125;
                    if (G > 100 && G <= 150) G = 125;
                    if (B > 100 && B <= 150) B = 125;
                    if (R > 150 && R <= 200) R = 175;
                    if (G > 150 && G <= 200) G = 175;
                    if (B > 150 && B <= 200) B = 175;
                    if (R > 200 && R <= 255) R = 230;
                    if (G > 200 && G <= 255) G = 230;
                    if (B > 200 && B <= 255) B = 230;


                    b.SetPixel(i, j, Color.FromArgb(R, G, B));


                }
            }
        }
        public static void karikaturizasyon_G(Bitmap b)
        {
            int[,] gaussian = { { 1, 2, 1 }, { 2, 4, 2 }, { 1, 2, 1 } };


            for (int i = 1; i < b.Width - 2; i++)
            {
                for (int j = 1; j < b.Height - 2; j++)
                {

                    int R = 0;
                    int G = 0;
                    int B = 0;

                    for (int a = -1; a < 2; a++)
                    {
                        for (int k = -1; k < 2; k++)
                        {
                            R += b.GetPixel(i + a, j + k).R * gaussian[a + 1, k + 1];
                            G += b.GetPixel(i + a, j + k).G * gaussian[a + 1, k + 1];
                            B += b.GetPixel(i + a, j + k).B * gaussian[a + 1, k + 1];
                        }

                    }
                    R /= 16;
                    G /= 16;
                    B /= 16;
                    b.SetPixel(i, j, Color.FromArgb(R, G, B));

                }
            }
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        public static void YCbCr(Bitmap b, int crmin, int crmax, int cbmin, int cbmax)
        {
            byte Y;
            byte Cb;
            byte Cr;
            float r1;
            float g1;
            float b1;

            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    r1 = (float)b.GetPixel(i, j).R;
                    g1 = (float)b.GetPixel(i, j).G;
                    b1 = (float)b.GetPixel(i, j).B;

                    Y = (byte)(0.2989 * r1 + 0.5866 * g1 + 0.1145 * b1);
                    Cb = (byte)(-0.169 * r1 - 0.3313 * g1 + 0.5000 * b1);
                    Cr = (byte)(0.5 * r1 - 0.4184 * g1 - 0.0816 * b1);
                    if (Cr > crmin && Cr < crmax && Cb > cbmin && Cb < cbmax)
                        b.SetPixel(i, j, Color.FromArgb((int)r1, (int)g1, (int)b1));
                    else
                        b.SetPixel(i, j, Color.FromArgb(255, 255, 255));

                }
            }
        }
        public static void deriboya(Bitmap b)
        {
            int r1 = 0, g1 = 0, b1 = 0, a = 0;
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    if (b.GetPixel(i, j).R < 250)
                    {
                        r1 += b.GetPixel(i, j).R;
                        g1 += b.GetPixel(i, j).G;
                        b1 += b.GetPixel(i, j).B;
                        a++;
                    }

                }
            }

            r1 /= a;
            g1 /= a;
            b1 /= a;

            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    if (b.GetPixel(i, j).R < 250)
                    {
                        b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                    }

                }
            }
        }
        public static void sonhali(Bitmap karikatur, Bitmap deri, Bitmap sonuc)
        {
            for (int i = 0; i < karikatur.Width; i++)
            {
                for (int j = 0; j < karikatur.Height; j++)
                {
                    int R = karikatur.GetPixel(i, j).R;
                    int G = karikatur.GetPixel(i, j).G;
                    int B = karikatur.GetPixel(i, j).B;
                    if (deri.GetPixel(i, j).R > 250 || karikatur.GetPixel(i, j).R < 50)
                    {

                        sonuc.SetPixel(i, j, Color.FromArgb(R, G, B));

                    }
                    else

                        sonuc.SetPixel(i, j, Color.FromArgb(deri.GetPixel(i, j).R, deri.GetPixel(i, j).G, deri.GetPixel(i, j).B));
                }

            }
        }
        public static void renklendir(Bitmap b)
        {
            Random rastgele = new Random();
            int a = 0, d= 0, f = 0;
            int deger;
            int deger2;
            int deger3;
            deger = rastgele.Next(220);
            deger2 = rastgele.Next(220);
            deger3 = rastgele.Next(220);
            for (int i = 0; i < b.Width; i++)
            {
                for(int j = 0; j < b.Height; j++)
                {
                    a =  b.GetPixel(i, j).R;
                    d = b.GetPixel(i, j).G;
                    f = b.GetPixel(i, j).B;
                    if (a < 50 || d<50 || f<50) { 

                        b.SetPixel(i, j, Color.FromArgb(deger, deger2, deger3));
                    }
                    else if (a < 150 || d < 150 || f < 150)
                    {

                        b.SetPixel(i, j, Color.FromArgb(deger2, deger, deger3));
                    }
                    else if (a < 220 || d < 220 || f < 220)
                    {

                        b.SetPixel(i, j, Color.FromArgb(deger3, deger, deger2));
                    }
                }
            }
        }
        public static void kenar_renk(Bitmap resim, Bitmap renk, Bitmap s)
        {
            int a, b, c,d,e,f;
            for (int i = 0; i < s.Width; i++)
            {
                for (int j = 0; j < s.Height; j++)
                {
                    a = renk.GetPixel(i, j).R;
                    b = renk.GetPixel(i, j).G;
                    c = renk.GetPixel(i, j).B;
                    d = resim.GetPixel(i, j).R;
                    e = resim.GetPixel(i, j).G;
                    f = resim.GetPixel(i, j).B;
                    if (a > 180 && b > 180 && c > 180)
                    {
                        s.SetPixel(i, j, Color.FromArgb(d, e, f));
                    }
                    else
                        s.SetPixel(i, j, Color.FromArgb(a, b, c));
                }
            }

        }
        public static void yarim(Bitmap resim, Bitmap kenar, Bitmap s)
        {
            int d, e, f;
            for (int i = 0; i < s.Width; i++)
            {
                for (int j = 0; j < s.Height; j++)
                {
                    
                    if (i < s.Width/2)
                    {
                        d = resim.GetPixel(i, j).R;
                        e = resim.GetPixel(i, j).G;
                        f = resim.GetPixel(i, j).B;
                    }
                    else {
                        d = kenar.GetPixel(i, j).R;
                        e = kenar.GetPixel(i, j).G;
                        f = kenar.GetPixel(i, j).B;
                    }


                    s.SetPixel(i, j, Color.FromArgb(d, e, f));
                   
                }
            }
        }

    }
}

