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
    
    public partial class Context
    {
        public System.Guid Id { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Modified { get; set; }
        public System.DateTime EffectiveEndDate { get; set; }
        public int Status { get; set; }
        public string Note { get; set; }
        public string ExplanationNote { get; set; }
        public Nullable<System.Guid> Creator { get; set; }
        public Nullable<System.Guid> Signator { get; set; }
        public string Token1 { get; set; }
        public string Token2 { get; set; }
        public int Ref { get; set; }
    }
}
