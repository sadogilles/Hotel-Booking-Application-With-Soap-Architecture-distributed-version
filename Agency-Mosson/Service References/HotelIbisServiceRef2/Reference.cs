﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Agency_Mosson.HotelIbisServiceRef2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HotelIbisServiceRef2.HotelWebService2Soap")]
    public interface HotelWebService2Soap {
        
        // CODEGEN: Generating message contract since element name _userName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/doBooking", ReplyAction="*")]
        Agency_Mosson.HotelIbisServiceRef2.doBookingResponse doBooking(Agency_Mosson.HotelIbisServiceRef2.doBookingRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/doBooking", ReplyAction="*")]
        System.Threading.Tasks.Task<Agency_Mosson.HotelIbisServiceRef2.doBookingResponse> doBookingAsync(Agency_Mosson.HotelIbisServiceRef2.doBookingRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class doBookingRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="doBooking", Namespace="http://tempuri.org/", Order=0)]
        public Agency_Mosson.HotelIbisServiceRef2.doBookingRequestBody Body;
        
        public doBookingRequest() {
        }
        
        public doBookingRequest(Agency_Mosson.HotelIbisServiceRef2.doBookingRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class doBookingRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _userName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _password;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int _offer_id;
        
        public doBookingRequestBody() {
        }
        
        public doBookingRequestBody(string _userName, string _password, int _offer_id) {
            this._userName = _userName;
            this._password = _password;
            this._offer_id = _offer_id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class doBookingResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="doBookingResponse", Namespace="http://tempuri.org/", Order=0)]
        public Agency_Mosson.HotelIbisServiceRef2.doBookingResponseBody Body;
        
        public doBookingResponse() {
        }
        
        public doBookingResponse(Agency_Mosson.HotelIbisServiceRef2.doBookingResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class doBookingResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string doBookingResult;
        
        public doBookingResponseBody() {
        }
        
        public doBookingResponseBody(string doBookingResult) {
            this.doBookingResult = doBookingResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HotelWebService2SoapChannel : Agency_Mosson.HotelIbisServiceRef2.HotelWebService2Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HotelWebService2SoapClient : System.ServiceModel.ClientBase<Agency_Mosson.HotelIbisServiceRef2.HotelWebService2Soap>, Agency_Mosson.HotelIbisServiceRef2.HotelWebService2Soap {
        
        public HotelWebService2SoapClient() {
        }
        
        public HotelWebService2SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HotelWebService2SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelWebService2SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelWebService2SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Agency_Mosson.HotelIbisServiceRef2.doBookingResponse Agency_Mosson.HotelIbisServiceRef2.HotelWebService2Soap.doBooking(Agency_Mosson.HotelIbisServiceRef2.doBookingRequest request) {
            return base.Channel.doBooking(request);
        }
        
        public string doBooking(string _userName, string _password, int _offer_id) {
            Agency_Mosson.HotelIbisServiceRef2.doBookingRequest inValue = new Agency_Mosson.HotelIbisServiceRef2.doBookingRequest();
            inValue.Body = new Agency_Mosson.HotelIbisServiceRef2.doBookingRequestBody();
            inValue.Body._userName = _userName;
            inValue.Body._password = _password;
            inValue.Body._offer_id = _offer_id;
            Agency_Mosson.HotelIbisServiceRef2.doBookingResponse retVal = ((Agency_Mosson.HotelIbisServiceRef2.HotelWebService2Soap)(this)).doBooking(inValue);
            return retVal.Body.doBookingResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Agency_Mosson.HotelIbisServiceRef2.doBookingResponse> Agency_Mosson.HotelIbisServiceRef2.HotelWebService2Soap.doBookingAsync(Agency_Mosson.HotelIbisServiceRef2.doBookingRequest request) {
            return base.Channel.doBookingAsync(request);
        }
        
        public System.Threading.Tasks.Task<Agency_Mosson.HotelIbisServiceRef2.doBookingResponse> doBookingAsync(string _userName, string _password, int _offer_id) {
            Agency_Mosson.HotelIbisServiceRef2.doBookingRequest inValue = new Agency_Mosson.HotelIbisServiceRef2.doBookingRequest();
            inValue.Body = new Agency_Mosson.HotelIbisServiceRef2.doBookingRequestBody();
            inValue.Body._userName = _userName;
            inValue.Body._password = _password;
            inValue.Body._offer_id = _offer_id;
            return ((Agency_Mosson.HotelIbisServiceRef2.HotelWebService2Soap)(this)).doBookingAsync(inValue);
        }
    }
}
