﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NTP_Ivo_Ojvan.Calculator {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfDouble", Namespace="http://tempuri.org/", ItemName="double")]
    [System.SerializableAttribute()]
    public class ArrayOfDouble : System.Collections.Generic.List<double> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Calculator.CalculatorSoap")]
    public interface CalculatorSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        NTP_Ivo_Ojvan.Calculator.HelloWorldResponse HelloWorld(NTP_Ivo_Ojvan.Calculator.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<NTP_Ivo_Ojvan.Calculator.HelloWorldResponse> HelloWorldAsync(NTP_Ivo_Ojvan.Calculator.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name numbers from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sum", ReplyAction="*")]
        NTP_Ivo_Ojvan.Calculator.SumResponse Sum(NTP_Ivo_Ojvan.Calculator.SumRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sum", ReplyAction="*")]
        System.Threading.Tasks.Task<NTP_Ivo_Ojvan.Calculator.SumResponse> SumAsync(NTP_Ivo_Ojvan.Calculator.SumRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public NTP_Ivo_Ojvan.Calculator.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(NTP_Ivo_Ojvan.Calculator.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public NTP_Ivo_Ojvan.Calculator.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(NTP_Ivo_Ojvan.Calculator.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SumRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Sum", Namespace="http://tempuri.org/", Order=0)]
        public NTP_Ivo_Ojvan.Calculator.SumRequestBody Body;
        
        public SumRequest() {
        }
        
        public SumRequest(NTP_Ivo_Ojvan.Calculator.SumRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SumRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public NTP_Ivo_Ojvan.Calculator.ArrayOfDouble numbers;
        
        public SumRequestBody() {
        }
        
        public SumRequestBody(NTP_Ivo_Ojvan.Calculator.ArrayOfDouble numbers) {
            this.numbers = numbers;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SumResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SumResponse", Namespace="http://tempuri.org/", Order=0)]
        public NTP_Ivo_Ojvan.Calculator.SumResponseBody Body;
        
        public SumResponse() {
        }
        
        public SumResponse(NTP_Ivo_Ojvan.Calculator.SumResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SumResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double SumResult;
        
        public SumResponseBody() {
        }
        
        public SumResponseBody(double SumResult) {
            this.SumResult = SumResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculatorSoapChannel : NTP_Ivo_Ojvan.Calculator.CalculatorSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorSoapClient : System.ServiceModel.ClientBase<NTP_Ivo_Ojvan.Calculator.CalculatorSoap>, NTP_Ivo_Ojvan.Calculator.CalculatorSoap {
        
        public CalculatorSoapClient() {
        }
        
        public CalculatorSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NTP_Ivo_Ojvan.Calculator.HelloWorldResponse NTP_Ivo_Ojvan.Calculator.CalculatorSoap.HelloWorld(NTP_Ivo_Ojvan.Calculator.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            NTP_Ivo_Ojvan.Calculator.HelloWorldRequest inValue = new NTP_Ivo_Ojvan.Calculator.HelloWorldRequest();
            inValue.Body = new NTP_Ivo_Ojvan.Calculator.HelloWorldRequestBody();
            NTP_Ivo_Ojvan.Calculator.HelloWorldResponse retVal = ((NTP_Ivo_Ojvan.Calculator.CalculatorSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NTP_Ivo_Ojvan.Calculator.HelloWorldResponse> NTP_Ivo_Ojvan.Calculator.CalculatorSoap.HelloWorldAsync(NTP_Ivo_Ojvan.Calculator.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<NTP_Ivo_Ojvan.Calculator.HelloWorldResponse> HelloWorldAsync() {
            NTP_Ivo_Ojvan.Calculator.HelloWorldRequest inValue = new NTP_Ivo_Ojvan.Calculator.HelloWorldRequest();
            inValue.Body = new NTP_Ivo_Ojvan.Calculator.HelloWorldRequestBody();
            return ((NTP_Ivo_Ojvan.Calculator.CalculatorSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NTP_Ivo_Ojvan.Calculator.SumResponse NTP_Ivo_Ojvan.Calculator.CalculatorSoap.Sum(NTP_Ivo_Ojvan.Calculator.SumRequest request) {
            return base.Channel.Sum(request);
        }
        
        public double Sum(NTP_Ivo_Ojvan.Calculator.ArrayOfDouble numbers) {
            NTP_Ivo_Ojvan.Calculator.SumRequest inValue = new NTP_Ivo_Ojvan.Calculator.SumRequest();
            inValue.Body = new NTP_Ivo_Ojvan.Calculator.SumRequestBody();
            inValue.Body.numbers = numbers;
            NTP_Ivo_Ojvan.Calculator.SumResponse retVal = ((NTP_Ivo_Ojvan.Calculator.CalculatorSoap)(this)).Sum(inValue);
            return retVal.Body.SumResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NTP_Ivo_Ojvan.Calculator.SumResponse> NTP_Ivo_Ojvan.Calculator.CalculatorSoap.SumAsync(NTP_Ivo_Ojvan.Calculator.SumRequest request) {
            return base.Channel.SumAsync(request);
        }
        
        public System.Threading.Tasks.Task<NTP_Ivo_Ojvan.Calculator.SumResponse> SumAsync(NTP_Ivo_Ojvan.Calculator.ArrayOfDouble numbers) {
            NTP_Ivo_Ojvan.Calculator.SumRequest inValue = new NTP_Ivo_Ojvan.Calculator.SumRequest();
            inValue.Body = new NTP_Ivo_Ojvan.Calculator.SumRequestBody();
            inValue.Body.numbers = numbers;
            return ((NTP_Ivo_Ojvan.Calculator.CalculatorSoap)(this)).SumAsync(inValue);
        }
    }
}
