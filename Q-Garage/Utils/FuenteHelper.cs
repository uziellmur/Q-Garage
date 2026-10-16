using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Q_Garage.Utils
{
    public static class FuenteHelper
    {
        private static PrivateFontCollection coleccionFuentes = new PrivateFontCollection();

        public static void CargarFuente()
        {
       
            string rutaFuente = Path.Combine(Application.StartupPath, "Resources", "Fonts", "High Speed.ttf");

            if (File.Exists(rutaFuente))
            {
                coleccionFuentes.AddFontFile(rutaFuente);
            }
        }

        public static Font ObtenerFuente(float tamaño, FontStyle estilo = FontStyle.Regular)
        {
  
            if (coleccionFuentes.Families.Length > 0)
            {
                return new Font(coleccionFuentes.Families[0], tamaño, estilo);
            }
            return new Font("Arial", tamaño, estilo);
        }
    }
}
