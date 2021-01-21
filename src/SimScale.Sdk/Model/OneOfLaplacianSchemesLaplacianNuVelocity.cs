/* 
 * SimScale API
 *
 * The version of the OpenAPI document: 0.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using JsonSubTypes;
using OpenAPIDateConverter = SimScale.Sdk.Client.OpenAPIDateConverter;

namespace SimScale.Sdk.Model
{
    /// <summary>
    /// &lt;p&gt;With this option you can choose your desired laplacian scheme.&lt;/p&gt;
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(GaussLinearCorrectedLaplacianScheme), "GAUSS_LINEAR_CORRECTED")]
    [JsonSubtypes.KnownSubType(typeof(GaussLinearLimitedCorrectedLaplacianScheme), "GAUSS_LINEAR_LIMITED_CORRECTED")]
    [JsonSubtypes.KnownSubType(typeof(GaussLinearUncorrectedLaplacianScheme), "GAUSS_LINEAR_UNCORRECTED")]
    public interface OneOfLaplacianSchemesLaplacianNuVelocity
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
