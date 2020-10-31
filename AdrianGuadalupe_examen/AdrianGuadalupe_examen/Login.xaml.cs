using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdrianGuadalupe_examen
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnAbrirRegistro_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPassword.Text;

            string user_val = "estudiante2020";
            string pass_val = "uisrael2020";

            if (user == user_val && pass == pass_val)
            {
                user = "Usuario conectado: " + user;
                await Navigation.PushAsync(new Registro(user));
            }
            else
            {
                await DisplayAlert("Login Incorrecto", "Datos incorrectos", "Volver");
            }
        }
    }
}