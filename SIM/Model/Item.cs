using System;
using System.Collections.Generic;
using System.Text;

namespace SIM.Model
{
    class Item
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public int Count { get; private set; }
        public double Price { get; private set; }

        public Item(string id, string name)
        {
            Id = id;
            Name = name;
            Count = 0;
            Price = 0;
        }
        public Item(string id, int count)
        {
            Id = id;
            Name = "";
            Count = count;
            Price = 0;
        }
        public Item(string id, double price)
        {
            Id = id;
            Name = "";
            Count = 0;
            Price = price;
        }
        public Item(string Id, string Name, int Count, double Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Count = Count;
            this.Price = Price;
        }

        public void SetCount (int count)
        {
            Count = count;
        }
        public void SetPrice(double price)
        {
            Price = price;
        }

        public override string ToString()
        {
            return string.Format(Id + " "+ Name + ": " + Count + " pcs available, Price: " 
                + Price.ToString() + "$, All: " + (Price * (double)Count).ToString());
        }
    }
}
