using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter
{
    public class Item
    {
        public Item(int id, string name,int value)
        {
            Id= id;
            Name= name; 
            Value= value;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

    }
}
