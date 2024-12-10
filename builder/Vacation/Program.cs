// See https://aka.ms/new-console-template for more information

using Vacation;

var outdoorsyVacationBuilder = new OutdoorsVacationBuilder();
var outdoorsyVacation = outdoorsyVacationBuilder
    .AddAccommodation("Two person tent", 2020, 7, 1, 5, 34)
    .AddEvent("Beach")
    .AddAccommodation("Two person tent")
    .AddEvent("Mountains")
    .Build();
Console.WriteLine(outdoorsyVacation);

var cityVacationBuilder = new CityVacationBuilder();
var cityVacation = cityVacationBuilder
    .AddAccommodation("Grand Facadian", 2020, 8, 1, 5, 0)
    .AddAccommodation("Hotel Commander", 2020, 8, 6, 2, 0)
    .AddEvent("Cirque du Soleil")
    .Build();
Console.WriteLine(cityVacation);
