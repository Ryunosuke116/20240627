using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rectangle
    {
        private double width;
        private double height;

        //デフォルトコンストラクタ
        public Rectangle()
        {
            this.width = 0;
            this.height = 0;
        }
        //コンストラクタ   
        public Rectangle(double Width, double Height)
        {
            this.width = Width;
            this.height = Height;
        }
        //面積
        public double GetArea()
        {
            return this.width * this.height;
        }
        //四辺の合計
        public double GetPerimeter()
        {
            double Perimeter = this.height * 2 + this.width * 2;
            return Perimeter;
        }

        public void Display()
        {
     
            Console.WriteLine($"長方形の面積{this.GetArea()}");
            Console.WriteLine($"長方形の周囲の長さ{this.GetPerimeter()}");

        }

    }

    internal class _20240627_Prac02_坂本竜之助
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Display();
            Rectangle rectangle2 = new Rectangle(5,3);
            rectangle2.Display();
        }

    }
}
