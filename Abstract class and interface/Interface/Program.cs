using System.Xml.Linq;

interface IGeographical_Object
{
    double IXcoordinate { get; set; }
    double IYcoordinate { get; set; }
    string Name { get; set; }
    string Description { get; set; }
    void getInformation() { }
}

class River : IGeographical_Object
{
    double speed;
    double length;
    double CoordinateX;
    double CoordinateY;
    string name;
    string description;

    public double IXcoordinate 
    { get 
        { 
            return CoordinateX; 
        } 
      set 
        { 
            CoordinateX = value; 
        } 
    }
    public double IYcoordinate 
    { 
        get 
        { 
            return CoordinateY; 
        } 
        set 
        { 
            CoordinateY = value; 
        } 
    }
    public string Name 
    { 
        get 
        { 
            return name; 
        } 
        set 
        { 
            name = value; 
        } 
    }
    public string Description 
    { 
        get 
        { 
            return description; 
        } 
        set 
        { 
            description = value; 
        } 
    }
    void IGeographical_Object.getInformation()
    {
        Console.WriteLine($"Назва річки {name}, координати якої {CoordinateX};{CoordinateY}, зі швидкістю {speed}, а її довжина {length}");
    }
}

class Mountain : IGeographical_Object
{
    double highestPoint;
    double CoordinateX;
    double CoordinateY;
    string name;
    string description;

    public double IXcoordinate 
    { 
        get 
        { 
            return CoordinateX; 
        } 
        set 
        { 
            CoordinateX = value; 
        } 
    }
    public double IYcoordinate 
    { 
        get 
        { 
            return CoordinateY; 
        } 
        set 
        { 
            CoordinateY = value; 
        } 
    }
    public string Name 
    { 
        get 
        { 
            return name; 
        } 
        set 
        { 
            name = value; 
        } 
    }
    public string Description 
    { 
        get 
        { 
            return description; 
        } 
        set 
        { 
            description = value; 
        } 
    }
    void IGeographical_Object.getInformation()
    {
        Console.WriteLine($"Назва гори {name}, яка знаходиться на {CoordinateX};{CoordinateY}, а найвища точка {highestPoint}");
    }
}