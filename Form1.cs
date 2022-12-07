using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections;

namespace karuygulaması
{
    public partial class Form1 : Form
    {
        List<KarTanesi> Kar_List; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kar_List = new List<KarTanesi>();//Liste hazır            
        }

        private void KarTanesiYarat(int x, int y)
        {
            Label LBL_X = new System.Windows.Forms.Label();
            LBL_X.Location = new System.Drawing.Point(x, y);
            LBL_X.Text = "*";
            LBL_X.AutoSize = true;
            LBL_X.Name = "LBL_1";
            this.Controls.Add(LBL_X);
        }     

        //istenildiği kadar kar tanesi yaratır.
        private void RastgeleKarTaneleriYarat(int sayi)
        {
            Random _r = new Random();
            for (int i = 0; i < sayi; i++)
            {
                int x = _r.Next(this.Width);
                KarTanesiYarat(x, 1);
                Kar_List.Add(new KarTanesi(x, 1));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RastgeleKarTaneleriYarat(5);
            int i = 0;
            while (true)
            {
                try
                {
                     if (i == this.Controls.Count)
                        break;   

                    KarTanesi _kt = Kar_List[i];
                    _kt.kar_dus();
                    Label LBL_X = (Label)this.Controls[i];

                    if (_kt.Y >= this.Height)
                    {
                        Kar_List.RemoveAt(i);
                        this.Controls.Remove(LBL_X);
                        LBL_X = null;
                    }
                    else
                    {
                        LBL_X.Location = new System.Drawing.Point(_kt.X, _kt.Y);
                        Kar_List[i] = _kt;
                        i++; 
                    }  
                                     
                }
                catch
                {
                }              
            }          
        }
    }
}
