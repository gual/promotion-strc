using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace strc.Pages
{
	public partial class TrainingPage : ContentPage
	{
		public TrainingPage()
		{
            InitializeComponent();

			switch (Device.RuntimePlatform)
			{
				case Device.iOS:
					Padding = new Thickness(0, 20, 0, 0);
					break;
				default:
					Padding = new Thickness(0, 0, 0, 0);
					break;
			}
		}
	}
}
