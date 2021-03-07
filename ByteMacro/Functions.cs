using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ByteMacro
{
    public class Functions
    {
        public void pressSpaceBar()
        {
            SendKeys.SendWait(" "); //spacebar
        }

        public Point pixelSearch(int x1, int y1, int x2, int y2, Color col)
        {
            bool notFound = true;

            int minVal = y1 * 1000 + x1; // example value for coordinates 100,200 would be:
            int maxVal = y2 * 1000 + x2; // 100200
            Point pos = new Point(0, 0);

            for(int i = minVal; i <= maxVal; i++)
            {
                int yPos = i / 1000; //integer division will return x position eg. 100200/1000=100(.200)(cuz int division)
                int xPos = i - ((i / 1000) * 1000);//get the only x part then subtract it from actual value to get y position
                pos.X = xPos;
                pos.Y = yPos;
                if (getPixel(pos) == col)
                {
                    notFound = false;
                    break;
                }
            }
            if (notFound) return new Point(-1, -1);
            else return pos;
        }

        public void setCursorPos(Point pos)
        {
            Console.SetCursorPosition(pos.X, pos.Y);
        }

        public Color getPixel(Point position)
        {
            using (var bitmap = new Bitmap(1, 1))
            {
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(position, new Point(0, 0), new Size(1, 1));
                }
                return bitmap.GetPixel(0, 0);
            }
        }
    }
}
