using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Transactions;
using System.ServiceModel;
using System.Windows;

namespace Bank.TransferClient
{
    class Program
    {

        [STAThread]
        public static void Main(string[] args)
        {
            Application lApp = new Application();
            Window lWindow = new Window();
            lWindow.Content = new BankTransferControl();
            lApp.MainWindow = lWindow;
            lApp.Run();
        }





    }
}
