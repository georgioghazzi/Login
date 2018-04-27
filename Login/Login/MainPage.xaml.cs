using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Login
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        private void LoginButton_Clicked(Object sender,EventArgs e)
        {
            bool isEmailEmpty = String.IsNullOrEmpty(email.Text);
            bool isPasswordEmpty = String.IsNullOrEmpty(password.Text);
            String emailAdd = email.ToString();
            String pass = password.ToString();
            if(isEmailEmpty || isPasswordEmpty)
            {
               
            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
            

        }

    }
}
