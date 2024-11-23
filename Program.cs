using ClassApplication.Enteties;
using System;

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        try
        {
            DateReceivedPassport dateReceivedPassport = new DateReceivedPassport(22, 09, 2024);
            Passport passport = new Passport("123443218", "David", ref dateReceivedPassport);
            Console.WriteLine("Паспорт успішно створено");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
}

/*
Паспорт успішно створено

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 13468) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно…
*/