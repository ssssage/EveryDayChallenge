using System.Collections.Generic;
using System.Linq;

namespace TheChallenge
{
    //Checkout LinkedIn ==> Tech Training Bootcamp UK
    public class FirstNonRepeatedCharacter
    {
        //abcdeab

        public static char FindFirstNonRepeatedChar(string str)
        {
            Dictionary<char, int> mapping = new Dictionary<char, int>();

            int temp = 0;

            foreach (var c in str.ToCharArray())
            {
                if (mapping.Keys.Contains(c))
                {
                    temp = mapping[c];
                    mapping[c] = temp + 1;
                    continue;
                }

                mapping.Add(c, 1);
            }

            if (mapping.Values.Contains(1))
            {
                return mapping.First(x => x.Value == 1).Key;
            }

            return ' ';
        }
    }
}


//Tech Training Bootcamp UK




















/*

 public static char FindFirstNoRepeatedCharcater(string word)
        {
            //create a dictionary to store the characters and thier values
            Dictionary<char, int> mapping = new Dictionary<char, int>();

            //create a variable to update the value of each character
            int temp = 0;

            //create foreach loop to store the string characters in the variable
            foreach (var c in word.ToCharArray())
            {
                //check if the dictionary contains the individual character
                if (mapping.Keys.Contains(c))
                {
                    //assign the charcater value to variable
                    temp = mapping[c];

                    //update variable value and assign
                    mapping[c] = temp + 1;
                    continue;
                }

                mapping.Add(c, 1);
            }

            //check if dictionary members has value 1
            if (mapping.Values.Contains(1))
            {
                //return the first charcater in the dictionary has value 1
                return mapping.First(x => x.Value == 1).Key;
            }

            return ' ';
        }

 */