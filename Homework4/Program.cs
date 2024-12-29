namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows, cols;

            Console.Write("Введите количество строк: ");
            rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            cols = int.Parse(Console.ReadLine());

            int[,] array = new int[rows, cols];

            // Ввод элементов массива
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Вывести массив");
                Console.WriteLine("2. Найти количество положительных чисел");
                Console.WriteLine("3. Найти количество отрицательных чисел");
                Console.WriteLine("4. Сортировка элементов массива построчно (по возрастанию)");
                Console.WriteLine("5. Сортировка элементов массива построчно (по убыванию)");
                Console.WriteLine("6. Инверсия элементов массива построчно");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите действие: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        PrintArray(array);
                        break;
                    case 2:
                        CountPositiveNumbers(array);
                        break;
                    case 3:
                        CountNegativeNumbers(array);
                        break;
                    case 4:
                        SortArrayRows(array, ascending: true);
                        Console.WriteLine("Массив отсортирован по возрастанию.");
                        break;
                    case 5:
                        SortArrayRows(array, ascending: false);
                        Console.WriteLine("Массив отсортирован по убыванию.");
                        break;
                    case 6:
                        InvertArrayRows(array);
                        Console.WriteLine("Элементы массива инвертированы.");
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }

        static void PrintArray(int[,] array)
        {
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j],4} "); // Форматирование для выравнивания
                }
                Console.WriteLine();
            }
        }

        static void CountPositiveNumbers(int[,] array)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (item > 0)
                    count++;
            }
            Console.WriteLine($"\nКоличество положительных чисел: {count}");
        }

        static void CountNegativeNumbers(int[,] array)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (item < 0)
                    count++;
            }
            Console.WriteLine($"\nКоличество отрицательных чисел: {count}");
        }

        static void SortArrayRows(int[,] array, bool ascending)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    for (int k = 0; k < array.GetLength(1) - j - 1; k++)
                    {
                        if ((ascending && array[i, k] > array[i, k + 1]) ||
                            (!ascending && array[i, k] < array[i, k + 1]))
                        {                       
                            int temp = array[i, k];
                            array[i, k] = array[i, k + 1];
                            array[i, k + 1] = temp;
                        }
                    }
                }
            }
        }

        static void InvertArrayRows(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1) / 2; j++)
                {                  
                    int temp = array[i, j];
                    array[i, j] = array[i, array.GetLength(1) - 1 - j];
                    array[i, array.GetLength(1) - 1 - j] = temp;
                }
            }
        }
    }
}