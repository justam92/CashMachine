using System;
using System.Xml.Serialization;

namespace CashMachine
{
    [Serializable]
    public class Customer
    {
        [XmlArray("People")]
        public Person[] people;
    }
    
}
