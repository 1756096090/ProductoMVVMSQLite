using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductoMVVMSQLite.Models;
using ProductoMVVMSQLite.Utils;
using ProductoMVVMSQLite.Views;
using PropertyChanged;
using System.Windows.Input;
namespace ProductoMVVMSQLite.ViewModels
{
    
    public class NuevoProductoViewModel
    {
        public String Nombre { get; set; }
        public String Descripcion { get; set; }

        public int Cantidad { get; set; }

        public NuevoProductoViewModel()
        {

        }


        public ICommand GuardarProducto =>
            new Command(async ()=>
            {
                Producto producto = new Producto
                {
                    Nombre = Nombre,
                    Descripcion = Descripcion,
                    Cantidad = Cantidad

                };
                App.productoRepository.Add(producto);
                Util.ListaProductos = App.productoRepository.GetAll();
                await App.Current.MainPage.Navigation.PopAsync();
            
            });

    }

   
}
