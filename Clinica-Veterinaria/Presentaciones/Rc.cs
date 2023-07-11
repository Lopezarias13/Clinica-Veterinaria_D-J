using Clinica_Veterinaria.Dato;
using Clinica_Veterinaria.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_Veterinaria.Presentaciones
{
    public partial class Rc : Form
    {
        public Rc()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Rc_Load(object sender, EventArgs e)
        {
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)//Boton Guardar
        {
            if (CamposVacios())
            {
                MessageBox.Show("Debes completar todos los campos", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AgregarFamilia();
                Limpiar();
            }
        }
        private bool CamposVacios()// Metodo para validar campos vacios para el registro de una nueva familia
        {
            return string.IsNullOrWhiteSpace(codigoTextBox.Text) ||
                   string.IsNullOrWhiteSpace(apellido1TextBox.Text) ||
                   string.IsNullOrWhiteSpace(property1TextBox.Text) ||
                   string.IsNullOrWhiteSpace(direccionTextBox.Text) ||
                   string.IsNullOrWhiteSpace(telefonoTextBox.Text);
        }

        private void AgregarFamilia()
        {
            if (CamposVacios())
            {
                // No se guardará la información si los campos están vacíos
                return;
            }

            Cliente cliente = new Cliente();
            cliente.Codigo = codigoTextBox.Text;
            cliente.Apellido = apellido1TextBox.Text;
            cliente.Nombre = property1TextBox.Text;
            cliente.Direccion = direccionTextBox.Text;
            cliente.Telefono = telefonoTextBox.Text;
            cliente.DNI = DnitextBox1.Text;


            

            if (CrudCliente.AgregarCliente(cliente) > 0)
            {
                MessageBox.Show("Cliente Registrado con Éxito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar la Cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Limpiar()
        {
            //idTextBox.Clear();
            codigoTextBox.Clear();
            apellido1TextBox.Clear();
            property1TextBox.Clear();
            direccionTextBox.Clear();
            telefonoTextBox.Clear();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)//bOTON CANCELAR
        {
            this.Close();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)//BOTON NUEVO
        {
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)//BOTON LISTAR CLIENTES
        {
            dataGridView1.DataSource = CrudCliente.ListarCliente();
        }

        private void buttonModificar_Click(object sender, EventArgs e)//BOTON MODIFICAR 
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idCliente = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);// Obtener el ID de la fila seleccionada

                // Buscar la familia por su ID
                Cliente cliente = CrudCliente.BuscarCliente(idCliente);

                if (cliente != null)
                {
                    // Asignar los nuevos valores a la familia
                    cliente.Codigo = codigoTextBox.Text;
                    cliente.Apellido = apellido1TextBox.Text;
                    cliente.Direccion = direccionTextBox.Text;
                    cliente.Telefono = telefonoTextBox.Text;
                    cliente.DNI = DnitextBox1.Text;

                    // Guardar los cambios en la base de datos
                    int resultado = CrudCliente.EditarCliente(cliente);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Cliente modificado exitosamente", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar la Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la Cliente seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el ID de la fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idCliente = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Confirmar la eliminación
                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar esta Cliente?", "Confirmar Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    // Eliminar la Cliente de la base de datos
                    int resultado = CrudCliente.EliminarCliente(idCliente);

                    if (resultado > 0)// Si el resultado es mayor a 0, significa que se eliminó la cliente
                    {
                        MessageBox.Show("¡Cliente eliminado exitosamente!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonIdPersona_CheckedChanged(object sender, EventArgs e)// RADIO BUTTON ID
        {
            if (radioButtonIdPersona.Checked == true)
            {
                textBox2.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                button2.Enabled = false;
                textBox2.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
