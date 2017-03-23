using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Challenge2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ThirdPage : ContentPage
	{
		public ThirdPage ()
		{
			InitializeComponent ();

            Label label = new Label
            {
                Text = "Page 3",
                FontSize = 26,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start
            };

            Button buttonRoot = new Button
            {
                Text = "Hoofdpagina",
                Font = Font.SystemFontOfSize(NamedSize.Small),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.EndAndExpand
            };

            buttonRoot.Clicked += ButtonRoot_Clicked;

            Button buttonBack = new Button
            {
                Text = "Vorige pagina",
                Font = Font.SystemFontOfSize(NamedSize.Small),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.EndAndExpand
            };

            buttonBack.Clicked += ButtonBack_Clicked;

            StackLayout stack = new StackLayout
            {
                Children =
                {
                    buttonBack,
                    buttonRoot,
                },
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.EndAndExpand,
            };

            Content = new StackLayout
            {
                Children =
                {
                    label,
                    stack
                },
                Padding = new Thickness(20, 20, 20, 20)
            };
        }

        async void ButtonBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void ButtonRoot_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
