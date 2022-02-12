﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaNonmina.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RespuestaCFDi", Namespace="http://schemas.datacontract.org/2004/07/FacturaService")]
    [System.SerializableAttribute()]
    public partial class RespuestaCFDi : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] DocumentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeField;
        
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
        public byte[] Documento {
            get {
                return this.DocumentoField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentoField, value) != true)) {
                    this.DocumentoField = value;
                    this.RaisePropertyChanged("Documento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensaje {
            get {
                return this.MensajeField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeField, value) != true)) {
                    this.MensajeField = value;
                    this.RaisePropertyChanged("Mensaje");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ITimbrado")]
    public interface ITimbrado {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimbrado/Timbrar", ReplyAction="http://tempuri.org/ITimbrado/TimbrarResponse")]
        SistemaNonmina.ServiceReference1.RespuestaCFDi Timbrar(string Usuario, string Password, byte[] ArchivoXML);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimbrado/Timbrar", ReplyAction="http://tempuri.org/ITimbrado/TimbrarResponse")]
        System.Threading.Tasks.Task<SistemaNonmina.ServiceReference1.RespuestaCFDi> TimbrarAsync(string Usuario, string Password, byte[] ArchivoXML);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimbrado/TimbrarTest", ReplyAction="http://tempuri.org/ITimbrado/TimbrarTestResponse")]
        SistemaNonmina.ServiceReference1.RespuestaCFDi TimbrarTest(string Usuario, string Password, byte[] ArchivoXML);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimbrado/TimbrarTest", ReplyAction="http://tempuri.org/ITimbrado/TimbrarTestResponse")]
        System.Threading.Tasks.Task<SistemaNonmina.ServiceReference1.RespuestaCFDi> TimbrarTestAsync(string Usuario, string Password, byte[] ArchivoXML);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimbrado/PDF", ReplyAction="http://tempuri.org/ITimbrado/PDFResponse")]
        SistemaNonmina.ServiceReference1.RespuestaCFDi PDF(string Usuario, string Password, byte[] ArchivoXML, byte[] ArchivoACK);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimbrado/PDF", ReplyAction="http://tempuri.org/ITimbrado/PDFResponse")]
        System.Threading.Tasks.Task<SistemaNonmina.ServiceReference1.RespuestaCFDi> PDFAsync(string Usuario, string Password, byte[] ArchivoXML, byte[] ArchivoACK);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimbrado/Cancelar", ReplyAction="http://tempuri.org/ITimbrado/CancelarResponse")]
        SistemaNonmina.ServiceReference1.RespuestaCFDi Cancelar(string Usuario, string Password, byte[] PFX, string[] UUID, string ContraseñaPFX);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimbrado/Cancelar", ReplyAction="http://tempuri.org/ITimbrado/CancelarResponse")]
        System.Threading.Tasks.Task<SistemaNonmina.ServiceReference1.RespuestaCFDi> CancelarAsync(string Usuario, string Password, byte[] PFX, string[] UUID, string ContraseñaPFX);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimbrado/CambiarContrasena", ReplyAction="http://tempuri.org/ITimbrado/CambiarContrasenaResponse")]
        SistemaNonmina.ServiceReference1.RespuestaCFDi CambiarContrasena(string Usuario, string Password, string NuevoPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimbrado/CambiarContrasena", ReplyAction="http://tempuri.org/ITimbrado/CambiarContrasenaResponse")]
        System.Threading.Tasks.Task<SistemaNonmina.ServiceReference1.RespuestaCFDi> CambiarContrasenaAsync(string Usuario, string Password, string NuevoPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimbrado/Login", ReplyAction="http://tempuri.org/ITimbrado/LoginResponse")]
        SistemaNonmina.ServiceReference1.RespuestaCFDi Login(string Usuario, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimbrado/Login", ReplyAction="http://tempuri.org/ITimbrado/LoginResponse")]
        System.Threading.Tasks.Task<SistemaNonmina.ServiceReference1.RespuestaCFDi> LoginAsync(string Usuario, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimbrado/PFX", ReplyAction="http://tempuri.org/ITimbrado/PFXResponse")]
        SistemaNonmina.ServiceReference1.RespuestaCFDi PFX(string Usuario, string PAssword, byte[] ArchivoCER, byte[] ArchivoKey, string ClavePrivada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimbrado/PFX", ReplyAction="http://tempuri.org/ITimbrado/PFXResponse")]
        System.Threading.Tasks.Task<SistemaNonmina.ServiceReference1.RespuestaCFDi> PFXAsync(string Usuario, string PAssword, byte[] ArchivoCER, byte[] ArchivoKey, string ClavePrivada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimbrado/CancelarAsincrono", ReplyAction="http://tempuri.org/ITimbrado/CancelarAsincronoResponse")]
        SistemaNonmina.ServiceReference1.RespuestaCFDi CancelarAsincrono(string Usuario, string Password, byte[] PFX, string UUID, string ContraseñaPFX, double Total, string RFCEmior, string RFCReceptor, string motivo, string sustitucion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimbrado/CancelarAsincrono", ReplyAction="http://tempuri.org/ITimbrado/CancelarAsincronoResponse")]
        System.Threading.Tasks.Task<SistemaNonmina.ServiceReference1.RespuestaCFDi> CancelarAsincronoAsync(string Usuario, string Password, byte[] PFX, string UUID, string ContraseñaPFX, double Total, string RFCEmior, string RFCReceptor, string motivo, string sustitucion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimbrado/VerStatus", ReplyAction="http://tempuri.org/ITimbrado/VerStatusResponse")]
        SistemaNonmina.ServiceReference1.RespuestaCFDi VerStatus(string Usuario, string Password, string UUID, double Total, string RFCEmisor, string RFCReceptor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimbrado/VerStatus", ReplyAction="http://tempuri.org/ITimbrado/VerStatusResponse")]
        System.Threading.Tasks.Task<SistemaNonmina.ServiceReference1.RespuestaCFDi> VerStatusAsync(string Usuario, string Password, string UUID, double Total, string RFCEmisor, string RFCReceptor);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITimbradoChannel : SistemaNonmina.ServiceReference1.ITimbrado, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TimbradoClient : System.ServiceModel.ClientBase<SistemaNonmina.ServiceReference1.ITimbrado>, SistemaNonmina.ServiceReference1.ITimbrado {
        
        public TimbradoClient() {
        }
        
        public TimbradoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TimbradoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TimbradoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TimbradoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SistemaNonmina.ServiceReference1.RespuestaCFDi Timbrar(string Usuario, string Password, byte[] ArchivoXML) {
            return base.Channel.Timbrar(Usuario, Password, ArchivoXML);
        }
        
        public System.Threading.Tasks.Task<SistemaNonmina.ServiceReference1.RespuestaCFDi> TimbrarAsync(string Usuario, string Password, byte[] ArchivoXML) {
            return base.Channel.TimbrarAsync(Usuario, Password, ArchivoXML);
        }
        
        public SistemaNonmina.ServiceReference1.RespuestaCFDi TimbrarTest(string Usuario, string Password, byte[] ArchivoXML) {
            return base.Channel.TimbrarTest(Usuario, Password, ArchivoXML);
        }
        
        public System.Threading.Tasks.Task<SistemaNonmina.ServiceReference1.RespuestaCFDi> TimbrarTestAsync(string Usuario, string Password, byte[] ArchivoXML) {
            return base.Channel.TimbrarTestAsync(Usuario, Password, ArchivoXML);
        }
        
        public SistemaNonmina.ServiceReference1.RespuestaCFDi PDF(string Usuario, string Password, byte[] ArchivoXML, byte[] ArchivoACK) {
            return base.Channel.PDF(Usuario, Password, ArchivoXML, ArchivoACK);
        }
        
        public System.Threading.Tasks.Task<SistemaNonmina.ServiceReference1.RespuestaCFDi> PDFAsync(string Usuario, string Password, byte[] ArchivoXML, byte[] ArchivoACK) {
            return base.Channel.PDFAsync(Usuario, Password, ArchivoXML, ArchivoACK);
        }
        
        public SistemaNonmina.ServiceReference1.RespuestaCFDi Cancelar(string Usuario, string Password, byte[] PFX, string[] UUID, string ContraseñaPFX) {
            return base.Channel.Cancelar(Usuario, Password, PFX, UUID, ContraseñaPFX);
        }
        
        public System.Threading.Tasks.Task<SistemaNonmina.ServiceReference1.RespuestaCFDi> CancelarAsync(string Usuario, string Password, byte[] PFX, string[] UUID, string ContraseñaPFX) {
            return base.Channel.CancelarAsync(Usuario, Password, PFX, UUID, ContraseñaPFX);
        }
        
        public SistemaNonmina.ServiceReference1.RespuestaCFDi CambiarContrasena(string Usuario, string Password, string NuevoPassword) {
            return base.Channel.CambiarContrasena(Usuario, Password, NuevoPassword);
        }
        
        public System.Threading.Tasks.Task<SistemaNonmina.ServiceReference1.RespuestaCFDi> CambiarContrasenaAsync(string Usuario, string Password, string NuevoPassword) {
            return base.Channel.CambiarContrasenaAsync(Usuario, Password, NuevoPassword);
        }
        
        public SistemaNonmina.ServiceReference1.RespuestaCFDi Login(string Usuario, string Password) {
            return base.Channel.Login(Usuario, Password);
        }
        
        public System.Threading.Tasks.Task<SistemaNonmina.ServiceReference1.RespuestaCFDi> LoginAsync(string Usuario, string Password) {
            return base.Channel.LoginAsync(Usuario, Password);
        }
        
        public SistemaNonmina.ServiceReference1.RespuestaCFDi PFX(string Usuario, string PAssword, byte[] ArchivoCER, byte[] ArchivoKey, string ClavePrivada) {
            return base.Channel.PFX(Usuario, PAssword, ArchivoCER, ArchivoKey, ClavePrivada);
        }
        
        public System.Threading.Tasks.Task<SistemaNonmina.ServiceReference1.RespuestaCFDi> PFXAsync(string Usuario, string PAssword, byte[] ArchivoCER, byte[] ArchivoKey, string ClavePrivada) {
            return base.Channel.PFXAsync(Usuario, PAssword, ArchivoCER, ArchivoKey, ClavePrivada);
        }
        
        public SistemaNonmina.ServiceReference1.RespuestaCFDi CancelarAsincrono(string Usuario, string Password, byte[] PFX, string UUID, string ContraseñaPFX, double Total, string RFCEmior, string RFCReceptor, string motivo, string sustitucion) {
            return base.Channel.CancelarAsincrono(Usuario, Password, PFX, UUID, ContraseñaPFX, Total, RFCEmior, RFCReceptor, motivo, sustitucion);
        }
        
        public System.Threading.Tasks.Task<SistemaNonmina.ServiceReference1.RespuestaCFDi> CancelarAsincronoAsync(string Usuario, string Password, byte[] PFX, string UUID, string ContraseñaPFX, double Total, string RFCEmior, string RFCReceptor, string motivo, string sustitucion) {
            return base.Channel.CancelarAsincronoAsync(Usuario, Password, PFX, UUID, ContraseñaPFX, Total, RFCEmior, RFCReceptor, motivo, sustitucion);
        }
        
        public SistemaNonmina.ServiceReference1.RespuestaCFDi VerStatus(string Usuario, string Password, string UUID, double Total, string RFCEmisor, string RFCReceptor) {
            return base.Channel.VerStatus(Usuario, Password, UUID, Total, RFCEmisor, RFCReceptor);
        }
        
        public System.Threading.Tasks.Task<SistemaNonmina.ServiceReference1.RespuestaCFDi> VerStatusAsync(string Usuario, string Password, string UUID, double Total, string RFCEmisor, string RFCReceptor) {
            return base.Channel.VerStatusAsync(Usuario, Password, UUID, Total, RFCEmisor, RFCReceptor);
        }
    }
}
