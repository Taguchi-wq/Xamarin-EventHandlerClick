using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EventHandlerClick
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void btnText_Clicked(System.Object sender, System.EventArgs e)
        {
            if (sender.Equals(btnText))
            {
                label.Text = "Button Clicked";
            }
            else if (sender.Equals(btnNext))
            {
                Navigation.PushAsync(new NextPage());
            }
        }
    }
}
