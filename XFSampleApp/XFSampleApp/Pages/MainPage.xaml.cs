using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFSampleApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ReadPdfByDefaultAppButton_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://xamarinclassdemo.azurewebsites.net/files/MyPDFDemoFile.pdf"));
        }

        private async void ReadPdfByWebViewButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReadPdfPage());
        }
    }
}
