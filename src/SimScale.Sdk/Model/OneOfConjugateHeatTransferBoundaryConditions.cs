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
    /// OneOfConjugateHeatTransferBoundaryConditions
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(VelocityInletBC), "VELOCITY_INLET_V3")]
    [JsonSubtypes.KnownSubType(typeof(VelocityOutletBC), "VELOCITY_OUTLET_V7")]
    [JsonSubtypes.KnownSubType(typeof(PressureInletBC), "PRESSURE_INLET_V31")]
    [JsonSubtypes.KnownSubType(typeof(PressureOutletBC), "PRESSURE_OUTLET_V30")]
    [JsonSubtypes.KnownSubType(typeof(WallBC), "WALL_V34")]
    [JsonSubtypes.KnownSubType(typeof(SymmetryBC), "SYMMETRY")]
    [JsonSubtypes.KnownSubType(typeof(PeriodicBC), "PERIODIC")]
    [JsonSubtypes.KnownSubType(typeof(WedgeBC), "WEDGE")]
    [JsonSubtypes.KnownSubType(typeof(CustomFluidBC), "CUSTOM_V37")]
    [JsonSubtypes.KnownSubType(typeof(Empty2DBC), "EMPTY_2D")]
    [JsonSubtypes.KnownSubType(typeof(NaturalConvectionInletOutletBC), "NATURAL_CONVECTION_INLET_OUTLET")]
    public interface OneOfConjugateHeatTransferBoundaryConditions
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
