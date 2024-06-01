using System;
using System.IO;
using System.Text.Json;

namespace WpfApp1
{
    public static class SerializationHelper
    {
        public static T Deserialize<T>(string jsonData)
        {
            return JsonSerializer.Deserialize<T>(jsonData);
        }

        public static string Serialize<T>(T obj)
        {
            return JsonSerializer.Serialize(obj);
        }
    }
}
