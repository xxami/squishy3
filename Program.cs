namespace Squishy3
{
    using System;

    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Squishy3())
                game.Run();
        }
    }
}
