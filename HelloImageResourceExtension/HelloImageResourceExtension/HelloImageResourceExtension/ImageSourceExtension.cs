using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloImageResourceExtension
{
    [ContentProperty("Source")]
    class ImageSourceExtension : IMarkupExtension<ImageSource>
    {
        public string Source { get; set; }

        public ImageSource ProvideValue(IServiceProvider serviceProvider)
        {
            string AssemblyName = GetType().GetTypeInfo().Assembly.GetName().Name;

            return ImageSource.FromResource(AssemblyName + "." + Source);
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return (this as IMarkupExtension<ImageSource>).ProvideValue(serviceProvider);
        }
    }
}
