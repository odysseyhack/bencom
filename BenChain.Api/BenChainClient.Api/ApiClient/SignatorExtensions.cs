﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace BenChainClient.Api
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for Signator.
    /// </summary>
    public static partial class SignatorExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<SignatoryModel> GetAll(this ISignator operations)
            {
                return Task.Factory.StartNew(s => ((ISignator)s).GetAllAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<SignatoryModel>> GetAllAsync(this ISignator operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='participantId'>
            /// </param>
            /// <param name='status'>
            /// </param>
            public static IList<SignatoryModel> GetAllByParticipant(this ISignator operations, Guid participantId, int status)
            {
                return Task.Factory.StartNew(s => ((ISignator)s).GetAllByParticipantAsync(participantId, status), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='participantId'>
            /// </param>
            /// <param name='status'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<SignatoryModel>> GetAllByParticipantAsync(this ISignator operations, Guid participantId, int status, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAllByParticipantWithHttpMessagesAsync(participantId, status, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='participantId'>
            /// </param>
            public static IList<SignatoryModel> GetAllNotOpenByParticipant(this ISignator operations, Guid participantId)
            {
                return Task.Factory.StartNew(s => ((ISignator)s).GetAllNotOpenByParticipantAsync(participantId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='participantId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<SignatoryModel>> GetAllNotOpenByParticipantAsync(this ISignator operations, Guid participantId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAllNotOpenByParticipantWithHttpMessagesAsync(participantId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='participantModel'>
            /// </param>
            public static SignatoryModel CreatedOrUpdate(this ISignator operations, SignatoryModel participantModel)
            {
                return Task.Factory.StartNew(s => ((ISignator)s).CreatedOrUpdateAsync(participantModel), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='participantModel'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SignatoryModel> CreatedOrUpdateAsync(this ISignator operations, SignatoryModel participantModel, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreatedOrUpdateWithHttpMessagesAsync(participantModel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='signatoryModel'>
            /// </param>
            public static SignatoryModel BenChainUpdate(this ISignator operations, SignatoryModel signatoryModel)
            {
                return Task.Factory.StartNew(s => ((ISignator)s).BenChainUpdateAsync(signatoryModel), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='signatoryModel'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SignatoryModel> BenChainUpdateAsync(this ISignator operations, SignatoryModel signatoryModel, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BenChainUpdateWithHttpMessagesAsync(signatoryModel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
