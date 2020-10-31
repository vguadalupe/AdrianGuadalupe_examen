using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdrianGuadalupe_examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string user)
        {
            InitializeComponent();
            lbluser.Text = user;
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {

        }
    }
}