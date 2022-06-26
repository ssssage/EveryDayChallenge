using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheChallenge
{
    public class MatchString
    {
        // Create a function accepts two strings, charStrings, DocString

        public static bool FindStringMatch(string charString, string docString)
        {
            Dictionary<char, int> mapping = new Dictionary<char, int>();
            
            foreach (var c in charString.ToCharArray())
            {
                if (!mapping.Keys.Contains(c))
                {
                    mapping[c] = 0;
                }

                else
                {
                    mapping[c] += 1;
                }

            }

            foreach (var c in docString.ToCharArray())
            {
                if (!mapping.Keys.Contains(c) || mapping[c] == 0)
                {

                    return false;
                }

                else
                {
                    mapping[c] -= 1;
                }
            }

            return true;
        }
    }
}

//The above solution runs in Big O(n + m) Time | Big O(C) Space