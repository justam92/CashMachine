using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace CashMachine
{
    class CustomersDatabase
    {

 /*       public static void Record<T>(string filePath, T obj)
        {
            if(obj != null)
            {

                try
                {
                    var fileStr = new FileStream(filePath, FileMode.Create);
                    XmlRootAttribute xRoot = new XmlRootAttribute();

                    XmlSerializer xml = new XmlSerializer(typeof(T), xRoot);
                    xml.Serialize(fileStr, obj);
                    fileStr.Close();

                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        } */

        public static T Reading<T>(string filePath)
        {
            T obj = default(T);
            if (File.Exists(filePath))
            {
                try
                {
                    var fileStr = new FileStream(filePath, FileMode.Open);
                    XmlRootAttribute xRoot = new XmlRootAttribute();
                    xRoot.ElementName = "Customer";
                    xRoot.IsNullable = true;

                    XmlSerializer xml = new XmlSerializer(typeof(T), xRoot);

                    obj = (T)xml.Deserialize(fileStr);
                    fileStr.Close();
                    return obj;
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return obj;
        }
    }
}
