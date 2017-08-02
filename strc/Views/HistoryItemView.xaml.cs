using System;
using System.Collections.Generic;
using strc.Pages;
using Xamarin.Forms;

namespace strc.Views
{
	public partial class HistoryItemView : ContentView
	{
		public HistoryItemView()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			var app = Application.Current as App;
			app.MainPage = new HistoryPage();
		}
	}
}
