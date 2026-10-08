namespace Q_Garage.UI.Components
{
    partial class UcSemaforo
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btn_rojo = new Guna.UI2.WinForms.Guna2CircleButton();
            btn_amarillo = new Guna.UI2.WinForms.Guna2CircleButton();
            btn_verde = new Guna.UI2.WinForms.Guna2CircleButton();
            lbl_completado = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbl_espera = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbl_proceso = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbl_completo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // btn_rojo
            // 
            btn_rojo.BorderColor = Color.Maroon;
            btn_rojo.BorderThickness = 4;
            btn_rojo.DisabledState.BorderColor = Color.DarkGray;
            btn_rojo.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_rojo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_rojo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_rojo.FillColor = Color.Red;
            btn_rojo.Font = new Font("Segoe UI", 9F);
            btn_rojo.ForeColor = Color.Transparent;
            btn_rojo.Location = new Point(104, 3);
            btn_rojo.Name = "btn_rojo";
            btn_rojo.PressedColor = Color.Transparent;
            btn_rojo.ShadowDecoration.BorderRadius = 30;
            btn_rojo.ShadowDecoration.Color = Color.Red;
            btn_rojo.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btn_rojo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btn_rojo.ShadowDecoration.Shadow = new Padding(10);
            btn_rojo.Size = new Size(31, 31);
            btn_rojo.TabIndex = 0;
            // 
            // btn_amarillo
            // 
            btn_amarillo.BorderColor = Color.FromArgb(192, 192, 0);
            btn_amarillo.BorderThickness = 4;
            btn_amarillo.DisabledState.BorderColor = Color.DarkGray;
            btn_amarillo.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_amarillo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_amarillo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_amarillo.FillColor = Color.Yellow;
            btn_amarillo.Font = new Font("Segoe UI", 9F);
            btn_amarillo.ForeColor = Color.White;
            btn_amarillo.Location = new Point(104, 40);
            btn_amarillo.Name = "btn_amarillo";
            btn_amarillo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_amarillo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btn_amarillo.Size = new Size(31, 31);
            btn_amarillo.TabIndex = 1;
            // 
            // btn_verde
            // 
            btn_verde.BorderColor = Color.Green;
            btn_verde.BorderThickness = 4;
            btn_verde.DisabledState.BorderColor = Color.DarkGray;
            btn_verde.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_verde.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_verde.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_verde.FillColor = Color.FromArgb(0, 192, 0);
            btn_verde.Font = new Font("Segoe UI", 9F);
            btn_verde.ForeColor = Color.White;
            btn_verde.Location = new Point(104, 77);
            btn_verde.Name = "btn_verde";
            btn_verde.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btn_verde.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btn_verde.Size = new Size(31, 31);
            btn_verde.TabIndex = 2;
            // 
            // lbl_completado
            // 
            lbl_completado.BackColor = Color.Transparent;
            lbl_completado.Location = new Point(0, 0);
            lbl_completado.Name = "lbl_completado";
            lbl_completado.Size = new Size(0, 0);
            lbl_completado.TabIndex = 0;
            lbl_completado.Text = null;
            // 
            // lbl_espera
            // 
            lbl_espera.BackColor = Color.Transparent;
            lbl_espera.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_espera.ForeColor = Color.White;
            lbl_espera.Location = new Point(7, 11);
            lbl_espera.Name = "lbl_espera";
            lbl_espera.Size = new Size(73, 16);
            lbl_espera.TabIndex = 3;
            lbl_espera.Text = "EN ESPERA";
            // 
            // lbl_proceso
            // 
            lbl_proceso.BackColor = Color.Transparent;
            lbl_proceso.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_proceso.ForeColor = Color.White;
            lbl_proceso.Location = new Point(7, 48);
            lbl_proceso.Name = "lbl_proceso";
            lbl_proceso.Size = new Size(85, 16);
            lbl_proceso.TabIndex = 4;
            lbl_proceso.Text = "EN PROCESO";
            // 
            // lbl_completo
            // 
            lbl_completo.BackColor = Color.Transparent;
            lbl_completo.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_completo.ForeColor = Color.White;
            lbl_completo.Location = new Point(7, 86);
            lbl_completo.Name = "lbl_completo";
            lbl_completo.Size = new Size(91, 16);
            lbl_completo.TabIndex = 5;
            lbl_completo.Text = "COMPLETADO";
            // 
            // UcSemaforo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            Controls.Add(lbl_completo);
            Controls.Add(lbl_proceso);
            Controls.Add(lbl_espera);
            Controls.Add(lbl_completado);
            Controls.Add(btn_verde);
            Controls.Add(btn_amarillo);
            Controls.Add(btn_rojo);
            Name = "UcSemaforo";
            Size = new Size(145, 115);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btn_rojo;
        private Guna.UI2.WinForms.Guna2CircleButton btn_amarillo;
        private Guna.UI2.WinForms.Guna2CircleButton btn_verde;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_completado;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_espera;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_proceso;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_completo;
    }
}
