using System;
using System.Threading.Tasks;
using stellar_dotnet_sdk;
using stellar_dotnet_sdk.responses;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AuthenticPayment.Views.AuthenthicatedViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WalletPage : ContentPage
    {
        public WalletPage()
        {
            InitializeComponent();
        }


        //Set network and server
        public void GenerateAccountKeypair()
        {
            //Generate a random KeyPair
            KeyPair keypair = KeyPair.FromAccountId("");

            //Show the KeyPair public address and secret seed
            Console.WriteLine("Account ID: " + keypair.AccountId);
            Console.WriteLine("Secret: " + keypair.SecretSeed);
        }

        //Set network and server
        public async Task GetAccountBalance()
        {
            //Set network and server
            Network network = new Network("Test SDF Network ; September 2015");
            Server server = new Server("https://horizon-testnet.stellar.org");

            //Generate a keypair from the account id.
            KeyPair keypair = KeyPair.FromAccountId("ACCOUNT_ID");

            //Load the account
            AccountResponse accountResponse = await server.Accounts.Account(keypair.AccountId);

            //Get the balance
            Balance[] balances = accountResponse.Balances;

            //Show the balance
            for (int i = 0; i < balances.Length; i++)
            {
                Balance asset = balances[i];
                Console.WriteLine("Asset Code: " + asset.AssetCode);
                Console.WriteLine("Asset Amount: " + asset.BalanceString);
            }
        }
    }
}





