﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cliente.ServicioDerivativos {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioDerivativos.ICalculadoraDerivativos")]
    public interface ICalculadoraDerivativos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadoraDerivativos/CalcularDerivativo", ReplyAction="http://tempuri.org/ICalculadoraDerivativos/CalcularDerivativoResponse")]
        decimal CalcularDerivativo(int dias, string[] simboloss, string[] funciones);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadoraDerivativos/CalcularDerivativo", ReplyAction="http://tempuri.org/ICalculadoraDerivativos/CalcularDerivativoResponse")]
        System.Threading.Tasks.Task<decimal> CalcularDerivativoAsync(int dias, string[] simboloss, string[] funciones);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculadoraDerivativosChannel : Cliente.ServicioDerivativos.ICalculadoraDerivativos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculadoraDerivativosClient : System.ServiceModel.ClientBase<Cliente.ServicioDerivativos.ICalculadoraDerivativos>, Cliente.ServicioDerivativos.ICalculadoraDerivativos {
        
        public CalculadoraDerivativosClient() {
        }
        
        public CalculadoraDerivativosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculadoraDerivativosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculadoraDerivativosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculadoraDerivativosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public decimal CalcularDerivativo(int dias, string[] simboloss, string[] funciones) {
            return base.Channel.CalcularDerivativo(dias, simboloss, funciones);
        }
        
        public System.Threading.Tasks.Task<decimal> CalcularDerivativoAsync(int dias, string[] simboloss, string[] funciones) {
            return base.Channel.CalcularDerivativoAsync(dias, simboloss, funciones);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioDerivativos.ICalculadoraSuma")]
    public interface ICalculadoraSuma {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadoraSuma/CalcularSuma", ReplyAction="http://tempuri.org/ICalculadoraSuma/CalcularSumaResponse")]
        decimal CalcularSuma(decimal x, decimal y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadoraSuma/CalcularSuma", ReplyAction="http://tempuri.org/ICalculadoraSuma/CalcularSumaResponse")]
        System.Threading.Tasks.Task<decimal> CalcularSumaAsync(decimal x, decimal y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculadoraSumaChannel : Cliente.ServicioDerivativos.ICalculadoraSuma, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculadoraSumaClient : System.ServiceModel.ClientBase<Cliente.ServicioDerivativos.ICalculadoraSuma>, Cliente.ServicioDerivativos.ICalculadoraSuma {
        
        public CalculadoraSumaClient() {
        }
        
        public CalculadoraSumaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculadoraSumaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculadoraSumaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculadoraSumaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public decimal CalcularSuma(decimal x, decimal y) {
            return base.Channel.CalcularSuma(x, y);
        }
        
        public System.Threading.Tasks.Task<decimal> CalcularSumaAsync(decimal x, decimal y) {
            return base.Channel.CalcularSumaAsync(x, y);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioDerivativos.ICalculadoraResta")]
    public interface ICalculadoraResta {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadoraResta/CalcularResta", ReplyAction="http://tempuri.org/ICalculadoraResta/CalcularRestaResponse")]
        decimal CalcularResta(decimal x, decimal y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadoraResta/CalcularResta", ReplyAction="http://tempuri.org/ICalculadoraResta/CalcularRestaResponse")]
        System.Threading.Tasks.Task<decimal> CalcularRestaAsync(decimal x, decimal y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculadoraRestaChannel : Cliente.ServicioDerivativos.ICalculadoraResta, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculadoraRestaClient : System.ServiceModel.ClientBase<Cliente.ServicioDerivativos.ICalculadoraResta>, Cliente.ServicioDerivativos.ICalculadoraResta {
        
        public CalculadoraRestaClient() {
        }
        
        public CalculadoraRestaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculadoraRestaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculadoraRestaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculadoraRestaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public decimal CalcularResta(decimal x, decimal y) {
            return base.Channel.CalcularResta(x, y);
        }
        
        public System.Threading.Tasks.Task<decimal> CalcularRestaAsync(decimal x, decimal y) {
            return base.Channel.CalcularRestaAsync(x, y);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioDerivativos.ICalculadoraMultiplicacion")]
    public interface ICalculadoraMultiplicacion {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadoraMultiplicacion/CalcularMultiplicacion", ReplyAction="http://tempuri.org/ICalculadoraMultiplicacion/CalcularMultiplicacionResponse")]
        decimal CalcularMultiplicacion(decimal x, decimal y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadoraMultiplicacion/CalcularMultiplicacion", ReplyAction="http://tempuri.org/ICalculadoraMultiplicacion/CalcularMultiplicacionResponse")]
        System.Threading.Tasks.Task<decimal> CalcularMultiplicacionAsync(decimal x, decimal y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculadoraMultiplicacionChannel : Cliente.ServicioDerivativos.ICalculadoraMultiplicacion, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculadoraMultiplicacionClient : System.ServiceModel.ClientBase<Cliente.ServicioDerivativos.ICalculadoraMultiplicacion>, Cliente.ServicioDerivativos.ICalculadoraMultiplicacion {
        
        public CalculadoraMultiplicacionClient() {
        }
        
        public CalculadoraMultiplicacionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculadoraMultiplicacionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculadoraMultiplicacionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculadoraMultiplicacionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public decimal CalcularMultiplicacion(decimal x, decimal y) {
            return base.Channel.CalcularMultiplicacion(x, y);
        }
        
        public System.Threading.Tasks.Task<decimal> CalcularMultiplicacionAsync(decimal x, decimal y) {
            return base.Channel.CalcularMultiplicacionAsync(x, y);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioDerivativos.ICalculadoraDivision")]
    public interface ICalculadoraDivision {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadoraDivision/CalcularDivision", ReplyAction="http://tempuri.org/ICalculadoraDivision/CalcularDivisionResponse")]
        decimal CalcularDivision(decimal x, decimal y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadoraDivision/CalcularDivision", ReplyAction="http://tempuri.org/ICalculadoraDivision/CalcularDivisionResponse")]
        System.Threading.Tasks.Task<decimal> CalcularDivisionAsync(decimal x, decimal y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculadoraDivisionChannel : Cliente.ServicioDerivativos.ICalculadoraDivision, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculadoraDivisionClient : System.ServiceModel.ClientBase<Cliente.ServicioDerivativos.ICalculadoraDivision>, Cliente.ServicioDerivativos.ICalculadoraDivision {
        
        public CalculadoraDivisionClient() {
        }
        
        public CalculadoraDivisionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculadoraDivisionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculadoraDivisionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculadoraDivisionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public decimal CalcularDivision(decimal x, decimal y) {
            return base.Channel.CalcularDivision(x, y);
        }
        
        public System.Threading.Tasks.Task<decimal> CalcularDivisionAsync(decimal x, decimal y) {
            return base.Channel.CalcularDivisionAsync(x, y);
        }
    }
}