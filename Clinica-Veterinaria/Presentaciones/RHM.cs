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
    public partial class RHM : Form
    {
        public RHM()
        {
            InitializeComponent();
        }

        private void historialMedicoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.historialMedicoSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaVeterinariaDataSet);

        }

        private void RHM_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clinicaVeterinariaDataSet.HistorialMedicoSet' Puede moverla o quitarla según sea necesario.
            this.historialMedicoSetTableAdapter.Fill(this.clinicaVeterinariaDataSet.HistorialMedicoSet);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButtonIdPersona_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
