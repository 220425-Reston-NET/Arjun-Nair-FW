using System.Collections;

namespace Day4

{
    public class StoreMenu
    {
        // public int _eggPrice;
        // public int _milkPrice;
        // public int _waterPrice;
        // public int _totalPrice;

        public string _name;
        public string Name
        {
            get{return _name;}
            set{_name = value;}
        }
        public int _eggPrice;
        public int _milkPrice;
        public int _waterPrice;
        public int _totalPrice;
        public  int TotalPrice
        {
            get{return _totalPrice;}
            set{_totalPrice = value;}
        }


        Dictionary<string, int> _storeItem = new Dictionary<string, int>();

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
            _storeItem.Add("Egg", 4);
            _storeItem.Add("Milk", 2);
            _storeItem.Add("Water", 3);


            List<int> _numbersList = new List<int>();

            HashSet<int> _numberHash = new HashSet<int>();
        }

        public void StoreItem()
        {
            bool repeat = true;
            while(repeat){
            
            Console.WriteLine("1. Egg $" + _eggPrice);
            Console.WriteLine("2. Milk $" + _milkPrice);
            Console.WriteLine("3. Water $" + _waterPrice);
            Console.WriteLine("4. Checkout");
            Console.WriteLine("Current Total $" + _totalPrice);
            
            string answer = Console.ReadLine();
            // if (answer == "1")
            // {
            //     Console.WriteLine("Current Total: $" + (_totalPrice = _totalPrice + _eggPrice));
            // }
            if(answer == "1")
            {
                Console.WriteLine("egg $4");
                _totalPrice += _eggPrice;
                Console.WriteLine("Current Total $" + _totalPrice);
            }
            else if (answer == "2")
            {
                Console.WriteLine("milk $2");
                _totalPrice += _milkPrice;
                Console.WriteLine("Current Total $" + _totalPrice);
            }
            else if(answer == "3")
            {
                Console.WriteLine("water $3");
                _totalPrice += _waterPrice;
                Console.WriteLine("Current Total $" + _totalPrice);
            }
            // else if(answer == "4")
            // {
            //     Console.WriteLine("Checkout");
            //     // repeat = false;
            // }
            else if(answer == "4")
                {
                    Console.WriteLine("Your total is: $" + _totalPrice);
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Error: Choose valid option.");
                }

        }
        }
    }
}