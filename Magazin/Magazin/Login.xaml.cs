using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Magazin.Data;
using Magazin.Models;

namespace Magazin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        protected override async void OnAppearing()
        {
            base.OnAppearing();
        }
        public Login()
        {
            InitializeComponent();
        }
        async void OnInregClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inregistrare
            {
                BindingContext = new Client()
            });
        }
        async void OnPaginiClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Pagini()));
        }
    }
}