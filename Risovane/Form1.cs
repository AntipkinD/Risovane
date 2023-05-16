namespace Risovane
{
    public partial class Form1 : Form
    {
        private int width = 400;
        private int height = 400;
        private int x = 0;
        private int y = 0;
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
    }
}