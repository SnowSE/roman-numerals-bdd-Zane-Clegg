using System;

namespace RomanizingLibrary
{
    public class Class1
    {
        static int[] nums = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        static string[] roman = { "m", "cm", "d", "cd", "c", "xc", "l", "xl", "x", "ix", "v", "iv", "i" };
        public int number = 0;
        public string Romanize(int number)                      
        {
            string answer = "";
            if (number == 0)
            {
                return "BLANK";
            }
            else if (number < 0 || number > 3999)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                for (int i = 0; i < nums.Length && number != 0; i++)
                {
                    while (number >= nums[i])
                    {
                        number -= nums[i];
                        answer += roman[i];
                    }
                }
            }
            return answer;
        }
    }
}
