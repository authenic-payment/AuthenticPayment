using AuthenticPayment.ViewModels;
using AuthenticPayment.Views;
using AuthenticPayment.Views.AuthenthicatedViews;
using AuthenticPayment.Views.GeneralPages;
using AuthenticPayment.Views.Socials;
using AuthenticPayment.Views.Terms_conditions;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AuthenticPayment
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
            Routing.RegisterRoute(nameof(AccountPage), typeof(AccountPage));
            Routing.RegisterRoute(nameof(ApayInformationPage), typeof(ApayInformationPage));
            Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));
            Routing.RegisterRoute(nameof(TransactionPage), typeof(TransactionPage));
            Routing.RegisterRoute(nameof(WalletPage), typeof(WalletPage));
            Routing.RegisterRoute(nameof(AVPage), typeof(AVPage));
            Routing.RegisterRoute(nameof(OthersPage), typeof(OthersPage));
            Routing.RegisterRoute(nameof(PDPage), typeof(PDPage));
            Routing.RegisterRoute(nameof(SocialsPage), typeof(SocialsPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(StartupPage), typeof(StartupPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
