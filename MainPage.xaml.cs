using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace radioland4
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            myimage.Source = "logo.png";
            //logo.jpg must be Embedded Resource.
        }

        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ManageRadio());
        }

      

        private async void NavigateButton3_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BaltimoreRadio());
        }

        private async void NYCButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NYCRadio());
        }
    }
}
