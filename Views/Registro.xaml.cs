namespace alassoExamen.Views;

public partial class Registro : ContentPage
{
    string user_global = "";

    public Registro(string Usuario)
    {
        InitializeComponent();
        lblUsuario.Text = "Usuario Conectado" + Usuario;
        user_global = Usuario;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        double montoInicial = Convert.ToDouble(montoInicialEntry.Text);
        if (montoInicial > 0 && montoInicial < 1500)
        {
            double costoTotal = 1500;

            double saldoRestante = costoTotal - montoInicial;

            double pagoMensual = (saldoRestante / 4) * 1.04;

            pagoMensualEntry.Text = pagoMensual.ToString("F2");
        }
        else
        {
            DisplayAlert("Error", "Los valores deben estar en el rango de 0 a 1500", "OK");
        }

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        string fechaSeleccionada = fechaPicker.Date.ToString("d"); 
        string pais = paisPicker.SelectedItem?.ToString();
        string ciudad = cuidadPicker.SelectedItem?.ToString();
        double montoInicial = Convert.ToDouble(montoInicialEntry.Text); 
        string nombre = nombreEntry.Text;
        string apellido = apellidoEntry.Text;
        string edad = edadEntry.Text;

        if (montoInicial > 0 && montoInicial < 1500)
        {
            double costoTotal = 1500;
            double saldoRestante = costoTotal - montoInicial;
            double pagoMensual2 = (saldoRestante / 4) * 1.04;

            pagoMensualEntry.Text = pagoMensual2.ToString("F2");

            Navigation.PushAsync(new Resumen(user_global, fechaSeleccionada, pais, ciudad, montoInicial.ToString("F2"), pagoMensual2.ToString("F2"), nombre, apellido, edad));
        }
        else
        {
            DisplayAlert("Error", "El monto inicial debe ser un número entre 0 y 1500.", "OK");
        }
    }
}
