using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SemCycle.DataBase;
namespace SemCycle
{
    public partial class MainPage : ContentPage
    {
        EduProcess MainObj = new EduProcess();
        string[][] terms = new string[8][];

        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            Button addSem = new Button
            {
                Text = "AddSem",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HeightRequest = 50,
                WidthRequest = 150,
                MinimumWidthRequest = 100,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness (0, 0, 0, 0) ,
                Padding = new Thickness(0, 0, 0, 0) ,
                BorderWidth = 0 ,
                BorderRadius = 0 ,
                BackgroundColor = Color.FromHex("#5677FC") ,
            };
            addSem.Clicked += AddSem_Clicked;
            Header.Children.Add(addSem);
            
            terms[0] = new string[] { "ADD", "ОАиП", "Математика", "Физика", "История" };
            terms[1] = new string[] { "ADD","АиЛОВТ", "ILOVEiT", "ОАиП", "Математика", "Физика" };
        }
        private void AddSem_Clicked(object sender, EventArgs e)
        {
            Button Sem = new Button
            {
                Text = "Семестр " + Convert.ToString(EduProcess.CurrentSem),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HeightRequest = 50,
                WidthRequest = 150,
                MinimumWidthRequest = 100,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(0, 0, 0, 0),
                Padding = new Thickness(0, 0, 0, 0),
                BorderWidth = 0,
                BorderRadius = 0,
                BackgroundColor = Color.FromHex("#5677FC"),
            };
            MainObj.addSem();
            Sem.Clicked += Sem_Clicked;
            Header.Children.Add(Sem);
        }
        private void Sem_Clicked(object sender, EventArgs e)
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
                    Term.ItemTapped += ToNext;
                }
            }

        }

        private async void ToNext(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                String str = e.Item.ToString();
                if (str == "ADD")
                {
                    await Navigation.PushAsync(new DisciplineNotes());
                }
                else
                {
                    await Navigation.PushAsync(new DisciplineNotes());
                }
            }
            ((ListView)sender).SelectedItem = null;          
        }
    }
}
