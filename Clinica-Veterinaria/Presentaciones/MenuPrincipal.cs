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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//Boton Registra Cliente
        {
            Rc rc = new Rc();
            rc.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)//Boton Salir
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Cerrar la aplicación
            }
        }

        private void button3_Click(object sender, EventArgs e)//Boton Registra Mascota
        {
            RPaciente rp = new RPaciente();// Instanciar el formulario
            //Limpiar();
            rp.ShowDialog();// Mostrar el formulario
            //rp.Show();// Mostrar el formulario
        }
    }
}
