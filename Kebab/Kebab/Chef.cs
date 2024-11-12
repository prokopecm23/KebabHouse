public class Chef
{
    private Storage _storage;
    private Dictionary<int, Kebab> _menu;

    public Chef(Storage storage)
    {
        _storage = storage;
        _menu = new Dictionary<int, Kebab>
        {
            { 1, new Kebab("Klasický kebab", new Dictionary<string, double>
                {
                    { "maso", 0.2 },
                    { "zelenina", 0.1 },
                    { "chléb", 1 }
                })
            },
            { 2, new Kebab("Velký kebab", new Dictionary<string, double>
                {
                    { "maso", 0.3 },
                    { "zelenina", 0.15 },
                    { "chléb", 1 }
                })
            }
        };
    }

    public bool PrepareKebab(int menuNumber)
    {
        if (!_menu.ContainsKey(menuNumber))
        {
            Console.WriteLine("Neplatné číslo menu!");
            return false;
        }

        var kebab = _menu[menuNumber];

        if (!_storage.HasEnoughIngredients(kebab.RequiredIngredients))
        {
            Console.WriteLine("Není dostatek surovin pro přípravu kebabu!");
            _storage.DisplayStock();
            return false;
        }

        _storage.UseIngredients(kebab.RequiredIngredients);
        Console.WriteLine($"Kebab {kebab.Name} byl připraven!");

        // Tady přidáme zobrazení stavu skladu:
        _storage.DisplayStock();

        return true;
    }

    public void DisplayMenu()
    {
        Console.WriteLine("\nMenu:");
        foreach (var item in _menu)
        {
            Console.WriteLine($"{item.Key}. {item.Value.Name}");
        }
    }
}