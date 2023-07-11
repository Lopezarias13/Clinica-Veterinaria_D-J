using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica_Veterinaria.Dato;
using System.Data.Entity;


namespace Clinica_Veterinaria.Negocio
{
    internal class CrudVacuna
    {


        //Intacia de la base de datos
        public static ClinicaVeterinariaContainer db = new ClinicaVeterinariaContainer();

        //Metodo Listar Vacuna ingresados en la base de datos
        public static List<Vacuna> ListarVacuna()
        {
            return db.Vacunas.ToList();
        }
        //Metodo para agregar un nuevo vacuna
        public static int AgregarVacuna(Vacuna V)
        {
            db.Vacunas.Add(V);
            return db.SaveChanges();
        }
        //Metodo para buscar un VACUNA por su id
        public static Vacuna BuscarVacuna(int id)
        {
            return db.Vacunas.Find(id);
        }
        //Metodo para editar un vacuna
        public static int EditarVacuna(Vacuna V)
        {
            db.Entry(V).State = EntityState.Modified;
            return db.SaveChanges();
        }
        //Metodo para eliminar un vACUNA
        public static int EliminarvACUNA(int id)
        {
            Vacuna AEliminar = BuscarVacuna(id);
            db.Vacunas.Remove(AEliminar);
            return db.SaveChanges();
        }
    }
}
