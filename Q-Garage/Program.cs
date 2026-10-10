using Q_Garage.Utils;
using Q_Garage.UI.Login;
namespace Q_Garage
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 1. Configuración inicial de Windows Forms
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 2. Cargar la fuente personalizada en memoria
            FuenteHelper.CargarFuente();

            // 3. Arrancar la aplicación con el Splash Screen
            Application.Run(new Q_Garage.UI.Login.FrmSplash());
        }
    }
}