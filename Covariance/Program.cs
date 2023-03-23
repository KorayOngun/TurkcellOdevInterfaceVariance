namespace Covariance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IBag<>

            Bag<Apple> bagOfApple = new Bag<Apple>();

            bagOfApple.Add(new Apple {Name = "1. elma" });
            bagOfApple.Add(new Apple {Name = "2.elma" });
            bagOfApple.Add(new Apple {Name = "3. elma " });

            

            IBag<Fruit> bagOfFruit = bagOfApple; // IBag<Apple>
            bagOfApple.Add(new Apple { Name = "4. elma " });
            Console.WriteLine(bagOfFruit.Get(3).Name);


            //----------------------------------------------------------
            Console.WriteLine("-------------------------------------------------");
            //----------------------------------------------------------


            // IEnumarable

            List<Apple> apples = new List<Apple>();
            apples.Add(new Apple { Name = "1. elma" });
            apples.Add(new Apple { Name = "2.elma" });
            apples.Add(new Apple { Name = "3. elma " });

            IEnumerable<Fruit> fruits;
            fruits = apples;
            apples.Add(new Apple { Name = "4. elma " });
            foreach (Fruit item in fruits)
                Console.WriteLine($"{item.Name}");

            

        }
    }
}