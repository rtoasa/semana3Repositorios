namespace rtoasas3A.Views;

public partial class vTres : ContentPage
{
	public vTres()
	{
		InitializeComponent();
	}

    private void btnSalir_Clicked(object sender, EventArgs e)
    {
		try
		{
			string usuario = txtUsuario.Text;
			string contrasena = txtContrasena.Text;
			Navigation.PushAsync(new vUno(usuario, contrasena));
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
			
		}
    }
}