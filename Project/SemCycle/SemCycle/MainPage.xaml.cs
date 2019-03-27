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
        protected string[] terms = new string[] { "Добавление дисциплины","Просмотр дисциплин", "Редактирование дисциплин", "Удаление семестра", };
        protected int CurrSem;

        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            Header.BackgroundColor = Color.FromHex("#6d6f9b");
            Button addSem = new Button
            {
                Text = "Add",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HeightRequest = 100,
                WidthRequest = 70,
                MinimumWidthRequest = 100,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(0, 0, 0, 0),
                Padding = new Thickness(0, 0, 0, 0),
                BorderWidth = 3,
                CornerRadius = 100,
                BackgroundColor = Color.FromHex("#f2522c"),
                BorderColor = Color.FromHex("#4d3d3a"),
                TextColor = Color.FromHex("#003b9f"),
                FontAttributes = FontAttributes.Bold,
            };
            addSem.Clicked += AddSem_Clicked;
            Header.Children.Add(addSem);

           /* Label stripe = new Label() { Text = " " };
            stripe.HorizontalTextAlignment = TextAlignment.Start;
            stripe.VerticalTextAlignment = TextAlignment.Center;
            stripe.BackgroundColor = Color.
            stripe.HeightRequest = 100;
            stripe.WidthRequest = 1000;
            Header.Children.Add(stripe);*/

            //terms[0] = new string[] { "ADD", "ОАиП", "Математика", "Физика", "История" };
            //terms[1] = new string[] { "Добавление", "Просмотр дисциплин", "Редактирование дисциплин", "Удаление семестра", "Математика", "Физика" };
        }
        private void AddSem_Clicked(object sender, EventArgs e)
        {
            Button Sem = new Button
            {
                Text = "Sem" + Convert.ToString(EduProcess.CurrentSem),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HeightRequest = 100,
                WidthRequest = 100,
                MinimumWidthRequest = 100,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(0, 0, 0, 0),
                Padding = new Thickness(0, 0, 0, 0),
                BorderWidth = 0,
                BackgroundColor = Color.FromHex("#6d6f9b"),
            };
            Sem.Clicked += Sem_Clicked;
            Header.Children.Add(Sem);

            MainObj.addSem();
        }

        private void Sem_Clicked(object sender, EventArgs e)
        {
            IList <View> list = Header.Children;
            foreach (View view in list)
            {
                 if((view as Button).Text != "Add") (view as Button).TextColor = Color.FromHex("#000000");
            }
            ((Button)sender).TextColor = Color.FromHex("#004b9f");    

            for (int i = 0; i < list.Count; i++)
            {
                if ((Button)list[i] == (Button)sender)
                {
                    //Term.ItemsSource = terms[i-1];
                    //Term.ItemTapped += ToNext;
                    CurrSem = i - 1;
                }
            }
            Term.ItemsSource = terms;
            Term.ItemTapped += ToNext;
            
        }

        private async void ToNext(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                String str = e.Item.ToString();
                if (str == "Добавление дисциплины")
                    await Navigation.PushAsync(new DisciplineNotes(CurrSem), true);
               /* if (str == "Просмотр дисциплин")
                    await Navigation.PushAsync(new DisciplineNotes());
                if (str == "Редактирование дисциплин")
                    await Navigation.PushAsync(new DisciplineNotes());
                if (str == "Удаление семестра")
                    if(CurrSem+1 == MainObj.GetSizeSemList())
                        MainObj.deleteSem(CurrSem);
                    else
                        MainObj.ClearDiscipline(CurrSem);*/
            }
            ((ListView)sender).SelectedItem = null;          
        }

        protected internal void addDiscipline(int numSem, string name, string addit, int labs, int doneLabs)
        {
            MainObj.getSem(numSem).addDiscipline(new Discipline(name, addit, labs, doneLabs));
        }
    }
}
