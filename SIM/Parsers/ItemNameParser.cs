using SIM.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIM.Parsers
{
    class ItemNameParser : IItemParser
    {
        public ItemNameParser()
        {
        }

        public Item Parse(string line)
        {
            string[] data = line.Split(";");

            return new Item(data[0].Trim(), data[1].Trim());
        }
    }
}
