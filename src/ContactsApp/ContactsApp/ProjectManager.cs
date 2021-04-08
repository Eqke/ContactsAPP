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
        /// Переменная, хранящая имя файла с данными о контактах
        /// </summary>
        private static string _defaultFileName = "Сontacts.json";

        /// <summary>
        /// Возвращает имя файла, хранящего данные о контактах
        /// </summary>
        public static string DefaultFileName => _defaultFileName;

        /// <summary>
        /// Переменная, хранящая дефолтный путь к данным о контактах
        /// </summary>
        private static string _defaultPathToData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                                                   + "\\ContactsApp\\data\\";

        /// <summary>
        /// Метод, возвращающий дефолтный путь к данным
        /// </summary>
        public static string DefaultPathToData => _defaultPathToData;
        
        /// <summary>
        /// Метод для десериализации
        /// </summary>
        /// <returns></returns>
        public static Project LoadFromFile(string path, string filename)
        {
            JsonSerializer serializer = new JsonSerializer()
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All
            };
            if (File.Exists(path + filename))
            {
                using (StreamReader sr = new StreamReader(path + filename))
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
        public static void SaveToFile(Project data, string path, string filename)
        {
            JsonSerializer serializer = new JsonSerializer()
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All
            };
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            using (StreamWriter sw = new StreamWriter(path + filename))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, data);
                }
            }
        }
    }
}
