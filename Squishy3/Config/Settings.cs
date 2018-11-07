
namespace Squishy3.Config {

    using System.IO;
    using SharpYaml;
    using SharpYaml.Serialization;

    public class Settings : ISettings {
        private readonly string _settingsFile = "settings.yaml";
        public string ProfileName { get; set; }
        public Resolution Resolution { get; set; }
        public Settings() {
            var serializer = new Serializer();
            using (var input = new StreamReader(_settingsFile)) {
                var settings = serializer.Deserialize<Settings>(input);
                ProfileName = settings.ProfileName;
                Resolution = settings.Resolution;
            }
        }
    }

    public class Resolution {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
