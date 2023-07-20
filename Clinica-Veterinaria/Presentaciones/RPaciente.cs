using Clinica_Veterinaria.Dato;
using System;
using Clinica_Veterinaria.Presentaciones;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinica_Veterinaria.Negocio;

namespace Clinica_Veterinaria.Presentaciones
{
    public partial class RPaciente : Form
    {
        public RPaciente()
        {
            InitializeComponent();
        }

        private void pacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaVeterinariaDataSet);
        }

        private void RPaciente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clinicaVeterinariaDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
            //this.pacientesTableAdapter.Fill(this.clinicaVeterinariaDataSet.Pacientes);
            
            cbClientes.DataSource = CrudCliente.ListarCliente();//
            cbClientes.DisplayMember = "Nombre";
            dateFecha.Format = DateTimePickerFormat.Short;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        { }
        private void clienteIdTextBox_TextChanged(object sender, EventArgs e)
        { }
        private void clienteIdLabel_Click(object sender, EventArgs e)
        { }
        private void button3_Click(object sender, EventArgs e)//Boton Buscar Cliente
        {
            
        }
        public void SetBuscarClienteText(string nombreCliente)//Metodo para buscar cliente por su nombre
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//Campo de texto para buscar cliente
        { }

        private void buttonCancelar_Click(object sender, EventArgs e)//Boton Cancelar
        {
            this.Close();
        }
        private void buttonRegistrar_Click(object sender, EventArgs e)//Boton Guardar
        {
            if (CamposVacios())
            {
                MessageBox.Show("Debes completar todos los campos", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AgregarPaciente();
                Limpiar();
            }
        }
        private bool CamposVacios()
        {
            // Metodo para validar campos vacios para el registro de un nuevo paciente
            return string.IsNullOrWhiteSpace(codigoTextBox.Text) ||
                   string.IsNullOrEmpty(cbClientes.Text) ||//Aqui se valida que el campo no este vacio
                   string.IsNullOrWhiteSpace(aliasTextBox.Text) ||
                   string.IsNullOrWhiteSpace(property1TextBox.Text) ||
                   string.IsNullOrWhiteSpace(razaTextBox.Text) ||
                   string.IsNullOrWhiteSpace(colorDePeloTextBox.Text) ||
                   string.IsNullOrWhiteSpace(pesoMedioTextBox.Text) ||
                   string.IsNullOrWhiteSpace(pesoActualTextBox.Text) ||
                   string.IsNullOrWhiteSpace(dateFecha.Text) ||
                   string.IsNullOrWhiteSpace(especieTextBox.Text);
        }
            
        private void AgregarPaciente()
        {
            Paciente paciente = new Paciente();
            paciente.Codigo = codigoTextBox.Text;
            paciente.Alias = aliasTextBox.Text;
            paciente.Property1 = property1TextBox.Text;
            paciente.Raza = razaTextBox.Text;
            paciente.ColorDePelo = colorDePeloTextBox.Text;
            paciente.PesoMedio = pesoMedioTextBox.Text;
            paciente.PesoActual = pesoActualTextBox.Text;
            paciente.FechaNacimiento = dateFecha.Value.ToShortDateString();
            paciente.Especie = especieTextBox.Text;
            paciente.ClienteId = ((Cliente)cbClientes.SelectedItem).Id;

            if(CrudPaciente.AgregarPaciente(paciente) > 0)
            {
                MessageBox.Show("Paciente agregado con éxito", "Paciente Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo agregar el paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Limpiar()
        {
            cbClientes.Text = "";
            codigoTextBox.Clear();
            aliasTextBox.Clear();
            property1TextBox.Clear();
            razaTextBox.Clear();
            colorDePeloTextBox.Clear();
            pesoMedioTextBox.Clear();
            pesoActualTextBox.Clear();
            dateFecha.ResetText();
            especieTextBox.Clear();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Listar Pacientes
        {
            dataGridView1.DataSource = CrudPaciente.ListarPacientes();
            //quitar columna cliente 
            dataGridView1.Columns.Remove("Cliente");
            //cambiar nombre de columnas
            dataGridView1.Columns[1].HeaderText = "Edad";
        }

        private void codigoLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void codigoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNuevo_Click(object sender, EventArgs e)//Boton Nuevo
        {
            Limpiar();
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)//
        {
            //limpiar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void buttonModificar_Click(object sender, EventArgs e)//Modificar Paciente
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int idPaciente = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                Paciente paciente = CrudPaciente.BuscarPaciente(idPaciente);
                if(paciente != null)
                {
                    //Llenar campos
                    codigoTextBox.Text = paciente.Codigo;
                    aliasTextBox.Text = paciente.Alias;
                    property1TextBox.Text = paciente.Property1;
                    razaTextBox.Text = paciente.Raza;
                    colorDePeloTextBox.Text = paciente.ColorDePelo;
                    pesoMedioTextBox.Text = paciente.PesoMedio;
                    pesoActualTextBox.Text = paciente.PesoActual;
                    dateFecha.Text = paciente.FechaNacimiento;
                    especieTextBox.Text = paciente.Especie;
                    cbClientes.Text = paciente.Cliente.Nombre;

                    // Realizar la modificacion del paciente
                    paciente.Codigo = codigoTextBox.Text;
                    paciente.Alias = aliasTextBox.Text;
                    paciente.Property1 = property1TextBox.Text;
                    paciente.Raza = razaTextBox.Text;
                    paciente.ColorDePelo = colorDePeloTextBox.Text;
                    paciente.PesoMedio = pesoMedioTextBox.Text;
                    paciente.PesoActual = pesoActualTextBox.Text;
                    paciente.FechaNacimiento = dateFecha.Value.ToShortDateString();
                    paciente.Especie = especieTextBox.Text;
                    paciente.ClienteId = ((Cliente)cbClientes.SelectedItem).Id;

                    if(CrudPaciente.EditarPaciente(paciente) > 0)
                    {
                        MessageBox.Show("Los datos del paciente se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar una fila para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)//Boton Eliminar
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idPaciente = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                // Confirmar la eliminación
                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar esta Paciente?", "Confirmar Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    // Eliminar la Cliente de la base de datos
                    int resultado = CrudPaciente.EliminarPaciente(idPaciente);

                    if (resultado > 0)// Si el resultado es mayor a 0, significa que se eliminó la cliente
                    {
                        MessageBox.Show("¡Paciente eliminado exitosamente!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la Paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void radioButtonIdPersona_CheckedChanged(object sender, EventArgs e)//Radio Button Id Paciente
        {
            if (radioButtonIdPersona.Checked == true)//Si el radio button esta seleccionado
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

        private void button2_Click(object sender, EventArgs e)// Boton Buscar Paciente
        {
            if (radioButtonIdPersona.Checked) // Verifica si el RadioButton está marcado
            {
                if (int.TryParse(textBox2.Text, out int idPaciente)) // Intenta convertir el texto del TextBox a un valor entero
                {
                    Paciente paciente = CrudPaciente.BuscarPaciente(idPaciente); // Buscar la cliente por ID

                    if (paciente != null)
                    {
                        // Crear una lista temporal con la familia encontrada
                        List<Paciente> PacienteEncontrados = new List<Paciente> { paciente };

                        // Asignar la lista como origen de datos del DataGridView
                        dataGridView1.DataSource = PacienteEncontrados;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el Paciente con el ID especificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un valor numérico válido para el ID del Paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
