using ClassApplication.Enteties;
using System;
using System.Collections.Specialized;

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("Виберіть напрямок конвертації:");
            Console.WriteLine("1. З десяткової до двійкової");
            Console.WriteLine("2. З двійкової до десяткової");
            Console.WriteLine("3. Вихід");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 3)
            {
                break;
            }

            Console.WriteLine("Введіть число:");
            string input = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case 1:
                        int decimalNumber = int.Parse(input);
                        string binaryResult = Convert.ToString(decimalNumber, 2);
                        Console.WriteLine($"Результат: {binaryResult}");
                        break;
                    case 2:
                        int binaryNumber = Convert.ToInt32(input, 2);
                        Console.WriteLine($"Результат: {binaryNumber}");
                        break;
                    default:
                        Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                        break;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


/*
Виберіть напрямок конвертації:
1. З десяткової до двійкової
2. З двійкової до десяткової
3. Вихід
2
Введіть число:
110100101
Результат: 421
Виберіть напрямок конвертації:
1. З десяткової до двійкової
2. З двійкової до десяткової
3. Вихід
3

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 8432) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно…

 */