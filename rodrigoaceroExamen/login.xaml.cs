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
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }
        private void btnInicio_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2023";
            string contraseña = "uisrael2023";

            if (usuario == txtUsuario.Text && contraseña == txtContraseña.Text)
            {
                Navigation.PushAsync(new registro(usuario));
            }

            else
            {
                DisplayAlert("Alerta", "Usuario o Contraseña incorrecta", "cerrar");
            }

        }
    }
}