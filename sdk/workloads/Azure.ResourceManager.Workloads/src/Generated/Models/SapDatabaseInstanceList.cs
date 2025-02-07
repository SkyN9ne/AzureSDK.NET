// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Workloads;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Defines the collection of SAP Database Instances. </summary>
    internal partial class SapDatabaseInstanceList
    {
        /// <summary> Initializes a new instance of SapDatabaseInstanceList. </summary>
        internal SapDatabaseInstanceList()
        {
            Value = new ChangeTrackingList<SapDatabaseInstanceData>();
        }

        /// <summary> Initializes a new instance of SapDatabaseInstanceList. </summary>
        /// <param name="value"> Gets the list of SAP Database instances. </param>
        /// <param name="nextLink"> Gets the value of next link. </param>
        internal SapDatabaseInstanceList(IReadOnlyList<SapDatabaseInstanceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the list of SAP Database instances. </summary>
        public IReadOnlyList<SapDatabaseInstanceData> Value { get; }
        /// <summary> Gets the value of next link. </summary>
        public string NextLink { get; }
    }
}
