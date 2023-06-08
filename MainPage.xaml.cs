namespace TrabajoGrupalMoviles;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        Contador.Text = countButton.Value.ToString();

    }

	private void onResetCount(object sender, EventArgs e)
	{
        resetValue.Text = Contador.Text;
    }

	private void onClickCheckBox(object sender, EventArgs e)
	{
		if (changeNumberSimbol.IsChecked)
		{
            countButton.Minimum = -999;
		}
		else
		{
            countButton.Minimum = 0;
        }
	}
}

