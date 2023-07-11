using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Clinica_Veterinaria.Dato;


namespace Clinica_Veterinaria.Negocio
{
    internal class CrudCliente
    {

        //Intacia de la base de datos
        public static ClinicaVeterinariaContainer db = new ClinicaVeterinariaContainer();

        public static List<Cliente> ListarCliente()
        {
            return db.Clientes.ToList();    
        }
        public static int AgregarCliente(Cliente C)
        {
            db.Clientes.Add(C);
            return db.SaveChanges();
        }

        //Metodo para buscar un familia por su id
        public static Cliente BuscarCliente(int id)
        {
            return db.Clientes.Find(id);
        }
        //Metodo para editar un familia
        public static int EditarCliente(Cliente C)
        {
            db.Entry(C).State = EntityState.Modified;
            return db.SaveChanges();
        }
        //Metodo para eliminar un familia
        public static int EliminarCliente(int id)// Metodo para eliminar un familia 
        {
            Cliente AEliminar = BuscarCliente(id);
            db.Clientes.Remove(AEliminar);
            return db.SaveChanges();
        }
    }
}
