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

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }
}
