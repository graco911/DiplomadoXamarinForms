using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloOnPlatform
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            //if (Device.RuntimePlatform == Device.iOS)
            //{
            //    Padding = new Thickness(0, 20, 0, 0);
            //}
		}
	}
}
