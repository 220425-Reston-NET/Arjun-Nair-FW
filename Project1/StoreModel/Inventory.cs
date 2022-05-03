// See https://aka.ms/new-console-template for more information
System.Console.WriteLine("Hello, World!");

namespace StoreModel
{
    public class Inventory
    {
        private int _invID;
        public int InvID 
        { 
            get { return _invID; }  
            set {
                if (value > 0)
                {
                    _invID = value;
                }
                else
                {
                    Console.WriteLine("Inventory ID can only hold positive numbers!");
                }
            }
        }

        public string Name { get; set; }
        public string Category { get; set; }

        public Inventory()
        {
            InvID = 1;
            Name = "Samsung 48in. SmartTV";
            Category = "TV";
        }
        
    }
    
}