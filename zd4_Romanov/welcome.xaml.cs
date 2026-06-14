using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd4_Romanov
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class welcome : ContentPage
	{
		public welcome (string login)
		{
			InitializeComponent ();
			welcomeLabel.Text = "Добро пожаловать, "+login+"!";
		}

        async private void Button_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushModalAsync(new MainPage());
        }
    }
}