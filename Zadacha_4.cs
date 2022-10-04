using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Invoice
    { 
        public readonly int Account;
        public readonly string Customer;
        public readonly string Provider;
        private string _article;
        private int _quantity;

        public string Article
        {
            get => _article;
            set => _article = value;
        }

        public int Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }

        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public Invoice(int account, string customer, string provider, string article, int quantity) : this(account, customer, provider)
        {
            _article = article;
            _quantity = quantity;
        }

        public double GetAccountWithNds(double nds = 0.2)
        {
            return Account + (Account * nds);
        }

        public void Show()
        { 
            Console.WriteLine($"До оплати: {Account} без ПДВ та {GetAccountWithNds()} з ПДВ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(200, "Ivanko", "KrytaCompany")
            {
                Quantity = 20,
                Article = "Noski"
            };
            invoice.GetAccountWithNds();
            invoice.Show();
        }
    }
}


