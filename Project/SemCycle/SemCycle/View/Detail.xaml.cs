using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SemCycle.ViewModels;
using SemCycle.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SemCycle.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Detail : ContentPage
	{
		ItemDetailViewModel viewModel;

		public Detail (ItemDetailViewModel viewModel)
		{
			InitializeComponent ();

			BindingContext = this.viewModel = viewModel;
		}

		public Detail()
		{
			InitializeComponent();

			var item = new Item
			{
				Text = "Item 1",
				Description = "This is an item description."
			};

			viewModel = new ItemDetailViewModel(item);
			BindingContext = viewModel;
		}
	}
}