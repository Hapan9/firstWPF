using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace DAL
{
    public class WorkWithXML<T>
    {
        /// <summary>
        /// Возвращает лист пользователей
        /// </summary>
        /// <param name="path">путь к файлу</param>
        /// <returns>Лист пользователей</returns>
        public static T InfoFromXml(string path)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                return (T)xml.Deserialize(fs);
            }
        }

        /// <summary>
        /// Записывает всех пользователей в xml
        /// </summary>
        /// <param name="path">путь к файлу</param>
        /// <param name="obj">Лист пользователей</param>
        public static void RewriteXML(string path, T obj)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                xml.Serialize(fs, obj);
            }
        }
    }
}
