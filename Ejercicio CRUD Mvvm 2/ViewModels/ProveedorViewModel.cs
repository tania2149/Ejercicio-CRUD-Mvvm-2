using Ejercicio_CRUD_Mvvm_2.DataAccess;
using Ejercicio_CRUD_Mvvm_2.Helpers;
using Ejercicio_CRUD_Mvvm_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_CRUD_Mvvm_2.ViewModels
{
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

}
