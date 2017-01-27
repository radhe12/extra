using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace SecondChair
{
    public class RoundedButton : Button
    {
            public readonly static BindableProperty BorderRadiusProperty = BindableProperty.Create("BorderRadius", typeof(int), typeof(CustomFrame), 5, BindingMode.OneWay, null, null, null, null, null);

        public readonly static BindableProperty OutlineColorProperty = BindableProperty.Create("OutlineColor", typeof(Color), typeof(CustomFrame), Color.Default, BindingMode.OneWay, null, null, null, null, null);

        public readonly static BindableProperty BorderWidthProperty = BindableProperty.Create("BorderWidth", typeof(int), typeof(CustomFrame), 2, BindingMode.OneWay, null, null, null, null, null);

        public int BorderWidth
        {
            get
            {
                return (int)base.GetValue(RoundedButton.BorderWidthProperty);
            }
            set
            {
                base.SetValue(RoundedButton.BorderWidthProperty, value);
            }
        }

        public Color OutlineColor
        {
            get
            {
                return (Color)base.GetValue(RoundedButton.OutlineColorProperty);
            }
            set
            {
                base.SetValue(RoundedButton.OutlineColorProperty, value);
            }
        }

        public int BorderRadius
        {
            get
            {
                return (int)base.GetValue(RoundedButton.BorderRadiusProperty);
            }
            set
            {
                base.SetValue(RoundedButton.BorderRadiusProperty, value);
            }
        }
        public RoundedButton()
        {
           var _button = new RoundedButton();
        }

    }
}
