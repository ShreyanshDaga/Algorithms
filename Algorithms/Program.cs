using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// GitHub management tested out with Visual Studio.
namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Now the algorithms start
            
            // Do HEAP operations
            // Min?Max heap and all the operations

            Dog D = new GreatDane();

            D.Bark();
        }
    }

    public class Dog
    {
        string DogName;

        public Dog()
        {
            Console.WriteLine("A Dog is born");
            this.Bark();
        }

        public virtual void Bark()
        {
            Console.WriteLine("Dog Barking!");
        }
    }

    public class GreatDane : Dog
    {
        public GreatDane()
        {
            Console.WriteLine("A GreatDane is Born");
        }

        public override void Bark()
        {
            Console.WriteLine("GreatDane Barking");
        }
    }
}
