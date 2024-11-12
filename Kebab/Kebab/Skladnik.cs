public class Stockkeeper
{
    private Storage _storage;

    public Stockkeeper(Storage storage)
    {
        _storage = storage;
    }

    public void RestockIngredients()
    {
        _storage.AddIngredient("maso", 5.0, "kg");
        _storage.AddIngredient("zelenina", 3.0, "kg");
        _storage.AddIngredient("chléb", 20.0, "ks");
        Console.WriteLine("Sklad byl doplněn!");
    }
}