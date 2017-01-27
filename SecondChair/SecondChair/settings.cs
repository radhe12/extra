using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace SecondChair
{
    public class settings : ContentPage
    {
        public settings()
        {
            var fs = new FormattedString();
            fs.Spans.Add(new Span { Text = "Set 'Rulling Record' report defaults:", FontSize = 14, FontAttributes = FontAttributes.Bold });

            var fs1 = new FormattedString();
            fs1.Spans.Add(new Span { Text = "Date Range", FontSize = 14, FontAttributes = FontAttributes.Bold });

            var fs2 = new FormattedString();
            fs2.Spans.Add(new Span { Text = "Court", FontSize = 14, FontAttributes = FontAttributes.Bold });

            Dictionary<string, string> court = new Dictionary<string, string>
            {
                { "ONSC","one"}
            };
            
            

            StackLayout child1 = new StackLayout
            {

                Children =
                       {
                             new Label
                             {
                                 HorizontalTextAlignment = TextAlignment.Center,
               FormattedText = fs1
                             },
                             new Picker
                             {

                VerticalOptions = LayoutOptions.Center,

                             }
                    },
                Orientation = StackOrientation.Horizontal,
                Spacing = 2,
            };
            StackLayout child2 = new StackLayout
            {

                Children =
                       {
                             new Label
                             {
                                 HorizontalTextAlignment = TextAlignment.Center,
                                 FormattedText = fs2
                             },
                             new Picker
                             {

                VerticalOptions = LayoutOptions.Center
                             },
                             
                             
                    },
                Orientation = StackOrientation.Horizontal,
                Spacing = 0,
            };

            Content = new StackLayout
            {
                Children = {
                    new Label {

                        Margin=10,
                        FormattedText =fs,
                        HorizontalOptions = LayoutOptions.Center

                    },
                    child1,child2
                    
                }
            };
        }
    }
}
