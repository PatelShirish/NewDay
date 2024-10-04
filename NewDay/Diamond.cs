using System;
using System.Collections.Generic;
using System.Linq;

namespace NewDay
{
    public class Diamond
    {
        public List<string> Print(char alphabet)
        {
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            if (!letters.Contains(alphabet))
            {
                throw new ArgumentException("Invalid parameter.");
            }

            int alphIndex = Array.IndexOf(letters, alphabet);
            int maxWidth = (alphIndex * 2) + 1; // Max width of the diamond
            int middle = maxWidth / 2; // Center point (Postion of 'A's)
            
            List<string> listOutput = new List<string>();
            int space = 1; // space between two same letters
           
            // Build Top part of the diamond
            for (int i = 0; i <= alphIndex; i++)
            {
                // First line ('A')
                if (i == 0)
                {
                    var line = Enumerable.Repeat<char>(' ', maxWidth).ToArray();
                    line[middle] = 'A';

                    listOutput.Add(new string(line));
                }

                // From 2nd line to the first half
                if (i > 0)
                {
                    var line = Enumerable.Repeat<char>(' ', maxWidth).ToArray();
                    
                    // Place same letter on the either side
                    line[middle - space] = letters[i];
                    line[middle + space] = letters[i];

                    listOutput.Add(new string(line));
                    space++;
                }
            }

            // Reverse and copy for the other half
            List<string> tempList = listOutput.Take(middle).Reverse().ToList();
            listOutput.AddRange(tempList);
            
            return listOutput;
        }
    }
}
