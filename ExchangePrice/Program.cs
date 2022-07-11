using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ExchangePrice.Classes;
using ExchangePrice.Model;

namespace ExchangePrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ExchangePriceEntities1 exchangePriceEntities = new ExchangePriceEntities1();
            GetCurrency getCurrency = new GetCurrency();
            Sale sale = new Sale();



            Console.WriteLine("Welcome To Currency Operation");
            Console.WriteLine();
            Console.WriteLine("User : Admin " + "           Date:" + DateTime.Now.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine("Select the operation you want to do..");
            Console.WriteLine();
            Console.WriteLine("1-Currencies List");
            Console.WriteLine("2-Live Exchange Currently");
            Console.WriteLine("3-Make Operation");
            Console.WriteLine("4-Buyying Operation List");
            Console.WriteLine("5-Selling Operation List");
            Console.WriteLine("6-Exchange Saved Database");
            Console.WriteLine("7-Help");
            Console.WriteLine("8-Exit");
            Console.WriteLine();
            Console.WriteLine("Operation Number:");

            string choose;
            choose = Console.ReadLine();

            if (choose == "1" || choose == "01")
            {
                CurrenciesList(exchangePriceEntities);
            }
            if (choose == "2" || choose == "02")
            {
                CurrentCurrency(exchangePriceEntities);
            }
            if (choose == "3" || choose == "03")
            {
                Console.WriteLine();
                Console.WriteLine("Customer Name : ");
                string customerName = Console.ReadLine();
                Console.WriteLine("Customer Surname : ");
                string customerSurname = Console.ReadLine();
                Console.WriteLine("Currencly code : ");
                int currenclyCode = int.Parse(Console.ReadLine()) ;
                Console.WriteLine("Operation Type : ");
                string operationType = Console.ReadLine();
                Console.WriteLine("Live Currencly Exchange Value : ");
                decimal currentValue = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Current Amount : ");
                decimal amount = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Total Price : ");
                decimal totalPrice = decimal.Parse(Console.ReadLine());

                sale.makeSale(customerName, customerSurname, currenclyCode, operationType, currentValue, amount, totalPrice);
            }
            if (choose == "4" || choose == "04")
            {
                Operation operation = new Operation();
                operation.CustomerSellingOperation();
            }
            if (choose == "5" || choose == "05")
            {
                Operation operation = new Operation();
                operation.CustomerBuyingOperation();
            }
            if (choose == "6" || choose == "06")
            {
                GetCurrencyClass(getCurrency);
                Console.WriteLine("Exchange save operation success.");
            }
            if (choose == "7" || choose == "07")
            {
                Console.WriteLine("For your questions : info@exchange.com");
            }
            if (choose == "8" || choose == "08")
            {
                Environment.Exit(0);
            }



            Console.ReadLine();
        }

        private static void CurrentCurrency(ExchangePriceEntities1 exchangePriceEntities)
        {
            Console.WriteLine();
            Console.WriteLine("Live Exchange List");
            Console.WriteLine();
            var values = exchangePriceEntities.CurrencyValues.ToList();
            foreach (var value in values)
            {
                Console.WriteLine("Exchange " + " " + value.Currencies.CurrencyName + " Buying : " + value.CurrencyBuying + " Selling : " + value.CurrencySelling);
            }
        }

        private static void GetCurrencyClass(GetCurrency getCurrency)
        {
            getCurrency.saveCurrencyDollar();
            getCurrency.saveCurrencyEuro();
            getCurrency.saveCurrencySterlin();
        }

        private static void CurrenciesList(ExchangePriceEntities1 exchangePriceEntities)
        {
            Console.WriteLine();
            Console.WriteLine("Exchange List");
            Console.WriteLine();
            var values = exchangePriceEntities.Currencies.ToList();
            foreach (var value in values)
            {
                Console.WriteLine(value.Id + " " + value.CurrencyName + " " + value.CurrencySembol);
            }
        }
    }
}
