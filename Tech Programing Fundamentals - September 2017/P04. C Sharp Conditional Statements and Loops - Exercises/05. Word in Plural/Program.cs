using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();

            
            bool nounEndInY;
            bool nounEndIn1;
            bool nounEndInOtherLetter;

            if ( nounEndInY = noun.EndsWith("y"))
            {
               noun = noun.Remove(noun.Length - 1);
                Console.WriteLine(noun + "ies");
            }
            else if ((nounEndIn1 = noun.EndsWith("o")) || (nounEndIn1 = noun.EndsWith("ch")) || (nounEndIn1 = noun.EndsWith("sh")) || (nounEndIn1 = noun.EndsWith("s"))  || (nounEndIn1 = noun.EndsWith("x")) || (nounEndIn1 = noun.EndsWith("z")))
            {
                Console.WriteLine(noun + "es");
            }
            else
            {
                Console.WriteLine(noun + "s");
            }
        }
    }
}
