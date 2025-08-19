using System;
using System.Linq;
using System.Windows.Forms;

namespace Practico3pt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Este método puede quedarse vacío si no se necesita ninguna acción al cargar el formulario
        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {
            // Este método puede quedarse vacío o usarse para validaciones en tiempo real
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
                MessageBox.Show("Solo se permiten números en el DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {
            // Este método puede quedarse vacío
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TDni.Text) ||
                string.IsNullOrWhiteSpace(TNombre.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!TDni.Text.All(char.IsDigit))
            {
                MessageBox.Show("El DNI solo puede contener números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!TNombre.Text.All(char.IsLetter) || !TApellido.Text.All(char.IsLetter))
            {
                MessageBox.Show("Nombre y Apellido solo pueden contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LModificar.Text = TNombre.Text + " " + TApellido.Text;

            DialogResult ask = MessageBox.Show(
                "Seguro que desea insertar un nuevo Cliente?",
                "Confirmar Insercion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
            );

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"El Cliente: {TNombre.Text} {TApellido.Text} se insertó correctamente",
                    "Guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void TEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show(
                $"Está apunto de eliminar el Cliente: {TNombre.Text} {TApellido.Text}",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2
            );

            if (ask == DialogResult.Yes)
            {
                string nombreCliente = $"{TNombre.Text} {TApellido.Text}";

                TDni.Clear();
                TNombre.Clear();
                TApellido.Clear();
                LModificar.Text = "";

                MessageBox.Show(
                    $"El Cliente: {nombreCliente} se eliminó correctamente",
                    "Eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void TSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            if (RBVaron.Checked)
            {
                PBPersona.Image = Properties.Resources.icono_varon; // Asigna la imagen de varón
            }
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMujer.Checked)
            {
                PBPersona.Image = Properties.Resources.icono_mujer; // Asigna la imagen de mujer
            }
        }
    }
}