﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bank.TransferClient.AccountService1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/Bank.Business.Entities", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<Bank.TransferClient.AccountService1.Account> AccountsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Bank.TransferClient.AccountService1.ObjectChangeTracker ChangeTrackerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<Bank.TransferClient.AccountService1.Account> Accounts {
            get {
                return this.AccountsField;
            }
            set {
                if ((object.ReferenceEquals(this.AccountsField, value) != true)) {
                    this.AccountsField = value;
                    this.RaisePropertyChanged("Accounts");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Bank.TransferClient.AccountService1.ObjectChangeTracker ChangeTracker {
            get {
                return this.ChangeTrackerField;
            }
            set {
                if ((object.ReferenceEquals(this.ChangeTrackerField, value) != true)) {
                    this.ChangeTrackerField = value;
                    this.RaisePropertyChanged("ChangeTracker");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ObjectChangeTracker", Namespace="http://schemas.datacontract.org/2004/07/Bank.Business.Entities", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class ObjectChangeTracker : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Bank.TransferClient.AccountService1.ExtendedPropertiesDictionary ExtendedPropertiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Bank.TransferClient.AccountService1.ObjectsAddedToCollectionProperties ObjectsAddedToCollectionPropertiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Bank.TransferClient.AccountService1.ObjectsRemovedFromCollectionProperties ObjectsRemovedFromCollectionPropertiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Bank.TransferClient.AccountService1.OriginalValuesDictionary OriginalValuesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Bank.TransferClient.AccountService1.ObjectState StateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Bank.TransferClient.AccountService1.ExtendedPropertiesDictionary ExtendedProperties {
            get {
                return this.ExtendedPropertiesField;
            }
            set {
                if ((object.ReferenceEquals(this.ExtendedPropertiesField, value) != true)) {
                    this.ExtendedPropertiesField = value;
                    this.RaisePropertyChanged("ExtendedProperties");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Bank.TransferClient.AccountService1.ObjectsAddedToCollectionProperties ObjectsAddedToCollectionProperties {
            get {
                return this.ObjectsAddedToCollectionPropertiesField;
            }
            set {
                if ((object.ReferenceEquals(this.ObjectsAddedToCollectionPropertiesField, value) != true)) {
                    this.ObjectsAddedToCollectionPropertiesField = value;
                    this.RaisePropertyChanged("ObjectsAddedToCollectionProperties");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Bank.TransferClient.AccountService1.ObjectsRemovedFromCollectionProperties ObjectsRemovedFromCollectionProperties {
            get {
                return this.ObjectsRemovedFromCollectionPropertiesField;
            }
            set {
                if ((object.ReferenceEquals(this.ObjectsRemovedFromCollectionPropertiesField, value) != true)) {
                    this.ObjectsRemovedFromCollectionPropertiesField = value;
                    this.RaisePropertyChanged("ObjectsRemovedFromCollectionProperties");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Bank.TransferClient.AccountService1.OriginalValuesDictionary OriginalValues {
            get {
                return this.OriginalValuesField;
            }
            set {
                if ((object.ReferenceEquals(this.OriginalValuesField, value) != true)) {
                    this.OriginalValuesField = value;
                    this.RaisePropertyChanged("OriginalValues");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Bank.TransferClient.AccountService1.ObjectState State {
            get {
                return this.StateField;
            }
            set {
                if ((this.StateField.Equals(value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Account", Namespace="http://schemas.datacontract.org/2004/07/Bank.Business.Entities", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Account : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double BalanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Bank.TransferClient.AccountService1.ObjectChangeTracker ChangeTrackerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Bank.TransferClient.AccountService1.Customer CustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Balance {
            get {
                return this.BalanceField;
            }
            set {
                if ((this.BalanceField.Equals(value) != true)) {
                    this.BalanceField = value;
                    this.RaisePropertyChanged("Balance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Bank.TransferClient.AccountService1.ObjectChangeTracker ChangeTracker {
            get {
                return this.ChangeTrackerField;
            }
            set {
                if ((object.ReferenceEquals(this.ChangeTrackerField, value) != true)) {
                    this.ChangeTrackerField = value;
                    this.RaisePropertyChanged("ChangeTracker");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Bank.TransferClient.AccountService1.Customer Customer {
            get {
                return this.CustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerField, value) != true)) {
                    this.CustomerField = value;
                    this.RaisePropertyChanged("Customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ExtendedPropertiesDictionary", Namespace="http://schemas.datacontract.org/2004/07/Bank.Business.Entities", ItemName="ExtendedProperties", KeyName="Name", ValueName="ExtendedProperty")]
    [System.SerializableAttribute()]
    public class ExtendedPropertiesDictionary : System.Collections.Generic.Dictionary<string, object> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ObjectsAddedToCollectionProperties", Namespace="http://schemas.datacontract.org/2004/07/Bank.Business.Entities", ItemName="AddedObjectsForProperty", KeyName="CollectionPropertyName", ValueName="AddedObjects")]
    [System.SerializableAttribute()]
    public class ObjectsAddedToCollectionProperties : System.Collections.Generic.Dictionary<string, Bank.TransferClient.AccountService1.ObjectList> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ObjectsRemovedFromCollectionProperties", Namespace="http://schemas.datacontract.org/2004/07/Bank.Business.Entities", ItemName="DeletedObjectsForProperty", KeyName="CollectionPropertyName", ValueName="DeletedObjects")]
    [System.SerializableAttribute()]
    public class ObjectsRemovedFromCollectionProperties : System.Collections.Generic.Dictionary<string, Bank.TransferClient.AccountService1.ObjectList> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="OriginalValuesDictionary", Namespace="http://schemas.datacontract.org/2004/07/Bank.Business.Entities", ItemName="OriginalValues", KeyName="Name", ValueName="OriginalValue")]
    [System.SerializableAttribute()]
    public class OriginalValuesDictionary : System.Collections.Generic.Dictionary<string, object> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.FlagsAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(Name="ObjectState", Namespace="http://schemas.datacontract.org/2004/07/Bank.Business.Entities")]
    public enum ObjectState : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unchanged = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Added = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Modified = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Deleted = 8,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ObjectList", Namespace="http://schemas.datacontract.org/2004/07/Bank.Business.Entities", ItemName="ObjectValue")]
    [System.SerializableAttribute()]
    public class ObjectList : System.Collections.Generic.List<object> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AccountService1.IAccountService")]
    public interface IAccountService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/Deposit", ReplyAction="http://tempuri.org/IAccountService/DepositResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        void Deposit(int pAcctId, double pAmount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/Withdraw", ReplyAction="http://tempuri.org/IAccountService/WithdrawResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        void Withdraw(int pAcctId, double pAmount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/CreateCustomer", ReplyAction="http://tempuri.org/IAccountService/CreateCustomerResponse")]
        int CreateCustomer(Bank.TransferClient.AccountService1.Customer pCustomer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/CreateAccount", ReplyAction="http://tempuri.org/IAccountService/CreateAccountResponse")]
        int CreateAccount(int pCustId, Bank.TransferClient.AccountService1.Account pAcct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetAccountBalance", ReplyAction="http://tempuri.org/IAccountService/GetAccountBalanceResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        double GetAccountBalance(int pAcctId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccountServiceChannel : Bank.TransferClient.AccountService1.IAccountService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountServiceClient : System.ServiceModel.ClientBase<Bank.TransferClient.AccountService1.IAccountService>, Bank.TransferClient.AccountService1.IAccountService {
        
        public AccountServiceClient() {
        }
        
        public AccountServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Deposit(int pAcctId, double pAmount) {
            base.Channel.Deposit(pAcctId, pAmount);
        }
        
        public void Withdraw(int pAcctId, double pAmount) {
            base.Channel.Withdraw(pAcctId, pAmount);
        }
        
        public int CreateCustomer(Bank.TransferClient.AccountService1.Customer pCustomer) {
            return base.Channel.CreateCustomer(pCustomer);
        }
        
        public int CreateAccount(int pCustId, Bank.TransferClient.AccountService1.Account pAcct) {
            return base.Channel.CreateAccount(pCustId, pAcct);
        }
        
        public double GetAccountBalance(int pAcctId) {
            return base.Channel.GetAccountBalance(pAcctId);
        }
    }
}
