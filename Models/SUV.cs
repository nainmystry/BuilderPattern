public class SUV : Car
{
    public int OffRoadCapability { get; set; }

    public override string GetDescription()
    {
        return base.GetDescription() + $" - Off-Road Capability: {OffRoadCapability}/10";
    }
}