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
    /// OneOfSolidNumericsEigenSolver
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(IRAMSorensen), "SORENSEN")]
    [JsonSubtypes.KnownSubType(typeof(Lanczos), "TRI_DIAG")]
    [JsonSubtypes.KnownSubType(typeof(BatheWilson), "JACOBI")]
    [JsonSubtypes.KnownSubType(typeof(QZ), "QZ")]
    public interface OneOfSolidNumericsEigenSolver
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
