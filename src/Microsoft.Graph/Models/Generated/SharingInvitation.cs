// ------------------------------------------------------------------------------
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
    /// The type SharingInvitation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class SharingInvitation
    {
    
        /// <summary>
        /// Gets or sets email.
        /// The email address provided for the recipient of the sharing invitation. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "email", Required = Newtonsoft.Json.Required.Default)]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or sets invitedBy.
        /// Provides information about who sent the invitation that created this permission, if that information is available. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invitedBy", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet InvitedBy { get; set; }
    
        /// <summary>
        /// Gets or sets redeemedBy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "redeemedBy", Required = Newtonsoft.Json.Required.Default)]
        public string RedeemedBy { get; set; }
    
        /// <summary>
        /// Gets or sets signInRequired.
        /// If true the recipient of the invitation needs to sign in in order to access the shared item. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "signInRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? SignInRequired { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
