// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of virtual network rules. </summary>
    public partial class VirtualNetworkRuleListResult
    {
        /// <summary> Initializes a new instance of VirtualNetworkRuleListResult. </summary>
        internal VirtualNetworkRuleListResult()
        {
            Value = new ChangeTrackingList<VirtualNetworkRule>();
        }

        /// <summary> Initializes a new instance of VirtualNetworkRuleListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal VirtualNetworkRuleListResult(IReadOnlyList<VirtualNetworkRule> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<VirtualNetworkRule> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}