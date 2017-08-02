using System.Collections.ObjectModel;
using Syncfusion.SfCarousel.XForms;
using Xamarin.Forms;

namespace strc
{
	public partial class strcPage : ContentPage
	{
		public strcPage()
		{
			InitializeComponent();

			var collectionOfItems = new ObservableCollection<SfCarouselItem>();

			collectionOfItems.Add(new SfCarouselItem() { ItemContent = new Button() { Image = "schools.jpg", Text = "ItemContent1", TextColor = Color.White, BackgroundColor = Color.FromHex("#ccd256"), FontSize = 12 } });
			collectionOfItems.Add(new SfCarouselItem() { ItemContent = new Button() { Image = "training.jpg", Text = "ItemContent1", TextColor = Color.White, BackgroundColor = Color.FromHex("#836186"), FontSize = 12 } });
			collectionOfItems.Add(new SfCarouselItem() { ItemContent = new Button() { Image = "history.jpg", Text = "ItemContent1", TextColor = Color.White, BackgroundColor = Color.FromHex("#ccd256"), FontSize = 12 } });
			collectionOfItems.Add(new SfCarouselItem() { ItemContent = new Button() { Image = "aliances.jpg", Text = "ItemContent1", TextColor = Color.White, BackgroundColor = Color.FromHex("#836186"), FontSize = 12 } });

			carousel.DataSource = collectionOfItems;

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
