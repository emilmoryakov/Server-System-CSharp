using System;

interface ICar
{
    void Buy();
}

abstract class Car
{
    public string color;

    public Car(string color)
    {
        this.color = color;
    }

    public abstract void Buy();
}

class Toyota : Car
{
    private int price;
    private int mileage;

    public Toyota(int price, int mileage, string color) : base(color)
    {
        this.price = price;
        this.mileage = mileage;
    }

    public override void Buy()
    {
        Console.WriteLine($" color: {color} width: {price} heigth: {mileage}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Car camry = new Toyota(5, 6, "car looking ahhh");
        camry.Buy();
    }
}

