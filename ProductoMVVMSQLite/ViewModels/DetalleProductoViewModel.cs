using ProductoMVVMSQLite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProductoMVVMSQLite.ViewModels
{

    internal class DetalleProductoViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }

        public ICommand EditarProducto =>
        new Command(async () =>
        {
            Producto producto = new Producto();
            producto.IdProducto = Id;
            producto.Nombre = Nombre;
            producto.Descripcion = Descripcion;
            producto.Cantidad = Cantidad;
            Console.WriteLine($" Prod1 {producto.Cantidad}");
            App.productoRepository.Update(producto);
            await App.Current.MainPage.Navigation.PopAsync();


        });

        public ICommand EliminarProducto =>
            new Command(async () =>
            {
                Producto producto = new Producto();
                producto.IdProducto = Id;
                producto.Nombre = Nombre;
                producto.Descripcion = Descripcion;
                producto.Cantidad = Cantidad;

                App.productoRepository.Delete(producto);
                await App.Current.MainPage.Navigation.PopAsync();
            });

    }

    


}
