namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            Console.WriteLine($"Производитель: {car1.Diller}");
            Console.WriteLine($"Модель: {car1.Model}");
            Console.WriteLine($"Цвет: {car1.Color}");
            Console.WriteLine($"Цена: {car1.Price}");

            car1.AutoStart();
            car1.Geolocation();
            car1.CruiseСontrol();
            car1.TurnOnTheDisco();

        }
    }
}
