using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Logic
{
    class SerializationHandler
    {   
        private static string _fileName = "Users.XML";

        public static List<T> ReadFromXML<T>()
        {
            List<T> list = new List<T>();
            if (File.Exists("Users.XML"))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<T>));
                using (FileStream fs = File.OpenRead(_fileName))
                {
                    list = (List<T>)deserializer.Deserialize(fs);
                }
            }
            return list;
        }

        public static void WriteToXML<T>(List<T> list)
        {
            using (Stream fs = new FileStream(_fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                serializer.Serialize(fs, list);
            }
        }
    }
}
