using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace SecondChair
{
    public class Home : ContentPage
    {
        
        public Home()
        {
            var tbi = new ToolbarItem("Settings", "setting.png", () => { Navigation.PushModalAsync(new settings()); }, ToolbarItemOrder.Primary);
            ToolbarItems.Add(tbi);
            var l1 = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                Text = " Choose a report to run :",
                FontSize = 16
            };
            var btn=new Button
            {
                Margin = 40,
                BackgroundColor = Color.FromHex("BC1F25"),
                TextColor = Color.White,
                Text = "JUDGE QUICK REPORT",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                HeightRequest=100
            };

            btn.Clicked += btn_clicked;
            Content = new StackLayout
            {
                Spacing = 1,
                Children = {
                   
                     new Image
                {
                         Margin = 35,
                         VerticalOptions = LayoutOptions.Center,
                         HorizontalOptions = LayoutOptions.Center,
                         HeightRequest=150,
                         WidthRequest=150,
                    
                    Source = ImageSource.FromFile("chair.png")
                },
 l1,            
                  btn,
					new Button
                {
                    Margin = 5,
                    BackgroundColor = Color.FromHex("4d94ff"),
                    TextColor = Color.White,
                    Text = "FIND A RULLING RECORD",
                    HorizontalOptions= LayoutOptions.Center,
                    HeightRequest=100
                }
        }
            };
            
        }
        async void btn_clicked(object sender, EventArgs e)
        {
            NavigationPage nav = new NavigationPage(new QuickReport());
            await Navigation.PushModalAsync(nav);
        }
    }
    
    
}
