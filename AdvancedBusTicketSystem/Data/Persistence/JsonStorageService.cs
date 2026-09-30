using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;

namespace AdvancedBusTicketSystem.Data.Persistence
{
    public class JsonStorageService
    {
        private readonly JavaScriptSerializer _serializer;

        public JsonStorageService()
        {
            _serializer = new JavaScriptSerializer();
            _serializer.MaxJsonLength = int.MaxValue;
        }

        public void SaveToFile<T>(string filePath, List<T> data)
        {
            try
            {
                string dir = Path.GetDirectoryName(filePath);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                string json = _serializer.Serialize(data);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error saving to {filePath}: {ex.Message}");
            }
        }

        public List<T> LoadFromFile<T>(string filePath)
        {
            try
            {
                if (!File.Exists(filePath)) return new List<T>();
                string json = File.ReadAllText(filePath);
                if (string.IsNullOrWhiteSpace(json)) return new List<T>();

                return _serializer.Deserialize<List<T>>(json) ?? new List<T>();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error loading from {filePath}: {ex.Message}");
                return new List<T>();
            }
        }
    }
}
