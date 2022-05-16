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
    public partial class Labels : ContentPage
    {
        public Labels()
        {
            InitializeComponent();
            //BindingContext = new MVLearnLabel(Navigation);
            
        }
    }
}