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
    /// &lt;p&gt;Ground reference can be either &lt;i&gt;absolute&lt;/i&gt; (uses bottom of region of interest as reference) or &lt;i&gt;relative&lt;/i&gt; (uses each assignment as a reference) and elevates those by the height defined. &lt;a href&#x3D; https://www.simscale.com/docs/analysis-types/pedestrian-wind-comfort-analysis/pedestrian-comfort-map/#ground&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.&lt;/p&gt; &lt;img src&#x3D;\&quot;/spec/resources/help/imgs/Ground_absolute_relative.jpg\&quot;, class&#x3D;\&quot;helpPopupImage\&quot;/&gt;
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(GroundAbsolute), "GROUND_ABSOLUTE")]
    [JsonSubtypes.KnownSubType(typeof(GroundRelative), "GROUND_RELATIVE")]
    public interface OneOfPedestrianComfortSurfaceGround
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
