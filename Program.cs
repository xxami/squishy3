namespace Squishy3
{
    using System;
    using MicroResolver;
    using SharpYaml;

    public static class Program
    {
        [STAThread]
        static void Main()
        {
            //var container = TinyIoCContainer.Current;
            //container.AutoRegister();

            using (var game = new Squishy3())
                game.Run();
        }
    }
}
