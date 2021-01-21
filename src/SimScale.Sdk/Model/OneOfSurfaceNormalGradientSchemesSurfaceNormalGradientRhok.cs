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
    /// &lt;p&gt;A surface normal gradient is the component, normal to the face, of the gradient of values at the centres of the 2 cells connected through that face. Choose your desired scheme.&lt;/p&gt;
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(CorrectedSurfaceNormalGradientScheme), "CORRECTED")]
    [JsonSubtypes.KnownSubType(typeof(UncorrectedSurfaceNormalGradientScheme), "UNCORRECTED")]
    [JsonSubtypes.KnownSubType(typeof(LimitedCorrectedSurfaceNormalGradientScheme), "LIMITED")]
    public interface OneOfSurfaceNormalGradientSchemesSurfaceNormalGradientRhok
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
