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
            string user = "";
            string name = "";
            double payment = 0.0;
            double initp = 0.00;
        public Registro(string user)
        {
            InitializeComponent();
            lbluser.Text = user;
            btnGuardar.IsEnabled = false;
            txtCuota.IsEnabled = false;
            

        }

        private async void  btnGuardar_Clicked(object sender, EventArgs e)
        {
            string user = lbluser.Text;
            await Navigation.PushAsync(new Resumen(user, name,payment,initp));
        }

        private void btnResumen_Clicked(object sender, EventArgs e)    {                }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            /*Una empresa privada se encarga de brindar cursos Online y necesita desarrollar una aplicación móvil para registrar estudiantes, 
             * el costo aproximado por curso es de 1800, pero el estudiante primero cancela una parte al momento de la inscripción y 
             * el resto se lo dividen para 3 cuotas, pero a cada cuota se le suma el 5% por ciento del costo.*/
            user = lbluser.Text;
            name = txtNombre.Text;
            initp = Double.Parse(txtMonto.Text);
            payment = (1800*0.05)+(1800 - Double.Parse(txtMonto.Text))/3;
            txtCuota.Text =  "$"+payment.ToString("0.00");
            




            btnGuardar.IsEnabled = true;
        }
    }
}