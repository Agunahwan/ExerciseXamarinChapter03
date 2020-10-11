using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Baskervilles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VariableFormattedTextPage : ContentPage
    {
        public VariableFormattedTextPage()
        {
            FormattedString formattedString = new FormattedString();

            formattedString.Spans.Add(new Span
            {
                Text = "I "
            });

            formattedString.Spans.Add(new Span
            {
                Text = "love",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold
            });

            formattedString.Spans.Add(new Span
            {
                Text = " Xamarin.Form!"
            });

            Content = new Label
            {
                FormattedText = formattedString,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
        }
    }
}