using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AprendiendoMVVM.VistaModelo
{
    internal class MVPicker:BaseViewModel
    {
        #region VARIABLES
        string _Cargo;
        DateTime _Fecha;
        string _ResultadoFecha;
        #endregion

        #region CONSTRUCTOR
        //Creamos método constructor para hacer que la página se comporta como una página navegable
        public MVPicker(INavigation navigation)
        {
            Navigation = navigation;
            //Actualizamos la fecha para mostrarla en el Datepicker
            Fecha = DateTime.Now;
        }

        #endregion

        #region OBJETO
        public string Cargo
        {
            get { return _Cargo; }
            set { SetValue(ref _Cargo, value); }
        }

        //Seleccionamos el Tipocargo lo asignamos al Cargo
        public string SeleccionarTipoCargo
        {
            get { return _Cargo; }
            set { SetProperty(ref _Cargo, value);
                SeleccionarTipoCargo = _Cargo;
                //Verificamos el cambio realizado en la fecha(Ver BaseViewModel)
                //OnpropertyChanged(Fecha.ToString());
            }
        }
                
        public string ResultadoFecha
        {
            get { return _ResultadoFecha; }
            set { SetValue(ref _ResultadoFecha, value); }
        }

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; 
            ResultadoFecha = _Fecha.ToString("dd/MM/yyyy");
            }
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
        //public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsync());
       
        #endregion




    }
}
