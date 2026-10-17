namespace proyecto1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //creamos un objeto pa el SplashScreen
            SplashScreen splash = new SplashScreen();
            splash.ShowDialog();
            
            //arrancamos la app y le decimos que FormLogin es la ventana principal
            Application.Run(new FormLogin());
        }
    }
}