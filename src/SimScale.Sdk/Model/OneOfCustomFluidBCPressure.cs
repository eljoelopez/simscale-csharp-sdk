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
    /// Please choose a boundary condition for pressure (p).
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(AdvectivePBC), "ADVECTIVE")]
    [JsonSubtypes.KnownSubType(typeof(SymmetryPBC), "SYMMETRY")]
    [JsonSubtypes.KnownSubType(typeof(FanPBC), "FAN_PRESSURE")]
    [JsonSubtypes.KnownSubType(typeof(FixedGradientPBC), "FIXED_GRADIENT")]
    [JsonSubtypes.KnownSubType(typeof(FixedValuePBC), "FIXED_VALUE")]
    [JsonSubtypes.KnownSubType(typeof(FreestreamPBC), "FREESTREAM")]
    [JsonSubtypes.KnownSubType(typeof(MeanValuePBC), "FIXED_MEAN")]
    [JsonSubtypes.KnownSubType(typeof(ZeroGradientPBC), "ZERO_GRADIENT")]
    [JsonSubtypes.KnownSubType(typeof(TotalPBC), "TOTAL_PRESSURE")]
    [JsonSubtypes.KnownSubType(typeof(WaveTransmissivePBC), "WAVE_TRANSMISSIVE")]
    public interface OneOfCustomFluidBCPressure
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
