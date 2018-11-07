
namespace Squishy3.Config {

    using System.IO;

    public interface ISettings {
        string ProfileName { get; set; }
        Resolution Resolution { get; set; }
    }
}
