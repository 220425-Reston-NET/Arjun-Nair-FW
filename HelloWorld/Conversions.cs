// public class Conversions
// {
//     // Static keyword will make whatever class member belong to the class itself
//     // For us, it means we don't have to create an object out of this class to use it
//     public static void ConversionMain()
//     {
//         // General coding terms
//         // Implicit - just means something is done automatically (usually the compiler)
//         // Explicit - just means you have to write some syntax to do something or to tell the compiler to do something

//         Console.WriteLine("=== Conversion Demo ===");
//         int number = 10;
//         double numberDecimal = 76.3;
//         string word = "Hello";

//         // Implicit Conversion
//         // The computer/ compiler will automatically convert one datatype to another without you having to convert
//         // The general rule is if you are going from a datatype to another datatype without losing information, it will be implicit conversion
//         Console.WriteLine("=Implicit=");
//         numberDecimal = number;

//         // double datatype can set its value using an int datatype
//         numberDecimal = number;
//         Console.WriteLine(numberDecimal);

//         // Explicit Conversion
//         // You have to write a syntax to tell the compiler/ computer to do the conversion anyway regardless of the potential posibility of lising
//         Console.WriteLine("=Explicit=");
//         numberDecimal = 76.3;

//         // A cast is required
//         // syntax: (datatype)variableName;
//         number = (int)numberDecimal;
//         Console.WriteLine(number);

//         // More Explicit Conversion
//         string numberString = number.ToString();
//         Console.WriteLine(numberString);

//         // Converting string into numerical values
//         string doubleString = "438.1239";
//         double double2 = Convert.ToDouble(doubleString);
//         Console.WriteLine(double2/2);
//     }
// }