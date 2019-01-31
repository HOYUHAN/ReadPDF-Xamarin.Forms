using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XFSampleApp.ViewModels
{
    public class ReadPdfPageViewModel : BaseViewModel
    {
        private bool _isDownloading;
        public bool IsDownloading
        {
            get
            {
                return _isDownloading;
            }

            set
            {
                if (value != _isDownloading)
                {
                    _isDownloading = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private Uri _pdfSource;
        public Uri PdfSource
        {
            get
            {
                return _pdfSource;
            }

            set
            {
                if (value != _pdfSource)
                {
                    _pdfSource = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
