using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TareaSemana2_DPortilla
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async Task btnAbrir_ClickedAsync(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string pass = txtPass.Text;
            await Navigation.PushAsync(new Vista_2());

        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {

        }
    }
}
