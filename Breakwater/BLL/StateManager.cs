using Breakwater.DataModels;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows;

namespace Breakwater.BLL
{
    public static class StateManager
    {
        private const string storageFile = "ApplicationState\\storage.json";

        public static void SetState(FirstPage state)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, storageFile);
            var newState = JsonConvert.SerializeObject(state);
            using (var writer = new StreamWriter(path))
            {
                writer.Write(newState);
            }
        }

        public static FirstPage GetState()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, storageFile);
            using (var reader = new StreamReader(path))
            {
                var states = reader.ReadToEnd();
                var firstPage = JsonConvert.DeserializeObject<FirstPage>(states);

                return firstPage;
            }
        }
    }
}
