using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AuthenticPayment.Views.AuthenthicatedViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApayInformationPage : ContentPage
    {
        public ApayInformationPage()
        {
            InitializeComponent();
            SetWebView();
        }

        void SetWebView()
        {
            Uri uri = new Uri("https://stellar.expert/explorer/public/asset/Apay-GBDKPRMOLDHTVUFTQATMMFUBKRI372YPUTOSEH5SZAFRAAVADTUGSSMA", UriKind.RelativeOrAbsolute);
            WebviewApay.Source = new UrlWebViewSource { Url = uri.ToString() };
        }
    }
}