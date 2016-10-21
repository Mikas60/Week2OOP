using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Inventory
    {

        int maxItems = 8;

        public int MaxItems
        {

            get {return maxItems;}
            set {maxItems = value;}

        }
        public List<Item> Items = new List<Item>();

        public bool IsOpen {get; set;}

        public Inventory()
        {
            
        }

        public void AddItem(Item item)
        {
            if(IsOpen)
            {
                if(Items.Count < maxItems)
                {
                    Items.Add(item);
                }
                else
                {
                    Console.WriteLine("Inventory is full!");
                }
            }
            else
            {
                Console.WriteLine("Inventory is closed!");
            }
        }


        public void Open()
        {
            if(IsOpen)
            {
                Console.WriteLine("Your Inventory is already open.");
            }
            else
            {
                Console.WriteLine("Your Inventory is now open.");
                IsOpen = true;
            }
        }

        public void Close()
        {
            if(IsOpen)
            {
                Console.WriteLine("Your Inventory is now closed.");
                IsOpen = false;
            }
            else
            {
                Console.WriteLine("Your Inventory is already close.");
            }
        }

        public void ListInventory()
        {

            foreach(Item item in Items)
            {
                item.Describe();
            }
        }

    }

}