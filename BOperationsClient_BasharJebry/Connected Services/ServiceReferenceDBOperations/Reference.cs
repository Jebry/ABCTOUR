﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOperationsClient_BasharJebry.ServiceReferenceDBOperations {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InsertABus", Namespace="http://schemas.datacontract.org/2004/07/FinalExam_BasharJebry")]
    [System.SerializableAttribute()]
    public partial class InsertABus : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BusIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MakeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NoOfSeatsField;
        
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
        public int BusId {
            get {
                return this.BusIdField;
            }
            set {
                if ((this.BusIdField.Equals(value) != true)) {
                    this.BusIdField = value;
                    this.RaisePropertyChanged("BusId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Make {
            get {
                return this.MakeField;
            }
            set {
                if ((object.ReferenceEquals(this.MakeField, value) != true)) {
                    this.MakeField = value;
                    this.RaisePropertyChanged("Make");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NoOfSeats {
            get {
                return this.NoOfSeatsField;
            }
            set {
                if ((this.NoOfSeatsField.Equals(value) != true)) {
                    this.NoOfSeatsField = value;
                    this.RaisePropertyChanged("NoOfSeats");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UpdateABus", Namespace="http://schemas.datacontract.org/2004/07/FinalExam_BasharJebry")]
    [System.SerializableAttribute()]
    public partial class UpdateABus : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BusIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MakeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NoOfSeatsField;
        
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
        public int BusId {
            get {
                return this.BusIdField;
            }
            set {
                if ((this.BusIdField.Equals(value) != true)) {
                    this.BusIdField = value;
                    this.RaisePropertyChanged("BusId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Make {
            get {
                return this.MakeField;
            }
            set {
                if ((object.ReferenceEquals(this.MakeField, value) != true)) {
                    this.MakeField = value;
                    this.RaisePropertyChanged("Make");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NoOfSeats {
            get {
                return this.NoOfSeatsField;
            }
            set {
                if ((this.NoOfSeatsField.Equals(value) != true)) {
                    this.NoOfSeatsField = value;
                    this.RaisePropertyChanged("NoOfSeats");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RetrieveBusInfo", Namespace="http://schemas.datacontract.org/2004/07/FinalExam_BasharJebry")]
    [System.SerializableAttribute()]
    public partial class RetrieveBusInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BOperationsClient_BasharJebry.ServiceReferenceDBOperations.BusInfo[] datasetField;
        
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
        public BOperationsClient_BasharJebry.ServiceReferenceDBOperations.BusInfo[] dataset {
            get {
                return this.datasetField;
            }
            set {
                if ((object.ReferenceEquals(this.datasetField, value) != true)) {
                    this.datasetField = value;
                    this.RaisePropertyChanged("dataset");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="BusInfo", Namespace="http://schemas.datacontract.org/2004/07/FinalExam_BasharJebry")]
    [System.SerializableAttribute()]
    public partial class BusInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BusIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MakeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NoOfSeatsField;
        
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
        public int BusId {
            get {
                return this.BusIdField;
            }
            set {
                if ((this.BusIdField.Equals(value) != true)) {
                    this.BusIdField = value;
                    this.RaisePropertyChanged("BusId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Make {
            get {
                return this.MakeField;
            }
            set {
                if ((object.ReferenceEquals(this.MakeField, value) != true)) {
                    this.MakeField = value;
                    this.RaisePropertyChanged("Make");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NoOfSeats {
            get {
                return this.NoOfSeatsField;
            }
            set {
                if ((this.NoOfSeatsField.Equals(value) != true)) {
                    this.NoOfSeatsField = value;
                    this.RaisePropertyChanged("NoOfSeats");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DeleteABus", Namespace="http://schemas.datacontract.org/2004/07/FinalExam_BasharJebry")]
    [System.SerializableAttribute()]
    public partial class DeleteABus : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BusIdField;
        
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
        public int BusId {
            get {
                return this.BusIdField;
            }
            set {
                if ((this.BusIdField.Equals(value) != true)) {
                    this.BusIdField = value;
                    this.RaisePropertyChanged("BusId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FindABus", Namespace="http://schemas.datacontract.org/2004/07/FinalExam_BasharJebry")]
    [System.SerializableAttribute()]
    public partial class FindABus : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BusIdField;
        
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
        public int BusId {
            get {
                return this.BusIdField;
            }
            set {
                if ((this.BusIdField.Equals(value) != true)) {
                    this.BusIdField = value;
                    this.RaisePropertyChanged("BusId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FoundRecord", Namespace="http://schemas.datacontract.org/2004/07/FinalExam_BasharJebry")]
    [System.SerializableAttribute()]
    public partial class FoundRecord : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BusIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MakeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NoOfSeatsField;
        
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
        public int BusId {
            get {
                return this.BusIdField;
            }
            set {
                if ((this.BusIdField.Equals(value) != true)) {
                    this.BusIdField = value;
                    this.RaisePropertyChanged("BusId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Make {
            get {
                return this.MakeField;
            }
            set {
                if ((object.ReferenceEquals(this.MakeField, value) != true)) {
                    this.MakeField = value;
                    this.RaisePropertyChanged("Make");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NoOfSeats {
            get {
                return this.NoOfSeatsField;
            }
            set {
                if ((this.NoOfSeatsField.Equals(value) != true)) {
                    this.NoOfSeatsField = value;
                    this.RaisePropertyChanged("NoOfSeats");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UserInfo", Namespace="http://schemas.datacontract.org/2004/07/FinalExam_BasharJebry")]
    [System.SerializableAttribute()]
    public partial class UserInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceDBOperations.ITourDBOperationsService_Bashar")]
    public interface ITourDBOperationsService_Bashar {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourDBOperationsService_Bashar/InsertABus", ReplyAction="http://tempuri.org/ITourDBOperationsService_Bashar/InsertABusResponse")]
        string InsertABus(BOperationsClient_BasharJebry.ServiceReferenceDBOperations.InsertABus bus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourDBOperationsService_Bashar/InsertABus", ReplyAction="http://tempuri.org/ITourDBOperationsService_Bashar/InsertABusResponse")]
        System.Threading.Tasks.Task<string> InsertABusAsync(BOperationsClient_BasharJebry.ServiceReferenceDBOperations.InsertABus bus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourDBOperationsService_Bashar/UpdateABus", ReplyAction="http://tempuri.org/ITourDBOperationsService_Bashar/UpdateABusResponse")]
        string UpdateABus(BOperationsClient_BasharJebry.ServiceReferenceDBOperations.UpdateABus bus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourDBOperationsService_Bashar/UpdateABus", ReplyAction="http://tempuri.org/ITourDBOperationsService_Bashar/UpdateABusResponse")]
        System.Threading.Tasks.Task<string> UpdateABusAsync(BOperationsClient_BasharJebry.ServiceReferenceDBOperations.UpdateABus bus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourDBOperationsService_Bashar/RetrieveBusInfo", ReplyAction="http://tempuri.org/ITourDBOperationsService_Bashar/RetrieveBusInfoResponse")]
        BOperationsClient_BasharJebry.ServiceReferenceDBOperations.RetrieveBusInfo RetrieveBusInfo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourDBOperationsService_Bashar/RetrieveBusInfo", ReplyAction="http://tempuri.org/ITourDBOperationsService_Bashar/RetrieveBusInfoResponse")]
        System.Threading.Tasks.Task<BOperationsClient_BasharJebry.ServiceReferenceDBOperations.RetrieveBusInfo> RetrieveBusInfoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourDBOperationsService_Bashar/DeleteABus", ReplyAction="http://tempuri.org/ITourDBOperationsService_Bashar/DeleteABusResponse")]
        string DeleteABus(BOperationsClient_BasharJebry.ServiceReferenceDBOperations.DeleteABus bus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourDBOperationsService_Bashar/DeleteABus", ReplyAction="http://tempuri.org/ITourDBOperationsService_Bashar/DeleteABusResponse")]
        System.Threading.Tasks.Task<string> DeleteABusAsync(BOperationsClient_BasharJebry.ServiceReferenceDBOperations.DeleteABus bus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourDBOperationsService_Bashar/FindABus", ReplyAction="http://tempuri.org/ITourDBOperationsService_Bashar/FindABusResponse")]
        BOperationsClient_BasharJebry.ServiceReferenceDBOperations.FoundRecord FindABus(BOperationsClient_BasharJebry.ServiceReferenceDBOperations.FindABus bus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourDBOperationsService_Bashar/FindABus", ReplyAction="http://tempuri.org/ITourDBOperationsService_Bashar/FindABusResponse")]
        System.Threading.Tasks.Task<BOperationsClient_BasharJebry.ServiceReferenceDBOperations.FoundRecord> FindABusAsync(BOperationsClient_BasharJebry.ServiceReferenceDBOperations.FindABus bus);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITourDBOperationsService_BasharChannel : BOperationsClient_BasharJebry.ServiceReferenceDBOperations.ITourDBOperationsService_Bashar, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TourDBOperationsService_BasharClient : System.ServiceModel.ClientBase<BOperationsClient_BasharJebry.ServiceReferenceDBOperations.ITourDBOperationsService_Bashar>, BOperationsClient_BasharJebry.ServiceReferenceDBOperations.ITourDBOperationsService_Bashar {
        
        public TourDBOperationsService_BasharClient() {
        }
        
        public TourDBOperationsService_BasharClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TourDBOperationsService_BasharClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TourDBOperationsService_BasharClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TourDBOperationsService_BasharClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string InsertABus(BOperationsClient_BasharJebry.ServiceReferenceDBOperations.InsertABus bus) {
            return base.Channel.InsertABus(bus);
        }
        
        public System.Threading.Tasks.Task<string> InsertABusAsync(BOperationsClient_BasharJebry.ServiceReferenceDBOperations.InsertABus bus) {
            return base.Channel.InsertABusAsync(bus);
        }
        
        public string UpdateABus(BOperationsClient_BasharJebry.ServiceReferenceDBOperations.UpdateABus bus) {
            return base.Channel.UpdateABus(bus);
        }
        
        public System.Threading.Tasks.Task<string> UpdateABusAsync(BOperationsClient_BasharJebry.ServiceReferenceDBOperations.UpdateABus bus) {
            return base.Channel.UpdateABusAsync(bus);
        }
        
        public BOperationsClient_BasharJebry.ServiceReferenceDBOperations.RetrieveBusInfo RetrieveBusInfo() {
            return base.Channel.RetrieveBusInfo();
        }
        
        public System.Threading.Tasks.Task<BOperationsClient_BasharJebry.ServiceReferenceDBOperations.RetrieveBusInfo> RetrieveBusInfoAsync() {
            return base.Channel.RetrieveBusInfoAsync();
        }
        
        public string DeleteABus(BOperationsClient_BasharJebry.ServiceReferenceDBOperations.DeleteABus bus) {
            return base.Channel.DeleteABus(bus);
        }
        
        public System.Threading.Tasks.Task<string> DeleteABusAsync(BOperationsClient_BasharJebry.ServiceReferenceDBOperations.DeleteABus bus) {
            return base.Channel.DeleteABusAsync(bus);
        }
        
        public BOperationsClient_BasharJebry.ServiceReferenceDBOperations.FoundRecord FindABus(BOperationsClient_BasharJebry.ServiceReferenceDBOperations.FindABus bus) {
            return base.Channel.FindABus(bus);
        }
        
        public System.Threading.Tasks.Task<BOperationsClient_BasharJebry.ServiceReferenceDBOperations.FoundRecord> FindABusAsync(BOperationsClient_BasharJebry.ServiceReferenceDBOperations.FindABus bus) {
            return base.Channel.FindABusAsync(bus);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceDBOperations.ITourAuthenticateUserService_Bashar")]
    public interface ITourAuthenticateUserService_Bashar {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourAuthenticateUserService_Bashar/AuthenticateUser", ReplyAction="http://tempuri.org/ITourAuthenticateUserService_Bashar/AuthenticateUserResponse")]
        string AuthenticateUser(BOperationsClient_BasharJebry.ServiceReferenceDBOperations.UserInfo user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourAuthenticateUserService_Bashar/AuthenticateUser", ReplyAction="http://tempuri.org/ITourAuthenticateUserService_Bashar/AuthenticateUserResponse")]
        System.Threading.Tasks.Task<string> AuthenticateUserAsync(BOperationsClient_BasharJebry.ServiceReferenceDBOperations.UserInfo user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITourAuthenticateUserService_BasharChannel : BOperationsClient_BasharJebry.ServiceReferenceDBOperations.ITourAuthenticateUserService_Bashar, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TourAuthenticateUserService_BasharClient : System.ServiceModel.ClientBase<BOperationsClient_BasharJebry.ServiceReferenceDBOperations.ITourAuthenticateUserService_Bashar>, BOperationsClient_BasharJebry.ServiceReferenceDBOperations.ITourAuthenticateUserService_Bashar {
        
        public TourAuthenticateUserService_BasharClient() {
        }
        
        public TourAuthenticateUserService_BasharClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TourAuthenticateUserService_BasharClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TourAuthenticateUserService_BasharClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TourAuthenticateUserService_BasharClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AuthenticateUser(BOperationsClient_BasharJebry.ServiceReferenceDBOperations.UserInfo user) {
            return base.Channel.AuthenticateUser(user);
        }
        
        public System.Threading.Tasks.Task<string> AuthenticateUserAsync(BOperationsClient_BasharJebry.ServiceReferenceDBOperations.UserInfo user) {
            return base.Channel.AuthenticateUserAsync(user);
        }
    }
}
