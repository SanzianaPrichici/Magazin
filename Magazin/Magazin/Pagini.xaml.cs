using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Magazin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagini : ContentPage
    {
        public Pagini()
        {
            InitializeComponent();
        }
        async void OnClClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClientList());
        }
    }
}