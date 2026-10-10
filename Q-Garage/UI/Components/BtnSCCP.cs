using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Q_Garage.Utils;

namespace Q_Garage.UI.Components
{
    public class BtnSCCP : Guna2Button
    {
        public BtnSCCP()
        {
            // Apariencia general
            this.BorderRadius = 8;
            this.FillColor = Color.FromArgb(255, 199, 15);
            this.ForeColor = Color.FromArgb(0, 0, 0);
            this.Size = new Size(180, 54);

            this.Font = FuenteHelper.ObtenerFuente(9.74f, FontStyle.Bold);

            this.Cursor = Cursors.Hand;
            this.Animated = true;

            this.HoverState.FillColor = Color.FromArgb(196, 153, 10);
        }
    }
}
