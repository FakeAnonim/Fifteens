using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fifteen
{
    public partial class Form1 : Form
    {
        FishManager fishManager;
        Graphics graphics;
        Int32 fishSize;
        Brush fishBrush;
        Brush emptyBrush;
        Font font;

        public Form1()
        {
            InitializeComponent();

            fishManager = FishManager.GetInstance(10);
            fishSize = 50;
            fishBrush = new SolidBrush(Color.Green);
            emptyBrush = new SolidBrush(this.BackColor);
            graphics = this.CreateGraphics();
            font = new Font("Arial", 18);

            Overdraw();
        }

        private void fish_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
            {
                b.Location = new Point(b.Location.X + 20, b.Location.Y);
            }
        }

        private void Overdraw()
        {
            /*
             * Do not use graphics.Clear(this.BackColor);
             * in other case image will twinkle
             * */
            for (int i = 0; i < fishManager.Fishes.Count - 1; i++)
            {
                graphics.FillRectangle(
                            fishBrush,
                            new Rectangle(
                                fishManager.Fishes[i].Location.X * fishSize,
                                fishManager.Fishes[i].Location.Y * fishSize,
                                fishSize - 1,
                                fishSize - 1)
                    );
                graphics.DrawString(
                            fishManager.Fishes[i].Value.ToString(), 
                            font, 
                            emptyBrush, 
                            (Single)(fishManager.Fishes[i].Location.X * fishSize + 3), 
                            (Single)(fishManager.Fishes[i].Location.Y * fishSize + 20)
                    );
            }

            // Decolorize empty fish
            graphics.FillRectangle(
                            emptyBrush, 
                            new Rectangle(
                                Fish.EmptyField.Location.X * fishSize, 
                                Fish.EmptyField.Location.Y * fishSize, 
                                fishSize - 1, 
                                fishSize - 1)
                    );
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Overdraw();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            fishManager.Move(new Coordinates(
                                    (Int32)Math.Floor((Single)(e.X / fishSize)),
                                    (Int32)Math.Floor((Single)(e.Y / fishSize))));
            Overdraw();
        }
    }
}
