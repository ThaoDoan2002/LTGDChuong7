using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace EmployeeManager
{
    public class SerializationFile
    {
        public static void ghiFile (List<Employee> listEm,string fileName)
        {
            using (FileStream f = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, listEm);
            }
        }

        public static List<Employee> docFile (string fileName)
        {
            using(FileStream f = new FileStream(fileName,FileMode.Open,FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                List<Employee> listEm =(List<Employee>) bf.Deserialize(f);

                return listEm;
            }
        }
        
    }
}
