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
            //creamos un objeto pa SplashScreen y cuando se abra pues luego de 3 segundos se cierra por el timer, eso creo xd
            //nanaa si funciono nice
            SplashScreen splash = new SplashScreen();
            splash.ShowDialog();
            //
            Application.Run(new FormLogin());
        }
    }
}