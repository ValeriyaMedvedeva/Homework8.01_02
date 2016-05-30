using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using GameOfLife.Data;

namespace GameOfLife.Data
{
    public class Settings
    {
        private string settingsPath;
        public Settings(string pathToSettings)
        {
            settingsPath = pathToSettings;
        }
        public GameSettings GetSettings()
        {
            GameSettings settings = null;
            var js = new DataContractJsonSerializer(typeof(GameSettings));
            string json = File.ReadAllText(settingsPath);
            using (MemoryStream stream1 = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                settings = (GameSettings)js.ReadObject(stream1);

            }
            return settings;
        }
    }
}
