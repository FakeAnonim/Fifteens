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
        Int32 fishCount;
        FishManager fishManager;
        Graphics graphics;
        Int32 fishSize;
        Brush fishBrush;
        Brush emptyBrush;
        Font font;
        Boolean mouseButtonDown;
        Point startMousePosition;

        public Form1()
        {
            InitializeComponent();

            fishCount = 4;
            fishManager = FishManager.GetInstance(fishCount);
            fishSize = 50;
            fishBrush = new SolidBrush(Color.Black);
            emptyBrush = new SolidBrush(this.BackColor);
            graphics = panelFishes.CreateGraphics();
            font = new Font("Arial", 18);

            /*
             * Drawing form
             * */
            panelFishes.Width = fishCount * fishSize;
            panelFishes.Height = fishCount * fishSize;
            this.Width = panelFishes.Width + 10;
            // fishPanel.Height + space + topPanel + bottomPanel
            this.Height = panelFishes.Height + 10 + 20 + 2;

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

        private void fishPanel_MouseClick(object sender, MouseEventArgs e)
        {
            fishManager.Move(new Coordinates(
                                    (Int32)Math.Floor((Single)(e.X / fishSize)),
                                    (Int32)Math.Floor((Single)(e.Y / fishSize))));
            Overdraw();
        }

        private void Pan_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pan_Close_MouseEnter(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.Brown;
        }

        private void Pan_Close_MouseLeave(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.Maroon;
        }

        private void panelMinimize_MouseEnter(object sender, EventArgs e)
        {
            panelMinimize.BackColor = Color.DarkGray;
        }

        private void panelMinimize_MouseLeave(object sender, EventArgs e)
        {
            panelMinimize.BackColor = Color.DimGray;
        }

        private void panelMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelUpper_MouseDown(object sender, MouseEventArgs e)
        {
            mouseButtonDown = true;
            startMousePosition = new Point(e.X, e.Y);
        }

        private void panelUpper_MouseUp(object sender, MouseEventArgs e)
        {
            mouseButtonDown = false;
        }

        private void panelUpper_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseButtonDown)
            {
                Int32 deltaX = e.X - startMousePosition.X;
                Int32 deltaY = e.Y - startMousePosition.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }
    }
}
