using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Drawing;



namespace mass_groundstation_v2.helper
{
    public class direct_bitmap
    {
        public Bitmap Bitmap { get; private set; }
        public byte[] Bits { get; private set; }
        public bool Disposed { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }

        protected GCHandle BitsHandle { get; private set; }

        public direct_bitmap(int width, int height)
        {
            Width = width;
            Height = height;
            Bits = new byte[width * height * 4];
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppArgb, BitsHandle.AddrOfPinnedObject());
        }

        public void SetPixel(int x, int y, Color colour)
        {
            int index = x + (y * Width);
            int col = colour.ToArgb();

            // Bits[index] = col;
        }

        public void SetLine(int y, byte[] line)
        {

            if(line[1] == 1)
            {
               

                for (int i = 0; i < Width; i++)
                {
                    byte col_byte = line[i];


                    Bits[i * 4 + Width * y * 2 * 4] = col_byte;
                    Bits[i * 4 + 1 + Width * y * 2 * 4] = col_byte;
                    Bits[i * 4 + 2 + Width * y * 2 * 4] = col_byte;
                    Bits[i * 4 + 3 + Width * y * 2 * 4] = 255;

                    Bits[i * 4 + Width * (y * 2 + 1) * 4] = col_byte;
                    Bits[i * 4 + 1 + Width * (y * 2 + 1) * 4] = col_byte;
                    Bits[i * 4 + 2 + Width * (y * 2 + 1) * 4] = col_byte;
                    Bits[i * 4 + 3 + Width * (y * 2 + 1) * 4] = 255;

                }

            }
            else
            {
                var start_pos = Width - 440;

                int pixel_pos = 0;

                for (int i = start_pos; i < Width; i++)
                {
                    byte col_byte = line[i];

                    Bits[pixel_pos * 4 + Width * y * 2 * 4] = col_byte;
                    Bits[pixel_pos * 4 + 1 + Width * y * 2 * 4] = col_byte;
                    Bits[pixel_pos * 4 + 2 + Width * y * 2 * 4] = col_byte;
                    Bits[pixel_pos * 4 + 3 + Width * y * 2 * 4] = 255;

                    Bits[pixel_pos * 4 + Width * (y * 2 + 1) * 4] = col_byte;
                    Bits[pixel_pos * 4 + 1 + Width * (y * 2 + 1) * 4] = col_byte;
                    Bits[pixel_pos * 4 + 2 + Width * (y * 2 + 1) * 4] = col_byte;
                    Bits[pixel_pos * 4 + 3 + Width * (y * 2 + 1) * 4] = 255;

                    pixel_pos++;

                }

                for (int i = 0; i < start_pos; i++)
                {
                    byte col_byte = line[i];

                    Bits[pixel_pos * 4 + Width * y * 2 * 4] = col_byte;
                    Bits[pixel_pos * 4 + 1 + Width * y * 2 * 4] = col_byte;
                    Bits[pixel_pos * 4 + 2 + Width * y * 2 * 4] = col_byte;
                    Bits[pixel_pos * 4 + 3 + Width * y * 2 * 4] = 255;

                    Bits[pixel_pos * 4 + Width * (y * 2 + 1) * 4] = col_byte;
                    Bits[pixel_pos * 4 + 1 + Width * (y * 2 + 1) * 4] = col_byte;
                    Bits[pixel_pos * 4 + 2 + Width * (y * 2 + 1) * 4] = col_byte;
                    Bits[pixel_pos * 4 + 3 + Width * (y * 2 + 1) * 4] = 255;
                    pixel_pos++;
                }

            }
        }

        public Color GetPixel(int x, int y)
        {
            int index = x + (y * Width);
            int col = Bits[index];
            Color result = Color.FromArgb(255);

            return result;
        }

        public void Dispose()
        {
            if (Disposed) return;
            Disposed = true;
            Bitmap.Dispose();
            BitsHandle.Free();
        }
    }
}
