public interface IAviaryService
{
    int GetNumberOfUniqueTypeAnimals(Aviary aviary);
    void SortAnimals(Aviary aviary);
    Animal[] GetAnimalsBySex(Aviary aviary, Sex sex);
}
