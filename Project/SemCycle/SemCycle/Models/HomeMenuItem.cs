using System;
using System.Collections.Generic;
using System.Text;

namespace SemCycle.Models
{
	public enum MenuItemType
	{
		First,
		Second,
		Third,
		Fourth,
		Fifth,
		Sixth,
		Seventh,
		Eight
	}
	public class HomeMenuItem
	{
		public MenuItemType Id { get; set; }

		public string Title { get; set; }
	}
}
