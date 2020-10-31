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
    public partial class Resumen : ContentPage
    {
        public Resumen(string user, string name, double payment,double initp)
        {
            InitializeComponent();
            lbluser.Text = user;
            lblname.Text = name;
            lblpay.Text = "$"+payment.ToString("0.00");
            lblinitp.Text = "$" + initp.ToString("0.00");
        }
    }
}