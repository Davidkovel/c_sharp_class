using ClassApplication.Enteties;
using System;
using System.Collections.Specialized;

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        try
        {
            Console.WriteLine("Write a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string translation_result = Translation(number);
            Console.WriteLine(translation_result);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static string Translation(int number)
    {
        switch (number)
        {
            case 0:
                return "Zero";
            case 1:
                return "One";
            case 2:
                return "Two";
            case 3:
                return "Three";
            case 4:
                return "Four";
            case 5:
                return "Five";
            case 6:
                return "Six";
            case 7:
                return "Seven";
            case 8:
                return "Eight";
            case 9:
                return "Nine";
            default:
                return "Invalid input";
        }
    }
}


/*
Write a number:
5
Five

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 4608) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно… 
*/