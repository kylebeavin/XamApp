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
    public partial class TestPage : TabbedPage
    {
        public TestPage()
        {
            InitializeComponent();

            if (Application.Current.Properties.ContainsKey("MenuName"))
            {
                var menuName = Application.Current.Properties["MenuName"].ToString();
                if (menuName == "Movies")
                {
                    this.CurrentPage = Children[1];
                }
            }
        }
    }
}