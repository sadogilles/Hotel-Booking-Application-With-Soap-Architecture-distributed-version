﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApplicationConsole.AgencyMossonServiceRef {
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
        private ClientApplicationConsole.AgencyMossonServiceRef.Room[] RoomsField;
        
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
        public ClientApplicationConsole.AgencyMossonServiceRef.Room[] Rooms {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AgencyMossonServiceRef.AgencyWebServiceSoap")]
    public interface AgencyWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name getHotelResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getHotel", ReplyAction="*")]
        ClientApplicationConsole.AgencyMossonServiceRef.getHotelResponse getHotel(ClientApplicationConsole.AgencyMossonServiceRef.getHotelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getHotel", ReplyAction="*")]
        System.Threading.Tasks.Task<ClientApplicationConsole.AgencyMossonServiceRef.getHotelResponse> getHotelAsync(ClientApplicationConsole.AgencyMossonServiceRef.getHotelRequest request);
        
        // CODEGEN: Generating message contract since element name _firstName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getBookingInformaton", ReplyAction="*")]
        ClientApplicationConsole.AgencyMossonServiceRef.getBookingInformatonResponse getBookingInformaton(ClientApplicationConsole.AgencyMossonServiceRef.getBookingInformatonRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getBookingInformaton", ReplyAction="*")]
        System.Threading.Tasks.Task<ClientApplicationConsole.AgencyMossonServiceRef.getBookingInformatonResponse> getBookingInformatonAsync(ClientApplicationConsole.AgencyMossonServiceRef.getBookingInformatonRequest request);
        
        // CODEGEN: Generating message contract since element name _hotelName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getRoomFromHotel", ReplyAction="*")]
        ClientApplicationConsole.AgencyMossonServiceRef.getRoomFromHotelResponse getRoomFromHotel(ClientApplicationConsole.AgencyMossonServiceRef.getRoomFromHotelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getRoomFromHotel", ReplyAction="*")]
        System.Threading.Tasks.Task<ClientApplicationConsole.AgencyMossonServiceRef.getRoomFromHotelResponse> getRoomFromHotelAsync(ClientApplicationConsole.AgencyMossonServiceRef.getRoomFromHotelRequest request);
        
        // CODEGEN: Generating message contract since element name _town from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/searchhotel", ReplyAction="*")]
        ClientApplicationConsole.AgencyMossonServiceRef.searchhotelResponse searchhotel(ClientApplicationConsole.AgencyMossonServiceRef.searchhotelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/searchhotel", ReplyAction="*")]
        System.Threading.Tasks.Task<ClientApplicationConsole.AgencyMossonServiceRef.searchhotelResponse> searchhotelAsync(ClientApplicationConsole.AgencyMossonServiceRef.searchhotelRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getHotelRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getHotel", Namespace="http://tempuri.org/", Order=0)]
        public ClientApplicationConsole.AgencyMossonServiceRef.getHotelRequestBody Body;
        
        public getHotelRequest() {
        }
        
        public getHotelRequest(ClientApplicationConsole.AgencyMossonServiceRef.getHotelRequestBody Body) {
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
        public ClientApplicationConsole.AgencyMossonServiceRef.getHotelResponseBody Body;
        
        public getHotelResponse() {
        }
        
        public getHotelResponse(ClientApplicationConsole.AgencyMossonServiceRef.getHotelResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getHotelResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ClientApplicationConsole.AgencyMossonServiceRef.Hotel[] getHotelResult;
        
        public getHotelResponseBody() {
        }
        
        public getHotelResponseBody(ClientApplicationConsole.AgencyMossonServiceRef.Hotel[] getHotelResult) {
            this.getHotelResult = getHotelResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getBookingInformatonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getBookingInformaton", Namespace="http://tempuri.org/", Order=0)]
        public ClientApplicationConsole.AgencyMossonServiceRef.getBookingInformatonRequestBody Body;
        
        public getBookingInformatonRequest() {
        }
        
        public getBookingInformatonRequest(ClientApplicationConsole.AgencyMossonServiceRef.getBookingInformatonRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getBookingInformatonRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int _hotel_id;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int _room_id;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int client_id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string _firstName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string _lastName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string _cardInfo;
        
        public getBookingInformatonRequestBody() {
        }
        
        public getBookingInformatonRequestBody(int _hotel_id, int _room_id, int client_id, string _firstName, string _lastName, string _cardInfo) {
            this._hotel_id = _hotel_id;
            this._room_id = _room_id;
            this.client_id = client_id;
            this._firstName = _firstName;
            this._lastName = _lastName;
            this._cardInfo = _cardInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getBookingInformatonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getBookingInformatonResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClientApplicationConsole.AgencyMossonServiceRef.getBookingInformatonResponseBody Body;
        
        public getBookingInformatonResponse() {
        }
        
        public getBookingInformatonResponse(ClientApplicationConsole.AgencyMossonServiceRef.getBookingInformatonResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getBookingInformatonResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getBookingInformatonResult;
        
        public getBookingInformatonResponseBody() {
        }
        
        public getBookingInformatonResponseBody(string getBookingInformatonResult) {
            this.getBookingInformatonResult = getBookingInformatonResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getRoomFromHotelRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getRoomFromHotel", Namespace="http://tempuri.org/", Order=0)]
        public ClientApplicationConsole.AgencyMossonServiceRef.getRoomFromHotelRequestBody Body;
        
        public getRoomFromHotelRequest() {
        }
        
        public getRoomFromHotelRequest(ClientApplicationConsole.AgencyMossonServiceRef.getRoomFromHotelRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getRoomFromHotelRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _hotelName;
        
        public getRoomFromHotelRequestBody() {
        }
        
        public getRoomFromHotelRequestBody(string _hotelName) {
            this._hotelName = _hotelName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getRoomFromHotelResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getRoomFromHotelResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClientApplicationConsole.AgencyMossonServiceRef.getRoomFromHotelResponseBody Body;
        
        public getRoomFromHotelResponse() {
        }
        
        public getRoomFromHotelResponse(ClientApplicationConsole.AgencyMossonServiceRef.getRoomFromHotelResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getRoomFromHotelResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ClientApplicationConsole.AgencyMossonServiceRef.Room[] getRoomFromHotelResult;
        
        public getRoomFromHotelResponseBody() {
        }
        
        public getRoomFromHotelResponseBody(ClientApplicationConsole.AgencyMossonServiceRef.Room[] getRoomFromHotelResult) {
            this.getRoomFromHotelResult = getRoomFromHotelResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class searchhotelRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="searchhotel", Namespace="http://tempuri.org/", Order=0)]
        public ClientApplicationConsole.AgencyMossonServiceRef.searchhotelRequestBody Body;
        
        public searchhotelRequest() {
        }
        
        public searchhotelRequest(ClientApplicationConsole.AgencyMossonServiceRef.searchhotelRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class searchhotelRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _town;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int _minPrice;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int _maxPrice;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int _numberofStars;
        
        public searchhotelRequestBody() {
        }
        
        public searchhotelRequestBody(string _town, int _minPrice, int _maxPrice, int _numberofStars) {
            this._town = _town;
            this._minPrice = _minPrice;
            this._maxPrice = _maxPrice;
            this._numberofStars = _numberofStars;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class searchhotelResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="searchhotelResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClientApplicationConsole.AgencyMossonServiceRef.searchhotelResponseBody Body;
        
        public searchhotelResponse() {
        }
        
        public searchhotelResponse(ClientApplicationConsole.AgencyMossonServiceRef.searchhotelResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class searchhotelResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ClientApplicationConsole.AgencyMossonServiceRef.Hotel[] searchhotelResult;
        
        public searchhotelResponseBody() {
        }
        
        public searchhotelResponseBody(ClientApplicationConsole.AgencyMossonServiceRef.Hotel[] searchhotelResult) {
            this.searchhotelResult = searchhotelResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AgencyWebServiceSoapChannel : ClientApplicationConsole.AgencyMossonServiceRef.AgencyWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AgencyWebServiceSoapClient : System.ServiceModel.ClientBase<ClientApplicationConsole.AgencyMossonServiceRef.AgencyWebServiceSoap>, ClientApplicationConsole.AgencyMossonServiceRef.AgencyWebServiceSoap {
        
        public AgencyWebServiceSoapClient() {
        }
        
        public AgencyWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AgencyWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AgencyWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AgencyWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientApplicationConsole.AgencyMossonServiceRef.getHotelResponse ClientApplicationConsole.AgencyMossonServiceRef.AgencyWebServiceSoap.getHotel(ClientApplicationConsole.AgencyMossonServiceRef.getHotelRequest request) {
            return base.Channel.getHotel(request);
        }
        
        public ClientApplicationConsole.AgencyMossonServiceRef.Hotel[] getHotel() {
            ClientApplicationConsole.AgencyMossonServiceRef.getHotelRequest inValue = new ClientApplicationConsole.AgencyMossonServiceRef.getHotelRequest();
            inValue.Body = new ClientApplicationConsole.AgencyMossonServiceRef.getHotelRequestBody();
            ClientApplicationConsole.AgencyMossonServiceRef.getHotelResponse retVal = ((ClientApplicationConsole.AgencyMossonServiceRef.AgencyWebServiceSoap)(this)).getHotel(inValue);
            return retVal.Body.getHotelResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientApplicationConsole.AgencyMossonServiceRef.getHotelResponse> ClientApplicationConsole.AgencyMossonServiceRef.AgencyWebServiceSoap.getHotelAsync(ClientApplicationConsole.AgencyMossonServiceRef.getHotelRequest request) {
            return base.Channel.getHotelAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientApplicationConsole.AgencyMossonServiceRef.getHotelResponse> getHotelAsync() {
            ClientApplicationConsole.AgencyMossonServiceRef.getHotelRequest inValue = new ClientApplicationConsole.AgencyMossonServiceRef.getHotelRequest();
            inValue.Body = new ClientApplicationConsole.AgencyMossonServiceRef.getHotelRequestBody();
            return ((ClientApplicationConsole.AgencyMossonServiceRef.AgencyWebServiceSoap)(this)).getHotelAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientApplicationConsole.AgencyMossonServiceRef.getBookingInformatonResponse ClientApplicationConsole.AgencyMossonServiceRef.AgencyWebServiceSoap.getBookingInformaton(ClientApplicationConsole.AgencyMossonServiceRef.getBookingInformatonRequest request) {
            return base.Channel.getBookingInformaton(request);
        }
        
        public string getBookingInformaton(int _hotel_id, int _room_id, int client_id, string _firstName, string _lastName, string _cardInfo) {
            ClientApplicationConsole.AgencyMossonServiceRef.getBookingInformatonRequest inValue = new ClientApplicationConsole.AgencyMossonServiceRef.getBookingInformatonRequest();
            inValue.Body = new ClientApplicationConsole.AgencyMossonServiceRef.getBookingInformatonRequestBody();
            inValue.Body._hotel_id = _hotel_id;
            inValue.Body._room_id = _room_id;
            inValue.Body.client_id = client_id;
            inValue.Body._firstName = _firstName;
            inValue.Body._lastName = _lastName;
            inValue.Body._cardInfo = _cardInfo;
            ClientApplicationConsole.AgencyMossonServiceRef.getBookingInformatonResponse retVal = ((ClientApplicationConsole.AgencyMossonServiceRef.AgencyWebServiceSoap)(this)).getBookingInformaton(inValue);
            return retVal.Body.getBookingInformatonResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientApplicationConsole.AgencyMossonServiceRef.getBookingInformatonResponse> ClientApplicationConsole.AgencyMossonServiceRef.AgencyWebServiceSoap.getBookingInformatonAsync(ClientApplicationConsole.AgencyMossonServiceRef.getBookingInformatonRequest request) {
            return base.Channel.getBookingInformatonAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientApplicationConsole.AgencyMossonServiceRef.getBookingInformatonResponse> getBookingInformatonAsync(int _hotel_id, int _room_id, int client_id, string _firstName, string _lastName, string _cardInfo) {
            ClientApplicationConsole.AgencyMossonServiceRef.getBookingInformatonRequest inValue = new ClientApplicationConsole.AgencyMossonServiceRef.getBookingInformatonRequest();
            inValue.Body = new ClientApplicationConsole.AgencyMossonServiceRef.getBookingInformatonRequestBody();
            inValue.Body._hotel_id = _hotel_id;
            inValue.Body._room_id = _room_id;
            inValue.Body.client_id = client_id;
            inValue.Body._firstName = _firstName;
            inValue.Body._lastName = _lastName;
            inValue.Body._cardInfo = _cardInfo;
            return ((ClientApplicationConsole.AgencyMossonServiceRef.AgencyWebServiceSoap)(this)).getBookingInformatonAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientApplicationConsole.AgencyMossonServiceRef.getRoomFromHotelResponse ClientApplicationConsole.AgencyMossonServiceRef.AgencyWebServiceSoap.getRoomFromHotel(ClientApplicationConsole.AgencyMossonServiceRef.getRoomFromHotelRequest request) {
            return base.Channel.getRoomFromHotel(request);
        }
        
        public ClientApplicationConsole.AgencyMossonServiceRef.Room[] getRoomFromHotel(string _hotelName) {
            ClientApplicationConsole.AgencyMossonServiceRef.getRoomFromHotelRequest inValue = new ClientApplicationConsole.AgencyMossonServiceRef.getRoomFromHotelRequest();
            inValue.Body = new ClientApplicationConsole.AgencyMossonServiceRef.getRoomFromHotelRequestBody();
            inValue.Body._hotelName = _hotelName;
            ClientApplicationConsole.AgencyMossonServiceRef.getRoomFromHotelResponse retVal = ((ClientApplicationConsole.AgencyMossonServiceRef.AgencyWebServiceSoap)(this)).getRoomFromHotel(inValue);
            return retVal.Body.getRoomFromHotelResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientApplicationConsole.AgencyMossonServiceRef.getRoomFromHotelResponse> ClientApplicationConsole.AgencyMossonServiceRef.AgencyWebServiceSoap.getRoomFromHotelAsync(ClientApplicationConsole.AgencyMossonServiceRef.getRoomFromHotelRequest request) {
            return base.Channel.getRoomFromHotelAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientApplicationConsole.AgencyMossonServiceRef.getRoomFromHotelResponse> getRoomFromHotelAsync(string _hotelName) {
            ClientApplicationConsole.AgencyMossonServiceRef.getRoomFromHotelRequest inValue = new ClientApplicationConsole.AgencyMossonServiceRef.getRoomFromHotelRequest();
            inValue.Body = new ClientApplicationConsole.AgencyMossonServiceRef.getRoomFromHotelRequestBody();
            inValue.Body._hotelName = _hotelName;
            return ((ClientApplicationConsole.AgencyMossonServiceRef.AgencyWebServiceSoap)(this)).getRoomFromHotelAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientApplicationConsole.AgencyMossonServiceRef.searchhotelResponse ClientApplicationConsole.AgencyMossonServiceRef.AgencyWebServiceSoap.searchhotel(ClientApplicationConsole.AgencyMossonServiceRef.searchhotelRequest request) {
            return base.Channel.searchhotel(request);
        }
        
        public ClientApplicationConsole.AgencyMossonServiceRef.Hotel[] searchhotel(string _town, int _minPrice, int _maxPrice, int _numberofStars) {
            ClientApplicationConsole.AgencyMossonServiceRef.searchhotelRequest inValue = new ClientApplicationConsole.AgencyMossonServiceRef.searchhotelRequest();
            inValue.Body = new ClientApplicationConsole.AgencyMossonServiceRef.searchhotelRequestBody();
            inValue.Body._town = _town;
            inValue.Body._minPrice = _minPrice;
            inValue.Body._maxPrice = _maxPrice;
            inValue.Body._numberofStars = _numberofStars;
            ClientApplicationConsole.AgencyMossonServiceRef.searchhotelResponse retVal = ((ClientApplicationConsole.AgencyMossonServiceRef.AgencyWebServiceSoap)(this)).searchhotel(inValue);
            return retVal.Body.searchhotelResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientApplicationConsole.AgencyMossonServiceRef.searchhotelResponse> ClientApplicationConsole.AgencyMossonServiceRef.AgencyWebServiceSoap.searchhotelAsync(ClientApplicationConsole.AgencyMossonServiceRef.searchhotelRequest request) {
            return base.Channel.searchhotelAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientApplicationConsole.AgencyMossonServiceRef.searchhotelResponse> searchhotelAsync(string _town, int _minPrice, int _maxPrice, int _numberofStars) {
            ClientApplicationConsole.AgencyMossonServiceRef.searchhotelRequest inValue = new ClientApplicationConsole.AgencyMossonServiceRef.searchhotelRequest();
            inValue.Body = new ClientApplicationConsole.AgencyMossonServiceRef.searchhotelRequestBody();
            inValue.Body._town = _town;
            inValue.Body._minPrice = _minPrice;
            inValue.Body._maxPrice = _maxPrice;
            inValue.Body._numberofStars = _numberofStars;
            return ((ClientApplicationConsole.AgencyMossonServiceRef.AgencyWebServiceSoap)(this)).searchhotelAsync(inValue);
        }
    }
}
