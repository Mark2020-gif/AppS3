using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppS3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;
                //Permite abrir la nueva ventana
                await Navigation.PushAsync(new PageDos(usuario, clave));

            }
            catch(Exception ex)
            {
               await DisplayAlert("Mensaje de alerta ", ex.Message, "OK");
            }

        }
    }
}
