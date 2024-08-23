
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            panel1 = new Panel();
            label1 = new Label();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            RBVaron = new RadioButton();
            RBMujer = new RadioButton();
            BSalir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(21, 61);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 0;
            LDni.Text = "DNI";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(21, 94);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(21, 142);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido";
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.Location = new Point(12, 11);
            LNya.Name = "LNya";
            LNya.Size = new Size(107, 15);
            LNya.TabIndex = 3;
            LNya.Text = "Nombre y Apellido";
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(193, 11);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 4;
            LModificar.Text = "Modificar";
            // 
            // TDni
            // 
            TDni.Location = new Point(102, 53);
            TDni.Name = "TDni";
            TDni.Size = new Size(149, 23);
            TDni.TabIndex = 5;
            TDni.TextChanged += TDni_TextChanged;
            TDni.KeyPress += TDni_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(102, 91);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(149, 23);
            TNombre.TabIndex = 6;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(102, 134);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(149, 23);
            TApellido.TabIndex = 7;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // BGuardar
            // 
            BGuardar.Image = (Image)resources.GetObject("BGuardar.Image");
            BGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BGuardar.Location = new Point(50, 298);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(111, 48);
            BGuardar.TabIndex = 8;
            BGuardar.Text = "Guardar";
            BGuardar.TextAlign = ContentAlignment.MiddleRight;
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Image = (Image)resources.GetObject("BEliminar.Image");
            BEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BEliminar.Location = new Point(193, 298);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(126, 48);
            BEliminar.TabIndex = 9;
            BEliminar.Text = "Eliminar";
            BEliminar.TextAlign = ContentAlignment.MiddleRight;
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(TDni);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(LNya);
            panel1.Controls.Add(LModificar);
            panel1.Controls.Add(LDni);
            panel1.Controls.Add(LNombre);
            panel1.Controls.Add(LApellido);
            panel1.Location = new Point(50, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 280);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 182);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 11;
            label1.Text = "Tarjeta de Credito";
            label1.Click += label1_Click;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(168, 203);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(47, 19);
            checkBox3.TabIndex = 10;
            checkBox3.Text = "Visa";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(168, 228);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(87, 19);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "MasterCard";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(168, 178);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Naranja";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(386, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // RBVaron
            // 
            RBVaron.AutoSize = true;
            RBVaron.Checked = true;
            RBVaron.Location = new Point(403, 208);
            RBVaron.Name = "RBVaron";
            RBVaron.Size = new Size(55, 19);
            RBVaron.TabIndex = 12;
            RBVaron.TabStop = true;
            RBVaron.Text = "Varon";
            RBVaron.UseVisualStyleBackColor = true;
            RBVaron.CheckedChanged += RBVaron_CheckedChanged;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Location = new Point(508, 208);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(56, 19);
            RBMujer.TabIndex = 13;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            RBMujer.CheckedChanged += RBMujer_CheckedChanged_1;
            RBMujer.Click += RBMujer_CheckedChanged_1;
            // 
            // BSalir
            // 
            BSalir.Image = (Image)resources.GetObject("BSalir.Image");
            BSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BSalir.Location = new Point(449, 291);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(115, 55);
            BSalir.TabIndex = 14;
            BSalir.Text = "Salir";
            BSalir.TextAlign = ContentAlignment.MiddleRight;
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 389);
            Controls.Add(BSalir);
            Controls.Add(RBMujer);
            Controls.Add(RBVaron);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Name = "Form1";
            Text = "Pequeño Formulario";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel1;
        private PictureBox pictureBox1;
        private RadioButton RBVaron;
        private RadioButton RBMujer;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button BSalir;
        private Label label1;
    }
}
