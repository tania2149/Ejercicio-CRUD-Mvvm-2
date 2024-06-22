using Ejercicio_CRUD_Mvvm_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_CRUD_Mvvm_2.DataAccess
{
    public class ProveedorDataAccess

    {

        private string _connectionString;


        public ProveedorDataAccess(string connectionString)

        {

            _connectionString = connectionString;

        }


        public void CreateProveedor(Proveedor proveedor)

        {

            using (var connection = new SQLiteConnection(_connectionString))

            {

                connection.Open();

                var command = connection.CreateCommand();

                command.CommandText = "INSERT INTO Proveedores (Nombre, Apellido, Direccion, Telefono, Email) VALUES (@Nombre, @Apellido, @Direccion, @Telefono, @Email)";

                command.Parameters.AddWithValue("@Nombre", proveedor.Nombre);

                command.Parameters.AddWithValue("@Apellido", proveedor.Apellido);

                command.Parameters.AddWithValue("@Direccion", proveedor.Direccion);

                command.Parameters.AddWithValue("@Telefono", proveedor.Telefono);

                command.Parameters.AddWithValue("@Email", proveedor.Email);

                command.ExecuteNonQuery();

            }

        }


        // Agregar métodos para leer, actualizar y eliminar proveedores

    }
}
