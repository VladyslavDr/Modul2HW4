using System.Collections.Generic;
public class AnimalNameComparer : IComparer<Animal>
{
    public int Compare(Animal o1, Animal o2)
    {
        return o1.Name.CompareTo(o2.Name);
    }
}