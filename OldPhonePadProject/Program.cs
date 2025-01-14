using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhonePadProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 'exit' to exit program: ");
            while (true)
            {
                Console.Write($"OldPhonePad => ");
                string input = Console.ReadLine();

                string result = OldPhone.OldPhonePad(input);
                Console.WriteLine("Output: " + result);


                if (input.ToUpper() == "EXIT")
                {
                    break;
                }
            }
        }
    }

    public class OldPhone
    {
        private static readonly string[] _keyWord = new string[] { " ", "&'(", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };

        public static string OldPhonePad(string input)
        {
            var output = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                char charKey = input[i];
                if (char.IsDigit(charKey))
                {
                    int keyIndex = charKey - '0';
                    int charCount = 0;
                    while (i < input.Length && input[i] == charKey)
                    {
                        charCount++;
                        i++;
                    }
                    i--;
                    int charIndex = (charCount - 1) % _keyWord[keyIndex].Length;
                    output.Append(_keyWord[keyIndex][charIndex]);
                }
                else if (charKey == '*')
                {
                    if (output.Length > 0)
                    {
                        output.Remove(output.Length - 1, 1);
                    }
                }
                else if (charKey == '#')
                {
                    break;
                }
            }
            return output.ToString();
        }
    }
}
