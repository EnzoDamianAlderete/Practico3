namespace Practico3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Validar que solo se ingresen letras en TApellido y TNombre
        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            // Verificar si alguno de los TextBox está vacío
            if (string.IsNullOrWhiteSpace(TDni.Text) ||
                string.IsNullOrWhiteSpace(TNombre.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text))
            {
                // Mostrar un mensaje de error si algún campo está incompleto
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Crear la variable ask y mostrar un cuadro de diálogo de consulta
                DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo Cliente?",
                                                   "Confirmar Inserción",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question,
                                                   MessageBoxDefaultButton.Button1);


                if (ask == DialogResult.Yes)
                {

                    string clienteNombre = $"{TNombre.Text} {TApellido.Text}";
                    MessageBox.Show($"El Cliente: {clienteNombre} se insertó correctamente",
                                    "Guardar",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    LModificar.Text = clienteNombre;
                }
                else
                {
                    // Opcional: manejar la acción cuando se selecciona "No"
                    MessageBox.Show("La inserción ha sido cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void BEliminar_Click(object sender, EventArgs e)
        {

            DialogResult ask = MessageBox.Show($"Está apunto de eliminar el Cliente: {TNombre.Text} {TApellido.Text}",
                                               "Confirmar Eliminación",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Exclamation,
                                               MessageBoxDefaultButton.Button2);

            // Evaluar la respuesta
            if (ask == DialogResult.Yes)
            {
                // Limpiar todos los campos y el label LModificar
                TDni.Clear();
                TNombre.Clear();
                TApellido.Clear();
                LModificar.Text = string.Empty;

                // Mostrar mensaje de confirmación de eliminación
                MessageBox.Show($"El Cliente: {TNombre.Text} {TApellido.Text} se eliminó correctamente",
                                "Eliminar",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                // Mostrar mensaje de cancelación (opcional)
                MessageBox.Show("La eliminación ha sido cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            if (RBVaron.Checked)
            {
                // Cambia la imagen del PictureBox a la del varón
                pictureBox1.Image = Image.FromFile("../../../Images/male.jpeg");
            }
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMujer.Checked)
            {
                // Cambia la imagen del PictureBox a la de la mujer
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RBMujer_CheckedChanged_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../../Images/female.jpeg");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
