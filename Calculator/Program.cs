namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                double number1, number2;
                double result;
                bool isNumber = false;
                string operand;



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
                operand = Console.ReadLine();
                switch (operand)
                {
                    case "+":
                        result = number1 + number2;
                        Console.WriteLine($"{number1} + {number2} = {result}");
                        break;
                    case "-":
                        result = number1 - number2;
                        Console.WriteLine($"{number1} - {number2} = {result}");
                        break;
                    case "*":
                        result = number1 * number2;
                        Console.WriteLine($"{number1} * {number2} = {result}");
                        break;
                    case "/":
                        if (number2 != 0)
                        {
                            result = number1 / number2;
                            Console.WriteLine($"{number1} / {number2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("\nОшибка: Деление на ноль! Попробуйте сново\n");
                        }
                        break;
                    case "%":
                        if (operand == "%")
                        {
                            Console.Write("Введите процент: ");
                            double percentage = Convert.ToDouble(Console.ReadLine());
                            result = (number1 * percentage) / 100;
                            Console.WriteLine($"{percentage}% от {number1} = {result}");
                        }
                        break;
                    case "^":
                        if (number1 >= 0)
                        {
                            double squareRoot = Math.Sqrt(number1);
                            Console.WriteLine($"Квадратный корень из {number1} равен {squareRoot}");
                        }
                        else
                        {
                            Console.WriteLine("Пожалуйста, введите положительное число!");
                        }
                        break;
                    default:
                        Console.WriteLine("\nНекорректный оператор. Используйте (+, -, *, /, %, ^)");
                        continue;
                }

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
