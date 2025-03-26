using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    internal class SnakeSegment : PictureBox
    {
        public static int SnakeSegmentSize { get; set; } = 20;
        public SnakeSegment()
        {
            BackColor = Color.Fuchsia;
            Height = SnakeSegmentSize;
            Width = SnakeSegmentSize;
        }
        public SnakeSegment(int step)
        {
            Height = SnakeSegmentSize;
            Width = SnakeSegmentSize;
            if (step % 2 ==0)
            {
                BackColor = Color.Fuchsia;
            }
            else
            {
                BackColor = Color.Pink;
            }
        }
    }
}
