using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Box
    {
        // C#에서는 속성(Property)

        private int width;

        public int Width
        {
            get { return width; }
            set { 
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("너비는 자연수로 초기화해주세요");
                }
            }
        }

        private int height;

        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("높이는 자연수로 초기화해주세요");
                }
            }
        }

        public int Area
        {
            get { return Width * Height; }
        }


        public Box(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
