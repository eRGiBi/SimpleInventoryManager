using System;
using System.Collections.Generic;
using System.Text;

namespace SIM.Model
{
    interface IItemParser
    {
        public Item Parse(string line);
    }
}
