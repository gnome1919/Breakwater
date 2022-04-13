using Breakwater.ApplicationState;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Breakwater.StateManagers
{
    public static class ArmStaticState
    {
        private const string storageFile = "ApplicationState\\storage.json";

        public static void SetState(ApplicationState.ApplicationState.ArmStaticPage armStaticPage)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, storageFile);
            var newState = JsonConvert.SerializeObject(armStaticPage);
            using (var writer = new StreamWriter(path))
            {
                writer.Write(newState);
            }
        }

        public static ApplicationState.ApplicationState.ArmStaticPage GetState()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, storageFile);
            using (var reader = new StreamReader(path))
            {
                var states = reader.ReadToEnd();
                var armStaticPage = JsonConvert.DeserializeObject<ApplicationState.ApplicationState.ArmStaticPage>(states);

                return armStaticPage;
            }
        }
    }
}
