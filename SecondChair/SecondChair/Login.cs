using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace SecondChair
{
    public class Login : ContentPage
    {
        public Login()
        {
            var fs = new FormattedString();
            fs.Spans.Add(new Span { Text = "Forgot your Password?", ForegroundColor = Color.Blue, FontSize = 14 });
            // The root page of your application
            var forgotpass = new Label
            {

                HorizontalTextAlignment = TextAlignment.Center, 
               FormattedText = fs
            };
            var i1 = new Image
            {
                WidthRequest = 200,
                HeightRequest = 150,
                Source = ImageSource.FromFile("l1.png")
          
                };
                var i2 = new Image
                {
                    HorizontalOptions = LayoutOptions.End,
                    WidthRequest = 200,
                    HeightRequest = 60,
                    Source = ImageSource.FromFile("loom_analytics_logo.png")
                };
                var uname = new Label
                {
                    HorizontalTextAlignment = TextAlignment.Center,
                    Text = "Username :",
                    Margin = 20,
                };
                var unamet = new Entry
                {
                    Placeholder = "Enter Email Address",
                    WidthRequest = 200
                };
                var pwd = new Label
                {
                    HorizontalTextAlignment = TextAlignment.Center,
                    Text = "Password :",
                    Margin = 22,
                };
                var pwdt = new Entry
                {
                    Placeholder = "Enter Password",
                    IsPassword = true,
                    WidthRequest = 200
                };
                var login = new RoundedButton
                {
                    BorderRadius = 80,
                 //   BackgroundColor = Color.FromHex("BC1F25"),
                   // TextColor = Color.White,
                    //Text = "LOGIN",
                    //WidthRequest = 70,
                    //HorizontalOptions = LayoutOptions.FillAndExpand
                };
                login.Clicked += Login_Clicked;
                StackLayout child1 = new StackLayout
                {

                    Children =
                       {
                             uname,unamet
                    },
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 5,
                };
                StackLayout child2 = new StackLayout
                {
                    Children =
                       {
                           pwd,pwdt
                       },
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 0,
                };

            Title = "SecondChair";
                    Content = new StackLayout
                    {
                        Spacing = 5,
                        Margin = new Thickness(0, 20, 0, 0),
                        VerticalOptions = LayoutOptions.Center,
                        Children = {

                            i1,i2,child1,child2,login,forgotpass

                            
                                }
                    
                };
             
        }

        async void Login_Clicked(object sender, EventArgs e)
        { 
            NavigationPage nav = new NavigationPage(new Home());
            await Navigation.PushModalAsync(nav);
        }
    }
}
