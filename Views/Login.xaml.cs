namespace alassoExamen.Views;

public partial class Login : ContentPage
{
    string[,] credenciales = { { "estudiante", "uisrael" }, { "moviles", "2024" } };
    public Login()
    {
        InitializeComponent();
    }
    private void LoginButton_Clicked(object sender, EventArgs e)
    {
            string user = txtUsuario.Text;
            string password = txtContrasena.Text;
            bool Ingreso = false;

            for (int i = 0; i < credenciales.GetLength(1); i++)
            {
                if (credenciales[0, i] == user && credenciales[1, i] == password)
                {
                    Ingreso = true;
                    Navigation.PushAsync(new Registro(user));
                    DisplayAlert("Bienvenido", "Hola" + user, "Cerrar");
                    break;
                }
            }
            if (Ingreso == false)
            {
                DisplayAlert("Error", "Usuario y Contraseña Incorrectos", "Cerrar");
            }
        
    }
}