using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutoCustomsClearance.XAML
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoadingPage : ContentPage
	{
		public LoadingPage ()
		{
			InitializeComponent ();
		}
        protected async override void OnAppearing()
        {
            SplashIcon.Opacity = 1;
            await SplashIcon.FadeTo(0, 800);
            Navigation.InsertPageBefore(new CalculatorPage(), Navigation.NavigationStack[0]);
            await Navigation.PopToRootAsync(false);
        }
    }
}