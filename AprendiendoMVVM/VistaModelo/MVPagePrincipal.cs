using AprendiendoMVVM.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace AprendiendoMVVM.VistaModelo
{
    internal class MVPagePrincipal:BaseViewModel
    {
        #region VARIABLES
        public string _Texto;
        #endregion

        #region CONSTRUCTOR
        //Creamos método constructor para hacer que la página se comporta como una página navegable
        public MVPagePrincipal(INavigation navigation)
        {
            Navigation = navigation;
        }

        #endregion

        #region OBJETO
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }

        #endregion

        #region PROCESOS
        //Procesos asincronos
        public async Task Mensaje()
        {
            if (!string.IsNullOrEmpty(Texto))
            {
                await DisplayAlert("Mensaje",Texto,"Ok");
            }
            else
            {
                await DisplayAlert("Mensaje","Ingrese un mensaje", "Ok");
            }
        }

        public async Task VentanaLabel()
        {
            await Navigation.PushAsync(new Labels());
        }

        public async Task VentanaPicker()
        {
            await Navigation.PushAsync(new Pickers());
        }

        public async Task VentanaCollectionView()
        {
            await Navigation.PushAsync(new PaginaCollectionView());


        }

        //Procesos no asincronos
        public void ProcesoSimple()
        {

        }

        #endregion

        #region COMANDOS

        //Para utilizar el proceso asincrono
        public ICommand MostrarMensaje => new Command(async () => await Mensaje());
        public ICommand AbrirVentaLabel => new Command(async () => await VentanaLabel());
        public ICommand AbrirVentaPicker => new Command(async () => await VentanaPicker());
        public ICommand AbrirCollectionView => new Command(async () => await VentanaCollectionView());

        #endregion
    }
}
