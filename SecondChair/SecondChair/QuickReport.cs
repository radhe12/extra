using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace SecondChair
{
    public class QuickReport : ContentPage
    {
        Entry name;
        
        public static List<String> names=null;
        public QuickReport()
        {
        name = new Entry
            {
                Placeholder = "Search",
                HorizontalTextAlignment = TextAlignment.Center,
            };
            Image search = new Image
            {
                Source = ImageSource.FromFile("search.png"),
                HeightRequest=20,
                WidthRequest=20
            };
           var l1 = new ListView
            {
                ItemsSource = names,

            };
            l1.ItemTapped += serch_Clicked;
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                names = new List<string> { "radhe", "centennial" };
                l1.ItemsSource = names;
                // handle the tap
            };
           
            
            search.GestureRecognizers.Add(tapGestureRecognizer);
            var fs = new FormattedString();
            fs.Spans.Add(new Span { Text = "Results for :", FontSize = 14, FontAttributes = FontAttributes.Bold,ForegroundColor=Color.Red });
            var fs1 = new FormattedString();
            fs1.Spans.Add(new Span { Text = "Search for a Judge or Master by Last Name", FontSize = 16, FontAttributes = FontAttributes.Bold });
            Content = new StackLayout
            {

                Children = {
                    new Label { HorizontalOptions=LayoutOptions.FillAndExpand,HorizontalTextAlignment = TextAlignment.Center,FormattedText=fs1,Margin=10 },
                    name,
                     search,     
                    new Label {
                        Margin = 3,
                        HorizontalOptions = LayoutOptions.Start,
                        FormattedText=fs
                    },l1,
                }
            };
        }

        async void serch_Clicked(object sender, ItemTappedEventArgs e)
        {
            NavigationPage nav = new NavigationPage(new MasterQuickReport());
            await Navigation.PushModalAsync(nav);
        }
    }
}
