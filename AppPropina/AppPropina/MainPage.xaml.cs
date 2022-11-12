namespace AppPropina;

public partial class MainPage : ContentPage
{
    decimal bill;
    int tip, noPerson = 1;


    public MainPage()
    {
        InitializeComponent();
    }

    void txtBill_Completed(System.Object sender, System.EventArgs e)
    {
        bill = decimal.Parse(txtBill.Text);
    }

}


