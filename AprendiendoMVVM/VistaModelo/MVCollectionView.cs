using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using AprendiendoMVVM.VistaModelo;
using AprendiendoMVVM.Modelo;
using System.ComponentModel;

namespace AprendiendoMVVM.VistaModelo
{
    public class MVCollectionView :BaseViewModel
    {
        
        #region VARIABLES
        //Creamos una lista para cargarla en el collection
        public List<MUsuarioCollectionView> ListaUsuario { get; set; }
        
        #endregion

        #region CONSTRUCTOR
        //Creamos método constructor para hacer que la página se comporta como una página navegable
        public MVCollectionView()
        {

            //Actualizamos la fecha para mostrarla en el Datepicker

        }
        public MVCollectionView(INavigation navigation)
        {
            Navigation = navigation;
            MostrarUsuarios();
            //Actualizamos la fecha para mostrarla en el Datepicker
        
        }

        #endregion

        #region OBJETO
                

       
              
        #endregion

        #region PROCESOS
        //Procesos asincronos
        //Procesos no asincronos
        public void MostrarUsuarios()
        {
            ListaUsuario = new List<MUsuarioCollectionView>
            {
                new MUsuarioCollectionView
                {
                    Nombre ="Carlos",
                    Imagen ="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.pinterest.com%2Fjessicabrera9%2Fim%25C3%25A1genes-cute%2F&psig=AOvVaw1OKsDkV532tkKE7Zsm-_YA&ust=1652578721102000&source=images&cd=vfe&ved=0CAwQjRxqFwoTCNjlr8_t3fcCFQAAAAAdAAAAABAD"
                },
                new MUsuarioCollectionView
                {
                    Nombre ="Andres",
                    Imagen =""
                },
                new MUsuarioCollectionView
                {
                    Nombre ="Lucas",
                    Imagen =""
                },
                new MUsuarioCollectionView
                {
                    Nombre ="Yuri",
                    Imagen =""
                },
                new MUsuarioCollectionView
                {
                    Nombre ="Pedro",
                    Imagen =""
                },
            };
        }
                
        #endregion

        #region COMANDOS

        //Para utilizar el proceso asincrono
        public ICommand ProcesoAsyncommand => new Command(MostrarUsuarios);

        #endregion

    }
}
