public class AnimalService : IAnimalService
{
    private readonly IAnimalProvider _animalProvider;

    public AnimalService(IAnimalProvider animalProvider)
    {
        _animalProvider = animalProvider;
    }

    public Animal[] GetAnimals()
    {
        return _animalProvider.GetAnimals();
    }
}
