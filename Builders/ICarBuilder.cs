public interface ICarBuilder<T> where T : Car
{
    ICarBuilder<T> SetMake(string make);
    ICarBuilder<T> SetModel(string model);
    ICarBuilder<T> SetYear(int year);
    ICarBuilder<T> SetColor(string color);
    
    
    //Defines the creation.
    T Build();
}