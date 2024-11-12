public class Storage
{
    private Dictionary<string, Ingredience> _ingredients;

    public Storage()
    {
        _ingredients = new Dictionary<string, Ingredience>();
    }

    public void AddIngredient(string name, double quantity, string unit)
    {
        if (_ingredients.ContainsKey(name))
        {
            _ingredients[name].Quantity += quantity;
        }
        else
        {
            _ingredients[name] = new Ingredience(name, quantity, unit);
        }
    }

    public bool HasEnoughIngredients(Dictionary<string, double> requiredIngredients)
    {
        foreach (var ingredient in requiredIngredients)
        {
            if (!_ingredients.ContainsKey(ingredient.Key) ||
                _ingredients[ingredient.Key].Quantity < ingredient.Value)
            {
                return false;
            }
        }
        return true;
    }

    public void UseIngredients(Dictionary<string, double> requiredIngredients)
    {
        foreach (var ingredient in requiredIngredients)
        {
            _ingredients[ingredient.Key].Quantity -= ingredient.Value;
        }
    }

    public void DisplayStock()
    {
        Console.WriteLine("\nAktuální stav skladu:");
        foreach (var ingredient in _ingredients)
        {
            Console.WriteLine($"{ingredient.Value.Name}: {ingredient.Value.Quantity} {ingredient.Value.Unit}");
        }
    }
}