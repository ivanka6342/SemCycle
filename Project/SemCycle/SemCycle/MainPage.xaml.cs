using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SemCycle
{
    public partial class MainPage : ContentPage
    {

        string[][] terms = new string[8][];

        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            terms[0] = new string[] { "ОАиП", "Математика", "Физика", "История" };
            terms[1] = new string[] { "АиЛОВТ", "ILOVEiT", "ОАиП", "Математика", "Физика" };
        }

        private void FirstSem_Clicked(object sender, EventArgs e)
        {
            IList<View> list = Header.Children;
            foreach (View view in list)
            {

                (view as Button).BackgroundColor = Color.FromHex("#5677FC");
            }

            ((Button)sender).BackgroundColor = Header.BackgroundColor;
            for (int i = 0; i < list.Count; i++)
            {
                if ((Button)list[i] == (Button)sender)
                {
                    Term.ItemsSource = terms[i];
                    //Term.ItemTapped += SemTapped;

                }
            }
            Term.ItemTapped += ToNext;
        }
        private void SemTapped(object sender, ItemTappedEventArgs e)
        {
            ToNext(sender, e);
        }
        private async void ToNext(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new MenuPage());
        }


    }
}
