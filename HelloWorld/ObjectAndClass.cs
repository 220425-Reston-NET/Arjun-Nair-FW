// This is how you create a class by using the class keyword
// Public is just there to make the class available for everyone
public class Car 
{
    // This is a field
    // This is used to store information or define the current state of the object
    public string _color = "Blue";
    public string _owner = "Stephen";

    public int _fuel = 100;
    public int _gallonPerMile = 5;

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