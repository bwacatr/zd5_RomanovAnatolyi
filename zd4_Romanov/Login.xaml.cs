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
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        async private void Button_Clicked(object sender, EventArgs e)
        {
			if (!string.IsNullOrWhiteSpace(UsernameEntry.Text) && !string.IsNullOrWhiteSpace(PasswordEntry.Text))
			{
				await Navigation.PushModalAsync(new welcome(UsernameEntry.Text));
			}
			
        }
    }
}