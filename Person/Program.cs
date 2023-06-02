using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Person> persons = new ();

            Console.WriteLine("Enter name:");
            string aName = Console.ReadLine();
            Console.WriteLine("Enter surname:");
            string aSurName = Console.ReadLine();
            Console.WriteLine("Enter age:");
            int aAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter weight:");
            string aWeight = Console.ReadLine();
            Console.WriteLine("Enter height:");
            string aHeight = Console.ReadLine();
            

            var person = new Person(aName, aSurName, aAge, aWeight, aHeight);


           Console.WriteLine(person.ToString());
            





        }
    }
}