namespace classpractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instance
            Car car1 = new Car("Toyota", "Prius Prime", 2024, "red", 15);
            Console.WriteLine($"Car 1: Make = {car1.Make}, Model = {car1.Model}");

            Car bike1 = new Bike("Royal", "kk", "mm", 2);
            Console.WriteLine($"Bike 1: Brand = {bike1.}, Model = {bike1.Model}");

        }


    
    }//class




}//namspcae