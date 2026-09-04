using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace Homework.Homework13
{
    internal class JsonToXmlService
    {

        public bool Process(string folderPath)
        {

            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine($"Ошибка: папка '{folderPath}' не существует.");
                return false;
            }

            string[] jsonFiles = Directory.GetFiles(folderPath, "*.json", SearchOption.TopDirectoryOnly);

            if (jsonFiles.Length == 0)
            {
                Console.WriteLine("Ошибка: в папке нет файлов с расширением .json.");
                return false;
            }
            if (jsonFiles.Length > 1)
            {
                Console.WriteLine($"Ошибка: в папке найдено {jsonFiles.Length} JSON-файлов. Ожидается ровно один.");
                return false;
            }

            string jsonFilePath = jsonFiles[0];
            Console.WriteLine($"Найден JSON-файл: {jsonFilePath}");

            Squad squad;
            try
            {
                string jsonContent = File.ReadAllText(jsonFilePath);
                squad = JsonSerializer.Deserialize<Squad>(jsonContent);
                if (squad == null)
                {
                    Console.WriteLine("Ошибка: десериализация вернула null.");
                    return false;
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Ошибка: JSON-файл повреждён и не может быть распарсен. {ex.Message}");
                return false;
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Ошибка ввода-вывода при чтении файла: {ex.Message}");
                return false;
            }

            if (string.IsNullOrWhiteSpace(squad.SquadName))
            {
                Console.WriteLine("Ошибка: в JSON отсутствует поле 'SquadName' или оно пустое.");
                return false;
            }

            string safeFileName = string.Join("_", squad.SquadName.Split(Path.GetInvalidFileNameChars()));
            if (string.IsNullOrEmpty(safeFileName))
                safeFileName = "squad"; 

            string xmlFilePath = Path.Combine(folderPath, $"{safeFileName}.xml");

            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Squad));
                using (FileStream fs = new FileStream(xmlFilePath, FileMode.Create))
                {
                    xmlSerializer.Serialize(fs, squad);
                }
                Console.WriteLine($"Успешно! XML сохранён в: {xmlFilePath}");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сохранении XML: {ex.Message}");
                return false;
            }
        }

    }
}
