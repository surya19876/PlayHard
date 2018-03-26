using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PlayHard.Models.Sports;
using PlayHard.ViewModels.Sports;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlayHard.Views.Games.Select_Game
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectGame : ContentPage
    {
        
        public SelectGame()
        {
            InitializeComponent();

            BindingContext = new SportsViewModel();

        }

        
    }
}