using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        int headX = 100;
        int headY = 100;
        int directionX = 1;
        int directionY = 0;
        int stepCounter = 0;
        int snakeLength = 5;

        List<SnakeSegment> snake = new List<SnakeSegment>();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            headX += directionX * SnakeSegment.SnakeSegmentSize;
            headY += directionY * SnakeSegment.SnakeSegmentSize;
            var newHead = new SnakeSegment(stepCounter) { Left = headX, Top = headY };
            foreach (var segment in snake) //??
            {
                if (segment.Top == headY && segment.Left == headX)
                {
                    timer1.Enabled = false;
                }
            }
            // Farokvágás
            if (snake.Count() > snakeLength)
            {
                var farok = snake[0]; // Snakesegment farok = snake.First()
                snake.Remove(farok); // snake.Removeat(0);
                Controls.Remove(farok);
            }
            

            Controls.Add(newHead);
            snake.Add(newHead);
            stepCounter++;

            if (stepCounter % 5 == 0)
            {
                snakeLength++;
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { directionX = 0; directionY = -1; }
            if (e.KeyCode == Keys.Down) { directionX = 0; directionY = 1; }
            if (e.KeyCode == Keys.Right) { directionX = 1; directionY = 0; }
            if (e.KeyCode == Keys.Left) { directionX = -1; directionY = 0; }
        }
    }
}
