using ClassApplication.Classes;
using ClassApplication.Enteties;
using System;
using System.Collections.Specialized;

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть математичний вираз, що містить лише цілі числа і оператор *:");
        string input = Console.ReadLine();

        try
        {
            int result = СalculateExpression(input);
            Console.WriteLine($"Результат: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static int СalculateExpression(string expression)
    {
        int result = 1;
        int[] arr;
        string[] parts = expression.Split('*');

        foreach (string part in parts) {
            if (int.TryParse(part, out int number))
            {
                result *= number;
            }

            else
            {
                throw new Exception("Невiрний формат!");
            }
        }

        return result;
    }
}

/*
Введіть математичний вираз, що містить лише цілі числа і оператор *:
1*2*2*2
Результат: 8

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 18072) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно…

*/