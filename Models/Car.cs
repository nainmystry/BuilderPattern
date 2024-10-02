public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int Year { get; set; }

    public virtual string GetDescription(){
        return $"{Year} {Color} {Make} {Model}";
    }

    public override string ToString()
    {
        return GetDescription();
    }
}