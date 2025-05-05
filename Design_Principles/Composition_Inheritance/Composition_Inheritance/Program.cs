namespace Composition_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var choice = 0;
            var pizza = new Pizze();
            do
            {
                choice = ReadChoice(choice);
                if (choice >= 1 && choice <= 3)
                {
                    ITopping topping = null;
                    switch (choice)
                    {
                        case 1:
                            topping = new Cheese();
                            break;
                        case 2:
                            topping = new Olives();
                            break;
                        case 3:
                            topping = new Mushrooms();
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;

                    }
                    pizza.AddTopping(topping);

                }
                
            }while(choice != 0);
            Console.WriteLine(pizza);
        }
        private static int ReadChoice(int choice)
        {
            Console.WriteLine("Available Topping");
            Console.WriteLine("------------");
            Console.WriteLine("1. Cheese");
            Console.WriteLine("2. Olives");
            Console.WriteLine("3. Mushrooms");
            Console.WriteLine("select topping: ");
            if (int.TryParse(Console.ReadLine(), out int ch))
            {
                choice = ch;
            }

            return choice;
        }
    }
    class Pizze
    {
        public virtual decimal Pirce => 10m;

        public List<ITopping> toppings = new List<ITopping>();

        public void AddTopping(ITopping topping) => toppings.Add(topping);

        private decimal CalculateToppingsPrice()
        {
            decimal total = Pirce;
            foreach (var topping in toppings)
            {
                total += topping.price;
            }
            return total;
        }
        public override string ToString()
        {
            var result = $"Pizza Price: {Pirce} \n";
            foreach (var topping in toppings)
            {
                result += $"{topping.title} : {topping.price} \n";
            }
            result += $"Total Price: {CalculateToppingsPrice()}";
            return result;
        }

    }

    public interface ITopping
    {
        string title { get; }
        decimal price { get; }
    }
    public class Cheese : ITopping
    {
        public string title => nameof(Cheese);

        public decimal price => 3m;
    }
    public class Olives : ITopping
    {
        public string title => nameof(Olives);
        public decimal price => 2m;
    }
    public class Mushrooms : ITopping
    {
        public string title => nameof(Mushrooms);
        public decimal price => 1m;
    }



}
