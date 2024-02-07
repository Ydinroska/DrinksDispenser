namespace DrinksDispenser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create drinks
            Beverage cola = new Beverage("Coca-Cola", "Cola", 2.75f, Beverage.ContainerType.Tin);
            Beverage sprite = new Beverage("Sprite", "Lime", 2.75f, Beverage.ContainerType.Plasticbottle);
            Beverage battery = new Beverage("Battery", "Battery Acid", 3.25f, Beverage.ContainerType.Tin);
            Beverage bigWater = new Beverage("Fuzzy Water", "Fresh", 3.0f, Beverage.ContainerType.Plasticbottle, 0.5f);
            Beverage coldDrink = new Beverage("Brain Freeze", "Cold", 2.75f, Beverage.ContainerType.Tin, 0.33f, hasIce: true);

            // create a dispenser
            Dispenser dispenser = new Dispenser();

            // fill the machine /type and quantity)
            dispenser.LoadMachine(cola, 5);
            dispenser.LoadMachine(sprite, 5);
            dispenser.LoadMachine(battery, 5);
            dispenser.LoadMachine(coldDrink, 4);

            // print out the contents 
            Console.WriteLine(dispenser);

        }
    }
}