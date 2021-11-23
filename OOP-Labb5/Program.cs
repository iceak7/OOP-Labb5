using System;

namespace OOP_Labb5
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckChild1<int> c1 = new CheckChild1<int>();
            int nr1 = 5;
            int nr2 = 5;
            if(c1.toCheck(nr1, nr2))
            {
                Console.WriteLine(nr1 + " är lika med " + nr2);
            }
            else
            {
                Console.WriteLine(nr1 + " är inte lika med " + nr2);
            }
            

            CheckChild1<string> c2 = new CheckChild1<string>();         
            string s1 = "Tja";
            string s2 = "Hej";
            if (c2.toCheck(s1, s2))
            {
                Console.WriteLine(s1 + " är lika med " + s2);
            }
            else
            {
                Console.WriteLine(s1 + " är inte lika med " + s2);
            }



            CheckChild2<int> cc1 = new CheckChild2<int>();
            int nr11 = 5;
            int nr22 = 10;
            if (cc1.toCheck(nr11, nr22))
            {
                Console.WriteLine(nr11 + " är lika med " + nr22);
            }
            else
            {
                Console.WriteLine(nr11 + " är inte lika med " + nr22);
            }


            CheckChild2<string> cc2 = new CheckChild2<string>();
            string s11 = "Tja";
            string s22 = "Tja";
            if (cc2.toCheck(s11, s22))
            {
                Console.WriteLine(s1 + " är lika med " + s2);
            }
            else
            {
                Console.WriteLine(s1 + " är inte lika med " + s2);
            }







        }
    }
}
