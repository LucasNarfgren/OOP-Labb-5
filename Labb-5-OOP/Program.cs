using System;
using System.Collections.Generic;
using System.Text;


namespace OOPLabb5
{
    class Check<T>
    {
        public bool toCheck(T n1, T n2)
        {
            if (n1.Equals(n2))
            {
                Console.WriteLine("True");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false; 
            }
        }
    }
    class Check1 : Check<int>
    {

    }

    class Check2 : Check<string>
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Check1 c1 = new Check1();
            c1.toCheck(5,5);

            Check2 c2 = new Check2();
            c2.toCheck("Då","Hej");

            Check1 c3 = new Check1();
            c3.toCheck(10,5);

            Check2 c4 = new Check2();
            c4.toCheck("Luva","Luva");
        }
    }
}
