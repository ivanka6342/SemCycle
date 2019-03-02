using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SemCycle
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabsPage : ContentPage
    {
        public LabsPage()
        {
            NavigationPage.SetHasNavigationBar(this, true);
            Title = "2 Семестр | ОАИП";
            InitializeComponent();
        }
        private void OnButtonClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            ToModalPage(sender, e);
            return;
        }
        private async void ToModalPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LabsNotes());
        }
    }
}