using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace legko.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        private krut krut;
        public AboutPage(krut _krut)
        {
            krut = _krut;
            InitializeComponent();
            Title = krut.Title;
            titleLabel.Text = krut.Title;
            tachkiImage.Source = krut.Image;
            descriptionLabel.Text = krut.Description;
        }

        private async void wikiButton_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync(krut.WikiUri);
        }
    }
}