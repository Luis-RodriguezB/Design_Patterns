﻿using System.Text;

namespace Builder;

public class Car
{
    private readonly List<string> _parts = new();
    private readonly string _carType;

    public Car(string carType)
    {
        _carType = carType;
    }

    public void AddPart(string part)
    {
        _parts.Add(part);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        foreach (var part in _parts)
        {
            sb.Append($"Car of type { _carType } has part {part}.");
        }

        return sb.ToString();
    }
}

/// <summary>
/// Builder
/// </summary>
public abstract class CarBuilder
{
    public Car Car { get; set; }

    protected CarBuilder(string carType)
    {
        Car = new Car(carType);
    }

    public abstract void BuildEngine();
    public abstract void BuildFrame();
}


/// <summary>
/// ConcreteBuilder1 Class
/// </summary>
public class MiniBuilder : CarBuilder
{
    public MiniBuilder() : base("Mini")
    {
        
    }

    public override void BuildEngine()
    {
        Car.AddPart("'not a V8'");
    }

    public override void BuildFrame()
    {
        Car.AddPart("'3-door with stripes'");
    }
}

/// <summary>
/// ConcreteBuilder2 class
/// </summary>
public class BMWBuilder : CarBuilder
{
    // Invoke base class contructor
    public BMWBuilder() : base("BMW")
    {
        
    }

    public override void BuildEngine()
    {
        Car.AddPart("'a fancy V8 engine'");
    }

    public override void BuildFrame()
    {
        Car.AddPart("'5-door with metallic finish'");
    }
}

/// <summary>
/// Director
/// </summary>
public class Garage
{
    private CarBuilder? _builder;

    public Garage()
    {
        
    }

    public void Construct(CarBuilder builder)
    {
        _builder = builder;

        _builder.BuildEngine();
        _builder.BuildFrame();
    }

    public void Show()
    {
        Console.WriteLine(_builder?.Car.ToString());
    }
}




 
