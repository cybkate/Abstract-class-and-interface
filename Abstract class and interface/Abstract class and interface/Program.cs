abstract class Geographical_Object
{
    protected double CoordinateX;
    protected double CoordinateY;
    protected string name;
    protected string description;

    protected virtual void getInformation() 
    {
    }
}

class River : Geographical_Object
{
    double speed;
    double general_length;

    public void getInformation()
    {
        Console.WriteLine($"Назва річки {name}, координати якої {CoordinateX};{CoordinateY}, зі швидкістю {speed}, а загальна довжина {general_length}");
    }
}

class Mountain : Geographical_Object
{
    double highestPoint;
}