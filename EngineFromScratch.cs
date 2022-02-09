using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;


namespace EngineFromScratch
{
    public class Canvas : Form
    {
        public Canvas()
        {
            this.DoubleBuffered = true;
        }
    }

    class Engine
    {
        public Canvas Window = new Canvas(); // window object
        public Shape2D Player = new Shape2D(new Vector2D(10f, 10f), new Vector2D(500f, 500f));

        public Engine()
        {
            Window.Size = new Size(1360, 768); // the resolution of the window
            Window.BackColor = Color.Aqua;
            Window.Text = "EngineFromScratch"; //name on the upper left cornet of the window
            Window.Paint += Render; // specific built in implementation, this way, the rendered objects can appear at any time

            Thread GameLoopThread = new Thread(GameLoop); // game loop needs another thread to be able to run simultaneously with rendering
            GameLoopThread.Start();

            Application.Run(Window);
        }

        public void GameLoop()
        {
            while (true)
            {
                Window.Refresh();
                Console.WriteLine("cs");

                Player.Position.x += 1;
            }
        }

        private void Render(object sender, PaintEventArgs e) // the Rended method needs to be implemented in a specific way
        {
            Graphics g = e.Graphics;
            g.FillRectangle(new SolidBrush(Color.Red), (int)Player.Position.x, (int)Player.Position.y, (int)Player.Scale.x, (int)Player.Scale.y);
        }
    }
}
