﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace BenChainClient.Api
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// BenChain Client API 2019.
    /// </summary>
    public partial interface IApiClient : IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IAppendix.
        /// </summary>
        IAppendix Appendix { get; }

        /// <summary>
        /// Gets the IContext.
        /// </summary>
        IContext Context { get; }

        /// <summary>
        /// Gets the IParticipant.
        /// </summary>
        IParticipant Participant { get; }

        /// <summary>
        /// Gets the ISignator.
        /// </summary>
        ISignator Signator { get; }

    }
}
