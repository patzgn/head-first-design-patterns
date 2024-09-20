using Ducks.Adapters;
using Ducks.Models.Ducks;
using Ducks.Models.Turkeys;

IDuck duck = new MallardDuck();

ITurkey turkey = new WildTurkey();
IDuck turkeyAdapter = new TurkeyAdapter(turkey);

Console.WriteLine("The Turkey says...");
TestTurkey(turkey);

Console.WriteLine("\nThe Duck says...");
TestDuck(duck);

Console.WriteLine("\nThe TurkeyAdapter says...");
TestDuck(turkeyAdapter);


ITurkey duckAdapter = new DuckAdapter(duck);

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("\nThe DuckAdapter says...");
    TestTurkey(duckAdapter);
}


void TestDuck(IDuck duck)
{
    duck.Quack();
    duck.Fly();
}

void TestTurkey(ITurkey turkey)
{
    turkey.Gobble();
    turkey.Fly();
}
