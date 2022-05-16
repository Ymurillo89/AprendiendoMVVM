using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AprendiendoMVVM.VistaModelo
{
    internal class VMPatron:BaseViewModel
    {
        #region VARIABLES
        public string _Texto;
        #endregion

        #region CONSTRUCTOR
        //Creamos método constructor para hacer que la página se comporta como una página navegable
        public VMPatron(INavigation navigation)
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
        public async Task ProcesoAsync() 
        {
        
        }


        //Procesos no asincronos
        public void ProcesoSimple()
        {

        }

        #endregion

        #region COMANDOS

        //Para utilizar el proceso asincrono
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsync());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
