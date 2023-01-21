using MauiVerter.MVVM.ViewsModels;

namespace MauiVerter.MVVM.View;

public partial class MenuView : ContentPage
{
	public MenuView()
	{
		InitializeComponent();

		BindingContext = new MenuViewModels();
	}
}
