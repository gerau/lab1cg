namespace lab1cg
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new DrawingLine());
        }
    }
}