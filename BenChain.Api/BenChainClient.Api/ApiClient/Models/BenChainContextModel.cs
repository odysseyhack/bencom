﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace BenChainClient.Api.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class BenChainContextModel
    {
        /// <summary>
        /// Initializes a new instance of the BenChainContextModel class.
        /// </summary>
        public BenChainContextModel() { }

        /// <summary>
        /// Initializes a new instance of the BenChainContextModel class.
        /// </summary>
        public BenChainContextModel(Guid? contextId = default(Guid?), string contractId = default(string), string aBI = default(string), string bytescode = default(string), int? status = default(int?))
        {
            ContextId = contextId;
            ContractId = contractId;
            ABI = aBI;
            Bytescode = bytescode;
            Status = status;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContextId")]
        public Guid? ContextId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContractId")]
        public string ContractId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ABI")]
        public string ABI { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Bytescode")]
        public string Bytescode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public int? Status { get; set; }

    }
}
