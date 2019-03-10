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
        //string[][] terms = new string[8][];
        protected string[] terms = new string[] { "Добавление дисциплины","Просмотр дисциплин", "Редактирование дисциплин", "Удаление семестра", };
        protected int CurrSem;

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

            //terms[0] = new string[] { "ADD", "ОАиП", "Математика", "Физика", "История" };
            //terms[1] = new string[] { "Добавление", "Просмотр дисциплин", "Редактирование дисциплин", "Удаление семестра", "Математика", "Физика" };
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
            Sem.Clicked += Sem_Clicked;
            Header.Children.Add(Sem);

            MainObj.addSem();
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
                if (str == "Добавление")
                    await Navigation.PushAsync(new DisciplineNotes());
                if (str == "Просмотр дисциплин")
                    await Navigation.PushAsync(new DisciplineNotes());
                if (str == "Редактирование дисциплин")
                    await Navigation.PushAsync(new DisciplineNotes());
                if (str == "Удаление семестра")
                    if(CurrSem+1 == MainObj.GetSizeSemList())
                        MainObj.deleteSem(CurrSem);
                    else
                        MainObj.ClearDiscipline(CurrSem);
            }
            ((ListView)sender).SelectedItem = null;          
        }
    }
}
