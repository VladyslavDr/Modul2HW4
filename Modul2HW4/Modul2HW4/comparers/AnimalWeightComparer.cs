using System.Collections.Generic;
public class AnimalWeightComparer : IComparer<Animal>
{
    public int Compare(Animal o1, Animal o2)
    {
        return o1.BodyParameters.BodyWeight.Value - o2.BodyParameters.BodyWeight.Value;
    }
}