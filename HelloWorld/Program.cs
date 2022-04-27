// See https://aka.ms/new-console-template for more information
Console.Clear(); // Will clear the console
Console.WriteLine("Hello, World!"); // Writeline will write something in the terminal

// Console.WriteLine("Making a car object!");
// //  [Class name] [NameOfObject] = new [Class name];
// Car carObj1 = new Car();
// Console.WriteLine(carObj1._Color);

// Car carObj2 = new Car("Black");
// Console.WriteLine(carObj2._Color);

// Car carObj3 = new Car();

Car carObj1 = new Car();


// Referencing class members within an object
int mile = carObj1.TotalDistancePerFuel();

carObj1.Sum(5, 10);

Console.WriteLine(mile);

Console.WriteLine("End of method");

string owner = "Chadel";

Car carObj2 = new Car(owner);
Console.WriteLine(carObj2.Owner);
carObj2.Owner = "Daniel";
System.Console.WriteLine(carObj2.Owner);

// Checking if our property constraints is working
carObj2.Fuel = 80;
System.Console.WriteLine(carObj2.Fuel);