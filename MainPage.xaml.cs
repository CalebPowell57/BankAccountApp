using LittleLittleTinyBank.Classes;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

namespace LittleLittleTinyBank
{
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<BankAccount> BankAccounts { get; set; } = new ObservableCollection<BankAccount>
        {
            new BankAccount
            {
                Balance = 2000,
                Name = "Ally's Checking Account",
                Number = 1000,
                Type = BankAccount.BankAccountType.Checking
            },
            new BankAccount
            {
                Balance = 50000,
                Name = "Ally's Savings Account",
                Number = 2000,
                Type = BankAccount.BankAccountType.Savings
            }
        };

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        }
    }
}
