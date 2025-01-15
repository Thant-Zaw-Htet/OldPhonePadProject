# Summary of OldPhonePadProject
The `OldPhonePadProject` uses a multi-tap input mechanism to mimic how texting might behave on an outdated mobile phone. On a conventional mobile phone, each number is associated with a group of letters (for example, 2 = ABC, 3 = DEF). Using the outdated mobile keypad technology, this project lets the user enter numerical sequences, which the application then translates into letters.

### Features
- Converts a sequence of digits into text using old mobile keypad mappings.
- Automatically adds the # at the end of the input if not provided by the user.
- Continuously accepts input until the user types exit.
- Exit Condition: The user can exit the program by typing "EXIT".


## Key Mappings

| Key | Characters       |
|-----|------------------|
| 0   | [space]          |
| 1   | & ' (            |
| 2   | ABC              |
| 3   | DEF              |
| 4   | GHI              |
| 5   | JKL              |
| 6   | MNO              |
| 7   | PQRS             |
| 8   | TUV              |
| 9   | WXYZ             |
| *   | Backspace        |
| #   | End of Input     |

### Example Usage

```csharp
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

```
## Example Input and Output

- Input: `4433555 555666#`
  - Output: `HELLO`

- Input: `8 88777444666*664#`
  - Output: `TURING`


