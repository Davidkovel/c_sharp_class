using System;

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть логічний вираз, що містить лише цілі числа і оператори (<, >, <=, >=, ==, !=):");
        string input = Console.ReadLine();

        try
        {
            bool result = EvaluateLogicalExpression(input);
            Console.WriteLine($"Результат: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Помилка: введений вираз містить недопустимі символи або неправильний формат.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Невідома помилка: {ex.Message}");
        }
    }

    static bool EvaluateLogicalExpression(string expression)
    {
        if (string.IsNullOrWhiteSpace(expression))
        {
            throw new FormatException("Вираз не може бути порожнім.");
        }

        string[] operererators = { "<=", ">=", "<", ">", "==", "!=" };
        foreach (string opererer in operererators)
        {
            int index = expression.IndexOf(opererer);
            if (index != -1)
            {
                string leftPart = expression.Substring(0, index).Trim();
                string rightPart = expression.Substring(index + opererer.Length).Trim();

                if (!int.TryParse(leftPart, out int left) || !int.TryParse(rightPart, out int right))
                {
                    throw new FormatException("Вираз містить недопустимі символи або неправильний формат.");
                }

                if (opererer == "<=")
                    return left <= right;
                else if (opererer == ">=")
                    return left >= right;
                else if (opererer == "<")
                    return left < right;
                else if (opererer == ">")
                    return left > right;
                else if (opererer == "==")
                    return left == right;
                else if (opererer == "!=")
                    return left != right;
                else
                    throw new FormatException("Невідомий оператор.");
            }
        }

        throw new FormatException("Вираз не містить жодного з допустимих операторів.");
    }
}

/*
Введіть логічний вираз, що містить лише цілі числа і оператори (<, >, <=, >=, ==, !=):
7>5
Результат: True

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 9052) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно…
*/