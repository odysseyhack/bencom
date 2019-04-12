﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace BenChain.Api.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class ResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the ResponseModel class.
        /// </summary>
        public ResponseModel() { }

        /// <summary>
        /// Initializes a new instance of the ResponseModel class.
        /// </summary>
        public ResponseModel(string contextId = default(string), string contractId = default(string), string abi = default(string), string bin = default(string))
        {
            ContextId = contextId;
            ContractId = contractId;
            Abi = abi;
            Bin = bin;
        }

        /// <summary>
        /// Context ID
        /// </summary>
        [JsonProperty(PropertyName = "ContextId")]
        public string ContextId { get; set; }

        /// <summary>
        /// Returns the contract ID
        /// </summary>
        [JsonProperty(PropertyName = "ContractId")]
        public string ContractId { get; set; }

        /// <summary>
        /// ABI file for reverse the SmartContract
        /// </summary>
        [JsonProperty(PropertyName = "Abi")]
        public string Abi { get; set; }

        /// <summary>
        /// Bin file is needed for the approving the contract
        /// </summary>
        [JsonProperty(PropertyName = "Bin")]
        public string Bin { get; set; }

    }
}