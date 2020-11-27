using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UkolMobApka
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void login_Clicked(object sender, EventArgs e)
        {
            LoginClass lc = new LoginClass(osloveni.SelectedItem.ToString(), name.Text, password.Text);
            Console.WriteLine(lc.Pass);
            if (lc.Pass != password.Text)
                Application.Current.MainPage.DisplayAlert("Chyba!", lc.Pass, "OK");
            else
            {
                Page p = new HiAfterLogin(lc);
                Application.Current.MainPage.Navigation.PushAsync(new NavigationPage(p));
            }
        }
    }
}
