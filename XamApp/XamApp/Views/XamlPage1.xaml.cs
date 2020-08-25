using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XamlPage1 : ContentPage
    {
        public XamlPage1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            valueLabel.Text = e.NewValue.ToString("F3");
            this.Opacity = (e.NewValue / 100);

        }
    }
}