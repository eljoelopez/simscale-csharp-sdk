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
    /// nuTilda is a Spalart-Allmaras variable which is a function of eddy viscosity. Choose a boundary type.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(CalculatedNBC), "CALCULATED")]
    [JsonSubtypes.KnownSubType(typeof(SymmetryNBC), "SYMMETRY")]
    [JsonSubtypes.KnownSubType(typeof(FixedGradientNBC), "FIXED_GRADIENT")]
    [JsonSubtypes.KnownSubType(typeof(FixedValueNBC), "FIXED_VALUE")]
    [JsonSubtypes.KnownSubType(typeof(InletOutletNBC), "INLET_OUTLET")]
    [JsonSubtypes.KnownSubType(typeof(ZeroGradientNBC), "ZERO_GRADIENT")]
    [JsonSubtypes.KnownSubType(typeof(WallFunctionNBC), "WALL_FUNCTION")]
    [JsonSubtypes.KnownSubType(typeof(FullResolutionNBC), "FULL_RESOLUTION")]
    public interface OneOfCustomFluidBCNuTilda
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
