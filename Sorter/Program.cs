using System;
using System.Collections.Generic;

namespace Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> FullList = new List<Item>();
          

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Item item = new Item(i, "item" + i, 1);
                    FullList.Add(item);
                }
                else 
                {
                    Item item = new Item(i, "item" + (i-1), 2);
                    FullList.Add(item);
                }
                 
            }
            List<Item> FullListSorted = new List<Item>();



            for (int i = 0; i < FullList.Count-1; i++)
            {
                if (FullList[i].Value < FullList[i + 1].Value)
                {
                    FullListSorted.Add(FullList[i]);
                }
         
            }
            for (int x = 0; x < FullList.Count - 1; x++)
            {
                if (FullList[x].Value == 2)
                {
                    FullListSorted.Add(FullList[x]);
                }
            }

            foreach (Item item in FullList) 
            {
                Console.WriteLine("Index: "+item.Id.ToString() + "  Item pair: " + item.Name.ToString() + "  Item type " + item.Value.ToString());
            }

            Console.WriteLine();

            foreach (Item item in FullListSorted)
            {
                Console.WriteLine("Index: " + item.Id.ToString() + "  Item pair: " + item.Name.ToString() + "  Item type " + item.Value.ToString());
            }

            Console.ReadLine();
        }
    }
}
