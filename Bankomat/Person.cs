using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    [Serializable]
    public class Person
    {
        public int accountNumber { get; set; }

        public int accountBalance { get; set; }

        public int PINcode { get; set; }
    }
}
