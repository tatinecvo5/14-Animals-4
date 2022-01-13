using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Animals_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat Cat = new Cat("Кошка", "Мяу");
            Console.WriteLine(Cat.ShowInfo());
            Dog Dog = new Dog("Собака", "Гав");
            Console.WriteLine(Dog.Say());
            /*Cat Cat= new Cat("Кошка", "Мяу");
            Console.WriteLine(Cat);
            Dog Dog = new Dog("Собака", "Гав");
            Console.WriteLine(Dog);*/
            Console.ReadKey();
        }
    }
}
