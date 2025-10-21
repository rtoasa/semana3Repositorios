namespace rtoasas3A.Views;

public partial class vDos : ContentPage
{
	public vDos(string dato1, string dato2)
	{
		InitializeComponent();
		lbldato1.Text = "El dato uno es " + dato1;
        lbldato2.Text = "El dato dos es " + dato2;
    }
}