using CapaPresentacion;

namespace ProyectoFinal_DISARQ
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
            System.Threading.Thread.CurrentThread.CurrentCulture=new System.Globalization.CultureInfo("es-PE");
            ApplicationConfiguration.Initialize();
            Application.Run(mainForm: new Login());
        }
    }
}