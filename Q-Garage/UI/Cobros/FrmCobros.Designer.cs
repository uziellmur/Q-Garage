namespace Q_Garage.UI.Cobros
{
    partial class FrmCobros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            controlBarra1 = new Q_Garage.UI.Components.ControlBarra();
            label1 = new Label();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btnc1 = new Q_Garage.UI.Components.btnC();
            btnc2 = new Q_Garage.UI.Components.btnC();
            btnc3 = new Q_Garage.UI.Components.btnC();
            btncs1 = new Q_Garage.UI.Components.btnCS();
            idcobro = new DataGridViewTextBoxColumn();
            idcliente = new DataGridViewTextBoxColumn();
            idcoti = new DataGridViewTextBoxColumn();
            pago = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // controlBarra1
            // 
            controlBarra1.Dock = DockStyle.Top;
            controlBarra1.Location = new Point(0, 0);
            controlBarra1.Margin = new Padding(3, 4, 3, 4);
            controlBarra1.Name = "controlBarra1";
            controlBarra1.Size = new Size(914, 42);
            controlBarra1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("High Speed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(351, 46);
            label1.Name = "label1";
            label1.Size = new Size(220, 44);
            label1.TabIndex = 1;
            label1.Text = "COBROS";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { idcobro, idcliente, idcoti, pago });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(21, 155);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.Size = new Size(612, 507);
            guna2DataGridView1.TabIndex = 2;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.Red;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 22;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderRadius = 15;
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(21, 97);
            guna2TextBox1.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderForeColor = Color.Gray;
            guna2TextBox1.PlaceholderText = "Buscar";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(286, 38);
            guna2TextBox1.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("High Speed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.Yellow;
            guna2HtmlLabel1.Location = new Point(21, 68);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(97, 22);
            guna2HtmlLabel1.TabIndex = 4;
            guna2HtmlLabel1.Text = "USUARIO";
            // 
            // guna2DateTimePicker1
            // 
            guna2DateTimePicker1.Checked = true;
            guna2DateTimePicker1.CustomizableEdges = customizableEdges3;
            guna2DateTimePicker1.FillColor = Color.Black;
            guna2DateTimePicker1.Font = new Font("Segoe UI", 9F);
            guna2DateTimePicker1.ForeColor = Color.White;
            guna2DateTimePicker1.Format = DateTimePickerFormat.Long;
            guna2DateTimePicker1.Location = new Point(631, 68);
            guna2DateTimePicker1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            guna2DateTimePicker1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2DateTimePicker1.Size = new Size(271, 22);
            guna2DateTimePicker1.TabIndex = 5;
            guna2DateTimePicker1.Value = new DateTime(2026, 10, 16, 10, 37, 0, 23);
            // 
            // btnc1
            // 
            btnc1.Animated = true;
            btnc1.BorderRadius = 8;
            btnc1.CustomizableEdges = customizableEdges5;
            btnc1.DisabledState.BorderColor = Color.DarkGray;
            btnc1.DisabledState.CustomBorderColor = Color.DarkGray;
            btnc1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnc1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnc1.FillColor = Color.FromArgb(255, 0, 0);
            btnc1.Font = new Font("High Speed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnc1.ForeColor = Color.White;
            btnc1.HoverState.FillColor = Color.FromArgb(181, 0, 0);
            btnc1.Location = new Point(662, 155);
            btnc1.Name = "btnc1";
            btnc1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnc1.Size = new Size(225, 68);
            btnc1.TabIndex = 6;
            btnc1.Text = "COBRAR";
            // 
            // btnc2
            // 
            btnc2.Animated = true;
            btnc2.BorderRadius = 8;
            btnc2.CustomizableEdges = customizableEdges7;
            btnc2.DisabledState.BorderColor = Color.DarkGray;
            btnc2.DisabledState.CustomBorderColor = Color.DarkGray;
            btnc2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnc2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnc2.FillColor = Color.FromArgb(255, 0, 0);
            btnc2.Font = new Font("High Speed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnc2.ForeColor = Color.White;
            btnc2.HoverState.FillColor = Color.FromArgb(181, 0, 0);
            btnc2.Location = new Point(662, 291);
            btnc2.Name = "btnc2";
            btnc2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnc2.Size = new Size(225, 68);
            btnc2.TabIndex = 6;
            btnc2.Text = "FACTURAR";
            // 
            // btnc3
            // 
            btnc3.Animated = true;
            btnc3.BorderRadius = 8;
            btnc3.CustomizableEdges = customizableEdges9;
            btnc3.DisabledState.BorderColor = Color.DarkGray;
            btnc3.DisabledState.CustomBorderColor = Color.DarkGray;
            btnc3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnc3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnc3.FillColor = Color.FromArgb(255, 0, 0);
            btnc3.Font = new Font("High Speed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnc3.ForeColor = Color.White;
            btnc3.HoverState.FillColor = Color.FromArgb(181, 0, 0);
            btnc3.Location = new Point(662, 436);
            btnc3.Name = "btnc3";
            btnc3.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnc3.Size = new Size(225, 68);
            btnc3.TabIndex = 6;
            btnc3.Text = "EDITAR";
            // 
            // btncs1
            // 
            btncs1.Animated = true;
            btncs1.BorderRadius = 8;
            btncs1.CustomizableEdges = customizableEdges11;
            btncs1.DisabledState.BorderColor = Color.DarkGray;
            btncs1.DisabledState.CustomBorderColor = Color.DarkGray;
            btncs1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btncs1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btncs1.FillColor = Color.FromArgb(255, 199, 15);
            btncs1.Font = new Font("High Speed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncs1.ForeColor = Color.FromArgb(0, 0, 0);
            btncs1.HoverState.FillColor = Color.FromArgb(196, 153, 10);
            btncs1.Location = new Point(662, 584);
            btncs1.Name = "btncs1";
            btncs1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btncs1.Size = new Size(225, 68);
            btncs1.TabIndex = 7;
            btncs1.Text = "SALIR";
            // 
            // idcobro
            // 
            idcobro.HeaderText = "ID Cobro";
            idcobro.MinimumWidth = 6;
            idcobro.Name = "idcobro";
            // 
            // idcliente
            // 
            idcliente.HeaderText = "ID Cliente";
            idcliente.MinimumWidth = 6;
            idcliente.Name = "idcliente";
            // 
            // idcoti
            // 
            idcoti.HeaderText = "No. Cotizacion";
            idcoti.MinimumWidth = 6;
            idcoti.Name = "idcoti";
            // 
            // pago
            // 
            pago.HeaderText = "Monto";
            pago.MinimumWidth = 6;
            pago.Name = "pago";
            // 
            // FrmCobros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(914, 695);
            ControlBox = false;
            Controls.Add(btncs1);
            Controls.Add(btnc3);
            Controls.Add(btnc2);
            Controls.Add(btnc1);
            Controls.Add(guna2DateTimePicker1);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2TextBox1);
            Controls.Add(guna2DataGridView1);
            Controls.Add(label1);
            Controls.Add(controlBarra1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCobros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCobros";
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Components.ControlBarra controlBarra1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private DataGridViewTextBoxColumn idcobro;
        private DataGridViewTextBoxColumn idcliente;
        private DataGridViewTextBoxColumn idcoti;
        private DataGridViewTextBoxColumn pago;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Components.btnC btnc1;
        private Components.btnC btnc2;
        private Components.btnC btnc3;
        private Components.btnCS btncs1;
    }
}