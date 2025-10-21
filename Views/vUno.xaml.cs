namespace rtoasas3A.Views;

public partial class vUno : ContentPage
{
	//variables globales
    string usuarioglobal ="a" ;
    string contrasglobal ;
    public vUno()
	{
		InitializeComponent();
	}
	public vUno(string usuarioacceso, string contrasenaaccesso)
	{
		InitializeComponent();
		usuarioglobal = usuarioacceso;
		contrasglobal = contrasenaaccesso;
    }
  
    private void btnAbrir_Clicked(object sender, EventArgs e)
    {
		try
		{
			//DATOS DE ACCESO
		
			string usuario = txtUsuario.Text;
			string contrasena = txtContrasena.Text;
			if(usuario== usuarioglobal && contrasena== contrasglobal)
			{
                Navigation.PushAsync(new vDos(usuario, contrasena));
            }
			else
			{
				DisplayAlert("Error", "Usuario o contraseña incorrectos","ok");
			}
		
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);


		}
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new vTres());
    }
}