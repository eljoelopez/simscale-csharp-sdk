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
    /// This toggle enables the automatic creation of boundary layers at no-slip walls. When toggled on, the meshing is started together with the simulation run.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(AutomaticLayerOn), "AUTOMATIC_LAYER_ON")]
    [JsonSubtypes.KnownSubType(typeof(AutomaticLayerOff), "AUTOMATIC_LAYER_OFF")]
    public interface OneOfSimmetrixMeshingFluidAutomaticLayerSettings
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
