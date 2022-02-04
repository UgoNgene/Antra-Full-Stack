using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorandBall
{

    public class Color
    {

        private int red ;
        private int green;
        private int blue;
        private int alpha;

        public Color()
        {
            Console.WriteLine("this is base class without parameter constructor");
        }
        public Color(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }

        public int Red {
            get { return red; }
            set { if(red>=0 && red <= 255) { red = value; } } 
        }
        public int Blue {
            get { return blue; }
            set { if (blue >= 0 && blue <= 255) { blue = value; } }
        }
        public int Green {
            get { return green; }
            set { if (green >= 0 && green <= 255) { green = value; } }
        }
        public int Alpha {
            get { return alpha; }
            set { if (alpha >= 0 && alpha <= 255) { alpha = value; } }
        }

        public double CalculateGrayScale()
        {
            double greyScale = (this.red + this.blue + this.green) / 3;

            return greyScale;
        }
    }

    
    class Ball
    {
        private int size;
        private Color color;
        int numThrows = 0;
        public Ball()
        {
            this.color = new Color();
        }
        
        public Ball(int size, Color color)
        {
            this.size = size;
            this.color = color;
        }

        public void Pop()
        {
            this.size = 0;
        }

        public void Throw()
        {
            if (size != 0)
            {
                this.numThrows++;
            }
        }

        public int getThrows()
        {
            return numThrows;
        }

        public static void Main(string[] args)
        {
            List<Ball> balls = new List<Ball>();
            
            balls.Add(new Ball(20,new Color(0,0,0)));
            balls.Add(new Ball(30, new Color(30, 50, 255,34)));
            balls.Add(new Ball(10, new Color(35, 90, 255, 10)));

           
            balls[0].Throw();
            balls[0].Pop();
            balls[0].Throw();
            balls[0].Throw();

            Console.Write(balls[0].getThrows());
        }

    }

    
}

    

