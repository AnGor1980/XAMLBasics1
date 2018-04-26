using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace AppTryEvents.SinglePages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
        int i;

        public Page1 ()
		{

            InitializeComponent ();
            buttonNavigatePage2.Text = "Navigate!";
            buttonNavigatePage2.Clicked += ButtonNavigatePage2_Clicked;

            button1.Text = "Click!";
            button1.HorizontalOptions = LayoutOptions.Center;
            button1.VerticalOptions = LayoutOptions.Center;
            button1.Clicked += Button1_Clicked;
        }

        private void ButtonNavigatePage2_Clicked(object sender, EventArgs e)
        {

            //Navigation.PushAsync(new Page2());
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            i++;
            label1.Text = System.String.Format("Clicked {0} times", i);
        }

	}
}