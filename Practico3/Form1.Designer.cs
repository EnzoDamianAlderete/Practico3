
namespace Practico3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LDni = new Label();
            LNombre = new Label();
            LApellido = new Label();
            LNya = new Label();
            LModificar = new Label();
            TDni = new TextBox();
            TNombre = new TextBox();
            TApellido = new TextBox();
            BGuardar = new Button();
            BEliminar = new Button();
            SuspendLayout();
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(57, 67);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 0;
            LDni.Text = "DNI";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(57, 100);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(57, 134);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido";
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.Location = new Point(57, 35);
            LNya.Name = "LNya";
            LNya.Size = new Size(107, 15);
            LNya.TabIndex = 3;
            LNya.Text = "Nombre y Apellido";
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(197, 35);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 4;
            LModificar.Text = "Modificar";
            // 
            // TDni
            // 
            TDni.Location = new Point(155, 64);
            TDni.Name = "TDni";
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 5;
            TDni.TextChanged += TDni_TextChanged;
            TDni.KeyPress += TDni_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(155, 97);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 6;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(155, 126);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 7;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(61, 190);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 8;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(180, 190);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 9;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Controls.Add(TApellido);
            Controls.Add(TNombre);
            Controls.Add(TDni);
            Controls.Add(LModificar);
            Controls.Add(LNya);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Controls.Add(LDni);
            Name = "Form1";
            Text = "Pequeño Formulario";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label LDni;
        private Label LNombre;
        private Label LApellido;
        private Label LNya;
        private Label LModificar;
        private TextBox TDni;
        private TextBox TNombre;
        private TextBox TApellido;
        private Button BGuardar;
        private Button BEliminar;
    }
}
