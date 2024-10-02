public class SUVBuilder : ICarBuilder<SUV>
{
    private readonly SUV _suv;
    public SUVBuilder()
    {
        _suv = new SUV();
    }
    public SUV Build()
    {
         return _suv;
    }

    public ICarBuilder<SUV> SetColor(string color)
    {
       _suv.Color = color;
            return this;
    }

    public ICarBuilder<SUV> SetMake(string make)
    {
       _suv.Make = make;
            return this;
    }

    public ICarBuilder<SUV> SetModel(string model)
    {
         _suv.Model = model;
            return this;
    }

    public ICarBuilder<SUV> SetYear(int year)
    {
        _suv.Year = year;
            return this;
    }

    public SUVBuilder SetOffRoadCapability(int capability)
    {
        _suv.OffRoadCapability = capability;
        return this;
    }
}