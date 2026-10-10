namespace Q_Garage.UI.Login
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();

            // 1. Conectar manualmente el evento Tick al temporizador
            timer1.Tick += new EventHandler(timer1_Tick);

            // 2. Asegurar que el intervalo esté activo (ej. 30 milisegundos)
            timer1.Interval = 30;

            // 3. Arrancar el temporizador
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Aumenta el valor de la barra
            guna2ProgressBar1.Value += 2;

            // Cuando llega al 100%
            if (guna2ProgressBar1.Value >= 100)
            {
                timer1.Stop(); // Detener el motor

                // Abrir la pantalla de Login
                FrmLogin login = new FrmLogin();
                login.Show();

                // Ocultar la pantalla de Splash
                this.Hide();
            }
        }
    }
}
