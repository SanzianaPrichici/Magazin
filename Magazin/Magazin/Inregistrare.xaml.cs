using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazin.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Magazin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inregistrare : ContentPage
    {
        public Inregistrare()
        {
            InitializeComponent();
        }
        async void OnButtonSave(object sender, EventArgs e)
        {
            try
            {
                var cli = (Client)BindingContext;
                cli.Data_nast = DateTime.UtcNow;
                cli.Mail = txtmail.Text;
                cli.Nume = txtnume.Text;
                cli.Prenume = txtprenume.Text;
                cli.Parola = cli.Parola2 = cli.Telefon = cli.Username = cli.Adresa = null;
                await App.Database.SaveClientAsync(cli);
                await Navigation.PopAsync();
                await DisplayAlert("URAA", cli.Nume, "OK");
                //txtmail.Text = null;
                //txtnume.Text = null;
                //txtprenume.Text = null;
            }
            catch (Exception ex)
            {
                await DisplayAlert("NEOK", ex.Message, "OK");
            }
        }
    }
}