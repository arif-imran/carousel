using Xamarin.Forms;
namespace CustomerPortal
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new ColorsPage())
				{
					BindingContext = new ColorsViewModel(),
				BarTextColor = Xamarin.Forms.Color.White,
					BarBackgroundColor = Xamarin.Forms.Color.FromHex("#2196F3")
				};
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
