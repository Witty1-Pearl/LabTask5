using System;

namespace MethodOverriding
{
    public class Bclass
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("I am leaning how to code in C-sharp");
        }
    
    }

    public class Dclass : Bclass
    {
        public override void GetInfo()
        {
            Console.WriteLine("Welcome to CodebitsAcademy");
        }
    }

    class Program
    {
        static void Main (string[] args)
        {
            Dclass d = new Dclass();
            d.GetInfo();
            Bclass b = new Bclass();
            b.GetInfo();
            Console.WriteLine("\nPress Enter Key to Exit..");

            Console.ReadLine();
        }
    }
}
