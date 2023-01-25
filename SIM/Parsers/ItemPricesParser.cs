using SIM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SIM.Parsers
{
    class ItemPricesParser :IItemParser
    {
        public ItemPricesParser()
        {
        }

        public Item Parse(string line)
        {
            string[] data = line.Split("|");
           
           // double result = DoubleParse(data[1]);
         //Localization <3
         
            return new Item(data[0].Trim(), double.Parse(data[1].Replace('.',',')));
         
        }
        private double DoubleParse(string data)
        {
            data= data.Trim();
            string[] data2 = data.Split(".");
            
            StringBuilder stringBuilder= new StringBuilder();

            stringBuilder.Append(data2[0]);
            stringBuilder.Append(',');
            stringBuilder.Append(data2[1]);
            

           string number = stringBuilder.ToString();

            if (Double.TryParse(number, out double result))
            {
                return result;
            }
            else
            {
                return 3;
            }           
        }
    }
}
