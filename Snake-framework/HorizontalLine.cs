using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Snake_framework
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int XReight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= XReight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}

