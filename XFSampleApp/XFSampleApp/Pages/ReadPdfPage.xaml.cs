using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFSampleApp.Services;

namespace XFSampleApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ReadPdfPage : ContentPage
	{
        public ReadPdfPage ()
		{
			InitializeComponent ();

		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await LoadPdfFile("https://xamarinclassdemo.azurewebsites.net/files/MyPDFDemoFile.pdf");

        }

        private async Task LoadPdfFile(string pdfUrlStr)
        {
            readPdfPageViewModel.IsDownloading = true;
            var localFilePath = await PdfService.DownloadAsync(pdfUrlStr).ConfigureAwait(false);
            readPdfPageViewModel.IsDownloading = false;

            readPdfPageViewModel.PdfSource = new Uri(localFilePath);
        }
    }
}