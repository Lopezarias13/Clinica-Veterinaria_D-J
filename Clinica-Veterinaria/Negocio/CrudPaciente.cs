using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica_Veterinaria.Dato;
using System.Data.Entity;


namespace Clinica_Veterinaria.Negocio
{
    internal class CrudPaciente
    {

        //Intacia de la base de datos
        public static ClinicaVeterinariaContainer db = new ClinicaVeterinariaContainer();

        //Metodo Listar Pacientes ingresados en la base de datos
        public static List<Paciente> ListarPacientes()
        {
            return db.Pacientes.ToList();
        }
        //Metodo para agregar un nuevo paciente
        public static int AgregarPaciente(Paciente P)// Crear un nuevo paciente
        {
            db.Pacientes.Add(P);
            return db.SaveChanges();
        }
        //Metodo para buscar un paciente por su id
        public static Paciente BuscarPaciente(int id)
        {
            return db.Pacientes.Find(id);
        }
        //Metodo para editar un paciente
        public static int EditarPaciente(Paciente P)
        {
            db.Entry(P).State = EntityState.Modified;
            return db.SaveChanges();
        }
        //Metodo para eliminar un paciente
        public static int EliminarPaciente(int id)
        {
            Paciente AEliminar = BuscarPaciente(id);
            db.Pacientes.Remove(AEliminar);
            return db.SaveChanges();
        }

    }
}
