﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApplicationConsole.HotelRenaviereServiceRef1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Hotel", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Hotel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TownField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
        private int RatingField;
        
        private int NumberOfRoomField;
        
        private int NumberOfBedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientApplicationConsole.HotelRenaviereServiceRef1.Room[] RoomsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientApplicationConsole.HotelRenaviereServiceRef1.Offer[] OffersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientApplicationConsole.HotelRenaviereServiceRef1.AgencyInfo[] AgenciesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Town {
            get {
                return this.TownField;
            }
            set {
                if ((object.ReferenceEquals(this.TownField, value) != true)) {
                    this.TownField = value;
                    this.RaisePropertyChanged("Town");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public int Rating {
            get {
                return this.RatingField;
            }
            set {
                if ((this.RatingField.Equals(value) != true)) {
                    this.RatingField = value;
                    this.RaisePropertyChanged("Rating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public int NumberOfRoom {
            get {
                return this.NumberOfRoomField;
            }
            set {
                if ((this.NumberOfRoomField.Equals(value) != true)) {
                    this.NumberOfRoomField = value;
                    this.RaisePropertyChanged("NumberOfRoom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public int NumberOfBed {
            get {
                return this.NumberOfBedField;
            }
            set {
                if ((this.NumberOfBedField.Equals(value) != true)) {
                    this.NumberOfBedField = value;
                    this.RaisePropertyChanged("NumberOfBed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public ClientApplicationConsole.HotelRenaviereServiceRef1.Room[] Rooms {
            get {
                return this.RoomsField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomsField, value) != true)) {
                    this.RoomsField = value;
                    this.RaisePropertyChanged("Rooms");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public ClientApplicationConsole.HotelRenaviereServiceRef1.Offer[] Offers {
            get {
                return this.OffersField;
            }
            set {
                if ((object.ReferenceEquals(this.OffersField, value) != true)) {
                    this.OffersField = value;
                    this.RaisePropertyChanged("Offers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public ClientApplicationConsole.HotelRenaviereServiceRef1.AgencyInfo[] Agencies {
            get {
                return this.AgenciesField;
            }
            set {
                if ((object.ReferenceEquals(this.AgenciesField, value) != true)) {
                    this.AgenciesField = value;
                    this.RaisePropertyChanged("Agencies");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Room", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Room : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private int PriceField;
        
        private int NumberOfBedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CapacityField;
        
        private bool StateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Price {
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int NumberOfBed {
            get {
                return this.NumberOfBedField;
            }
            set {
                if ((this.NumberOfBedField.Equals(value) != true)) {
                    this.NumberOfBedField = value;
                    this.RaisePropertyChanged("NumberOfBed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Capacity {
            get {
                return this.CapacityField;
            }
            set {
                if ((object.ReferenceEquals(this.CapacityField, value) != true)) {
                    this.CapacityField = value;
                    this.RaisePropertyChanged("Capacity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public bool State {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Offer", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Offer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private int NumberOfBedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DateAvailableField;
        
        private int PriceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int NumberOfBed {
            get {
                return this.NumberOfBedField;
            }
            set {
                if ((this.NumberOfBedField.Equals(value) != true)) {
                    this.NumberOfBedField = value;
                    this.RaisePropertyChanged("NumberOfBed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string DateAvailable {
            get {
                return this.DateAvailableField;
            }
            set {
                if ((object.ReferenceEquals(this.DateAvailableField, value) != true)) {
                    this.DateAvailableField = value;
                    this.RaisePropertyChanged("DateAvailable");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int Price {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AgencyInfo", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class AgencyInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HotelRenaviereServiceRef1.HotelWebService1Soap")]
    public interface HotelWebService1Soap {
        
        // CODEGEN: Generating message contract since element name getHotelResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getHotel", ReplyAction="*")]
        ClientApplicationConsole.HotelRenaviereServiceRef1.getHotelResponse getHotel(ClientApplicationConsole.HotelRenaviereServiceRef1.getHotelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getHotel", ReplyAction="*")]
        System.Threading.Tasks.Task<ClientApplicationConsole.HotelRenaviereServiceRef1.getHotelResponse> getHotelAsync(ClientApplicationConsole.HotelRenaviereServiceRef1.getHotelRequest request);
        
        // CODEGEN: Generating message contract since element name _userName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getAgencyLogin", ReplyAction="*")]
        ClientApplicationConsole.HotelRenaviereServiceRef1.getAgencyLoginResponse getAgencyLogin(ClientApplicationConsole.HotelRenaviereServiceRef1.getAgencyLoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getAgencyLogin", ReplyAction="*")]
        System.Threading.Tasks.Task<ClientApplicationConsole.HotelRenaviereServiceRef1.getAgencyLoginResponse> getAgencyLoginAsync(ClientApplicationConsole.HotelRenaviereServiceRef1.getAgencyLoginRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getHotelRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getHotel", Namespace="http://tempuri.org/", Order=0)]
        public ClientApplicationConsole.HotelRenaviereServiceRef1.getHotelRequestBody Body;
        
        public getHotelRequest() {
        }
        
        public getHotelRequest(ClientApplicationConsole.HotelRenaviereServiceRef1.getHotelRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class getHotelRequestBody {
        
        public getHotelRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getHotelResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getHotelResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClientApplicationConsole.HotelRenaviereServiceRef1.getHotelResponseBody Body;
        
        public getHotelResponse() {
        }
        
        public getHotelResponse(ClientApplicationConsole.HotelRenaviereServiceRef1.getHotelResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getHotelResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ClientApplicationConsole.HotelRenaviereServiceRef1.Hotel getHotelResult;
        
        public getHotelResponseBody() {
        }
        
        public getHotelResponseBody(ClientApplicationConsole.HotelRenaviereServiceRef1.Hotel getHotelResult) {
            this.getHotelResult = getHotelResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getAgencyLoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getAgencyLogin", Namespace="http://tempuri.org/", Order=0)]
        public ClientApplicationConsole.HotelRenaviereServiceRef1.getAgencyLoginRequestBody Body;
        
        public getAgencyLoginRequest() {
        }
        
        public getAgencyLoginRequest(ClientApplicationConsole.HotelRenaviereServiceRef1.getAgencyLoginRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getAgencyLoginRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _userName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string _startReservationDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string _endReservationDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int _numberOfPersonToHost;
        
        public getAgencyLoginRequestBody() {
        }
        
        public getAgencyLoginRequestBody(string _userName, string _password, string _startReservationDate, string _endReservationDate, int _numberOfPersonToHost) {
            this._userName = _userName;
            this._password = _password;
            this._startReservationDate = _startReservationDate;
            this._endReservationDate = _endReservationDate;
            this._numberOfPersonToHost = _numberOfPersonToHost;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getAgencyLoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getAgencyLoginResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClientApplicationConsole.HotelRenaviereServiceRef1.getAgencyLoginResponseBody Body;
        
        public getAgencyLoginResponse() {
        }
        
        public getAgencyLoginResponse(ClientApplicationConsole.HotelRenaviereServiceRef1.getAgencyLoginResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getAgencyLoginResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ClientApplicationConsole.HotelRenaviereServiceRef1.Offer[] getAgencyLoginResult;
        
        public getAgencyLoginResponseBody() {
        }
        
        public getAgencyLoginResponseBody(ClientApplicationConsole.HotelRenaviereServiceRef1.Offer[] getAgencyLoginResult) {
            this.getAgencyLoginResult = getAgencyLoginResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HotelWebService1SoapChannel : ClientApplicationConsole.HotelRenaviereServiceRef1.HotelWebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HotelWebService1SoapClient : System.ServiceModel.ClientBase<ClientApplicationConsole.HotelRenaviereServiceRef1.HotelWebService1Soap>, ClientApplicationConsole.HotelRenaviereServiceRef1.HotelWebService1Soap {
        
        public HotelWebService1SoapClient() {
        }
        
        public HotelWebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HotelWebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelWebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelWebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientApplicationConsole.HotelRenaviereServiceRef1.getHotelResponse ClientApplicationConsole.HotelRenaviereServiceRef1.HotelWebService1Soap.getHotel(ClientApplicationConsole.HotelRenaviereServiceRef1.getHotelRequest request) {
            return base.Channel.getHotel(request);
        }
        
        public ClientApplicationConsole.HotelRenaviereServiceRef1.Hotel getHotel() {
            ClientApplicationConsole.HotelRenaviereServiceRef1.getHotelRequest inValue = new ClientApplicationConsole.HotelRenaviereServiceRef1.getHotelRequest();
            inValue.Body = new ClientApplicationConsole.HotelRenaviereServiceRef1.getHotelRequestBody();
            ClientApplicationConsole.HotelRenaviereServiceRef1.getHotelResponse retVal = ((ClientApplicationConsole.HotelRenaviereServiceRef1.HotelWebService1Soap)(this)).getHotel(inValue);
            return retVal.Body.getHotelResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientApplicationConsole.HotelRenaviereServiceRef1.getHotelResponse> ClientApplicationConsole.HotelRenaviereServiceRef1.HotelWebService1Soap.getHotelAsync(ClientApplicationConsole.HotelRenaviereServiceRef1.getHotelRequest request) {
            return base.Channel.getHotelAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientApplicationConsole.HotelRenaviereServiceRef1.getHotelResponse> getHotelAsync() {
            ClientApplicationConsole.HotelRenaviereServiceRef1.getHotelRequest inValue = new ClientApplicationConsole.HotelRenaviereServiceRef1.getHotelRequest();
            inValue.Body = new ClientApplicationConsole.HotelRenaviereServiceRef1.getHotelRequestBody();
            return ((ClientApplicationConsole.HotelRenaviereServiceRef1.HotelWebService1Soap)(this)).getHotelAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientApplicationConsole.HotelRenaviereServiceRef1.getAgencyLoginResponse ClientApplicationConsole.HotelRenaviereServiceRef1.HotelWebService1Soap.getAgencyLogin(ClientApplicationConsole.HotelRenaviereServiceRef1.getAgencyLoginRequest request) {
            return base.Channel.getAgencyLogin(request);
        }
        
        public ClientApplicationConsole.HotelRenaviereServiceRef1.Offer[] getAgencyLogin(string _userName, string _password, string _startReservationDate, string _endReservationDate, int _numberOfPersonToHost) {
            ClientApplicationConsole.HotelRenaviereServiceRef1.getAgencyLoginRequest inValue = new ClientApplicationConsole.HotelRenaviereServiceRef1.getAgencyLoginRequest();
            inValue.Body = new ClientApplicationConsole.HotelRenaviereServiceRef1.getAgencyLoginRequestBody();
            inValue.Body._userName = _userName;
            inValue.Body._password = _password;
            inValue.Body._startReservationDate = _startReservationDate;
            inValue.Body._endReservationDate = _endReservationDate;
            inValue.Body._numberOfPersonToHost = _numberOfPersonToHost;
            ClientApplicationConsole.HotelRenaviereServiceRef1.getAgencyLoginResponse retVal = ((ClientApplicationConsole.HotelRenaviereServiceRef1.HotelWebService1Soap)(this)).getAgencyLogin(inValue);
            return retVal.Body.getAgencyLoginResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientApplicationConsole.HotelRenaviereServiceRef1.getAgencyLoginResponse> ClientApplicationConsole.HotelRenaviereServiceRef1.HotelWebService1Soap.getAgencyLoginAsync(ClientApplicationConsole.HotelRenaviereServiceRef1.getAgencyLoginRequest request) {
            return base.Channel.getAgencyLoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientApplicationConsole.HotelRenaviereServiceRef1.getAgencyLoginResponse> getAgencyLoginAsync(string _userName, string _password, string _startReservationDate, string _endReservationDate, int _numberOfPersonToHost) {
            ClientApplicationConsole.HotelRenaviereServiceRef1.getAgencyLoginRequest inValue = new ClientApplicationConsole.HotelRenaviereServiceRef1.getAgencyLoginRequest();
            inValue.Body = new ClientApplicationConsole.HotelRenaviereServiceRef1.getAgencyLoginRequestBody();
            inValue.Body._userName = _userName;
            inValue.Body._password = _password;
            inValue.Body._startReservationDate = _startReservationDate;
            inValue.Body._endReservationDate = _endReservationDate;
            inValue.Body._numberOfPersonToHost = _numberOfPersonToHost;
            return ((ClientApplicationConsole.HotelRenaviereServiceRef1.HotelWebService1Soap)(this)).getAgencyLoginAsync(inValue);
        }
    }
}
