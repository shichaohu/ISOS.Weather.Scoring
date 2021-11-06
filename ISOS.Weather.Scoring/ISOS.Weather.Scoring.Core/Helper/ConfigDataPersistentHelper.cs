using ISOS.Weather.Scoring.Core.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISOS.Weather.Scoring.Core.Helper
{
    /// <summary>
    /// 配置数据持久化帮助类
    /// </summary>
    public static class ConfigDataPersistentHelper
    {
        private static readonly string ConfigDataFilePath = Path.Combine(AppContext.BaseDirectory, "ConfigData.json");
        static ConfigDataPersistentHelper()
        {
            if (!File.Exists(ConfigDataFilePath))
            {
                File.Create(ConfigDataFilePath);
            }
        }
        public static void SaveConfigDataToJsonFile<T>(T configData) where T : class
        {
            string configDataJson = JsonConvert.SerializeObject(configData);
            using FileStream fs = new(ConfigDataFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            using StreamWriter sw = new(fs, Encoding.UTF8);
            sw.WriteLine(configDataJson);
        }
        public static T ReadeConfigDataFileToList<T>() where T : class
        {
            if (!File.Exists(ConfigDataFilePath)) return null;
            string json = string.Empty;
            using (FileStream fs = new(ConfigDataFilePath, FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                using StreamReader sr = new(fs, Encoding.UTF8);
                json = sr.ReadToEnd().ToString();
            }

            //反序列化Json字符串内容为配置数据对象
            var result = JsonConvert.DeserializeObject<T>(json);

            return result;
        }
    }
}
