using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branchingOefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal in:");
            int getal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef een tweede getal in:");
            int getal2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"De twee getalen zijn: { getal1} en { getal2}");


            switch (getal1 > getal2)
            {
                case true:
                    Console.WriteLine($"De stijgende volgorde is: {getal2}, {getal1}");
                    break;
                case false:
                    Console.WriteLine($"De stijgende volgorde is: {getal1}, {getal2}");
                    break;
            }



            Console.ReadKey();


        }
    }
}
