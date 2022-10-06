using System;

namespace _66_Plus_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] digits = { 1, 9, 9 };

            int[] num = PlusOne(digits);
            Console.WriteLine(num);

            string trs = "TD";
        }



        public static int[] PlusOne(int[] digits)
        {
            int length = digits.Length;
            if (digits[length - 1] < 9)
            {
                digits[length - 1] = digits[length - 1] + 1;
                return digits;
            }
            int carry = 0;
            for (int i = length - 1; i >= 0; i--)
            {
                if (carry == 1)
                {
                    if (digits[i] % 9 == 0)
                    {
                        digits[i] = 0;
                        carry = 1;
                        continue;
                    }
                    else
                    {
                        digits[i] = digits[i] + 1;
                        carry = 0;
                        break;
                    }

                }
                if (digits[i] % 9 == 0)
                {
                    digits[i] = 0;
                    carry = 1;
                }
            }
            if (carry == 1)
            {
                Array.Resize(ref digits, digits.Length + 1);
                digits[0] = 1;
            }
            return digits;

        }



        // Undersatnd the requirement wrongly

        public static int[] PlusOne2(int[] digits)
        {
            int length = digits.Length;
            int lastVal = digits[length - 1];

            int sumVal = lastVal + 1;
            int lengthofNewNum = sumVal.ToString().Length;
            if (lengthofNewNum > 1)
            {
                Array.Resize(ref digits, length + (lengthofNewNum - 1));
            }
            else
            {
                digits[length - 1] = sumVal;
                return digits;
            }


            int count = 1;
            for (int i = 0; i < lengthofNewNum; i++)
            {
                int modVal = sumVal % 10;
                sumVal = sumVal / 10;
                int tempLength = digits.Length;
                digits[tempLength - count] = modVal;
                count++;

            }


            return digits;

        }
    }
}
