using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace karuygulaması
{
    public class KarTanesi
    {
        private int x, y;

        public KarTanesi(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public void kar_dus()
        {
            y += 15;
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }
    }
}
