using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ContactsApp
{
    /// <summary>
    /// Класс, содержащий методы для сохранения и загрузки из проекта в файл
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// Переменная, хранящая дефолтный путь к данным о контактах
        /// </summary>
        private static string _defaultPathToData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) 
                                                   + "\\ContactsApp\\data\\contacts.txt";
        /// <summary>
        /// Метод, возвращающий 
        /// </summary>
        public static string DefaultPathToData => _defaultPathToData;
        
        /// <summary>
        /// Метод для десериализации
        /// </summary>
        /// <returns></returns>
        public static Project LoadFromFile(string path)
        {
            JsonSerializer serializer = new JsonSerializer()
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All
            };
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    using (JsonReader reader = new JsonTextReader(sr))
                    {
                        return (Project) serializer.Deserialize<Project>(reader);
                    }
                }
            }
            else
            {
                return new Project();
            }
        }

        /// <summary>
        /// Метод для сериализации
        /// </summary>
        /// <param name="data"></param>
        public static void SaveToFile(Project data, string path)
        {
            JsonSerializer serializer = new JsonSerializer()
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All
            };
            using (StreamWriter sw = new StreamWriter(path))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, data);
                }
            }
        }
    }
}
