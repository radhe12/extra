using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace SecondChair
{
    public class MasterQuickReport : ContentPage
    {
        public MasterQuickReport()
        {
            var tbi = new ToolbarItem("Done", null, null, ToolbarItemOrder.Primary);
            var tbi1 = new ToolbarItem("Back", "backicon.png", () => { Navigation.PushModalAsync(new QuickReport()); }, ToolbarItemOrder.Primary);
            ToolbarItems.Add(tbi);
            ToolbarItems.Add(tbi1);
            Content = new ScrollView { 
            Content = new StackLayout
            {

                Children = {
                    new Label {
                        Text = "radhe",
                        FontSize = 20,
                        HorizontalOptions=LayoutOptions.CenterAndExpand,
                        Margin=20
                    }
                }
            }
            };
        }
    }
}
