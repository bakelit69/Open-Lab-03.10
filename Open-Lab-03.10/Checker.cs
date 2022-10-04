using System;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int letterCount = 0;
            for(int i=0; i<str.Length; i++)
            {
                if (str[i] == letter)
                {
                    letterCount++;
                }
            }
            return letterCount;
        }
    }
}
