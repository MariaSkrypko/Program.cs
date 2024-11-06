using System;
using System.Text;

class Task1
{
    static void Main()
    {
        Console.WriteLine("Enter_1 some phrase: ");
        string input = Console.ReadLine();

        StringBuilder sb = new StringBuilder(input);
        for(int i = 0; i < sb.Length; i++)
        {
            sb[i] = Char.ToUpper(sb[i]);
        }
        Console.WriteLine("UpperCase: " + sb.ToString());
        Console.WriteLine();



        Console.WriteLine("Enter_2 some phrase: ");
        string input2 = Console.ReadLine();
        string result = input2.ToLower();
        Console.WriteLine("LowerCase: " + result);
    }
}