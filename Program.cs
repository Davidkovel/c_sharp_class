using System;

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть рядок, що містить лише 0 та 1:");
        string ?input = Console.ReadLine();

        try
        {
            if (string.IsNullOrWhiteSpace(input) || input.Trim('0', '1').Length > 0)
            {
                throw new FormatException("Рядок повинен містити лише 0 та 1.");
            }

            int result = Convert.ToInt32(input, 2);
            Console.WriteLine($"Число в десятковому поданні: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Помилка: рядок повинен містити лише 0 та 1.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Помилка: введене число виходить за межі діапазону типу int.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Невiдома помилка ", ex.Message);
        }
    }
}

/*
Введіть рядок, що містить лише 0 та 1:
010101010
Число в десятковому поданні: 170

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 9780) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно…
 
*/