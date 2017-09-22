// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum WebsiteType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum WebsiteType
    {
    
        /// <summary>
        /// other
        /// </summary>
        Other = 0,
	
        /// <summary>
        /// home
        /// </summary>
        Home = 1,
	
        /// <summary>
        /// work
        /// </summary>
        Work = 2,
	
        /// <summary>
        /// blog
        /// </summary>
        Blog = 3,
	
        /// <summary>
        /// profile
        /// </summary>
        Profile = 4,
	
    }
}
