// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Input required to add a provider. </summary>
    public partial class RecoveryServicesProviderCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of RecoveryServicesProviderCreateOrUpdateContent. </summary>
        /// <param name="properties"> The properties of an add provider request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public RecoveryServicesProviderCreateOrUpdateContent(AddRecoveryServicesProviderInputProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> The properties of an add provider request. </summary>
        public AddRecoveryServicesProviderInputProperties Properties { get; }
    }
}
