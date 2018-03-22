using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlayHard.Views.Games
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterHomeMaster : ContentPage
    {
        public ListView ListView => ListViewMenuItems;

        public MasterHomeMaster()
        {
            InitializeComponent();
            BindingContext = new MasterHomeMasterViewModel();
        }

        class MasterHomeMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterHomeMenuItem> MenuItems { get; }
            public MasterHomeMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterHomeMenuItem>(new[]
                {
                    new MasterHomeMenuItem { Id = 0, Title = "New Invite"},
                    new MasterHomeMenuItem { Id = 1, Title = "My Scores" },
                    new MasterHomeMenuItem { Id = 2, Title = "My Invites" }
                    //new MasterHomeMenuItem { Id = 3, Title = "Page 4" },
                    //new MasterHomeMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            #endregion
        }
    }
}