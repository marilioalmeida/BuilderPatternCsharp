namespace BuilderPattern;

public partial class Car
{
    public class Builder
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        public Builder(string make)
        {
            Make = make;
        }

        public Builder SetModel(string model)
        {
            Model = model;
            return this;
        }

        public Builder SetYear(int year)
        {
            Year = year;
            return this;
        }

        public Builder SetColor(string color)
        {
            Color = color;
            return this;
        }

        public Builder SetPrice(int price)
        {
            Price = price;
            return this;
        }

        public Car Build()
        {
            return new Car(this);
        }
    }
}