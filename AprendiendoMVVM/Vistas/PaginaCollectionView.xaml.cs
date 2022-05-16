using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AprendiendoMVVM.VistaModelo;

namespace AprendiendoMVVM.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaCollectionView : ContentPage
    {
        public PaginaCollectionView()
        {
            InitializeComponent();
            BindingContext = new MVCollectionView(Navigation);
        }
    }
}