using Xamarin.Forms;

namespace SSwRemote
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            BindingContext = new MainViewModel();
        }
	}
}