using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rodrigoaceroExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registro : ContentPage
    {
        string usuario1;
        public registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "USUARIO CONECTADO:" + usuario;
            usuario1 = usuario;
        }
        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {


            try
            {
                double dato = Convert.ToDouble(txtdato.Text);
                if (dato > 100)
                {
                    DisplayAlert("Error", "El dato no esta en el rango", "Cerrar");
                    txtdato.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            double dato = Convert.ToDouble(txtdato.Text);
            string paices = pkPaices.Items[pkCiudad.SelectedIndex];
            string alumno = pkCiudad.Items[pkCiudad.SelectedIndex];

            Navigation.PushAsync(new resumen(usuario1, dato, paices));

        }

        private void btnAbrir_Clicked_1(object sender, EventArgs e)
        {

        }

        
    }
}