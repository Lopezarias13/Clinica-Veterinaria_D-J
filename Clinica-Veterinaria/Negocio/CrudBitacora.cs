using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Clinica_Veterinaria.Dato;

namespace Clinica_Veterinaria.Negocio
{
    internal class CrudBitacora
    {
        //Intacia de la base de datos
        public static ClinicaVeterinariaContainer db = new ClinicaVeterinariaContainer();

        //Metodo Listar Bitacora ingresados en la base de datos
        public static List<Bitacora> ListarBitacora()
        {
            return db.Bitacoras.ToList();
        }
        //Metodo para agregar un nuevo bitacora
        public static int AgregarBitacora(Bitacora B)
        {
            db.Bitacoras.Add(B);
            return db.SaveChanges();
        }
        //Metodo para buscar un bitacora por su id
        public static Bitacora BuscarBitacora(int id)
        {
            return db.Bitacoras.Find(id);
        }
        //Metodo para editar un Bitacora
        public static int EditarBitacora(Bitacora B)
        {
            db.Entry(B).State = EntityState.Modified;
            return db.SaveChanges();
        }
        //Metodo para eliminar un bitacora
        public static int EliminarBitacora(int id)
        {
            Bitacora AEliminar = BuscarBitacora(id);
            db.Bitacoras.Remove(AEliminar);
            return db.SaveChanges();
        }


    }
}
