using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Bank.Business.Entities;

namespace Bank.Services.Interfaces
{
    [ServiceContract]
    public interface IAccountService
    {
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void Deposit(int pAcctId, double pAmount);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void Withdraw(int pAcctId, double pAmount);

        [OperationContract]
        int CreateCustomer(Customer pCustomer);

        [OperationContract]
        int CreateAccount(int pCustId, Account pAcct);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        double GetAccountBalance(int pAcctId);
    }
}
