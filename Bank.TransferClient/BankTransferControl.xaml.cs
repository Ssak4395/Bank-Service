using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Transactions;

namespace Bank.TransferClient
{
    /// <summary>
    /// Interaction logic for BankTransferControl.xaml
    /// </summary>
    public partial class BankTransferControl : UserControl
    {
        private int mIdA;
        private int mIdB;

        public  AccountService1.AccountServiceClient Bank1AccountService
        {
            get
            {
                return new AccountService1.AccountServiceClient("NetTcpBinding_IAccountService", "net.tcp://localhost:2967/AccountService1");
            }
        }


        public  AccountService2.AccountServiceClient Bank2AccountService
        {
            get
            {
                return new AccountService2.AccountServiceClient("NetTcpBinding_IAccountService1", "net.tcp://localhost:2967/AccountService1");
            }
        }

        public BankTransferControl()
        {
            InitializeComponent();
            
        }

        private void CreateAccounts()
        {
            mIdA = CreateCustomerBranch1();
            mIdB = CreateCustomerBranch2();
        }

        private  int CreateCustomerBranch2()
        {
            AccountService2.AccountServiceClient lClient = Bank2AccountService;
            Bank.TransferClient.AccountService2.Customer lCust2 = new AccountService2.Customer() { Name = "Branch2Customer" };
            int lCustId = lClient.CreateCustomer(lCust2);
            return lClient.CreateAccount(lCustId, new AccountService2.Account() { Balance = 50.0 });
        }

        private  int CreateCustomerBranch1()
        {
            AccountService1.AccountServiceClient lClient = Bank1AccountService;
            Bank.TransferClient.AccountService1.Customer lCust1 = new AccountService1.Customer() { Name = "Branch1Customer" };
            int lCustId = lClient.CreateCustomer(lCust1);
            return lClient.CreateAccount(lCustId, new AccountService1.Account() { Balance = 50.0 });
        }


        public  void PerformTransfer(int pAcctAId, int pAcctBId)
        {
            using (TransactionScope lScope = new TransactionScope())
            {
                //transfer 20.0 from Branch1Customer to Branch2Customer
                AccountService1.AccountServiceClient lClient1 = Bank1AccountService;
                AccountService2.AccountServiceClient lClient2 = Bank2AccountService;

                lClient1.Withdraw(pAcctAId, 20);
                lClient2.Deposit(pAcctBId, 20);

                //someone wishing to find the sum of both balances may also get an inconsistent read if there's no distributed transaction
                if ((lClient1.GetAccountBalance(pAcctAId) + lClient2.GetAccountBalance(pAcctBId)) != 100)
                {
                    System.Diagnostics.Trace.WriteLine("INCONSISTENCY!!!!");
                }

                lScope.Complete();
            }
        }

        private void PerformTransferBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateAccounts();
            PerformTransfer(mIdA, mIdB);
        }
    }
}
