using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string from 0 to 9:");
        string input = Console.ReadLine();

        try
        {
            int number = Convert.ToInt32(input);
            Console.WriteLine($"Converted to number: {number}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: The string is not number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: the number is out of range of the int type");
        }

        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error ", ex);
        }
    }
}

/*
Enter a string from 0 to 9:
52
Converted to number: 52

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 2564) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно:


*/