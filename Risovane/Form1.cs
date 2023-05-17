namespace Risovane
{
    public partial class Form1 : Form
    {
        private int width = 400;
        private int height = 400;
        private int x = 0;
        private int y = 0;
        int xo, yo;
        Random rnd = new Random();
        int r, g, b;
        void RndColor()
        {
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
        }
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(width, height);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RndColor();
            pictureBox1.BackColor = Color.White;
            y = 0;
            for (x = 0; x < height; x++)
            {
                ((Bitmap)pictureBox1.Image).SetPixel(x, y, Color.FromArgb(r, g, b));
                y++;
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RndColor();
            pictureBox1.BackColor = Color.White;
            y = width - 1;
            for (x = 0; x < height; x++)
            {
                ((Bitmap)pictureBox1.Image).SetPixel(x, y, Color.FromArgb(r, g, b));
                y--;
            }
            pictureBox1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RndColor();
            pictureBox1.BackColor = Color.White;
            y = width / 2;
            for (x = 0; x < height; x++)
            {
                ((Bitmap)pictureBox1.Image).SetPixel(x, y, Color.FromArgb(r, g, b));
            }
            pictureBox1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RndColor();
            pictureBox1.BackColor = Color.White;
            x = width / 2;
            for (y = 0; y < height; y++)
            {
                ((Bitmap)pictureBox1.Image).SetPixel(x, y, Color.FromArgb(r, g, b));
            }
            pictureBox1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RndColor();
            pictureBox1.BackColor = Color.Black;
            x = rnd.Next(0, 400);
            y = rnd.Next(0, 400);
            ((Bitmap)pictureBox1.Image).SetPixel(x, y, Color.FromArgb(r, g, b));
            pictureBox1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(width, height);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RndColor();
            pictureBox1.BackColor = Color.White;
            int xo = 200, yo = 200;
            double r1 = rnd.Next(0, xo), r2 = Math.Pow(r1, 2);
            for (int i = xo - (int)r1; i <= xo + r1; i++)
            {
                for (int j = yo - (int)r1; j <= yo + r1; j++)
                {
                    if (Math.Abs(Math.Pow(i - xo, 2) + Math.Pow(j - yo, 2) - r2) <= r1)
                    {
                        ((Bitmap)pictureBox1.Image).SetPixel(i, j, Color.FromArgb(r, g, b));
                    }
                }
            }
            pictureBox1.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RndColor();
            pictureBox1.BackColor = Color.White;
            xo = rnd.Next(75, 315); yo = rnd.Next(75, 315);
            double r1 = rnd.Next(0, 75), r2 = Math.Pow(r1, 2);
            for (int i = xo - (int)r1; i <= xo + r1; i++)
            {
                for (int j = yo - (int)r1; j <= yo + r1; j++)
                {
                    if (Math.Abs(Math.Pow(i - xo, 2) + Math.Pow(j - yo, 2) - r2) <= r1)
                    {
                        ((Bitmap)pictureBox1.Image).SetPixel(i, j, Color.FromArgb(r, g, b));
                    }
                }
            }
            pictureBox1.Refresh();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            int h = 1;
            int w = 0;
            Graphics grrra = Graphics.FromImage((Bitmap)pictureBox1.Image);
            Pen punpun = new Pen(Color.Black, 1);
            for (int step = 1; step < height; step *= 3)
            {
                h *= 2;
                w += h;
                int eto = (200 - (w / 2));
                grrra.DrawEllipse(punpun, eto, step, w, h);
                pictureBox1.Refresh();
                if (step > 1)
                    step -= 1;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            int h = 100;
            int w = 200;
            Graphics grrra = Graphics.FromImage((Bitmap)pictureBox1.Image);
            Pen punpun = new Pen(Color.Black, 1);
            for (int step = 1; step < height; step += 32)
            {
                int eto = (200 - (w / 2));
                grrra.DrawEllipse(punpun, eto, step, w, h);
                pictureBox1.Refresh();
            }
        }
    }
}