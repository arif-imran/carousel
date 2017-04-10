using System;
using System.Collections.Generic;
using System.Linq;
using CustomLayouts;
using Xamarin.Forms;

namespace CustomerPortal
{
	public partial class ColorsPage : ContentPage
	{

		List<Button> dots = new List<Button>();
		public ColorsPage()
		{
			InitializeComponent();
		}
		protected override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();
			var colors = BindingContext as ColorsViewModel;
			var dotsPanel = this.Content.FindByName<StackLayout>("DotsIndicator");
			for (int c = 0; c < colors.Colors.Count; c++)
			{
				var button = new Button
				{
					BorderRadius = Convert.ToInt32(3),
					HeightRequest = 5,
					WidthRequest = 5,
					BackgroundColor = Xamarin.Forms.Color.Black,
					Opacity = (c==0? 1.0f:0.5f)
				};
				dotsPanel.Children.Add(button);
				dots.Add(button);
			}

			ColorsPageCarousel.ItemSelected += (sender, e) =>
			{
				SelectDot(((CarouselView)sender).Position);
			};
		}
		void SelectDot(int position)
		{
			
			foreach (Button dot in dots)
			{
				dot.Opacity = 0.5f;
			}
			dots[position].Opacity = 1.0f;
		}
	}
}
