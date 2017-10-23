﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalBoxConsumer_Client.BoxCalServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BoxCalServiceReference.IBoxCalService")]
    public interface IBoxCalService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBoxCalService/GetVolume", ReplyAction="http://tempuri.org/IBoxCalService/GetVolumeResponse")]
        double GetVolume(double length, double width, double height);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBoxCalService/GetVolume", ReplyAction="http://tempuri.org/IBoxCalService/GetVolumeResponse")]
        System.Threading.Tasks.Task<double> GetVolumeAsync(double length, double width, double height);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBoxCalService/GetSide", ReplyAction="http://tempuri.org/IBoxCalService/GetSideResponse")]
        double GetSide(double volume, double side1, double side2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBoxCalService/GetSide", ReplyAction="http://tempuri.org/IBoxCalService/GetSideResponse")]
        System.Threading.Tasks.Task<double> GetSideAsync(double volume, double side1, double side2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBoxCalServiceChannel : CalBoxConsumer_Client.BoxCalServiceReference.IBoxCalService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BoxCalServiceClient : System.ServiceModel.ClientBase<CalBoxConsumer_Client.BoxCalServiceReference.IBoxCalService>, CalBoxConsumer_Client.BoxCalServiceReference.IBoxCalService {
        
        public BoxCalServiceClient() {
        }
        
        public BoxCalServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BoxCalServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BoxCalServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BoxCalServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double GetVolume(double length, double width, double height) {
            return base.Channel.GetVolume(length, width, height);
        }
        
        public System.Threading.Tasks.Task<double> GetVolumeAsync(double length, double width, double height) {
            return base.Channel.GetVolumeAsync(length, width, height);
        }
        
        public double GetSide(double volume, double side1, double side2) {
            return base.Channel.GetSide(volume, side1, side2);
        }
        
        public System.Threading.Tasks.Task<double> GetSideAsync(double volume, double side1, double side2) {
            return base.Channel.GetSideAsync(volume, side1, side2);
        }
    }
}