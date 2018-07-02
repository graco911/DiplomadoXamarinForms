using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloDataBinding
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            //lblMessage.BindingContext = new DataBindingSource();

            //lblMessage.SetBinding(Label.TextProperty, "Message");
        }
	}
}
