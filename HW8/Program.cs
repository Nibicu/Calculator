namespace HW8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите имя собаки: ");
            string dogName = Console.ReadLine();
            
            Dog myDog = new Dog();
            myDog.SetName(dogName);
           
            Console.WriteLine($"Имя собаки: {myDog.GetName()}");
            myDog.Eat();
        }
    }
}
