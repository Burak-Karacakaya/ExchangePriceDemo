using ExchangePrice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangePrice.Classes
{
    public class Sale
    {
        ExchangePriceEntities1 exchangePriceEntities = new ExchangePriceEntities1();
        public void makeSale(string customerName, string customerSurname, int currencyCode, string operationType, decimal currentValue, decimal amount, decimal totalprice)
        {
            Operations operation = new Operations();
            operation.CustomerName = customerName;
            operation.CustomerSurname = customerSurname;
            operation.CurrencyId = currencyCode;
            operation.OperationType = operationType;
            operation.CurrentValue = currentValue;
            operation.Amount = amount;
            operation.TotalPrice = totalprice;
            operation.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            exchangePriceEntities.Operations.Add(operation);
            exchangePriceEntities.SaveChanges();
            Console.WriteLine("Selling is success.");


        }
    }
}
