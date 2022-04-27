using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaSemana2_DPortilla
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Vista_2();
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
