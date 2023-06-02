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
    public partial class CalculadoraSimples : ContentPage
    {
        public CalculadoraSimples()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            double a = 0, b= 0 , t = 0;
            a = double.Parse(etNumero1.Text);
            b = double.Parse(etNumero2.Text);
            if (bt.Text == "+")
            {
                t = a + b;
            }
            if (bt.Text == "-")
            {
                t = a - b;
            }
            if (bt.Text == "*")
            {
                t = a * b;
            }
            if (bt.Text == "/")
            {
                t = a / b;
            }
            lbResposta.Text = t.ToString();
        }
    }
}