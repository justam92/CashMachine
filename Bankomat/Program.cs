using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //odczyt pliku xml
            string filePath = @"klienci.xml";

            Customer readingOfCustomer = new Customer();

            readingOfCustomer = CustomersDatabase.Reading<Customer>(filePath);

            //Console.WriteLine(odczytKlient.numerKonta + " " + odczytKlient.stanKonta + " " + odczytKlient.kodPin);

            CashMachine cashMachine = new CashMachine(readingOfCustomer);
            cashMachine.SignIn();

            Console.Read();
        }
    }
}
