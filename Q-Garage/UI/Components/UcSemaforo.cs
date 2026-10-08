using System.Drawing;
using System.Windows.Forms;
using Q_Garage.Models;

namespace Q_Garage.UI.Components
{
    public partial class UcSemaforo : UserControl
    {
        // Colores de luces activas
        private readonly Color RojoActivo = Color.FromArgb(255, 0, 0);
        private readonly Color AmarilloActivo = Color.FromArgb(255, 216, 0);
        private readonly Color VerdeActivo = Color.FromArgb(35, 219, 0);

        // Colores de luces apagadas (atenuadas)
        private readonly Color RojoApagado = Color.FromArgb(100, 0, 0);
        private readonly Color AmarilloApagado = Color.FromArgb(60, 50, 10);
        private readonly Color VerdeApagado = Color.FromArgb(10, 50, 20);

        // Color para el texto de las etiquetas inactivas
        private readonly Color TextoInactivo = Color.FromArgb(55, 55, 55);

        public UcSemaforo()
        {
            InitializeComponent();
            EstablecerEstatus(EstatusServicio.EnEspera);
        }

        public void EstablecerEstatus(EstatusServicio estatus)
        {
            // 1. Apagar todas las luces
            btn_rojo.FillColor = RojoApagado;
            btn_amarillo.FillColor = AmarilloApagado;
            btn_verde.FillColor = VerdeApagado;

            // 2. Atenuar todas las etiquetas
            lbl_espera.ForeColor = TextoInactivo;
            lbl_proceso.ForeColor = TextoInactivo;
            lbl_completo.ForeColor = TextoInactivo;

            // 3. Encender la luz y resaltar la etiqueta activa
            switch (estatus)
            {
                case EstatusServicio.EnEspera:
                    btn_rojo.FillColor = RojoActivo;
                    lbl_espera.ForeColor = RojoActivo;
                    break;

                case EstatusServicio.EnProceso:
                    btn_amarillo.FillColor = AmarilloActivo;
                    lbl_proceso.ForeColor = AmarilloActivo;
                    break;

                case EstatusServicio.Completado:
                    btn_verde.FillColor = VerdeActivo;
                    lbl_completo.ForeColor = VerdeActivo;
                    break;
            }
        }
    }
}
