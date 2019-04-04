using SemCycle.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SemCycle.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : MasterDetailPage
	{
		Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
		public MainPage()
		{
			InitializeComponent();

			MasterBehavior = MasterBehavior.Popover;

			MenuPages.Add((int)MenuItemType.First, (NavigationPage)Detail);
		}

		public async Task NavigateFromMenu(int id)
		{
			if (!MenuPages.ContainsKey(id))
			{
				switch (id)
				{
					case (int)MenuItemType.First:
						MenuPages.Add(id, new NavigationPage(new ItemsPage()));
						break;
					case (int)MenuItemType.Second:
						MenuPages.Add(id, new NavigationPage(new ItemsPage()));
						break;
					case (int)MenuItemType.Third:
						MenuPages.Add(id, new NavigationPage(new ItemsPage()));
						break;
					case (int)MenuItemType.Fourth:
						MenuPages.Add(id, new NavigationPage(new ItemsPage()));
						break;
					case (int)MenuItemType.Fifth:
						MenuPages.Add(id, new NavigationPage(new ItemsPage()));
						break;
					case (int)MenuItemType.Sixth:
						MenuPages.Add(id, new NavigationPage(new ItemsPage()));
						break;
					case (int)MenuItemType.Seventh:
						MenuPages.Add(id, new NavigationPage(new ItemsPage()));
						break;
					case (int)MenuItemType.Eight:
						MenuPages.Add(id, new NavigationPage(new ItemsPage()));
						break;
				}
			}

			var newPage = MenuPages[id];

			if (newPage != null && Detail != newPage)
			{
				Detail = newPage;

				if (Device.RuntimePlatform == Device.Android)
					await Task.Delay(100);

				IsPresented = false;
			}
		}
	}
}