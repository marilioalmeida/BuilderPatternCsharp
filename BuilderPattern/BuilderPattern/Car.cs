namespace BuilderPattern;

public partial class Car
{
    public string Make { get; protected set; }
    public string Model { get; protected set; }
    public int Year { get; protected set; }
    public string Color { get; protected set; }
    public double Price { get; protected set; }

    public Car(Builder builder)
    {
        Make = builder.Make;
        Model = builder.Model;
        Year = builder.Year;
        Color = builder.Color;
        Price = builder.Price;
    }
}