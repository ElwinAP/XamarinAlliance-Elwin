using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Challenge2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            Label label1 = new Label
            {
                Text="Xamarin Challenge 2 Elwin Van Dosselaer",
                FontSize = 20,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand,
                HorizontalTextAlignment = TextAlignment.Center
            };

            Label label2 = new Label
            {
                Text = "Page 1",
                FontSize = 26,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand
            };

            Button buttonNext = new Button
            {
                Text = "Begin navigatie",
                Font = Font.SystemFontOfSize(NamedSize.Medium),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            buttonNext.Clicked += ButtonNext_Clicked;

            this.Content = new StackLayout
            {
                Children =
                {  
                    label2,
                    label1,                  
                    buttonNext                    
                },
                Padding = new Thickness(0, 20, 0, 20)

            };
        }

        async void ButtonNext_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Challenge2.SecondPage());
        }
    }
}
