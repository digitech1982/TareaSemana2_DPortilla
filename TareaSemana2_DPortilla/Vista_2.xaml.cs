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
    public partial class Vista_2 : ContentPage
    {
        public Vista_2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            {

                var dat1 = decimal.Parse(NotaSeg1.Text) * (decimal)0.3;
                var dat2 = decimal.Parse(NotaExa1.Text) * (decimal)0.2;
                var NotaPar1 = dat1 + dat2;

                // NotaPar1.ToString = Nota_Par1.ToString();

                var dat3 = decimal.Parse(NotaSeg2.Text) * (decimal)0.3;
                var dat4 = decimal.Parse(NotaExa2.Text) * (decimal)0.2;
                var NotaPar2 = dat3 + dat4;
                //NotaPar2 = resultado1.ToString();

                var not = NotaPar1 + NotaPar2;
                NotaFinal.Text = not.ToString();
                string mensaje = "";
                if (not >= 7 & not <= 10)
                    mensaje = "Aprobado";
                else
                    if (not >= 5 & not < 7)
                    mensaje = "Supletorio";
                else
                    if (not < 5 & not > 0)
                    mensaje = "Reprobado";
                else
                    mensaje = "Nota Invalida";
                DisplayAlert("Alumno:", mensaje, "Cerrar");
            }

        }
    }
}

