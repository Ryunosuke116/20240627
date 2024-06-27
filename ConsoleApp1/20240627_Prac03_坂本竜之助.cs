using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player
    {
        string name;
        int level;
        //コンストラクタ
        public Player(string Name,int Level)
        {
            this.name= Name;
            this.level = Level;
        }
        //デフォルトコンストラクタ
        public Player()
        {
            this.name = "JohnDoe";
            this.level = 1;
        }

        public void Display()
        {
            Console.WriteLine($"名前:{this.name}");
            Console.WriteLine($"レベル:{this.level}");
        }
            
    }
    internal class _20240627_Prac03_坂本竜之助
    {

        static void Main(string[] args)
        {
            Player player = new Player();
            player.Display();

            Random random = new Random();  
            int level = random.Next(6);
            Console.WriteLine("名前を入力してね");
            string name = Console.ReadLine();

            Player player2= new Player(name, level);
            player2.Display();
        }
    }
}
