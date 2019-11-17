using System;
using System.Collections.Generic;

namespace _07._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxesList = new List<Box>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                Box box = ReadInput(input);

                Insert(boxesList, box);
            }
            Print(boxesList);
        }

        private static Box ReadInput(string input)
        {
            string[] splitedInput = input.Split();
            string serialNumber = splitedInput[0];
            string itemName = splitedInput[1];
            int itemQantity = int.Parse(splitedInput[2]);
            decimal itemPrice = decimal.Parse(splitedInput[3]);

            Box box = new Box();
            box.Item = new Item();

            box.SerialNumber = serialNumber;
            box.Item.Name = itemName;
            box.ItemQantity = itemQantity;
            box.Item.Price = itemPrice;
            box.BoxPrice = itemQantity * itemPrice;
            return box;
        }

        private static void Print(List<Box> boxesList)
        {
            foreach (var box in boxesList)
            {
                string serialNumber = box.SerialNumber;
                string itemName = box.Item.Name;
                int itemQantity = box.ItemQantity;
                decimal itemPrice = box.Item.Price;
                decimal boxPrice = box.BoxPrice;

                Console.WriteLine(serialNumber);
                Console.WriteLine($"-- {itemName} - ${itemPrice:F2}: {itemQantity}");
                Console.WriteLine($"-- ${boxPrice:F2}");
            }
        }

        private static void Insert(List<Box> boxesList, Box box)
        {
            if (boxesList.Count == 0)
            {
                boxesList.Add(box);
            }
            else
            {
                bool inserted = false;
                for (int i = boxesList.Count - 1; i >= 0; i--)
                {
                    if (box.BoxPrice < boxesList[i].BoxPrice)
                    {
                        boxesList.Insert(i + 1, box);
                        inserted = true;
                        break;
                    }
                }
                if (!inserted)
                {
                    boxesList.Insert(0, box);
                }
            }
        }
    }
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQantity { get; set; }
        public decimal BoxPrice { get; set; }
    }
}
