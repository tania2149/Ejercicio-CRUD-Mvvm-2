using Ejercicio_CRUD_Mvvm_2.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_CRUD_Mvvm_2.Helpers
{
    public class Proveedor

    {

        [Required(ErrorMessage = "El nombre es requerido")]

        [StringLength(50, ErrorMessage = "El nombre debe tener máximo 50 caracteres")]

        public string Nombre { get; set; }


        [Required(ErrorMessage = "La dirección es requerida")]

        [StringLength(100, ErrorMessage = "La dirección debe tener máximo 100 caracteres")]

        public string Direccion { get; set; }


        [Required(ErrorMessage = "El teléfono es requerido")]

        [StringLength(20, ErrorMessage = "El teléfono debe tener máximo 20 caracteres")]

        public string Telefono { get; set; }


        [Required(ErrorMessage = "El email es requerido")]

        [EmailAddress(ErrorMessage = "El email no es válido")]

        public string Email { get; set; }

    }


    public class ProveedorViewModel : INotifyPropertyChanged

    {

        private Proveedor _proveedor;


        public Proveedor Proveedor

        {

            get { return _proveedor; }

            set { _proveedor = value; OnPropertyChanged("Proveedor"); }

        }


        public string ErrorMessage { get; set; }


        public ProveedorViewModel()

        {

            Proveedor = new Proveedor();

        }


        public void SaveProveedor()

        {

            if (ValidatorHelper.IsValid(Proveedor))

            {

                // Llamada al método CreateProveedor de la clase ProveedorDataAccess

                ProveedorDataAccess.CreateProveedor(Proveedor);

            }

            else

            {

                ErrorMessage = "Por favor, complete todos los campos obligatorios";

            }

        }


        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged(string propertyName)

        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

    }


    public static class ValidatorHelper

    {

        public static bool IsValid(object obj)

        {

            var context = new ValidationContext(obj);

            var results = new List<ValidationResult>();


            if (!Validator.TryValidateObject(obj, context, results))

            {

                foreach (var error in results)

                {

                    // Agregar mensaje de error

                    Console.WriteLine(error.ErrorMessage);

                }


                return false;

            }


            return true;

        }

    }
}
