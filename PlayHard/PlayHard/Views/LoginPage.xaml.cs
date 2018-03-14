using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayHard.Views.Games;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlayHard.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            //Identity server code
            Application.Current.MainPage = new MasterHome();
            
            

        }
    }
}