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
            this.pacientesTableAdapter.Fill(this.clinicaVeterinariaDataSet.Pacientes);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clienteIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clienteIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)//Boton Guardar
        {

        }
    }
}
