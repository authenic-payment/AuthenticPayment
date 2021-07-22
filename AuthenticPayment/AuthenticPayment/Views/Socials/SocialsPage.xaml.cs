using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AuthenticPayment.Views.Socials
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SocialsPage : ContentPage
    {
        public SocialsPage()
        {
            InitializeComponent();
            Gestures();
        }

        void Gestures()
        {
            TapGestureRecognizer telegramGesture = new TapGestureRecognizer()
            {
                NumberOfTapsRequired = 1,
            };
            telegramGesture.Tapped += TelegramGesture_Tapped;
            TelegramLabel.GestureRecognizers.Add(telegramGesture);

            TapGestureRecognizer FacebookGesture = new TapGestureRecognizer()
            {
                NumberOfTapsRequired = 1,
            };
            FacebookGesture.Tapped += FacebookGesture_Tapped; ;
            FacebookLabel.GestureRecognizers.Add(FacebookGesture);

            TapGestureRecognizer TwitterGesture = new TapGestureRecognizer()
            {
                NumberOfTapsRequired = 1,
            };
            TwitterGesture.Tapped += TwitterGesture_Tapped; ;
            TwitterLabel.GestureRecognizers.Add(TwitterGesture);

            TapGestureRecognizer WebsiteGesture = new TapGestureRecognizer()
            {
                NumberOfTapsRequired = 1,
            };
            WebsiteGesture.Tapped += WebsiteGesture_Tapped; ;
            WebsiteLabel.GestureRecognizers.Add(WebsiteGesture);

            TapGestureRecognizer EmailGesture = new TapGestureRecognizer()
            {
                NumberOfTapsRequired = 1,
            };
            EmailGesture.Tapped += EmailGesture_Tapped; ;
            EmailLabel.GestureRecognizers.Add(EmailGesture);


            TapGestureRecognizer RedditGesture = new TapGestureRecognizer()
            {
                NumberOfTapsRequired = 1,
            };
            RedditGesture.Tapped += RedditGesture_Tapped; ; ;
            RedditLabel.GestureRecognizers.Add(RedditGesture);
        }

        private void RedditGesture_Tapped(object sender, EventArgs e)
        {
            Launcher.OpenAsync("https://www.reddit.com/r/OfficialApay/");
        }

        private void EmailGesture_Tapped(object sender, EventArgs e)
        {
            var address = "support@authentic-payment.com";
            Launcher.OpenAsync($"mailto:{address}");
        }

        private void WebsiteGesture_Tapped(object sender, EventArgs e)
        {
            Launcher.OpenAsync("https://www.Authentic-Payment.com");
        }

        private void TwitterGesture_Tapped(object sender, EventArgs e)
        {
            Launcher.OpenAsync("https://twitter.com/officialapay?s=11");
        }

        private void FacebookGesture_Tapped(object sender, EventArgs e)
        {
            Launcher.OpenAsync("https://www.facebook.com/Authentic-Payment-103724298649650");
        }

        private void TelegramGesture_Tapped(object sender, EventArgs e)
        {
            Launcher.OpenAsync("https://t.me/Authenticpayment");
        }


    }
}