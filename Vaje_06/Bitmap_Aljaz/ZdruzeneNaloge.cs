using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bitmap_Aljaz
{
    class ZdruzeneNaloge
    {
        static void Main(string[] args)
        {
            Bitmap slika = new Bitmap(@"..\..\slika_liam.jpg");
            Bitmap obrnjena = obrezi_in_obrni(slika);
            Bitmap zrcaljena = zrcali(slika);

        }
        static Bitmap obrezi_in_obrni(Bitmap slika)
        {
            Rectangle rec = new Rectangle(600, 250, 600, 600);
            Bitmap obrezana_slika = slika.Clone(rec, slika.PixelFormat);
            obrezana_slika.RotateFlip(RotateFlipType.Rotate180FlipX);
            obrezana_slika.Save(@"..\..\obrezan_liam.jpg");
            return obrezana_slika;
        }

        static Bitmap zrcali(Bitmap slika)
        {

            Bitmap zrcaljena = (Bitmap)slika.Clone();
            for (int i = 0; i < zrcaljena.Height; i++)
            {
                for (int j = 0; j < zrcaljena.Width / 2; j++)
                {
                    Color barva = zrcaljena.GetPixel(zrcaljena.Width - j - 1, i);
                    zrcaljena.SetPixel(j, i, barva);
                }
            }
            zrcaljena.Save(@"..\..\zrcaljen_liam.jpg");
            return zrcaljena;

        }
    }
}
