using System.Collections.ObjectModel;
using Syncfusion.SfCarousel.XForms;
using Xamarin.Forms;

using strc.Views;

namespace strc
{
	public partial class strcPage : ContentPage
	{
		public strcPage()
		{
			InitializeComponent();

			var collectionOfItems = new ObservableCollection<SfCarouselItem>();

			collectionOfItems.Add(new SfCarouselItem() { ItemContent = new SchoolsItemView() });
			collectionOfItems.Add(new SfCarouselItem() { ItemContent = new TrainingItemView() });
			collectionOfItems.Add(new SfCarouselItem() { ItemContent = new HistoryItemView() });
			collectionOfItems.Add(new SfCarouselItem() { ItemContent = new AliancesItemView() });

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
