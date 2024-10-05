public class SportsCarBuilder : ICarBuilder<SportsCar>
{
    private readonly SportsCar _sportsCar;
    public SportsCarBuilder()
    {
        _sportsCar = new SportsCar();
    }

    public SportsCar Build()
    {
        return _sportsCar;
    }

    public ICarBuilder<SportsCar> SetColor(string color)
    {
        _sportsCar.Color = color;
        return this;
    }

    public ICarBuilder<SportsCar> SetMake(string make)
    {
        _sportsCar.Make = make;
        return this;
    }

    public ICarBuilder<SportsCar> SetModel(string model)
    {
        _sportsCar.Model = model;
        return this;
    }

    public ICarBuilder<SportsCar> SetYear(int year)
    {
        _sportsCar.Year = year;
        return this;
    }

    public ICarBuilder<SportsCar> SetTopSpeed(int speed)
    {
        _sportsCar.TopSpeed = speed;
        return this;
    }
}