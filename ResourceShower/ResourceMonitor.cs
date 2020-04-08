using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceShower
{
    public class ResourceMonitor
    {
        private List<Canva> canvas;

        private Graphics g, g2, g3;
        private Bitmap b, b2, b3;

        private int prev_value;

        private int gap;

        public ResourceMonitor(List<Canva> canvas)
        {
            this.canvas = canvas;

            g = canvas[0].g;
            g2 = canvas[1].g;
            g3 = canvas[2].g;

            b = canvas[0].b;
            b2 = canvas[1].b;
            b3 = canvas[2].b;

            this.gap = Form1.gap;
        }

        public Bitmap Ddraw(int value, bool smooth, Pen pen, Font font)
        {
            int new_gap = Form1.gap;

            if (gap != new_gap) {
                g.Clear(Color.FromArgb(18, 53, 84));
                g2.Clear(Color.FromArgb(18, 53, 84));
                g3.Clear(Color.FromArgb(18, 53, 84));
                gap = new_gap;
            }

            g2.Clear(Color.FromArgb(18, 53, 84));
            g2.DrawImage(b, -gap, 0);

            g.DrawImage(b2, 0, 0);

            if (smooth)
            {
                int temp = value;
                prev_value = (prev_value+temp)/2;
            }
            else
            {
                prev_value = value;
            }

            int pc = prev_value;

            g.DrawLine(pen, 199, (100 - pc) / 2, 199, 50);

            g3.DrawImage(b, 0, 0);
            g3.DrawString(pc + " %", font, Brushes.AliceBlue, 95, 20);
            return b3;
        }
    }
}
