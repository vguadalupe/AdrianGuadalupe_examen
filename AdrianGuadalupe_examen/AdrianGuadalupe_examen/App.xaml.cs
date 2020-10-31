using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdrianGuadalupe_examen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Login = new Login();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
