using CommunityToolkit.Maui.Alerts;

namespace Proyecto01;

public partial class MainPage : ContentPage
{
	bool isRandom = false;
	string hexValue;


    public MainPage()
	{
		InitializeComponent();
	}

    void slideRed_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
		if (!isRandom)
		{
            var red = slideRed.Value;
            var green = slideGreen.Value;
            var blue = slideBlue.Value;

            Color color = Color.FromRgb(red, green, blue);
            SetColor(color);

        }

    }

    private void SetColor(Color color)
    {
		
		btnRandom.BackgroundColor = color;
		container.BackgroundColor = color;
		hexValue = color.ToHex();
		lblHex.Text = color.ToHex();

    }

    void btnRandom_Clicked(System.Object sender, System.EventArgs e)
    {

		isRandom = true;
		var random = new Random();
		var color = Color.FromRgb(random.Next(0, 256),
			random.Next(0,256),
			random.Next(0, 256));

		SetColor(color);
		slideRed.Value = color.Red;
		slideGreen.Value = color.Green;
		slideBlue.Value = color.Blue;

		isRandom = false;
    }

    async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
    {
		//copiar dato
		await Clipboard.SetTextAsync(hexValue);
		var vTotas = Toast.Make("Color Copiado fer",
			CommunityToolkit.Maui.Core.ToastDuration.Long,
			12
			);

		await vTotas.Show();

    }
}


