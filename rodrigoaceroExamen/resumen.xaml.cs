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
    public partial class resumen : ContentPage
    {
        public resumen(string usuario, double dato, string estudiante)
        {
            InitializeComponent();
            lblUsuario.Text = "USUARIO CONECTADO:" + usuario;
            txtdato.Text = dato.ToString();
            txtEstudiante.Text = estudiante;
        }
    }
}