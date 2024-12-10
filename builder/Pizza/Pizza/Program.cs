// See https://aka.ms/new-console-template for more information

using Pizza;

var pizzaDirector = new PizzaDirector();

var veggieBuilder = new VeggieLoversPizzaBuilder();
var veggie = pizzaDirector.MakePizza(veggieBuilder);
Console.WriteLine(veggie);

var meatBuilder = new MeatLoversPizzaBuilder();
var meat = pizzaDirector.MakePizza(meatBuilder);
Console.WriteLine(meat);
