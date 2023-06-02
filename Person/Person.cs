using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        public string Name;
        public string SurName;
        public int Age;
        public string Weight;
        public string Height;

        public Person(string aName, string aSurName, int aAge, string aWeight, string aHeight)
        {
            this.Name = aName;
            this.SurName = aSurName;
            this.Age = aAge;
            this.Weight = aWeight;
            this.Height = aHeight; 
        }

      


        public override string ToString()
        {
            return $"Your name is {Name} your surname is {SurName} your age is {Age} your weight is {Weight} your height is {Height}!";
        }


    }
}
