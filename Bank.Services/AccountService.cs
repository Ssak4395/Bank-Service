using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bank.Services.Interfaces;
using Bank.Business.Entities;
using System.Transactions;
using System.Data.SqlClient;
using System.ServiceModel;

namespace Bank.Services
{
    public class AccountService : IAccountService
    {
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        public void Deposit(int pAcctId, double pAmount)
        {
            using (BankEntityModelContainer lContainer = new BankEntityModelContainer())
            {
                LockAccount(pAcctId);
                Account lAcct = (from acct in lContainer.Accounts where acct.Id == pAcctId select acct).FirstOrDefault();
                if (lAcct != null)
                {
                    lAcct.Balance += pAmount;
                    Logger.Log("Depositing Money");
                    lContainer.SaveChanges();
                }
            }
        }

        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        public void Withdraw(int pAcctId, double pAmount)
        {
            using (BankEntityModelContainer lContainer = new BankEntityModelContainer())
            {
                LockAccount(pAcctId);
                Account lAcct = (from acct in lContainer.Accounts where acct.Id == pAcctId select acct).FirstOrDefault();
                if (lAcct != null)
                {
                    lAcct.Balance -= pAmount;
                    lContainer.SaveChanges();
                }
            }
        }

        private void LockAccount(int pAcctId)
        {
            using (BankEntityModelContainer lContainer = new BankEntityModelContainer())
            using (SqlConnection lConn = new SqlConnection((lContainer.Connection as System.Data.EntityClient.EntityConnection).StoreConnection.ConnectionString))
            using (SqlCommand lCmd = new SqlCommand())
            {
                lCmd.CommandText =
@"
select * from dbo.Accounts with (updlock) where Id = @p_AccountId
";
                lCmd.Parameters.AddWithValue("@p_AccountId", pAcctId);
                lCmd.Connection = lConn;
                lConn.Open();
                lCmd.ExecuteNonQuery();
            }
        }

        public int CreateCustomer(Customer pCustomer)
        {
            using (TransactionScope lScope = new TransactionScope(TransactionScopeOption.Required))
            using (BankEntityModelContainer lContainer = new BankEntityModelContainer())
            {
                lContainer.Customers.AddObject(pCustomer);
                lContainer.SaveChanges();
                lScope.Complete();
            }
            return pCustomer.Id;
        }

        public int CreateAccount(int pCustId, Account pAcct)
        {
            using (TransactionScope lScope = new TransactionScope(TransactionScopeOption.Required))
            using (BankEntityModelContainer lContainer = new BankEntityModelContainer())
            {
                Customer lCust = (from cust in lContainer.Customers where cust.Id == pCustId select cust).FirstOrDefault();
                lCust.Accounts.Add(pAcct);
                lContainer.SaveChanges();
                lScope.Complete();
            }
            return pAcct.Id;
        }

        [OperationBehavior(TransactionScopeRequired=true, TransactionAutoComplete=true)]
        public double GetAccountBalance(int pAcctId)
        {
            using (BankEntityModelContainer lContainer = new BankEntityModelContainer())
            {
                Account lAcct = (from acct in lContainer.Accounts where acct.Id == pAcctId select acct).FirstOrDefault();
                return lAcct.Balance;
            }
        }
    }
}
