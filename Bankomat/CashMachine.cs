using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    class CashMachine
    {
        private Customer customer;

        private int accountNumber;

        public CashMachine(Customer customer) {
            this.customer = customer;
        }    

        public void SignIn()
        {
            SignIn signIn = new SignIn();
            accountNumber = signIn.UserSignIn(customer);
            Menu(signIn);
        }

        public void Menu(SignIn signIn)
        {
            int usersChoice;
            bool leaveTheLoop = false;

            Console.WriteLine("Witamy w bankomacie");
            do
            {
                Console.WriteLine("Proszę wybrać czynność");
                Console.WriteLine("1. Wpłata gotówki");
                Console.WriteLine("2. Wypłata gotówki");
                Console.WriteLine("3. Sprawdź stan konta");
                Console.WriteLine("4. Wyloguj");

                usersChoice = int.Parse(Console.ReadLine());

                switch (usersChoice)
                {
                    case 1:
                        CashPayment();
                        break;
                    case 2:
                        CashWithdrawal();
                        break;
                    case 3:
                        CheckTheAccountBalance();
                        break;
                    case 4:
                        SignOut();
                        leaveTheLoop = true;
                        break;
                    default:
                        Console.WriteLine("Niestety, na liście nie ma takiego wyboru...");
                        break;
                }
            } while (leaveTheLoop != true);
        }

        public void CashPayment()
        {
            foreach(Person person in customer.people)
            {
                if(accountNumber == person.accountNumber)
                {
                    Console.WriteLine("Ile wpłacić gotówki?");
                    int paidInCash = int.Parse(Console.ReadLine());
                    person.accountBalance += paidInCash;

                    Console.WriteLine("Teraz łącznie na koncie jest: " + person.accountBalance);
                    break;
                }
            }
        }

        public void CashWithdrawal()
        {
            foreach (Person person in customer.people)
            {
                if (accountNumber == person.accountNumber)
                {
                    Console.WriteLine("Ile wypłacić gotówki?");
                    int paidOutCash = int.Parse(Console.ReadLine());
                    person.accountBalance -= paidOutCash;

                    Console.WriteLine("Teraz łącznie na koncie jest: " + person.accountBalance);
                    break;
                }
            }
        }

        public void CheckTheAccountBalance()
        {

            foreach (Person person in customer.people)
            {
                if (accountNumber == person.accountNumber)
                {
                    Console.WriteLine("Na Twoim koncie jest: " + person.accountBalance);
                    break;
                }
            }
        }

        public void SignOut()
        {
            Console.WriteLine("Wylogowano");
        }
    }
}
