﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarBrandClientSide.CarBrandServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CarBrand", Namespace="http://schemas.datacontract.org/2004/07/ServiceProject")]
    [System.SerializableAttribute()]
    public partial class CarBrand : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrandNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> PriceField;
        
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
        public string BrandName {
            get {
                return this.BrandNameField;
            }
            set {
                if ((object.ReferenceEquals(this.BrandNameField, value) != true)) {
                    this.BrandNameField = value;
                    this.RaisePropertyChanged("BrandName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CarBrandServiceReference.IBrandService")]
    public interface IBrandService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBrandService/DoWork", ReplyAction="http://tempuri.org/IBrandService/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBrandService/DoWork", ReplyAction="http://tempuri.org/IBrandService/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBrandService/GetCarBrands", ReplyAction="http://tempuri.org/IBrandService/GetCarBrandsResponse")]
        CarBrandClientSide.CarBrandServiceReference.CarBrand[] GetCarBrands();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBrandService/GetCarBrands", ReplyAction="http://tempuri.org/IBrandService/GetCarBrandsResponse")]
        System.Threading.Tasks.Task<CarBrandClientSide.CarBrandServiceReference.CarBrand[]> GetCarBrandsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBrandServiceChannel : CarBrandClientSide.CarBrandServiceReference.IBrandService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BrandServiceClient : System.ServiceModel.ClientBase<CarBrandClientSide.CarBrandServiceReference.IBrandService>, CarBrandClientSide.CarBrandServiceReference.IBrandService {
        
        public BrandServiceClient() {
        }
        
        public BrandServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BrandServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BrandServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BrandServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public CarBrandClientSide.CarBrandServiceReference.CarBrand[] GetCarBrands() {
            return base.Channel.GetCarBrands();
        }
        
        public System.Threading.Tasks.Task<CarBrandClientSide.CarBrandServiceReference.CarBrand[]> GetCarBrandsAsync() {
            return base.Channel.GetCarBrandsAsync();
        }
    }
}
