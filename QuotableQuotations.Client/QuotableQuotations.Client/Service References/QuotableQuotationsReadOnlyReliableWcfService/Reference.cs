﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuotableQuotations.Client.QuotableQuotationsReadOnlyReliableWcfService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="QuotableQuotation", Namespace="http://schemas.datacontract.org/2004/07/QuotableQuotations.Contracts.Classes")]
    [System.SerializableAttribute()]
    public partial class QuotableQuotation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QuoteField;
        
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
        public string Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Quote {
            get {
                return this.QuoteField;
            }
            set {
                if ((object.ReferenceEquals(this.QuoteField, value) != true)) {
                    this.QuoteField = value;
                    this.RaisePropertyChanged("Quote");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="QuotableQuotationsReadOnlyReliableWcfService.IQuotableQuotationsReadOnlyReliableW" +
        "cfService")]
    public interface IQuotableQuotationsReadOnlyReliableWcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuotableQuotationsReadOnlyReliableWcfService/GetQuotationsByQ" +
            "uoteStrings", ReplyAction="http://tempuri.org/IQuotableQuotationsReadOnlyReliableWcfService/GetQuotationsByQ" +
            "uoteStringsResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        QuotableQuotations.Client.QuotableQuotationsReadOnlyReliableWcfService.QuotableQuotation[] GetQuotationsByQuoteStrings(string[] quoteTexts);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuotableQuotationsReadOnlyReliableWcfService/GetQuotationsByQ" +
            "uoteStrings", ReplyAction="http://tempuri.org/IQuotableQuotationsReadOnlyReliableWcfService/GetQuotationsByQ" +
            "uoteStringsResponse")]
        System.Threading.Tasks.Task<QuotableQuotations.Client.QuotableQuotationsReadOnlyReliableWcfService.QuotableQuotation[]> GetQuotationsByQuoteStringsAsync(string[] quoteTexts);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuotableQuotationsReadOnlyReliableWcfService/GetQuotationsByN" +
            "ames", ReplyAction="http://tempuri.org/IQuotableQuotationsReadOnlyReliableWcfService/GetQuotationsByN" +
            "amesResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        QuotableQuotations.Client.QuotableQuotationsReadOnlyReliableWcfService.QuotableQuotation[] GetQuotationsByNames(string[] names);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuotableQuotationsReadOnlyReliableWcfService/GetQuotationsByN" +
            "ames", ReplyAction="http://tempuri.org/IQuotableQuotationsReadOnlyReliableWcfService/GetQuotationsByN" +
            "amesResponse")]
        System.Threading.Tasks.Task<QuotableQuotations.Client.QuotableQuotationsReadOnlyReliableWcfService.QuotableQuotation[]> GetQuotationsByNamesAsync(string[] names);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuotableQuotationsReadOnlyReliableWcfService/GetQuotationsByC" +
            "ategories", ReplyAction="http://tempuri.org/IQuotableQuotationsReadOnlyReliableWcfService/GetQuotationsByC" +
            "ategoriesResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        QuotableQuotations.Client.QuotableQuotationsReadOnlyReliableWcfService.QuotableQuotation[] GetQuotationsByCategories(string[] categories);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuotableQuotationsReadOnlyReliableWcfService/GetQuotationsByC" +
            "ategories", ReplyAction="http://tempuri.org/IQuotableQuotationsReadOnlyReliableWcfService/GetQuotationsByC" +
            "ategoriesResponse")]
        System.Threading.Tasks.Task<QuotableQuotations.Client.QuotableQuotationsReadOnlyReliableWcfService.QuotableQuotation[]> GetQuotationsByCategoriesAsync(string[] categories);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IQuotableQuotationsReadOnlyReliableWcfServiceChannel : QuotableQuotations.Client.QuotableQuotationsReadOnlyReliableWcfService.IQuotableQuotationsReadOnlyReliableWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class QuotableQuotationsReadOnlyReliableWcfServiceClient : System.ServiceModel.ClientBase<QuotableQuotations.Client.QuotableQuotationsReadOnlyReliableWcfService.IQuotableQuotationsReadOnlyReliableWcfService>, QuotableQuotations.Client.QuotableQuotationsReadOnlyReliableWcfService.IQuotableQuotationsReadOnlyReliableWcfService {
        
        public QuotableQuotationsReadOnlyReliableWcfServiceClient() {
        }
        
        public QuotableQuotationsReadOnlyReliableWcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public QuotableQuotationsReadOnlyReliableWcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuotableQuotationsReadOnlyReliableWcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuotableQuotationsReadOnlyReliableWcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public QuotableQuotations.Client.QuotableQuotationsReadOnlyReliableWcfService.QuotableQuotation[] GetQuotationsByQuoteStrings(string[] quoteTexts) {
            return base.Channel.GetQuotationsByQuoteStrings(quoteTexts);
        }
        
        public System.Threading.Tasks.Task<QuotableQuotations.Client.QuotableQuotationsReadOnlyReliableWcfService.QuotableQuotation[]> GetQuotationsByQuoteStringsAsync(string[] quoteTexts) {
            return base.Channel.GetQuotationsByQuoteStringsAsync(quoteTexts);
        }
        
        public QuotableQuotations.Client.QuotableQuotationsReadOnlyReliableWcfService.QuotableQuotation[] GetQuotationsByNames(string[] names) {
            return base.Channel.GetQuotationsByNames(names);
        }
        
        public System.Threading.Tasks.Task<QuotableQuotations.Client.QuotableQuotationsReadOnlyReliableWcfService.QuotableQuotation[]> GetQuotationsByNamesAsync(string[] names) {
            return base.Channel.GetQuotationsByNamesAsync(names);
        }
        
        public QuotableQuotations.Client.QuotableQuotationsReadOnlyReliableWcfService.QuotableQuotation[] GetQuotationsByCategories(string[] categories) {
            return base.Channel.GetQuotationsByCategories(categories);
        }
        
        public System.Threading.Tasks.Task<QuotableQuotations.Client.QuotableQuotationsReadOnlyReliableWcfService.QuotableQuotation[]> GetQuotationsByCategoriesAsync(string[] categories) {
            return base.Channel.GetQuotationsByCategoriesAsync(categories);
        }
    }
}
