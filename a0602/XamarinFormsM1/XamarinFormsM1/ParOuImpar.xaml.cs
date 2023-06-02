using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsM1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParOuImpar : ContentPage
    {
        public ParOuImpar()
        {
            InitializeComponent();
            btExecutar.Clicked += btExecutar_Cliked;
        }

        private void btExecutar_Cliked(object sender, EventArgs e)
        {
            int n = int.Parse(etNumero.Text);
            string res = $"O número {n} é ";
            if (n%2==0)
            {
                res += "Par";  
            }
            else
            {
                res += "Impar";
            }
            lbResposta.Text = res;
        }
    }
}