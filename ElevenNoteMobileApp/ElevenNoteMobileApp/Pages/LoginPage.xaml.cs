using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElevenNoteMobileApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        private async void BtnLogin_OnClicked(object sender, EventArgs e)
        {
            pleaseWait.IsRunning = true;
            await DisplayAlert("Whoa!", "You clicked login!", "Sweet!");
            pleaseWait.IsRunning = false;
        }
    }
}