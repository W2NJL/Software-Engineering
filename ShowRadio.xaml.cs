using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace radioland4
{
    public partial class ShowRadio : ContentPage
    {
        Radio mSelRadio;
        public ShowRadio(Radio aSelectedRadio)
        {
            InitializeComponent();
            mSelRadio = aSelectedRadio;
            BindingContext = mSelRadio;

            String joe = aSelectedRadio.Calls; 

            stationimage.Source = joe + ".png";
        }

       
    }
}