using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloCustomMarkup
{
    class HslColorExtension : IMarkupExtension<Color>
    {
        public double H { get; set; }
        public double S { get; set; }
        public double L { get; set; }
        public double A { get; set; } = 1.0;

        public Color ProvideValue(IServiceProvider serviceProvider)
        {
            return Color.FromHsla(H, S, L, A);
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return (this as IMarkupExtension<Color>).ProvideValue(serviceProvider);
        }
    }
}
