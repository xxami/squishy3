
namespace XDii {

    using System.Threading;
    using Config;

    public static class Program {
        static void Main() {
            Thread.CurrentThread.SetApartmentState(ApartmentState.STA);
            var setup = new ContainerSetup();
            using (var game = new XDii())
                game.Run();
        }
    }
}
