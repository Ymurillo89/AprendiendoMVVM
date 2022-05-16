using AprendiendoMVVM.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace AprendiendoMVVM.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            //Enlazamos la vista con el su respectiva VistaModelo
            BindingContext = new MVPagePrincipal(Navigation);
        }
    }
}