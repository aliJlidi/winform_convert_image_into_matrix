using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsImgPross
{
    class Converting
    {
        
        public Converting()
        {

        }

        public static float[,] ConvertToMatrix(Bitmap b)
        {
           float[,] pixels = new float[b.Width,b.Height];
           for(int i=0; i<b.Width;i++)
                for(int j=0; j<b.Height; j++)
                {
                    Color cl = b.GetPixel(i, j);
                    int rl = cl.R;
                    int gl = cl.G;
                    int b1 = cl.B;
                    float gray =(float)( .299 * rl + .587 * gl + .114 * b1);
                    pixels[i, j] =(gray==255)?0:(gray/256);
                 
                }
            return pixels;
        }
    }
}
