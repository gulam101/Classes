using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public string Name;
        public string House;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1} in {2}", to, Name, House);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Cat";
            person.House = "ENG";
            person.Introduce("Teddy");
        }
    }
}
