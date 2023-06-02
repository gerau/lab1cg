using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab1cg
{
    static class DrawingLogic
    {
        public static void drawPixel(this Bitmap bitmap, int x0, int y0, Color color)//  Метод малювання великого пікселя 16х16
        {
            if((bitmap.Height%16 != 0) || bitmap.Width%16 != 0)
            {
                return;
            }
            for(int x = x0*16; x <= x0*16 + 15; x++)
            {
                for(int y = y0*16; y <= y0*16 + 15; y++)
                {
                    bitmap.SetPixel(x, y, color);
                }
            }
        }
        public static void drawLine(this Bitmap bitmap, int x0, int y0, int x1, int y1, Color color)// метод малювання лінії(взяв алгоритм з методички)
                                                                                                    // за довільними координатами, які дозволяє розмір bitmap'и
        {
            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);
            int x = x0; int y = y0;
            int rx; int ry;

            if(dx >= dy)
            {
                if(dx == 0) bitmap.drawPixel(x0,y0, color);
                else
                {
                    ry = dx / 2;
                    for(int i = 0; i <= dx; i++)
                    {
                        bitmap.drawPixel(x, y, color);
                        if (x0 < x1) x++;
                        if (x0 > x1) x--;
                        ry += dy;
                        if (ry >= dx)
                        {
                            ry -= dx;
                            if(y0 < y1) y++;
                            if (y0 > y1) y--;
                        }
                    }
                }
            }
            else
            {
                if (dy == 0) bitmap.drawPixel(x0, y0, color);
                else
                {
                    rx = dy / 2;
                    for (int i = 0; i <= dy; i++)
                    {
                        bitmap.drawPixel(x, y, color);
                        if (y0 < y1) y++;
                        if (y0 > y1) y--;
                        rx += dx;
                        if (rx >= dy)
                        {
                            rx -= dy;
                            if (x0 < x1) x++;
                            if (x0 > x1) x--;
                        }
                    }
                }
            }
        }
    }
}
