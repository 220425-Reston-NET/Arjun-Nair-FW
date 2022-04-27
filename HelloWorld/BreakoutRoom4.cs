// Console.WriteLine("Welcome to the Store Menu");

public class StoreMenu
{
    public int _eggPrice;
    public int _milkPrice;
    public int _waterPrice;
    public int _totalPrice;


    
    public void Menu() 
    {
        Console.WriteLine("Welcome to the Store Menu");
        Console.WriteLine("Please select from the menu");

        Console.WriteLine("1. Eggs");
        Console.WriteLine("2. Milk");
        Console.WriteLine("3. Water");
        Console.WriteLine("4. Checkout");

        // return false;
        
    }

    public StoreMenu()
    {
        _eggPrice = 4;
        _milkPrice = 2;
        _waterPrice = 3;
        _totalPrice = 0;


    }




    // _eggSize = "large";
    // _eggPrice = 5;
    // _eggQTY = 12;

    
    public string egg;

    
}