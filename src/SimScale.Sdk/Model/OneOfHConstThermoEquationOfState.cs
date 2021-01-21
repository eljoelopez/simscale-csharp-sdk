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
    /// OneOfHConstThermoEquationOfState
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(PerfectGasEquationOfState), "PERFECT_GAS")]
    [JsonSubtypes.KnownSubType(typeof(RhoConstEquationOfState), "RHO_CONST")]
    [JsonSubtypes.KnownSubType(typeof(PerfectFluidEquationOfState), "PERFECT_FLUID")]
    [JsonSubtypes.KnownSubType(typeof(IncompressiblePerfectGasEquationOfState), "INCOMPRESSIBLE_PERFECT_GAS")]
    [JsonSubtypes.KnownSubType(typeof(AdiabaticPerfectFluidEquationOfState), "ADIABATIC_PERFECT_FLUID")]
    [JsonSubtypes.KnownSubType(typeof(PengRobinsonGasEquationOfState), "PENG_ROBINSON_GAS")]
    public interface OneOfHConstThermoEquationOfState
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
