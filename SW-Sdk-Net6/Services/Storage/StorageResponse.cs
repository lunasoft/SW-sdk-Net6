﻿using SW.Entities;
using System.Runtime.Serialization;

namespace SW.Services.Storage
{
    [DataContract]
    public class StorageResponse : Response
    {
        [DataMember]
        public StorageData Data { get; set; }
    }
    public partial class StorageData
    {
        [DataMember]
        public StorageRecords[] Records { get; set; }
    }
    public partial class StorageRecords
    {
        [DataMember]
        public string UrlXml { get; set; }
        [DataMember]
        public string UrlPdf { get; set; }
        [DataMember]
        public string UrlAckCfdi { get; set; }
        [DataMember]
        public string UrlAckCancellation { get; set; }
        [DataMember]
        public string UrlAddenda { get; set; }
    }

    [DataContract]
    public class StorageExtraResponse : Response
    {
        [DataMember]
        public StorageExtraData Data { get; set; }
    }
    public class StorageExtraData
    {
        public StorageExtraRecords[] Records { get; set; }
    }
    
    public partial class StorageExtraRecords : StorageRecords
    {
        [DataMember]
        public string FechaGeneracionPdf { get; set; }
        [DataMember]
        public string IdDealer { get; set; }
        [DataMember]
        public string IdUser { get; set; }
        [DataMember]
        public string Version { get; set; }
        [DataMember]
        public string Serie { get; set; }
        [DataMember]
        public string Folio { get; set; }
        [DataMember]
        public string Fecha { get; set; }
        [DataMember]
        public string NumeroCertificado { get; set; }
        [DataMember]
        public decimal SubTotal { get; set; }
        [DataMember]
        public decimal Descuento { get; set; }
        [DataMember]
        public decimal Total { get; set; }
        [DataMember]
        public string Moneda { get; set; }
        [DataMember]
        public decimal TipoCambio { get; set; }
        [DataMember]
        public string TipoDeComprobante { get; set; }
        [DataMember]
        public string MetodoPago { get; set; }
        [DataMember]
        public string FormaPago { get; set; }
        [DataMember]
        public string CondicionesPago { get; set; }
        [DataMember]
        public string LuegarExpedicion { get; set; }
        [DataMember]
        public string EmisorRfc { get; set; }
        [DataMember]
        public string EmisorNombre { get; set; }
        [DataMember]
        public string RegimenFiscal { get; set; }
        [DataMember]
        public string ReceptorRfc { get; set; }
        [DataMember]
        public string ReceptorNombre { get; set; }
        [DataMember]
        public string ResidenciaFiscal { get; set; }
        [DataMember]
        public string NumRegIdTrib { get; set; }
        [DataMember]
        public string usoCFDI { get; set; }
        [DataMember]
        public decimal TotalImpuestosTraslados { get; set; }
        [DataMember]
        public decimal TotalImpuestosRetencion { get; set; }
        [DataMember]
        public decimal TrasladosIVA { get; set; }
        [DataMember]
        public decimal TrasladosIEPS { get; set; }
        [DataMember]
        public decimal RetencionesISR { get; set; }
        [DataMember]
        public decimal RetencionesIVA { get; set; }
        [DataMember]
        public decimal RetencionesIEPS { get; set; }
        [DataMember]
        public decimal TotalImpuestosLocalesTraslados { get; set; }
        [DataMember]
        public decimal TotalImpuestosLocalesRetencion { get; set; }
        [DataMember]
        public string Complementos { get; set; }
        [DataMember]
        public string Uuid { get; set; }
        [DataMember]
        public string FechaTimbrado { get; set; }
        [DataMember]
        public string RfcProvCertif { get; set; }
        [DataMember]
        public string selloCFD { get; set; }
    }
}