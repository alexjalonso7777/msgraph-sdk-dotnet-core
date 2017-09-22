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
    /// The type EmailAppUsageUserCounts.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class EmailAppUsageUserCounts
    {
    
        /// <summary>
        /// Gets or sets reportRefreshDate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportRefreshDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportRefreshDate { get; set; }
    
        /// <summary>
        /// Gets or sets mailForMac.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mailForMac", Required = Newtonsoft.Json.Required.Default)]
        public Int64? MailForMac { get; set; }
    
        /// <summary>
        /// Gets or sets outlookForMac.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outlookForMac", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OutlookForMac { get; set; }
    
        /// <summary>
        /// Gets or sets outlookForWindows.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outlookForWindows", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OutlookForWindows { get; set; }
    
        /// <summary>
        /// Gets or sets outlookForMobile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outlookForMobile", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OutlookForMobile { get; set; }
    
        /// <summary>
        /// Gets or sets otherForMobile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "otherForMobile", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OtherForMobile { get; set; }
    
        /// <summary>
        /// Gets or sets outlookForWeb.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outlookForWeb", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OutlookForWeb { get; set; }
    
        /// <summary>
        /// Gets or sets pop3App.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pop3App", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Pop3App { get; set; }
    
        /// <summary>
        /// Gets or sets imap4App.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "imap4App", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Imap4App { get; set; }
    
        /// <summary>
        /// Gets or sets smtpApp.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "smtpApp", Required = Newtonsoft.Json.Required.Default)]
        public Int64? SmtpApp { get; set; }
    
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
