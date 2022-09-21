using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweySort
{
    class generate
    {
        
        public static int randomNum(Random rand, int min, int max)
        {
            int randNumber = rand.Next(min, max);
            return randNumber;
        }
        //random select 3 letters form alphabet
        public static string randomString(Random rand)
        {
            string output = null;
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToArray();
            for (int i = 0; i < 3; i++)
            {
                string randLetter = letters[rand.Next(0, letters.Length)].ToString();
                output += randLetter;
            }
            return output;
        }
        public static string generateEverything(Random rand)
        {
            //code to generate 3 random numbers
            string numbers = randomNum(rand,100,999).ToString();
            string letters = randomString(rand);

            //concat numbers and letters generated 
            string total = numbers + letters;
            return total;
        }

    }
}
