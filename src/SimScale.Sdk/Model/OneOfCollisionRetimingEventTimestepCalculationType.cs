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
    /// OneOfCollisionRetimingEventTimestepCalculationType
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(NewtonIterationTimestepCalculationType), "NEWTON_ITERATION")]
    [JsonSubtypes.KnownSubType(typeof(ManualTimestepCalculationType), "MANUAL")]
    public interface OneOfCollisionRetimingEventTimestepCalculationType
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
