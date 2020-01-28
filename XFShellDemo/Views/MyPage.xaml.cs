using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFShellDemo.ViewModels;

namespace XFShellDemo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyPage : ContentPage
	{
		MyViewModel viewModel;
		
		public MyPage()
		{
			InitializeComponent();

			BindingContext = viewModel = new MyViewModel();
		}
	}
}