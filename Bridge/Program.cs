
using Bridge;

Console.Title = "Bridge";

var noCoupon = new NoCoupon();
var oneEuroCoupon = new OneEuroCoupon();

var meatBasedMenu = new MeatBaseMenu(noCoupon);
Console.WriteLine($"Meat base menu, no coupon: {meatBasedMenu.CalculatePrice()} euro.");

var vegetarianMenu = new VegetarianMenu(noCoupon);
Console.WriteLine($"Vegetarian menu, no coupon: {vegetarianMenu.CalculatePrice()} euro");

meatBasedMenu = new MeatBaseMenu(oneEuroCoupon);
Console.WriteLine($"Meat base menu, no coupon: {meatBasedMenu.CalculatePrice()} euro.");

vegetarianMenu = new VegetarianMenu(oneEuroCoupon);
Console.WriteLine($"Vegetarian menu, no coupon: {vegetarianMenu.CalculatePrice()} euro");


Console.ReadKey();