using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    class SignIn
    {
        public int UserSignIn(Customer customer)
        {
            Console.WriteLine("Logowanie do Bankomatu");

            bool leaveTheLoop = false;
            bool correctAccountNumber = false;
            int login;
            int PINcode;

            do
            {

                do
                {
                    Console.WriteLine("Aby zalogować się prosze podać numer konta");
                    login = Int32.Parse(Console.ReadLine());

                    foreach (Person person in customer.people)
                    {
                        int accountNr = person.accountNumber;

                        if (login == accountNr)
                        {
                            Console.WriteLine("Prawidłowy numer konta");
                            correctAccountNumber = true;
                            break;
                        }

                    }

                    if (correctAccountNumber == false)
                    {
                        Console.WriteLine("Taki numer konta nie istnieje w bazie danych");
                    }

                } while (correctAccountNumber == false);

                Console.WriteLine("Podaj hasło do konta");
                int password = Int32.Parse(Console.ReadLine());

                foreach (Person person in customer.people)
                {
                    PINcode = person.PINcode;

                    if (password == PINcode)
                    {
                        Console.WriteLine("Zalogowano na konto");
                        leaveTheLoop = true;
                        break;
                        //później powinno przejść do Bankomat menu
                    }
                }

                if (leaveTheLoop == false)
                {
                    Console.WriteLine("Wpisz ponownie hasło");
                }

            } while (leaveTheLoop != true);

            return login;
        }
    }
}
