using System;
using System.IO;
using Newtonsoft.Json;

namespace LOLSensFix.Configuration
{
    internal class LsfConfig
    {
        private static LsfConfigContainer _container;
        private static bool _initialized;

        public static bool Init()
        {
            if (_initialized)
            {
                return true;
            }

            var path = GetConfigPath();

            if (!File.Exists(path))
            {
                CreateEmpty();
                return true;
            }

            if (!Load())
            {
                CreateEmpty();
            }

            _initialized = true;
            return true;
        }

        public static LsfConfigContainer Get()
        {
            if (!_initialized)
            {
                return null;
            }

            return _container;
        }

        private static void CreateEmpty()
        {
            _container = new LsfConfigContainer();
            _initialized = true;

            Save();
        }

        private static bool Load()
        {
            var cont = File.ReadAllText(GetConfigPath());

            try
            {
                _container = JsonConvert.DeserializeObject<LsfConfigContainer>(cont);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static void Save()
        {
            File.WriteAllText(GetConfigPath(),
                JsonConvert.SerializeObject(_container, Formatting.Indented));
        }

        private static string GetConfigPath() => $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\lsfcfg.json";
    }
}
