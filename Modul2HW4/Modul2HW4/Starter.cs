using System;
public class Starter
{
    public void Run()
    {
        var animals = new AnimalProvider().GetAnimals();

        var aviary = new Aviary { Animals = animals };

        Print(aviary.Animals);

        new AviaryService().SortAnimals(aviary);

        Print(aviary.Animals);
        Print(aviary.GetAnimalsBySex(Sex.MALE));
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
