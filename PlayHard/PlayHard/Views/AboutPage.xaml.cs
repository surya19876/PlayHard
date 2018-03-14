
using Xamarin.Forms;

namespace PlayHard.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            Navigation.PushModalAsync(new LoginPage());
        }
    }
}
