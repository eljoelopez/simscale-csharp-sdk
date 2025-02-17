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
    /// OneOfFrequencyAnalysisBoundaryConditions
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(BoltPreloadBC), "BOLT_PRELOAD")]
    [JsonSubtypes.KnownSubType(typeof(ElasticSupportBC), "ELASTIC_SUPPORT")]
    [JsonSubtypes.KnownSubType(typeof(FixedSupportBC), "FIXED_SUPPORT")]
    [JsonSubtypes.KnownSubType(typeof(FixedValueBC), "FIXED_VALUE")]
    [JsonSubtypes.KnownSubType(typeof(PointMassBC), "POINT_MASS")]
    [JsonSubtypes.KnownSubType(typeof(RemoteDisplacementLoadBC), "REMOTE_DISPLACEMENT_LOAD")]
    [JsonSubtypes.KnownSubType(typeof(SymmetryPlaneBC), "SYMMETRY_PLANE")]
    public interface OneOfFrequencyAnalysisBoundaryConditions
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
