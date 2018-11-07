
namespace Squishy3 {

    using System.Threading;
    using Config;

    public static class Program {
        static void Main() {
            Thread.CurrentThread.SetApartmentState(ApartmentState.STA);
            var setup = new ContainerSetup();
            using (var game = new Squishy3())
                game.Run();
        }
    }
}
