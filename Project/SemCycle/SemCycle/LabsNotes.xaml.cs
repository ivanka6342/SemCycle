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
    public partial class LabsNotes : ContentPage
    {
        public LabsNotes()
        {
            NavigationPage.SetHasNavigationBar(this, true);
            Title = "ОАИП | Лабораторная 2";
            InitializeComponent();
        }
    }
}