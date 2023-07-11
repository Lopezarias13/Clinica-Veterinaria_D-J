using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Clinica_Veterinaria.Dato;


namespace Clinica_Veterinaria.Negocio
{
    internal class CrudUsuario
    {
        //Intacia de la base de datos
        public static ClinicaVeterinariaContainer db = new ClinicaVeterinariaContainer();

        //Metodo Listar Pacientes ingresados en la base de datos
        public static List<Usuario> ListarUsuario()
        {
            return db.Usuarios.ToList();
        }
        //Metodo para agregar un nuevo usuario
        public static int AgregarUsuario(Usuario U)
        {
            db.Usuarios.Add(U);
            return db.SaveChanges();
        }
        //Metodo para buscar un usuario por su id
        public static Usuario BuscarUsuario(int id)
        {
            return db.Usuarios.Find(id);
        }
        //Metodo para editar un usuario
        public static int EditarUsuario(Usuario U)
        {
            db.Entry(U).State = EntityState.Modified;
            return db.SaveChanges();
        }
        //Metodo para eliminar un paciente
        public static int EliminarUsuario(int id)
        {
            Usuario AEliminar = BuscarUsuario(id);
            db.Usuarios.Remove(AEliminar);
            return db.SaveChanges();
        }


    }
}
