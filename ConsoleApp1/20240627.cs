using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Myclass
    {
        private int number;
        private string name;

        //コンストラクタ
        public Myclass(string Name, int Number)
        {
            this.name = Name;
            this.number = Number;
        }

        //デフォルトコンストラクタ
        public Myclass()
        {
            this.name = "Bob";
            this.number = 0;
        }

        public void Display()
        {
            Console.WriteLine($"出席番号:{this.number}");
            Console.WriteLine($"名前:{this.name}");
        }
    }
    internal class _20240627
    {
      static void Main(string[] args )
        {
            Myclass myclass = new Myclass("安藤",5);
            myclass.Display();
            Myclass myclass2 = new Myclass();
            myclass2.Display();
        }
    }
}
