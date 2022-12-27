using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            word.ToLower();
            //char[] charArray = word.ToCharArray();
            //int fcount = 0;
            // a string is already a char array so just go through the string index. Instead of charArray[] its just word[]
            for (int i = 1; i <= word.Length / 2; i++)
            {
                if (word[i - 1] == word[word.Length - i])
                {
                    continue;
                }
                else
                {
                    //fcount += 1;
                    return false;
                }

            }
            return true;
            //if (fcount > 0)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
            
        }
    }
}
