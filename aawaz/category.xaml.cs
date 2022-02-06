using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aawaz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class category : ContentPage
    {
        public category()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Fruits());
        }
        private async void Button_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Vegetables());
        }
        private async void Button_Clicked2(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Ingrediants());
        }
        private async void Button_Clicked3(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Drinks());
        }
        private async void Button_Clicked4(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Objects());
        }
        private async void Button_Clicked5(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Mood());
        }
    }
}