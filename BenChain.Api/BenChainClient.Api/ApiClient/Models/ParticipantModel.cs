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

    public partial class ParticipantModel
    {
        /// <summary>
        /// Initializes a new instance of the ParticipantModel class.
        /// </summary>
        public ParticipantModel() { }

        /// <summary>
        /// Initializes a new instance of the ParticipantModel class.
        /// </summary>
        public ParticipantModel(Guid? id = default(Guid?), string name = default(string), string email = default(string), string phone = default(string), string signatorLevel = default(string), string participantHash = default(string))
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            SignatorLevel = signatorLevel;
            ParticipantHash = participantHash;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Phone")]
        public string Phone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SignatorLevel")]
        public string SignatorLevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ParticipantHash")]
        public string ParticipantHash { get; set; }

    }
}