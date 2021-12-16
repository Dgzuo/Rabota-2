using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            Most auto = new Most("Мостовая");
            Nebo pyatno = new Nebo("Небо");

            Console.WriteLine("{0} {1} {2} {3}", auto.name, auto.heightSpeed(), pyatno.name, pyatno.prostupat());

            Console.ReadKey();
        }
    }

    public class Most
    {
        public string name { get; set; }

        public Most(string name)
        {
            this.name = name;
        }

        public string heightSpeed()
        {
            return "Сквозь шум ветра раздался визг дудок,прямо из мостовой начали выскакивать горячие пончики по десять пенсов за штуку,";
        }


    }

    public class Nebo
    {
        public string name { get; set; }

        public Nebo(string name)
        {
            this.name = name;
        }

        public string prostupat()
        {
            return "из небес спикировала ужасная рыбина, и Артур с Фордом поняли, что нужно спасаться бегством.";
        }

    }

}
