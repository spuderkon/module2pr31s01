using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace module2pr31s01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();          
        }

       private void Button_Clicked(object sened,EventArgs e)
        {
            App.Current.MainPage = new Page1();
        }
    }
}
