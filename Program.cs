using ClassApplication.Classes;
using ClassApplication.Enteties;
using System;

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        try { 
            DateExpiredCard expire_card = new DateExpiredCard(12, 06, 2025);
            CreditCard card = new CreditCard("1234567898765432", "Vova Bob", 123, ref expire_card); 
            Console.WriteLine("Картка успішно створена."); }
        catch (ArgumentException ex) { 
            Console.WriteLine($"Помилка: {ex.Message}"); 
        }
    }
}

/*
Картка успішно створена.

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 11172) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно…
*/