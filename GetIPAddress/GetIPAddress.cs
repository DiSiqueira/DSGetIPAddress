using System;

using Xamarin.Forms;
using GetIPAddress.Services;

namespace GetIPAddress
{
	public class App : Application
	{
		public App ()
		{

			string ipaddress = DependencyService.Get<IIPAddressManager>().GetIPAddress();

			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Seu Ip é: " + ipaddress
						}
					}
				}
			};
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

