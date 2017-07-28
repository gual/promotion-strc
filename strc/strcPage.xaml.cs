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

			collectionOfItems.Add(new SfCarouselItem() { ItemContent = new Button() { Text = "ItemContent1", TextColor = Color.White, BackgroundColor = Color.FromHex("#ccd256"), FontSize = 12 } });
			collectionOfItems.Add(new SfCarouselItem() { ItemContent = new Label() { Text = "ItemContent2", BackgroundColor = Color.FromHex("#836186"), FontSize = 12 } });

			carousel.DataSource = collectionOfItems;
		}
	}
}
