using System;
using System.Collections.Generic;
using strc.Pages;
using Xamarin.Forms;

namespace strc.Views
{
	public partial class TrainingItemView : ContentView
	{
		public TrainingItemView()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			var app = Application.Current as App;
			app.MainPage = new TrainingPage();
		}
	}
}
