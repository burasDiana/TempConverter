﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceConsumer.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCelsius", ReplyAction="http://tempuri.org/IService1/GetCelsiusResponse")]
        double GetCelsius(int tempF);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCelsius", ReplyAction="http://tempuri.org/IService1/GetCelsiusResponse")]
        System.Threading.Tasks.Task<double> GetCelsiusAsync(int tempF);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFarenheit", ReplyAction="http://tempuri.org/IService1/GetFarenheitResponse")]
        double GetFarenheit(int tempC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFarenheit", ReplyAction="http://tempuri.org/IService1/GetFarenheitResponse")]
        System.Threading.Tasks.Task<double> GetFarenheitAsync(int tempC);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ServiceConsumer.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiceConsumer.ServiceReference1.IService1>, ServiceConsumer.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double GetCelsius(int tempF) {
            return base.Channel.GetCelsius(tempF);
        }
        
        public System.Threading.Tasks.Task<double> GetCelsiusAsync(int tempF) {
            return base.Channel.GetCelsiusAsync(tempF);
        }
        
        public double GetFarenheit(int tempC) {
            return base.Channel.GetFarenheit(tempC);
        }
        
        public System.Threading.Tasks.Task<double> GetFarenheitAsync(int tempC) {
            return base.Channel.GetFarenheitAsync(tempC);
        }
    }
}
