# Builder Pattern Example in C#

This repository provides an example implementation of the Builder Pattern in C#. The main focus is on a `Car` class that showcases the usage of the Builder Pattern to create complex objects with flexible construction.

## Builder Pattern Overview

The **Builder Pattern** is a creational design pattern that allows for the construction of complex objects step by step. It separates the construction of a complex object from its representation, allowing the same construction process to create different representations.

In this example, we have a `Car` class that utilizes the Builder Pattern to construct cars with various properties.

## `Car` Class

The `Car` class demonstrates the Builder Pattern implementation. It has the following properties:

- `Make`: The make of the car.
- `Model`: The model of the car.
- `Year`: The manufacturing year of the car.
- `Color`: The color of the car.
- `Price`: The price of the car.

### `Builder` Class

The `Builder` class within the `Car` namespace is responsible for constructing `Car` objects. It offers methods to set various properties of the car, and it has a `Build` method to finalize the construction and create a `Car` object.

#### Usage

Here's an example of how you can use the `Builder` class to create a `Car` object:

```csharp
var car = new Car.Builder("Toyota")
    .SetModel("Camry")
    .SetYear(2023)
    .SetColor("Silver")
    .SetPrice(25000)
    .Build();
