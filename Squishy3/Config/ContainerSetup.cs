
namespace Squishy3.Config {

    using System.IO;
    using System.IO.Abstractions;
    using MicroResolver;

    public class ContainerSetup {
        private ObjectResolver _resolver;

        public ContainerSetup() {
            _resolver = ObjectResolver.Create();
            _resolver.Register<IFileSystem, FileSystem>();
            _resolver.Register<ISettings, Settings>(Lifestyle.Singleton);

            _resolver.Compile();
        }
    }
}
