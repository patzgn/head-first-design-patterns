﻿using PizzaStoreAbstractFactory.Products.Ingredients;

namespace PizzaStoreAbstractFactory.AbstractFactories;

public class NYPizzaIngredientFactory : IPizzaIngredientFactory
{
    public ICheese CreateCheese()
    {
        return new ReggianoCheese();
    }

    public IClams CreateClams()
    {
        return new FreshClams();
    }

    public IDough CreateDough()
    {
        return new ThickCrustDough();
    }

    public IPepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public ISauce CreateSauce()
    {
        return new MarinaraSauce();
    }

    public IVeggies[] CreateVeggies()
    {
        IVeggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
        return veggies;
    }
}
