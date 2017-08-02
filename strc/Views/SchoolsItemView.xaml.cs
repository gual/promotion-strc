using System;
using System.Collections.Generic;
using Xamarin.Forms;

using strc.Pages;

namespace strc.Views
{
	public partial class SchoolsItemView : ContentView
	{
		public SchoolsItemView()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			var app = Application.Current as App;
			app.MainPage = new SchoolsPage();
		}
	}
}
