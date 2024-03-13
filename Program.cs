namespace classpractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instance
            Car car1 = new Car("Toyota", "Prius Prime", 2024, "red", 15);
            Console.WriteLine($"Car 1: Make = {car1.Make}, Model = {car1.Model}");

            Bike bike1 = new Bike("Royal", "Gas","Yellow", 2);
            Console.WriteLine($"Bike 1: Brand = {bike1.Brand}, Fuel = {bike1.Fuel}, Color = {bike1.Color}, NumberOfWheels = {bike1.Numberofwheels}");

            Hobby hobby1 = new Hobby("Book", "Secret", "Rhonda Byrne", "Self help", 198,15);
            Console.WriteLine($"Hobby 1: HobbyName = {hobby1.Hobbyname}, Name = {hobby1.Name}, Type = {hobby1.Type}, Number of pages= {hobby1.Pages}, Price = {hobby1.Price}");

        }


    
    }//class




}//namspcae