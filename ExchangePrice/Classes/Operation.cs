using ExchangePrice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangePrice.Classes
{
    
    public class Operation
    {
        ExchangePriceEntities1 exchangePriceEntities = new ExchangePriceEntities1();

        public void CustomerSellingOperation()
        {
            var values = exchangePriceEntities.Operations.Where(x => x.OperationType == "selling").ToList();
            foreach (var value in values)
            {
                Console.WriteLine("Id : " + value.Id+ " Customer : " + value.CustomerName + " " + value.CustomerSurname + " Currency : " + value.Currencies.CurrencyName + " Operation Type : " + value.OperationType + " Currency Price : "
                    + value.CurrentValue + " Buying Amount : " + value.Amount + " Total price : " + value.TotalPrice);
            }
        }
        public void CustomerBuyingOperation()
        {
            var values = exchangePriceEntities.Operations.Where(x => x.OperationType == "buying").ToList();
            foreach (var value in values)
            {
                Console.WriteLine("Id : " + value.Id + " Customer : " + value.CustomerName + " " + value.CustomerSurname + " Currency : " + value.Currencies.CurrencyName + " Operation Type : " + value.OperationType + " Currency Price : "
                    + value.CurrentValue + " Buying Amount : " + value.Amount + " Total price : " + value.TotalPrice);
            }
        }

    }
}
