namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Ford", "Focus", "Red", 25000.00m);

            Console.WriteLine($"Производитель: {car1.Diller}\nМодель: {car1.Model}\nЦвет: {car1.Color}\nЦена: {car1.Price}");                    
            

            car1.AutoStart();  //Console.WriteLine("Автомобиль запущен автоматически.");          
            car1.Geolocation();  //Console.WriteLine("Геолокация: текущие координаты автомобиля.");
            car1.CruiseСontrol();   //Console.WriteLine("Круиз-контроль активирован.");
            car1.TurnOnTheDisco();  //Console.WriteLine("Дискотека включена! Музыка играет.");

        }
    }
}
