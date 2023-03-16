using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace FEEngageRandomizer
{
    public class mainclass
    {
        static void Main(string[] args)
        {
            //Runs population of classes
            Cl c = new();
            c.AddValues();
            //Runs randomizer for each character and outputs 
            Randomizer r = new();
            r.Randomize();
            Console.WriteLine("Press enter to exit");
            string exit = Console.ReadLine();
            if(exit !=null) 
            {
                Console.WriteLine();
            }
        }
    }

}



