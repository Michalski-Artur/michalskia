using System;
using System.Collections.Generic;

namespace TDD
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if(numbers == String.Empty)
                return 0;

            int result = 0;
            List<char> singleCharDelimiters = new List<char>();
            if(numbers.StartsWith("//"))
                singleCharDelimiters.Add(numbers[2]);
            singleCharDelimiters.Add(',');
            singleCharDelimiters.Add('\n');
            string[] separatedNumbers = numbers.Split(singleCharDelimiters.ToArray());
            for(int i=0;i<separatedNumbers.Length;i++)
            {
                int number = 0;
                try
                {
                    number = int.Parse(separatedNumbers[i]);
                }
                catch
                {
                    continue;
                }
                if (number < 0)
                    throw new ArgumentException("Negative number");
                if (number > 1000)
                    continue;
                result += number;
            }
            return result;
        }

    }
}
