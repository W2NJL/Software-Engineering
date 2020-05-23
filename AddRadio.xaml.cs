using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace radioland4
{
    public partial class AddRadio : ContentPage
    {
        public AddRadio()
        {
            InitializeComponent();
        }

        public void OnSaveClicked(object sender, EventArgs args)
        {
            var vRadio = new Radio()
            {
                Calls = txtCalls.Text,
                Freq = txtFreq.Text,
                City = txtCity.Text,
                Format = txtFormat.Text
            };
            App.DAUtil.SaveRadio(vRadio);
            Navigation.PushAsync(new ManageRadio());
        }
    }
}