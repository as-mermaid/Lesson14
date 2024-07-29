using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    internal class Dog : Animal
    {
        string name;
        readonly string message = "Гав";

        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Dog(string name)
            : base(name)
        {
        }

        public override void Say()
        {
            Console.WriteLine(message);
        }
    }
}
