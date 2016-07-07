// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Media.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The response body for a RegenerateKey API.
    /// </summary>
    public partial class RegenerateKeyOutput
    {
        /// <summary>
        /// Initializes a new instance of the RegenerateKeyOutput class.
        /// </summary>
        public RegenerateKeyOutput() { }

        /// <summary>
        /// Initializes a new instance of the RegenerateKeyOutput class.
        /// </summary>
        public RegenerateKeyOutput(string key = default(string))
        {
            Key = key;
        }

        /// <summary>
        /// The new key of either the primary or secondary key.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

    }
}
