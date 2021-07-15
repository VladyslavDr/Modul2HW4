public class AviaryService : IAviaryService
{
    public Animal[] GetAnimalsBySex(Aviary aviary, Sex sex)
    {
        return aviary.GetAnimalsBySex(sex);
    }

    public int GetNumberOfUniqueTypeAnimals(Aviary aviary)
    {
        var index = 0;
        var names = new string[aviary.Animals.Length];
        names[index] = aviary.Animals[0].Name;

        foreach (var animal in aviary.Animals)
        {
            foreach (var name in names)
            {
                if (animal.Name != name)
                {
                    names[index++] = animal.Name;
                }
            }
        }

        var counter = 0;
        foreach (var name in names)
        {
            if (name != null)
            {
                counter++;
            }
        }

        return counter;
    }

    public void SortAnimals(Aviary aviary)
    {
    }
}