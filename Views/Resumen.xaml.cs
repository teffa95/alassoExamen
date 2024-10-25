namespace alassoExamen.Views;

public partial class Resumen : ContentPage
{
	public Resumen()
	{
		InitializeComponent();
	}

    public Resumen(string usuario, string fecha, string pais, string ciudad, string montoInicial, string pagoMensual, string nombre, string apellido, string edad)
    {
        InitializeComponent();

        lblUsuario.Text = usuario;

        lblFecha.Text = fecha;
        lblPais.Text = pais ?? "No seleccionado";
        lblCiudad.Text = ciudad ?? "No seleccionada";
        lblMontoInicial.Text = montoInicial;
        lblPagoMensual.Text = pagoMensual;
        lblNombre.Text = nombre;
        lblApellido.Text = apellido;
        lblEdad.Text = edad;
    }

}