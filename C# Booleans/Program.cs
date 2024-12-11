using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Booleans
{
    internal class Program
    {
        static void Main(string[] args)
        {
                bool isCSharpFun = true;
                bool isFishTasty = false;
                Console.WriteLine(isCSharpFun);   // Outputs True
                Console.WriteLine(isFishTasty);   // Outputs False

                int x = 10;
                int y = 9;
                int z = 10;

                // higher or lower
                Console.WriteLine(x > y); // returns True, because 10 is higher than 9

                Console.WriteLine(x < y); // returns False, because 9 is lower than 10


                // equal
                Console.WriteLine(x == y);// returns False, because 9 is not equal with 10
                Console.WriteLine(x == 10);// returns True, because 10 is equal 10
                Console.WriteLine(x == z); //returns True , Because 10 is equal 10.


                // Higher equal



                int myAge = 25;
                int myAgeTrue = 18;
                int myAgeFalse = 17;
                int votingAge = 18;

                // Vergleich: Größer oder gleich
                Console.WriteLine(myAge >= votingAge);   // Gibt True aus, weil 25 >= 18
                Console.WriteLine(myAgeTrue >= votingAge); // Gibt True aus, weil 18 >= 18
                Console.WriteLine(myAgeFalse >= votingAge); // Gibt False aus, weil 17 < 18

                // Vergleich: Größer als
                Console.WriteLine(myAge > votingAge);  // Gibt True aus, weil 25 > 18
                Console.WriteLine(myAgeTrue > votingAge); // Gibt False aus, weil 18 nicht größer als 18
                Console.WriteLine(myAgeFalse > votingAge); // Gibt False aus, weil 17 nicht größer als 18

                // Vergleich: Kleiner als
                Console.WriteLine(myAge < votingAge);  // Gibt False aus, weil 25 nicht kleiner als 18
                Console.WriteLine(myAgeTrue < votingAge); // Gibt False aus, weil 18 nicht kleiner als 18
                Console.WriteLine(myAgeFalse < votingAge); // Gibt True aus, weil 17 kleiner als 18

                // Vergleich: Kleiner oder gleich
                Console.WriteLine(myAge <= votingAge);  // Gibt False aus, weil 25 nicht kleiner oder gleich 18
                Console.WriteLine(myAgeTrue <= votingAge); // Gibt True aus, weil 18 gleich 18
                Console.WriteLine(myAgeFalse <= votingAge); // Gibt True aus, weil 17 kleiner als 18

                // Vergleich: Gleich
                Console.WriteLine(myAge == votingAge);  // Gibt False aus, weil 25 nicht gleich 18
                Console.WriteLine(myAgeTrue == votingAge); // Gibt True aus, weil 18 gleich 18
                Console.WriteLine(myAgeFalse == votingAge); // Gibt False aus, weil 17 nicht gleich 18

                // Vergleich: Ungleich
                Console.WriteLine(myAge != votingAge);  // Gibt True aus, weil 25 nicht gleich 18
                Console.WriteLine(myAgeTrue != votingAge); // Gibt False aus, weil 18 gleich 18
                Console.WriteLine(myAgeFalse != votingAge); // Gibt True aus, weil 17 nicht gleich 18

                // Beispiel mit Bedingung: Wenn-Alter ist größer oder gleich Wahlalter
                if (myAge >= votingAge)
                {
                    Console.WriteLine("Du bist wahlberechtigt.");
                }
                else
                {
                    Console.WriteLine("Du bist nicht wahlberechtigt.");
                }

                // Beispiel mit Ternärem Operator
                string result = (myAge >= votingAge) ? "Wahlberechtigt" : "Nicht wahlberechtigt";
                
                Console.WriteLine(result);
            }
        }




    }
