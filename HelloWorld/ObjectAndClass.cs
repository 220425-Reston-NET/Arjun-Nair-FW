// This is how you create a class by using the class keyword
// Public is just there to make the class available for everyone
public class Car 
{
    // This is a field
    // This is used to store information or define the current state of the object
    // By default, fields should all be private
    private string _color;
    private string _owner;

    private int _fuel;
    private int _gallonPerMile;

    private string _brand;

    // This is a method
    // A way to represent behavior/ function and it will run multiple lines of code
    // void means that the method will not returnm anything
    // Any other datatype, the method
    public int TotalDistancePerFuel()
    {
        Console.WriteLine("Current Fuel: " + _fuel + " This is the owner of the car: " + _owner);
        Console.WriteLine("Gallon used per mile: " + _gallonPerMile + " This is the owner of the car: " + _owner);
        Console.WriteLine("This is how many miles: " + _fuel/ _gallonPerMile);

        // Return keyword is what the method will give back
        return _fuel/ _gallonPerMile;

        
    }

    public void Sum(int num1, int num2)
    {
        Console.WriteLine(num1+num2);
    }

    // This is a contructor
    // It is a special method that will run whenever you create an object
    public Car()
    {
        _color = "Blue";
        _owner = "Stephen";
        _fuel = 100;
        _gallonPerMile = 5;
    }

    public Car(string p_owner)
    {
        _owner = p_owner;
    }

    // This is Property
    // Gives us the flexibility to check that the data being stored is correct, let only certain things access data, make things read or write
    public string Owner
    {
        get{return _owner + " is the owner of this car.";}

        // set keyword is how you change the data that is being stored
        set {_owner = value + " Owner";}
    }

    // Fuel can only hold numbers from 0 to 100
    public int Fuel
    {
        get {return _fuel;}
        set 
        {
            if (value <= 100 && value >= 0)
            {
                _fuel = value;
            }
            else
            {
                _fuel = 100;
                System.Console.WriteLine("Fuel can only hold from 0 to 100.");
            }
        }
    }

    public string Brand { get; internal set; }






    // This is a constructor
    //  It is a method that will execute whenever you create an object
    // public Car()
    // {
    //     Console.WriteLine("Making a car object!");
    // }

    // public Car(string p_color)
    // {
    //     _color = p_color;
    // }

    // //  This is a property
    // public string _Color 
    // { 
    //     get { return _color + " is the color of the car"; } 
    //     set { _color = value; } 
    // }
}