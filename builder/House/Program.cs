// See https://aka.ms/new-console-template for more information

using House;

var houseDirector = new HouseDirector();

var woodHouseBuilder = new WoodHouseBuilder();
var woodHouse = houseDirector.BuildHouse(woodHouseBuilder);
Console.WriteLine(woodHouse);

var stoneHouseBuilder = new StoneHouseBuilder();
var stoneHouse = houseDirector.BuildHouse(stoneHouseBuilder);
Console.WriteLine(stoneHouse);

var gingerbreadHouseBuilder = new GingerbreadHouseBuilder();
var gingerbreadHouse = houseDirector.BuildHouse(gingerbreadHouseBuilder);
Console.WriteLine(gingerbreadHouse);
