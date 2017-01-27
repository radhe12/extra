using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SecondChair;
using SecondChair.Droid;
using Android.Graphics.Drawables;
using Xamarin.Forms.Platform.Android;
using System.ComponentModel;

[assembly: Xamarin.Forms.ExportRenderer(typeof(RoundedButton), typeof(RoundedButtonRederer))]
namespace SecondChair.Droid
{
    class RoundedButtonRederer : ButtonRenderer
    {
        private GradientDrawable _normal, _pressed;
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {

            RoundedButton customFram = e.NewElement as RoundedButton;
            // Create a drawable for the button's normal state
            _normal = new Android.Graphics.Drawables.GradientDrawable();
            _normal.SetColor(customFram.BackgroundColor.ToAndroid());
            _normal.SetStroke(customFram.BorderWidth, customFram.OutlineColor.ToAndroid());
            _normal.SetCornerRadius(customFram.BorderRadius);

            SetBackgroundColor(customFram.BackgroundColor.ToAndroid());

            base.OnElementChanged(e);
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
          /*  var button = (Xamarin.Forms.Button)sender;

            if (_normal != null && _pressed != null)
            {
                if (e.PropertyName == "BorderRadius")
                {
                    _normal.SetCornerRadius(button.BorderRadius);
                    _pressed.SetCornerRadius(button.BorderRadius);
                }
                if (e.PropertyName == "BorderWidth" || e.PropertyName == "BorderColor")
                {
                    _normal.SetStroke((int)button.BorderWidth, button.BorderColor.ToAndroid());
                    _pressed.SetStroke((int)button.BorderWidth, button.BorderColor.ToAndroid());
                }
            }*/
        }
    }
}