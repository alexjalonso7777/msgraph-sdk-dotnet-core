// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type List.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class List : BaseItem
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets list.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "list", Required = Newtonsoft.Json.Required.Default)]
        public ListInfo ListInfo { get; set; }
    
        /// <summary>
        /// Gets or sets sharepoint ids.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharepointIds", Required = Newtonsoft.Json.Required.Default)]
        public SharepointIds SharepointIds { get; set; }
    
        /// <summary>
        /// Gets or sets system.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "system", Required = Newtonsoft.Json.Required.Default)]
        public SystemFacet System { get; set; }
    
        /// <summary>
        /// Gets or sets columns.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "columns", Required = Newtonsoft.Json.Required.Default)]
        public IListColumnsCollectionPage Columns { get; set; }
    
        /// <summary>
        /// Gets or sets content types.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentTypes", Required = Newtonsoft.Json.Required.Default)]
        public IListContentTypesCollectionPage ContentTypes { get; set; }
    
        /// <summary>
        /// Gets or sets drive.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "drive", Required = Newtonsoft.Json.Required.Default)]
        public Drive Drive { get; set; }
    
        /// <summary>
        /// Gets or sets items.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "items", Required = Newtonsoft.Json.Required.Default)]
        public IListItemsCollectionPage Items { get; set; }
    
    }
}

