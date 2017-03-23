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
	public partial class SecondPage : ContentPage
	{
		public SecondPage ()
		{
			InitializeComponent ();

            Label label = new Label
            {
                Text="Page 2",
                FontSize = 26,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start
            };

            Button buttonRoot = new Button
            {
                Text = "Hoofdpagina",
                Font = Font.SystemFontOfSize(NamedSize.Small),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.EndAndExpand
            };

            buttonRoot.Clicked += buttonRoot_Clicked;

            Button buttonBack = new Button
            {
                Text = "Vorige pagina",
                Font = Font.SystemFontOfSize(NamedSize.Small),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.EndAndExpand
            };

            buttonBack.Clicked += ButtonBack_Clicked;

            Button buttonNext = new Button
            {
                Text = "Volgende pagina",
                Font = Font.SystemFontOfSize(NamedSize.Small),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.EndAndExpand,
                VerticalOptions = LayoutOptions.EndAndExpand
            };

            buttonNext.Clicked += ButtonNext_Clicked;

            StackLayout stack = new StackLayout
            {
                Children =
                {
                    buttonBack,
                    buttonRoot,
                    buttonNext
                },
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.EndAndExpand
            };

            Content = new StackLayout
            {
                Children =
                {
                    label,
                    stack
                },
                Padding = new Thickness(0, 20, 0, 20)
            };            

        }

        async void ButtonBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void ButtonNext_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Challenge2.ThirdPage());
        }

        async void buttonRoot_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
