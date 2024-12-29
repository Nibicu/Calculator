namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                double number1, number2;
                bool isNumber = false;
                



                Console.WriteLine("Введите первое число");
                string num_1 = Console.ReadLine();
                isNumber = double.TryParse(num_1, out number1);
                if (!isNumber)
                {
                    Console.WriteLine("Ошибка: Недопустимые символы! Попробуйте сново\n");
                    continue;
                }

                Console.WriteLine("Введите второе число");
                string num_2 = Console.ReadLine();
                isNumber = double.TryParse(num_2, out number2);
                if (!isNumber)
                {
                    Console.WriteLine("Ошибка: Недопустимые символы! Попробуйте сново\n");
                    continue;
                }

                Console.WriteLine("Введите оператор (+, -, *, /, %, ^)");
                string operant = Console.ReadLine();
                double result = operant switch
                {
                    "+" => number1 + number2,
                    "-" => number1 - number2,
                    "*" => number1 * number2,
                    "/" => number1 / number2,
                    "%" => number1 % number2,
                    "sqrt" => Math.Sqrt(number1), 
                    _ => throw new NotImplementedException($"\nОперации {operant} не существует!"),
                };
                Console.WriteLine($"{number1} {operant} {number2} = {result}\n");

                Console.WriteLine("\nНажмите 'Y' если хотите попробывать еще!");
                string input = Console.ReadLine();
                if (input == "Y")
                    continue;
                else
                    Console.WriteLine("\nНажмите любую клавишу для выхода.");
                Console.ReadLine();
                break;
            }

        }

    }
}

