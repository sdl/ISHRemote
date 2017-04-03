﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trisoft.ISHRemote.EDT25ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API25/")]
    [System.SerializableAttribute()]
    public partial class InfoShareFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long InfoShareErrorNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OriginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string XMLDetailField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long InfoShareErrorNumber {
            get {
                return this.InfoShareErrorNumberField;
            }
            set {
                if ((this.InfoShareErrorNumberField.Equals(value) != true)) {
                    this.InfoShareErrorNumberField = value;
                    this.RaisePropertyChanged("InfoShareErrorNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Origin {
            get {
                return this.OriginField;
            }
            set {
                if ((object.ReferenceEquals(this.OriginField, value) != true)) {
                    this.OriginField = value;
                    this.RaisePropertyChanged("Origin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XMLDetail {
            get {
                return this.XMLDetailField;
            }
            set {
                if ((object.ReferenceEquals(this.XMLDetailField, value) != true)) {
                    this.XMLDetailField = value;
                    this.RaisePropertyChanged("XMLDetail");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityFilter", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Enumerations/API25/")]
    public enum ActivityFilter : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inactive = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/", ConfigurationName="EDT25ServiceReference.EDT")]
    public interface EDT {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/GetList", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/GetListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Trisoft.ISHRemote.EDT25ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/GetListInfoShareFau" +
            "lt", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API25/")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="xmlObjectList")]
        string GetList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/GetList", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/GetListResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="xmlObjectList")]
        System.Threading.Tasks.Task<string> GetListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/Create", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/CreateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Trisoft.ISHRemote.EDT25ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/CreateInfoShareFaul" +
            "t", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API25/")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="returnValue")]
        string Create(string edtName, string xmlMetadata);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/Create", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/CreateResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="returnValue")]
        System.Threading.Tasks.Task<string> CreateAsync(string edtName, string xmlMetadata);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/Update", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/UpdateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Trisoft.ISHRemote.EDT25ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/UpdateInfoShareFaul" +
            "t", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API25/")]
        void Update(string edtId, string xmlMetadata, string xmlRequiredCurrentMetadata);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/Update", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(string edtId, string xmlMetadata, string xmlRequiredCurrentMetadata);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/Delete", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/DeleteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Trisoft.ISHRemote.EDT25ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/DeleteInfoShareFaul" +
            "t", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API25/")]
        void Delete(string edtId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/Delete", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(string edtId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/GetMetadata", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/GetMetadataResponse" +
            "")]
        [System.ServiceModel.FaultContractAttribute(typeof(Trisoft.ISHRemote.EDT25ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/GetMetadataInfoShar" +
            "eFault", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API25/")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="xmlObjectList")]
        string GetMetadata(string edtId, string xmlRequestedMetadata);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/GetMetadata", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/GetMetadataResponse" +
            "")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="xmlObjectList")]
        System.Threading.Tasks.Task<string> GetMetadataAsync(string edtId, string xmlRequestedMetadata);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/RetrieveMetadata", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/RetrieveMetadataRes" +
            "ponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Trisoft.ISHRemote.EDT25ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/RetrieveMetadataInf" +
            "oShareFault", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API25/")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="xmlObjectList")]
        string RetrieveMetadata(string[] edtIds, Trisoft.ISHRemote.EDT25ServiceReference.ActivityFilter activityFilter, string xmlMetadataFilter, string xmlRequestedMetadata);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/RetrieveMetadata", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/RetrieveMetadataRes" +
            "ponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="xmlObjectList")]
        System.Threading.Tasks.Task<string> RetrieveMetadataAsync(string[] edtIds, Trisoft.ISHRemote.EDT25ServiceReference.ActivityFilter activityFilter, string xmlMetadataFilter, string xmlRequestedMetadata);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/Find", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/FindResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Trisoft.ISHRemote.EDT25ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/FindInfoShareFault", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API25/")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="xmlObjectList")]
        string Find(Trisoft.ISHRemote.EDT25ServiceReference.ActivityFilter activityFilter, string xmlMetadataFilter, string xmlRequestedMetadata);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/Find", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/EDT/FindResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="xmlObjectList")]
        System.Threading.Tasks.Task<string> FindAsync(Trisoft.ISHRemote.EDT25ServiceReference.ActivityFilter activityFilter, string xmlMetadataFilter, string xmlRequestedMetadata);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EDTChannel : Trisoft.ISHRemote.EDT25ServiceReference.EDT, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EDTClient : System.ServiceModel.ClientBase<Trisoft.ISHRemote.EDT25ServiceReference.EDT>, Trisoft.ISHRemote.EDT25ServiceReference.EDT {
        
        public EDTClient() {
        }
        
        public EDTClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EDTClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EDTClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EDTClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetList() {
            return base.Channel.GetList();
        }
        
        public System.Threading.Tasks.Task<string> GetListAsync() {
            return base.Channel.GetListAsync();
        }
        
        public string Create(string edtName, string xmlMetadata) {
            return base.Channel.Create(edtName, xmlMetadata);
        }
        
        public System.Threading.Tasks.Task<string> CreateAsync(string edtName, string xmlMetadata) {
            return base.Channel.CreateAsync(edtName, xmlMetadata);
        }
        
        public void Update(string edtId, string xmlMetadata, string xmlRequiredCurrentMetadata) {
            base.Channel.Update(edtId, xmlMetadata, xmlRequiredCurrentMetadata);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(string edtId, string xmlMetadata, string xmlRequiredCurrentMetadata) {
            return base.Channel.UpdateAsync(edtId, xmlMetadata, xmlRequiredCurrentMetadata);
        }
        
        public void Delete(string edtId) {
            base.Channel.Delete(edtId);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(string edtId) {
            return base.Channel.DeleteAsync(edtId);
        }
        
        public string GetMetadata(string edtId, string xmlRequestedMetadata) {
            return base.Channel.GetMetadata(edtId, xmlRequestedMetadata);
        }
        
        public System.Threading.Tasks.Task<string> GetMetadataAsync(string edtId, string xmlRequestedMetadata) {
            return base.Channel.GetMetadataAsync(edtId, xmlRequestedMetadata);
        }
        
        public string RetrieveMetadata(string[] edtIds, Trisoft.ISHRemote.EDT25ServiceReference.ActivityFilter activityFilter, string xmlMetadataFilter, string xmlRequestedMetadata) {
            return base.Channel.RetrieveMetadata(edtIds, activityFilter, xmlMetadataFilter, xmlRequestedMetadata);
        }
        
        public System.Threading.Tasks.Task<string> RetrieveMetadataAsync(string[] edtIds, Trisoft.ISHRemote.EDT25ServiceReference.ActivityFilter activityFilter, string xmlMetadataFilter, string xmlRequestedMetadata) {
            return base.Channel.RetrieveMetadataAsync(edtIds, activityFilter, xmlMetadataFilter, xmlRequestedMetadata);
        }
        
        public string Find(Trisoft.ISHRemote.EDT25ServiceReference.ActivityFilter activityFilter, string xmlMetadataFilter, string xmlRequestedMetadata) {
            return base.Channel.Find(activityFilter, xmlMetadataFilter, xmlRequestedMetadata);
        }
        
        public System.Threading.Tasks.Task<string> FindAsync(Trisoft.ISHRemote.EDT25ServiceReference.ActivityFilter activityFilter, string xmlMetadataFilter, string xmlRequestedMetadata) {
            return base.Channel.FindAsync(activityFilter, xmlMetadataFilter, xmlRequestedMetadata);
        }
    }
}