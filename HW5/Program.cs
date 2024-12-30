using System.Text.RegularExpressions;

namespace HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Введите строку текста:");
                string input = Console.ReadLine();

                while (true)
                {
                    Console.WriteLine("\nВыберите действие:");
                    Console.WriteLine("1. Найти слова, содержащие максимальное количество цифр.");
                    Console.WriteLine("2. Найти самое длинное слово и определить, сколько раз оно встретилось в тексте.");
                    Console.WriteLine("3. Заменить цифры от 0 до 9 на слова «ноль», «один», ..., «девять».");
                    Console.WriteLine("4. Вывести на экран сначала вопросительные, а затем восклицательные предложения.");
                    Console.WriteLine("5. Вывести на экран только предложения, не содержащие запятых.");
                    Console.WriteLine("0. Выход.");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            FindWordsWithMaxDigits(input);
                            break;
                        case "2":
                            FindLongestWord(input);
                            break;
                        case "3":
                            ReplaceDigitsWithWords(input);
                            break;
                        case "4":
                            PrintQuestionsAndExclamations(input);
                            break;
                        case "5":
                            PrintSentencesWithoutCommas(input);
                            break;
                        case "0":
                            return;
                        default:
                            Console.WriteLine("\nНеверный выбор. Попробуйте снова.");
                            break;
                    }
                }
            }

            static void FindWordsWithMaxDigits(string input)
            {
                var words = Regex.Matches(input, @"\b\w+\b");
                int maxDigitCount = 0;
                List<string> maxDigitWords = new List<string>();

                foreach (Match word in words)
                {
                    int digitCount = word.Value.Count(char.IsDigit);
                    if (digitCount > maxDigitCount)
                    {
                        maxDigitCount = digitCount;
                        maxDigitWords.Clear();
                        maxDigitWords.Add(word.Value);
                    }
                    else if (digitCount == maxDigitCount && digitCount > 0)
                    {
                        maxDigitWords.Add(word.Value);
                    }
                }

                Console.WriteLine("\nСлова с максимальным количеством цифр:");
                foreach (var word in maxDigitWords)
                {
                    Console.WriteLine(word);
                }
            }

            static void FindLongestWord(string input)
            {
                var words = Regex.Matches(input, @"\b\w+\b");
                string longestWord = "";
                int longestWordCount = 0;

                foreach (Match word in words)
                {
                    if (word.Value.Length > longestWord.Length)
                    {
                        longestWord = word.Value;
                        longestWordCount = 1;
                    }
                    else if (word.Value.Length == longestWord.Length)
                    {
                        longestWordCount++;
                    }
                }

                Console.WriteLine($"\nСамое длинное слово: {longestWord}, встречается {longestWordCount} раз(а).");
            }

            static void ReplaceDigitsWithWords(string input)
            {
                string[] digitWords = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
                string result = Regex.Replace(input, @"\d", match => digitWords[int.Parse(match.Value)]);
                Console.WriteLine("\nРезультат замены цифр на слова:");
                Console.WriteLine(result);
            }

            static void PrintQuestionsAndExclamations(string input)
            {
                var sentences = Regex.Split(input, @"(?<=[.!?])\s+");
                var questions = sentences.Where(s => s.Trim().EndsWith("?"));
                var exclamations = sentences.Where(s => s.Trim().EndsWith("!"));

                Console.WriteLine("\nВопросительные предложения:");
                foreach (var question in questions)
                {
                    Console.WriteLine(question);
                }

                Console.WriteLine("\nВосклицательные предложения:");
                foreach (var exclamation in exclamations)
                {
                    Console.WriteLine(exclamation);
                }
            }

            static void PrintSentencesWithoutCommas(string input)
            {
                var sentences = Regex.Split(input, @"(?<=[.!?])\s+");
                var sentencesWithoutCommas = sentences.Where(s => !s.Contains(","));

                Console.WriteLine("\nПредложения без запятых:");
                foreach (var sentence in sentencesWithoutCommas)
                {
                    Console.WriteLine(sentence);
                }
            }
        
    }
}
