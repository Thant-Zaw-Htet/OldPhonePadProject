using System;
using System.Text;

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

                if (input.ToUpper() == "EXIT")
                {
                    break;
                }

                if (!input.EndsWith("#"))
                {
                    input += "#";
                }

                string result = OldPhone.OldPhonePad(input);
                Console.WriteLine($"OldPhonePad({input}) => output: " + result);
                
            }
        }
    }

    public  class OldPhone
    {
        private static readonly string[] KeyMappings = new string[]
        {
            " ",    //is 0
            "&'(",  //is 1
            "ABC",  //is 2
            "DEF",  //is 3
            "GHI",  //is 4
            "JKL",  //is 5
            "MNO",  //is 6
            "PQRS", //is 7
            "TUV",  //is 8
            "WXYZ"  //is 9
        };

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

                    int charIndex = (charCount - 1) % KeyMappings[keyIndex].Length;
                    output.Append(KeyMappings[keyIndex][charIndex]);
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
