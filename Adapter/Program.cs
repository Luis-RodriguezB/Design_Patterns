//using ObjectAdapter;
using ClassAdapter;

Console.Title = "Adapter";

// OBJECT ADAPTER EXAMPLE

//ICityAdapter adapter = new CityAdapter();
//var city = adapter.GetCity();

//Console.WriteLine($"{city.FullName}, {city.Inhabitans}");



// CLASS ADAPTER EXAMPLE
ICityAdapter adapter = new CityAdapter();
var city = adapter.GetCity();

Console.WriteLine($"{city.FullName}, {city.Inhabitans}");


Console.ReadKey();
