using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SemCycle.DataBase;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SemCycle
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisciplineNotes : ContentPage
    {
      private int curSem;
        public DisciplineNotes()
        {
            InitializeComponent();
        }
        public DisciplineNotes(int sem)
        {
            curSem = sem;
            NavigationPage.SetHasNavigationBar(this, true);
            Title = "Добавление дисциплины";
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, System.EventArgs e)
        {
            string name = this.FindByName<Entry>("name").Text;
            string additional = this.FindByName<Entry>("addit").Text;
            string allLab = this.FindByName<Entry>("all").Text;
            string doneLab = this.FindByName<Entry>("done").Text;
           
            if (name == null || allLab == null || doneLab == null || additional == null )
                Navigation.PopAsync();
            else
            {
                int all = int.Parse(allLab);
                int done = int.Parse(doneLab);
                NavigationPage navPage = (NavigationPage)Application.Current.MainPage;
                IReadOnlyList<Page> navStack = navPage.Navigation.NavigationStack;
                MainPage homePage = navStack[0] as MainPage;

                if (homePage != null)
                {
                    homePage.addDiscipline(curSem, name, additional, all, done);
                    Navigation.PopAsync();
                }
            }
        }
    }
}