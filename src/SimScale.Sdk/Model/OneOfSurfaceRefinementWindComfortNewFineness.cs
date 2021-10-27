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
    /// &lt;p&gt;This parameter determines the &lt;b&gt;fineness of the mesh&lt;/b&gt; and affects the overall number of cells. It is recommended to start with the &lt;i&gt;coarse&lt;/i&gt; setting. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/analysis-types/pedestrian-wind-comfort-analysis/mesh-settings/&#39; target&#x3D;&#39;_blank&#39;&gt;Find out more.&lt;/a&gt;&lt;/p&gt;&lt;p&gt;&lt;b&gt;Note:&lt;/b&gt; This setting will impact the accuracy of your results as well as computing time and result size. A finer mesh will be more demanding in terms of machine size and memory but lead to more accurate results in most cases.&lt;/p&gt;
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(PacefishFinenessVeryCoarse), "VERY_COARSE")]
    [JsonSubtypes.KnownSubType(typeof(PacefishFinenessCoarse), "COARSE")]
    [JsonSubtypes.KnownSubType(typeof(PacefishFinenessModerate), "MODERATE")]
    [JsonSubtypes.KnownSubType(typeof(PacefishFinenessFine), "FINE")]
    [JsonSubtypes.KnownSubType(typeof(PacefishFinenessVeryFine), "VERY_FINE")]
    [JsonSubtypes.KnownSubType(typeof(PacefishFinenessTargetSize), "TARGET_SIZE")]
    public interface OneOfSurfaceRefinementWindComfortNewFineness
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
