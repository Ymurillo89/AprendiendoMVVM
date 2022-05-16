using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AprendiendoMVVM.Vistas;

namespace AprendiendoMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Para navegar de atrás hacia adelante 
            MainPage =new NavigationPage( new Page1());
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
