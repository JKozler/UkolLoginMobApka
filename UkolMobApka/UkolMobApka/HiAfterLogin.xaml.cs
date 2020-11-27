using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UkolMobApka
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HiAfterLogin : ContentPage
    {
        public HiAfterLogin(LoginClass lc)
        {
            InitializeComponent();
            lblOsloveni.Text = "Oslovení: " + lc.Osloveni;
            lblName.Text = "Jméno: " + lc.Name;
            lblPassword.Text = "Heslo: " + lc.Pass;
        }
    }
}