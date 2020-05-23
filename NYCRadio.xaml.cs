using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace radioland4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NYCRadio : ContentPage
    {
        public NYCRadio()
        {
            InitializeComponent();
            var vList = App.DAUtil.GetNYCRadios();
            lstData.ItemsSource = vList;
        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
                //ItemSelected is called on deselection,   
                //which results in SelectedItem being set to null  
            }
            var vSelUser = (Radio)e.SelectedItem;
            Navigation.PushAsync(new ShowRadio(vSelUser));
        }
        public void OnNewClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new AddRadio());
        }
    }
}