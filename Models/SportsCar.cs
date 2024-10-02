public class SportsCar : Car
{
    public int TopSpeed { get; set; }

    public override string GetDescription()
    {
        return base.GetDescription() + $" Top Speed - {TopSpeed}";
    }
}