using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using SemCycle.Models;
using SemCycle.ViewModels;

namespace SemCycle.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemDetailPage : ContentPage
	{

		ItemsViewModel viewModel = new ItemsViewModel();

		public ItemDetailPage()
		{
			InitializeComponent();
			viewModel = new ItemsViewModel();

			BindingContext = viewModel;
		}

		async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
		{
			var item = args.SelectedItem as Item;
			if (item == null)
				return;

			await Navigation.PushAsync(new Detail(new ItemDetailViewModel(item)));

			// Manually deselect item.
			ItemsListView.SelectedItem = null;
		}

		async void AddItem_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
		}

		public void DeleteClicked(object sender, EventArgs e)
		{
			var list = new List<Item>(viewModel.Items);
			var item = (Xamarin.Forms.Button)sender;
			Item listitem = (from itm in list
							 where itm.Id == item.CommandParameter.ToString()
							 select itm)
							.FirstOrDefault<Item>();
			list.Remove(listitem);
			viewModel.Items = new ObservableCollection<Item>(list);
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			if (viewModel.Items.Count == 0)
				viewModel.LoadItemsCommand.Execute(null);
		}
	}
}