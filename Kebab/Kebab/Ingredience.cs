using System;

public class Ingredience
{
    public string Name { get; set; }
    public double Quantity { get; set; }
    public string Unit { get; set; }

    public Ingredience(string name, double quantity, string unit)
    {
        Name = name;
        Quantity = quantity;
        Unit = unit;
    }
}