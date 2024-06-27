using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dog
    {
        private string name;
        private int    age;

        //デフォルトコンストラクタ
        public Dog()
        {
            this.name = null;
            this.age  = 0;
        }

        //コンストラクタ
        public Dog(string Name,int Age)
        {
            this.name = Name;
            this.age = Age;
        }

        public void Display()
        {
            Console.WriteLine($"名前:{this.name}");
            Console.WriteLine($"年齢:{this.age}");
        }

    }

    internal class _20240627_Prac01_坂本竜之助
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Display();
            Dog dog1 = new Dog("Bob",1);
            dog1.Display();
        }
    }
}
