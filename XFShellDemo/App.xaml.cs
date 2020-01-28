using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFShellDemo.Services;
using XFShellDemo.Views;
using Xamarin.Essentials;

namespace XFShellDemo
{
	public partial class App : Application
	{

		public App()
		{
			InitializeComponent();

			DependencyService.Register<MockDataStore>();
			MainPage = new AppShell();
		}

		protected override void OnStart()
		{
			var myRoute = Preferences.Get("my_route", "");

			if (myRoute != "")
			{
				Shell.Current.GoToAsync(myRoute);
			}
		}

		protected override void OnSleep()
		{
			var myRoute = Shell.Current.CurrentState.Location.ToString();
			Preferences.Set("my_route", myRoute);
		}

		protected override void OnResume()
		{
		}
	}
}
