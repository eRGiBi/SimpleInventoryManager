using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SIM.Model
{
    class ItemStorage : IEnumerable<Item>
    {
        private List<Item> items;

        public ItemStorage()
        {
            items = new List<Item>();
        }
        public int Count { get { return items.Count; } }

        public Item this[int index] => items[index];

        public void Add(Item item) { items.Add(item); }
        public void Remove(Item item) { items.Remove(item); }
        public void Clear() { items.Clear(); }

        public void AddRange (List<Item> itemsToAdd)
        {
            bool ItemFound = false;

            foreach(Item itemToAdd in itemsToAdd)
            {
                foreach(Item item in items)
                {
                    if (itemToAdd.Id.Equals(item.Id) && (itemToAdd.Price != 0))
                    {
                        item.SetPrice(itemToAdd.Price);
                        ItemFound = true;
                        break;
                    }
                    if (itemToAdd.Id.Equals(item.Id) && (itemToAdd.Count != 0))
                    {
                        item.SetCount(itemToAdd.Count);
                        ItemFound = true;
                        break;
                    }
                }
                if(!ItemFound)            
                {              
                    items.Add(itemToAdd);           
                }               
            }          
        }
        public IEnumerator<Item> GetEnumerator()
        {
            return new ItemStorageEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
