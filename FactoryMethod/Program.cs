﻿
using FactoryMethod;

Console.Title = "Factory Pattern";


var factories = new List<DiscountFactory>
{
    new CodeDiscountFactory(Guid.NewGuid()),
    new CountryDiscountFactory("BE"),
    new CountryDiscountFactory("CRC")
};

foreach (var factory in factories)
{
    var discountService = factory.CreateDiscountService();
    Console.WriteLine($"Percentage {discountService.DiscountPercentage} " +
        $"coming from {discountService}");
}

Console.ReadKey();