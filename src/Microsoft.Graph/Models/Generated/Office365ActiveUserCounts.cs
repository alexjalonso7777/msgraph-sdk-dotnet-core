﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Office365ActiveUserCounts.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class Office365ActiveUserCounts
    {
    
        /// <summary>
        /// Gets or sets reportRefreshDate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportRefreshDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportRefreshDate { get; set; }
    
        /// <summary>
        /// Gets or sets office365.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "office365", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Office365 { get; set; }
    
        /// <summary>
        /// Gets or sets exchange.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exchange", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Exchange { get; set; }
    
        /// <summary>
        /// Gets or sets oneDrive.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "oneDrive", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OneDrive { get; set; }
    
        /// <summary>
        /// Gets or sets sharePoint.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharePoint", Required = Newtonsoft.Json.Required.Default)]
        public Int64? SharePoint { get; set; }
    
        /// <summary>
        /// Gets or sets skypeForBusiness.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "skypeForBusiness", Required = Newtonsoft.Json.Required.Default)]
        public Int64? SkypeForBusiness { get; set; }
    
        /// <summary>
        /// Gets or sets yammer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "yammer", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Yammer { get; set; }
    
        /// <summary>
        /// Gets or sets reportDate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportDate { get; set; }
    
        /// <summary>
        /// Gets or sets reportPeriod.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportPeriod", Required = Newtonsoft.Json.Required.Default)]
        public string ReportPeriod { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
