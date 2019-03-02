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
    public partial class DisciplineNotes : ContentPage
    {
        public DisciplineNotes()
        {
            NavigationPage.SetHasNavigationBar(this, true);
            Title = "2 Семестр | ОАИП";
            InitializeComponent();
        }
    }
}