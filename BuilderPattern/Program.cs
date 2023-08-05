// See https://aka.ms/new-console-template for more information

using BuilderPattern;


var car = new Car
        .Builder("Make 1")
    .SetModel("Model 1")
    .SetYear(2023)
    .SetColor("Color 1")
    .SetPrice(100000)
    .Build();


Console.WriteLine(car.Make);
Console.WriteLine(car.Model);
Console.WriteLine(car.Year);
Console.WriteLine(car.Color);
Console.WriteLine(car.Price);
 
Console.WriteLine("Hello, World!");


