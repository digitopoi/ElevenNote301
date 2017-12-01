using ElevenNoteMobileApp.Contracts;
using ElevenNoteMobileApp.Pages;
using ElevenNoteMobileApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

//  Define dependencies for injection
//#if DEBUG
[assembly: Dependency(typeof(RealNoteService))]
//#else
//[assembly: Dependency(typeof(RealNoteService))]
//#endif
namespace ElevenNoteMobileApp
{
    
	public partial class App : Application
	{
        public static readonly INoteService NoteService = DependencyService.Get<INoteService>();

		public App ()
		{
			InitializeComponent();

            this.MainPage = new NavigationPage(new LoginPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
