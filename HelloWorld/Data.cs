// using System.Collections;

// public class Data {
//     public int _eggPrice;
//     public int _milkPrice;
//     public int _waterPrice;
//     public int _totalPrice;



//     public void Menu() 
//     {
//         Console.WriteLine("Welcome to the Store Menu");
//         Console.WriteLine("Please select from the menu");

//         Console.WriteLine("1. Eggs");
//         Console.WriteLine("2. Milk");
//         Console.WriteLine("3. Water");
//         Console.WriteLine("4. Checkout");

//         // return false;

//     }

//     public Data()
//     {
//         _eggPrice = 4;
//         _milkPrice = 2;
//         _waterPrice = 3;
//         _totalPrice = 0;


//     }

//     Dictionary<string> _StoreItems = new _S

//     List<int> _numbersList = new List<int>();

// HashSet<int> _numberHash = new HashSet<int>();

// foreach(int elemant in _numbersArray)
//     {
//         Console.WriteLine(elemant);
//     }

//     for (int i = 0; i < _numbersList.Count; i++)
//     {
//         Console.WriteLine(_numbersList[i]);

//     }
//     int i2 =0;
//     while (i2 < _numbersList.Count)
//         i2++;
//     {

//             Console.WriteLine(_numbersList[12]);
//             i2++;
//     }
//     Console.WriteLine("===Tores Items===");
//     _numberHash.Add(Eggs);
//     _numberHash.Add(Milk);
//     _numberHash.Add(Water);

// }

using System.Collections;

public class StoreMenu
{
    public int _eggPrice;
    public int _milkPrice;
    public int _waterPrice;
    public int _totalPrice;

    Dictionary<string, int> _personAge = new Dictionary<string, int>();

    ArrayList _numbersArrayList = new ArrayList();
    
    int[] _numbersArray = new int[5];


    
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

        Console.WriteLine("===Dictionary Demo===");
        _personAge.Add("Egg", 4);
        _personAge.Add("Milk", 2);
        _personAge.Add("Water", 3);


        List<int> _numbersList = new List<int>();

        HashSet<int> _numberHash = new HashSet<int>();

        // foreach(int elemant in _numbersArray)
        //     {
        //         Console.WriteLine(elemant);
        //     }

        //     for (int i = 0; i < _numbersList.Count; i++)
        //     {
        //         Console.WriteLine(_numbersList[i]);

        //     }
        //     int i2 =0;
        //     while (i2 < _numbersList.Count)
        //         i2++;
        //     {
                    
        //             Console.WriteLine(_numbersList[i2]);
        //     }
    }
}
