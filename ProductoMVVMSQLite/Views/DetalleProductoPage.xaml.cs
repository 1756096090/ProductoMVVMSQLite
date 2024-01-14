using ProductoMVVMSQLite.ViewModels;

namespace ProductoMVVMSQLite.Views;

public partial class DetalleProductoPage : ContentPage
{
    public DetalleProductoPage(Models.Producto producto)
    {
        InitializeComponent();
        

        var viewModel = new DetalleProductoViewModel
        {
            Id = producto.IdProducto,
            Nombre = producto.Nombre,
            Cantidad = producto.Cantidad,
            Descripcion = producto.Descripcion
        };

        BindingContext = viewModel;
    }
}
