﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IGoogle_Voice")]
    public interface IGoogle_Voice {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogle_Voice/DoWork", ReplyAction="http://tempuri.org/IGoogle_Voice/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogle_Voice/Welcome", ReplyAction="http://tempuri.org/IGoogle_Voice/WelcomeResponse")]
        string Welcome(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogle_Voice/Call_Google", ReplyAction="http://tempuri.org/IGoogle_Voice/Call_GoogleResponse")]
        string[] Call_Google(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGoogle_VoiceChannel : WebApplication2.ServiceReference1.IGoogle_Voice, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Google_VoiceClient : System.ServiceModel.ClientBase<WebApplication2.ServiceReference1.IGoogle_Voice>, WebApplication2.ServiceReference1.IGoogle_Voice {
        
        public Google_VoiceClient() {
        }
        
        public Google_VoiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Google_VoiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Google_VoiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Google_VoiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public string Welcome(string name) {
            return base.Channel.Welcome(name);
        }
        
        public string[] Call_Google(string name) {
            return base.Channel.Call_Google(name);
        }
    }
}
