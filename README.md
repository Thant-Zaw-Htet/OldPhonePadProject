# Summary of OldPhonePadProject
The `OldPhonePadProject` uses a multi-tap input mechanism to mimic how texting might behave on an outdated mobile phone. On a conventional mobile phone, each number is associated with a group of letters (for example, 2 = ABC, 3 = DEF). Using the outdated mobile keypad technology, this project lets the user enter numerical sequences, which the application then translates into letters.

The application also manages special characters:

- `*` which functions similarly to a backspace, is used to remove the previous character.
- `#` denotes that the input has ended.

### Features
- Multi-tap text input simulation based on old phone keypads.
- Handles backspace using the * character.
- Stops processing when # is encountered.
- Continuously accepts input until the user types exit.

### Example Usage

```csharp
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
```
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
