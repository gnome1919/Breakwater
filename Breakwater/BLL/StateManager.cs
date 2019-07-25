using Breakwater.DataModels;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Resources;

namespace Breakwater.BLL
{
    public static class StateManager
    {
        private const string storageFile = "/ApplicationState/storage.json";

        public static void SetState(FirstPage state)
        {
            var newState = JsonConvert.SerializeObject(state);
            var uri = new Uri(storageFile, UriKind.Relative);
            var info = Application.GetResourceStream(uri);
            using (var writer = new StreamWriter(info.Stream))
            {
                writer.Write(newState);
            }
        }

        public static FirstPage GetState()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, storageFile);
            var uri = new Uri("pack://application:,,,/ApplicationState/storage.json");
            var info = Application.GetResourceStream(uri);
            using (var reader = new StreamReader(info.Stream))
            {
                var states = reader.ReadToEnd();
                var firstPage = JsonConvert.DeserializeObject<FirstPage>(states);

                return firstPage;
            }
        }
    }
}
