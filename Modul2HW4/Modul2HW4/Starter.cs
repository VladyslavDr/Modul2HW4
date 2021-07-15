using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
public class Starter
{
    public void Run()
    {
        var serviceProvider = new ServiceCollection()
            .AddTransient<IAnimalProvider, AnimalProvider>()
            .AddTransient<IAviaryService, AviaryService>()
            .AddTransient<IAnimalService, AnimalService>()
            .AddTransient<IComparer<Animal>, AnimalNameComparer>()
            .BuildServiceProvider();

        var animalService = serviceProvider.GetService<IAnimalService>();
        var aviaryService = serviceProvider.GetService<IAviaryService>();

        var animals = animalService.GetAnimals();
        Print(animals);

        var aviary = new Aviary { Animals = animals };
        Print(aviary.Animals);

        aviaryService.SortAnimals(aviary);
        Print(aviary.Animals);
    }

    public void Print(Animal[] animals)
    {
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Name + " : " + animal.Sex + " : " + animal.BodyParameters.BodyWeight.Value);
        }

        Console.WriteLine(string.Empty);
    }
}
