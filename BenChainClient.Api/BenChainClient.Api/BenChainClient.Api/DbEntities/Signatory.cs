//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BenChainClient.Api.DbEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Signatory
    {
        public System.Guid Id { get; set; }
        public System.Guid ContextId { get; set; }
        public System.Guid ParticipantId { get; set; }
        public string BenChainContractId { get; set; }
        public int Status { get; set; }
        public System.DateTime Modified { get; set; }
        public int OrderId { get; set; }
        public string Note { get; set; }
        public string BenChainABI { get; set; }
        public string BenChainBytescode { get; set; }
    }
}
