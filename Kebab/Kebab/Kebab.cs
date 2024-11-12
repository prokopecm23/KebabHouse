public class Kebab
{
    public string Name { get; set; }
    public Dictionary<string, double> RequiredIngredients { get; set; }

    public Kebab(string name, Dictionary<string, double> requiredIngredients)
    {
        Name = name;
        RequiredIngredients = requiredIngredients;
    }
}