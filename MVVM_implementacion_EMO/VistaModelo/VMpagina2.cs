using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM_implementacion_EMO.Modelo;
using Xamarin.Forms;

namespace MVVM_implementacion_EMO.VistaModelo
{
    public class VMpagina2 : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Musuarios> listausuarios { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMpagina2(INavigation navigation)
        {
            Navigation = navigation;
            MostrarUsuarios();
        }
        #endregion

        #region PROCESOS
        public void MostrarUsuarios()
        {
            listausuarios = new List<Musuarios>
            {
                new Musuarios
                {
                    Nombre = "Emiliano",
                    Imagen = "https://i.ibb.co/gzD21y9/almuerzo-cohete.png"
                },
                new Musuarios
                {
                    Nombre = "Alexa",
                    Imagen = "https://i.ibb.co/fkQv8Gd/estrellas.png"
                },
                new Musuarios
                {
                    Nombre = "José Luis",
                    Imagen = "https://i.ibb.co/z4tkKGR/dolar-de-saco.png"
                }
            };
        }
        public async Task Alerta(Musuarios parametros)
        {
            await DisplayAlert("Titulo", parametros.Nombre, "Ok");
        }
        #endregion

        #region COMANDOS
        //public ICommand VolverCommand => new Command(async () => await Volver());
        public ICommand AlertaCommand => new Command<Musuarios>(async (p) => await Alerta(p));
        #endregion
    }
}
