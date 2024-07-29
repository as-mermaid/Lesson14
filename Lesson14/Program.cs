using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка");
            Dog dog = new Dog("Жучка");

            cat.ShowInfo();
            dog.ShowInfo();

            Console.ReadKey();
        }
    }
}
