using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SIM.Model
{
    class ItemStorageEnumerator : IEnumerator<Item>
    {
        private ItemStorage storage;
        private int index;

        public ItemStorageEnumerator(ItemStorage storage)
        {
            this.storage = storage;
            index = -1;
        }

        public Item Current => storage[index];

        object IEnumerator.Current => Current;

        public void Dispose() {}

        public bool MoveNext()
        {
            return ++index < storage.Count ;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
