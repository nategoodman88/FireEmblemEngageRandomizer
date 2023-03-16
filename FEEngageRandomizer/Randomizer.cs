using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace FEEngageRandomizer
{
    public class Randomizer : Cl
    {
        public void Randomize()
        {
            //Save to txt for future reference
            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream("./FEERandomizerResults.txt", FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open Redirect.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);
            //For each character/starting class pair, randomize the class to a new one from the dictionary of classes
            foreach (KeyValuePair<string, string> x in Characters.d)
            {

                //Initiate while loop within for each so that way we ensure the exclusive classes only get assigned to the specfic characters that they are exclusive to
                
                bool picking = true;
                while (picking)
                {
                    var rand = new Random();
                    string NewClassID = rand.Next(1, Cl.ClassDict.Count).ToString();
                    string NewClassName = Cl.ClassDict.FirstOrDefault(x => x.Value == NewClassID).Key.ToString();
                    string changer = x.Key.ToString();
                    changer = NewClassName;

                    if (changer == "Dragon Child" && !Characters.d.Equals("Alear") ||
                        changer == "Divine Dragon" && !Characters.d.Equals("Alear") ||
                        changer == "Noble (Alfred)" && !Characters.d.Equals("Alfred") ||
                        changer == "Noble (Celine)" && !Characters.d.Equals("Celine") ||
                        changer == "Avenir" && !Characters.d.Equals("Alfred") ||
                        changer == "Vidame" && !Characters.d.Equals("Celine") ||
                        changer == "Lord (Diamant)" && !Characters.d.Equals("Diamant") ||
                        changer == "Lord (Alcryst)" && !Characters.d.Equals("Alcryst") ||
                        changer == "Successeur" && !Characters.d.Equals("Diamant") ||
                        changer == "Tireur d`elite" && !Characters.d.Equals("Alear") ||
                        changer == "Wing Tamer" && !Characters.d.Equals("Ivy") ||
                        changer == "Wing Tamer" && !Characters.d.Equals("Hortensia") ||
                        changer == "Lindwurm" && !Characters.d.Equals("Ivy") ||
                        changer == "Sleipnir Rider" && !Characters.d.Equals("Hortensia") ||
                        changer == "Tireur d`elite" && !Characters.d.Equals("Alcryst") ||
                        changer == "Sentinel (Timerra)" && !Characters.d.Equals("Timerra") ||
                        changer == "Sentinel (Fogado)" && !Characters.d.Equals("Fogado") ||
                        changer == "Picket" && !Characters.d.Equals("Timerra") ||
                        changer == "Cupido" && !Characters.d.Equals("Fogado") ||
                        changer == "Dancer" && !Characters.d.Equals("Seadall") ||
                        changer == "Fell Child" && !Characters.d.Equals("Veyle")
                         
                        ) 
                    {
                        picking = true;
                    }
                    else
                    {
                        Console.WriteLine(x.Key + " new class is " + changer);

                        picking = false;
                    }
                }
            }
            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
            Console.WriteLine("Character class randomization complete; saved to FEERandomizerResults.txt");
        }

    }
}
