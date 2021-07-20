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
        }

        private void TelegramGesture_Tapped(object sender, EventArgs e)
        {
            Launcher.OpenAsync("https://t.me/Authenticpayment");
        }

        private void Telegram_clicked(object sender, EventArgs e)
        {
            Launcher.OpenAsync("https://t.me/Authenticpayment");
        }
    }
}