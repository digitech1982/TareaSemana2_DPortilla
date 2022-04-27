using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaSemana2_DPortilla
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Loggin : ContentPage
    {
        public Loggin()
        {
        }

        public Loggin(string usuario, string contrasena)
        {
            InitializeComponent();
            // DisplayAlert("datos enviados", "El usuario es" + usuario + "La clave es" + contrasena, "cerrar");

            lblNombre.Text = "El Usuario es" + usuario;
            lblContrasena.Text = "La Contrasena es" + contrasena;
        }
    }
}