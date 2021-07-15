public static class AnimalExtension
{
    public static Animal[] GetAnimalsBySex(this Aviary aviary, Sex sex)
    {
        var counter = 0;
        var index = 0;
        var animalsOfSameSex = new Animal[aviary.Animals.Length];

        foreach (var animal in aviary.Animals)
        {
            if (animal.Sex == sex)
            {
                animalsOfSameSex[index++] = animal;
                counter++;
            }
        }

        var animalsOfSameSexWithoutNull = new Animal[counter];

        for (var i = 0; i < animalsOfSameSexWithoutNull.Length; i++)
        {
            animalsOfSameSexWithoutNull[i] = animalsOfSameSex[i];
        }

        return animalsOfSameSexWithoutNull;
    }
}