using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace elte_diffuzgazmodell
{
    class DiffuzGazModell
    {
        /// <summary>
        /// ez a modell igazából. 
        /// 0: üres
        /// 1: gáz
        /// 2: fal
        /// </summary>
        int[,] t;
        double g;
        int m;
        int N;
        int M;
        PictureBox pb;
        Bitmap bmp;
        public bool szimuláció_fut;
        Random r;
        CheckBox debug;

        public DiffuzGazModell(int N, int M, double g, int m, PictureBox pb, Bitmap bmp, CheckBox debug)
        {
            r = new Random();
            szimuláció_fut = false;
            this.N = N;
            this.M = M;
            this.g = g;
            this.m = m;
            this.pb = pb;
            this.bmp = bmp;
            this.debug = debug;

            if (m > N * M)
                m = N * M;

            t = new int[N, M];
        }

        public void Teszt()
        {
            while (szimuláció_fut)
            {
                Egyet_lép();
            }
        }

        public void Egyet_lép()
        {
            Mozog(Véletlenhely());

            pb.Refresh();
        }

        string Stringbe()
        {
            string s = "";
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    s += t[i, j];
                }
                s += "\n";
            }
            return s;
        }
        (int, int) Véletlenhely()
        {
            return (r.Next(N), r.Next(M));
        }

        List<(int, int)> szomszedok = new List<(int, int)> {
            (-1, -1),
            (-1, 0),
            (-1, 1),
            (0, -1),
            (0, 1),
            (1, -1),
            (1, 0),
            (1, 1) 
        };

        (int, int) Véletlenirány()
        {
            return szomszedok[r.Next(8)];
        }

        void Mozog((int,int) pár)
        {
            (int i, int j) = pár;
            (int im, int jm) = Véletlenirány();
            int ti = i+im;
            int tj = j+jm;
            if (ti < 0 || N <= ti)
                ti = i;
            if (tj < 0 || M <= tj)
                tj = j;

            (t[i, j], t[ti, tj]) = (t[ti, tj], t[i, j]);
            if (debug.Checked && t[ti, tj]!=t[i, j])
            {
                MessageBox.Show($"Valódi csere történt: (t[{i}, {j}], t[{ti}, {tj}]) = (t[{ti}, {tj}], t[{i}, {j}]), ({t[i, j]}, {t[ti, tj]}) = ({t[ti, tj]}, {t[i, j]})\n" + Stringbe());
                int a = 0;
            }
            Kirajzol(i, j);
            Kirajzol(ti, tj);

        }

        public void Inicializál()
        {
            int i = 0;
            int j = 0;
            for (int k = 0; k < m; k++)
            {
                t[i, j] = 1;
                j++;
                i += j / M;
                j %= M;
            }
        }


        void Kirajzol(int i, int j)
        {
            switch (t[i, j])
            {
                case 0:
                    bmp.SetPixel(i, j, Color.White);
                    break;

                case 1:
                    bmp.SetPixel(i, j, Color.Black);
                    break;

                case 2:
                    bmp.SetPixel(i, j, Color.Red);
                    break;

                default:
                    break;
            }
        }

        public void Egész_kirajzolása()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Kirajzol(i, j);
                }
            }
        }
    }
}
