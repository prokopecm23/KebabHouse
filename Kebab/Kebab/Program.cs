class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Storage storage = new Storage();
        Chef chef = new Chef(storage);
        Stockkeeper stockkeeper = new Stockkeeper(storage);

        // Počáteční naskladnění
        stockkeeper.RestockIngredients();

        while (true)
        {
            Console.WriteLine("\nVyberte akci:");
            Console.WriteLine("1. Zobrazit menu");
            Console.WriteLine("2. Objednat kebab");
            Console.WriteLine("3. Zobrazit stav skladu");
            Console.WriteLine("4. Doplnit sklad");
            Console.WriteLine("5. Konec");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    chef.DisplayMenu();
                    break;
                case "2":
                    chef.DisplayMenu();
                    Console.Write("Zadejte číslo kebabu: ");
                    if (int.TryParse(Console.ReadLine(), out int menuNumber))
                    {
                        chef.PrepareKebab(menuNumber);
                    }
                    break;
                case "3":
                    storage.DisplayStock();
                    break;
                case "4":
                    stockkeeper.RestockIngredients();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Neplatná volba!");
                    break;
            }
        }
    }
}