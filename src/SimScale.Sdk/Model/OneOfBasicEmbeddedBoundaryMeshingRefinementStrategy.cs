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
    /// Strategy used to refine the cells adjacent to the geometry surface, the same procedure is applied to the inner and outer part of the geometry. The propagation of the refinement can be controlled by either one of the following parameters:&lt;br&gt; &lt;b&gt;Refinement propagation layers:&lt;/b&gt; The specified number of background grid layers controls the distance from the geometry surface up which the cells will be refined. It ensures that all cells adjacent to the geometry are refined.&lt;br&gt; &lt;b&gt;Distance from surface:&lt;/b&gt; Cells whose center lies within the specified distance from the geometry are refined. If the value of the distance is too small, some cells might not be refined.&lt;br&gt;
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(EmbeddedNumberOfCellsRefinement), "LAYER_REFINEMENT")]
    [JsonSubtypes.KnownSubType(typeof(EmbeddedDistanceRefinement), "DISTANCE_REFINEMENT")]
    public interface OneOfBasicEmbeddedBoundaryMeshingRefinementStrategy
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
