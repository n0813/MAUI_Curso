using System.ComponentModel;

namespace DataBindingApp;

public partial class MainPage : ContentPage
{
    Models.Persona person = new Models.Persona();

	public MainPage()
	{
		InitializeComponent();

        person = new Models.Persona
        {
            Name = "Camarillo",
            Phone = "8715652552",
            Address = "direccion mia"
        };

        BindingContext = person;
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{

		person.Name = "Alma";
		person.Phone = "9292929";
		person.Address = "Torreon";

		
		

		//Binding personBinding = new Binding();

		//personBinding.Source = person;
		//personBinding.Path = "Name";

		//txtNombre.SetBinding(Label.TextProperty, personBinding);

    }
}


