using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AprendiendoMVVM.VistaModelo
{
    internal class MVLearnLabel:BaseViewModel
    {
        
        #region VARIABLES
        string _N1;
        string _N2;
        string _Respuesta;
        #endregion

        #region CONSTRUCTOR
        //Creamos método constructor para hacer que la página se comporta como una página navegable
        public MVLearnLabel()
        {
            
        }
        public MVLearnLabel(INavigation navigation)
        {
            Navigation = navigation;
        }

        #endregion

        #region OBJETO
        public string N1 { get { return _N1; } set { SetValue(ref _N1, value); } }
        public string N2 { get { return _N2; } set { SetValue(ref _N2, value); } }

        public string Res {
            get { 
                return _Respuesta; 
            } 
            set { SetValue (ref _Respuesta,value); } 
        }

        #endregion

        #region PROCESOS
        //Procesos asincronos
        public async Task SumaAsync()
        {
            
        }


        //Procesos no asincronos
        public void ProcesoSimple()
        {
            if (string.IsNullOrEmpty(N1) || string.IsNullOrEmpty(N2))
            {
                DisplayAlert("Error", "Favor ingresar dos números", "Ok");
            }
            else
            {
                double n1 = double.Parse(N1);
                double n2 = double.Parse(N2);
                double respuesta = n1 + n2;
                Res= respuesta.ToString();
                
                
            }
        }


        #endregion

        #region COMANDOS

        //Para utilizar el proceso asincrono
        public ICommand CalcularSuma => new Command(async () => await SumaAsync());

        public ICommand Suma => new Command(ProcesoSimple);
        
        #endregion
    }
}
