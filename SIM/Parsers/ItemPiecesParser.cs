using SIM.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIM.Parsers
{
    class ItemPiecesParser :IItemParser
    {
        public ItemPiecesParser()
        {
        }

        public Item Parse (string line)
        {
            string[] data = line.Split(",");

            return new Item(data[0].Trim(), int.Parse(data[1].Trim()));
        }
    }
}
