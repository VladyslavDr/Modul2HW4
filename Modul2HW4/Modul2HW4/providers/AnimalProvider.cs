public class AnimalProvider : IAnimalProvider
{
    // private readonly IAnimalProvider _animalProvider;
    public AnimalProvider(/* IAnimalProvider animalProvider */)
    {
        // _animalProvider = animalProvider;
    }

    public Animal[] GetAnimals()
    {
        return new Animal[]
        {
            new Donkey
            {
                Sex = Sex.FEMALE,
                BodyCover = Cover.WOOl,
                BodyParameters = new BodyParameters
                {
                    BodyLength = new Length { Value = 1500, Unit = UnitLength.CM },
                    BodyHeight = new Length { Value = 95, Unit = UnitLength.CM },
                    BodyWeight = new Weight { Value = 230, Unit = UnitWeight.KG }
                },
                TailLength = new Length { Value = 25, Unit = UnitLength.CM },
                HoofParameter = new Hoof
                {
                    Width = new Length { Value = 18, Unit = UnitLength.CM },
                    Height = new Length { Value = 10, Unit = UnitLength.CM },
                    Length = new Length { Value = 15, Unit = UnitLength.CM }
                },
                HoofForm = HoofForm.LEVELED,
                MaxTravelSpeed = new Speed { Value = 24, Unit = UnitSpeed.KMpH },
                Name = "PARLAGI"
            },

            new Deer
            {
                Sex = Sex.MALE,
                BodyCover = Cover.WOOl,
                BodyParameters = new BodyParameters
                {
                    BodyLength = new Length { Value = 1800, Unit = UnitLength.CM },
                    BodyHeight = new Length { Value = 120, Unit = UnitLength.CM },
                    BodyWeight = new Weight { Value = 160, Unit = UnitWeight.KG }
                },
                TailLength = new Length { Value = 15, Unit = UnitLength.CM },
                HoofParameter = new Hoof
                {
                    Width = new Length { Value = 9, Unit = UnitLength.CM },
                    Height = new Length { Value = 8, Unit = UnitLength.CM },
                    Length = new Length { Value = 8, Unit = UnitLength.CM }
                },
                HornsLength = new Length { Value = 65, Unit = UnitLength.CM },
                MaxTravelSpeed = new Speed { Value = 50, Unit = UnitSpeed.KMpH },
                Name = "NOBLE"
            },

            new Deer
            {
                Sex = Sex.FEMALE,
                BodyCover = Cover.WOOl,
                BodyParameters = new BodyParameters
                {
                    BodyLength = new Length { Value = 1850, Unit = UnitLength.CM },
                    BodyHeight = new Length { Value = 120, Unit = UnitLength.CM },
                    BodyWeight = new Weight { Value = 165, Unit = UnitWeight.KG }
                },
                TailLength = new Length { Value = 17, Unit = UnitLength.CM },
                HoofParameter = new Hoof
                {
                    Width = new Length { Value = 11, Unit = UnitLength.CM },
                    Height = new Length { Value = 9, Unit = UnitLength.CM },
                    Length = new Length { Value = 8, Unit = UnitLength.CM }
                },
                HornsLength = new Length { Value = 58, Unit = UnitLength.CM },
                MaxTravelSpeed = new Speed { Value = 45, Unit = UnitSpeed.KMpH },
                Name = "SPOTTED"
            },

            new Lion
            {
                Sex = Sex.MALE,
                BodyCover = Cover.WOOl,
                BodyParameters = new BodyParameters
                {
                    BodyLength = new Length { Value = 1850, Unit = UnitLength.CM },
                    BodyHeight = new Length { Value = 60, Unit = UnitLength.CM },
                    BodyWeight = new Weight { Value = 165, Unit = UnitWeight.KG }
                },
                CanineLength = new Length { Value = 7, Unit = UnitLength.CM },
                MustacheLength = new Length { Value = 15, Unit = UnitLength.CM },
                TailLength = new Length { Value = 93, Unit = UnitLength.CM },
                MaxTravelSpeed = new Speed { Value = 80, Unit = UnitSpeed.KMpH },
                Name = "ASIATIC"
            },

            new Donkey
            {
                Sex = Sex.MALE,
                BodyCover = Cover.WOOl,
                BodyParameters = new BodyParameters
                {
                    BodyLength = new Length { Value = 1300, Unit = UnitLength.CM },
                    BodyHeight = new Length { Value = 88, Unit = UnitLength.CM },
                    BodyWeight = new Weight { Value = 215, Unit = UnitWeight.KG }
                },
                TailLength = new Length { Value = 25, Unit = UnitLength.CM },
                HoofParameter = new Hoof
                {
                    Width = new Length { Value = 14, Unit = UnitLength.CM },
                    Height = new Length { Value = 9, Unit = UnitLength.CM },
                    Length = new Length { Value = 8, Unit = UnitLength.CM }
                },
                HoofForm = HoofForm.LAMINITE,
                MaxTravelSpeed = new Speed { Value = 24, Unit = UnitSpeed.KMpH },
                Name = "PONUI"
            },

            new Tiger
            {
                Sex = Sex.FEMALE,
                BodyCover = Cover.WOOl,
                BodyParameters = new BodyParameters
                {
                    BodyLength = new Length { Value = 2730, Unit = UnitLength.CM },
                    BodyHeight = new Length { Value = 75, Unit = UnitLength.CM },
                    BodyWeight = new Weight { Value = 70, Unit = UnitWeight.KG }
                },
                TailLength = new Length { Value = 85, Unit = UnitLength.CM },
                CanineLength = new Length { Value = 10, Unit = UnitLength.CM },
                MustacheLength = new Length { Value = 15, Unit = UnitLength.CM },
                MaxTravelSpeed = new Speed { Value = 50, Unit = UnitSpeed.KMpH },
                Name = "MALAY"
            },

            new Lion
            {
                Sex = Sex.FEMALE,
                BodyCover = Cover.WOOl,
                BodyParameters = new BodyParameters
                {
                    BodyLength = new Length { Value = 1755, Unit = UnitLength.CM },
                    BodyHeight = new Length { Value = 55, Unit = UnitLength.CM },
                    BodyWeight = new Weight { Value = 130, Unit = UnitWeight.KG }
                },
                CanineLength = new Length { Value = 8, Unit = UnitLength.CM },
                MustacheLength = new Length { Value = 10, Unit = UnitLength.CM },
                TailLength = new Length { Value = 85, Unit = UnitLength.CM },
                MaxTravelSpeed = new Speed { Value = 80, Unit = UnitSpeed.KMpH },
                Name = "EAST_AFRICAN"
            }
        };
    }
}
