using ExchangePrice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExchangePrice.Classes
{
    public class GetCurrency
    {
        ExchangePriceEntities1 exchangePriceEntities = new ExchangePriceEntities1();
        public void saveCurrencyDollar()
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);


            //Dollar
            string dolarBuying = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod = 'USD']/BanknoteBuying").InnerXml;
            dolarBuying = dolarBuying.Replace(".", ",");
            string dolarSelling = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod = 'USD']/BanknoteSelling").InnerXml;
            dolarSelling = dolarSelling.Replace(".", ",");

            CurrencyValues currencyValues = new CurrencyValues();
            currencyValues.CurrencyId = 1;
            currencyValues.CurrencyBuying = decimal.Parse(dolarBuying);
            currencyValues.CurrencySelling = decimal.Parse(dolarSelling);
            currencyValues.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            exchangePriceEntities.CurrencyValues.Add(currencyValues);
            exchangePriceEntities.SaveChanges();


        }
        public void saveCurrencyEuro()
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);

            //Euro
            string euroBuying = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod = 'EUR']/BanknoteBuying").InnerXml;
            euroBuying = euroBuying.Replace(".", ",");
            string euroSelling = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod = 'EUR']/BanknoteSelling").InnerXml;
            euroSelling = euroSelling.Replace(".", ",");

            CurrencyValues currencyValues = new CurrencyValues();
            currencyValues.CurrencyId = 2;
            currencyValues.CurrencyBuying = decimal.Parse(euroBuying);
            currencyValues.CurrencySelling = decimal.Parse(euroSelling);
            currencyValues.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            exchangePriceEntities.CurrencyValues.Add(currencyValues);
            exchangePriceEntities.SaveChanges();


        }

        public void saveCurrencySterlin()
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);


            //Dollar
            string sterlinBuying = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod = 'GBP']/BanknoteBuying").InnerXml;
            sterlinBuying = sterlinBuying.Replace(".", ",");
            string sterlinSelling = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod = 'GBP']/BanknoteSelling").InnerXml;
            sterlinSelling = sterlinSelling.Replace(".", ",");

            CurrencyValues currencyValues = new CurrencyValues();
            currencyValues.CurrencyId = 4;
            currencyValues.CurrencyBuying = decimal.Parse(sterlinBuying);
            currencyValues.CurrencySelling = decimal.Parse(sterlinSelling);
            currencyValues.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            exchangePriceEntities.CurrencyValues.Add(currencyValues);
            exchangePriceEntities.SaveChanges();


        }
    }
}
