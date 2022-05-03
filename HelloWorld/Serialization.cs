// Summary
// Serialization is the process of converting your objects into stream of bytes (000111001), JSON (JavaScript Object Notation), or XML
// We will be using JSON file since it is the most popular format for storing and transfering data to other computers

using System.IO;
using System.Text.Json;

public class Serialization
{
    private string _filepath = "./Data/Car.json";

    public void SerializationMain()
    {
        Console.WriteLine("===Serialization Demo===");

        // Create a car object we are going to store
        Car carobj = new Car()
        {
            Owner = "Stephen",
            Fuel = 100,
            Brand = "Toyota"
        };

        // We will use a premade class called JsonSerializer that was made for serialization converting C# objects into JSON
        // JsonSerializer has a Serialize method that will convert that C# object into a string datatype that follows the JSON format
        // JsonSerializerOptions object is used to configure the JsonSerializer to make it more readable

        // string jsonString = JsonSerializer.Serialize(carobj, new JsonSerializerOptions()(WriteIndented = true));
        string jsonString = JsonSerializer.Serialize(carobj);
        Console.WriteLine(jsonString);

        // We will use a premade class called File that can be used to read/ write files
        // WriteAllText method will create a file if no file exists and use the jsonString to store that information in that file
        // try 
        // {

        //     File.WriteAllText(_filepath, jsonString);

        // Next step is reading that file and storing it in a C# object

        try
        {
            
            // We need to read the file first to get the information back from the JSON file
            string jsonString2 = File.ReadAllText(_filepath);
            Console.WriteLine(jsonString2);
            // while(true)
            // {
            //     double test = 165
            // }

            // Deserialize method will convert 
            Car carobj2 = JsonSerializer.Deserialize<Car>(jsonString2);
            Console.WriteLine(carobj2.Owner);
        }
        // FileNetFound means that the Car.json doesn't exist and it tried reading it
        catch (FileNotFoundException)
        {
            
            Car carobj3 = new Car();
            string jsonString3 = JsonSerializer.Serialize(carobj3);

            File.WriteAllText(_filepath, jsonString3);
            string jsonString4 = File.ReadAllText(_filepath);
            Console.WriteLine(jsonString4);
        }
        // }
        // catch (DirectoryNotFoundException)
        // {
        //     // this line of code instead
        //     Console.WriteLine("File cannot be found!");
        // }
    }
}