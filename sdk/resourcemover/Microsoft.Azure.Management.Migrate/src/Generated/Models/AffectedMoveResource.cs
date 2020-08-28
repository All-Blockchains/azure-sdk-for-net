// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Migrate.ResourceMover.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The RP custom operation error info.
    /// </summary>
    public partial class AffectedMoveResource
    {
        /// <summary>
        /// Initializes a new instance of the AffectedMoveResource class.
        /// </summary>
        public AffectedMoveResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AffectedMoveResource class.
        /// </summary>
        /// <param name="id">The affected move resource id.</param>
        /// <param name="sourceId">The affected move resource source
        /// id.</param>
        /// <param name="moveResources">The affected move resources.</param>
        public AffectedMoveResource(string id = default(string), string sourceId = default(string), IList<AffectedMoveResource> moveResources = default(IList<AffectedMoveResource>))
        {
            Id = id;
            SourceId = sourceId;
            MoveResources = moveResources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the affected move resource id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the affected move resource source id.
        /// </summary>
        [JsonProperty(PropertyName = "sourceId")]
        public string SourceId { get; private set; }

        /// <summary>
        /// Gets the affected move resources.
        /// </summary>
        [JsonProperty(PropertyName = "moveResources")]
        public IList<AffectedMoveResource> MoveResources { get; private set; }

    }
}