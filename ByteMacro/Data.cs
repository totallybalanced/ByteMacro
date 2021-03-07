using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace ByteMacro
{
    public class FormData
    {
        public string trigKey = "t";
        public string macroKey = "space";
        public decimal macroDelay = 200;
        public string macroOutput = "test123";
        public string ACKey = "q";
        public decimal ACDelay = 200;
    }

    public static class DataManager
    {
        public static FormData data = new();
    }

    public class NonStaticData
    {
        public string trigKey;
        public string macroKey;
        public decimal macroDelay;
        public string macroOutput;

        public string ACKey;
        public decimal ACDelay;
    }

    public class Data
    {   
        public static void saveData()
        {

            XmlSerializer xs = new XmlSerializer(typeof(FormData));

            using (FileStream fs = new FileStream("Data.xml", FileMode.Create))
            {
                xs.Serialize(fs, DataManager.data);
            }
        }

        public static FormData loadData()
        {
            XmlSerializer xs = new XmlSerializer(typeof(FormData));

            using (FileStream fs = new FileStream("Data.xml", FileMode.Open))
            {
                // This will read the XML from the file and create the new instance
                DataManager.data = xs.Deserialize(fs) as FormData;

                return DataManager.data;
            }
        }
    }
}
