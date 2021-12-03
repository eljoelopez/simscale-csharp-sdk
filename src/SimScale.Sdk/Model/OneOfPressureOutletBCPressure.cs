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
    /// Please choose a boundary condition for pressure (p). &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/boundary-conditions/pressure-inlet-and-pressure-outlet/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(FixedValuePBC), "FIXED_VALUE")]
    [JsonSubtypes.KnownSubType(typeof(MeanValuePBC), "FIXED_MEAN")]
    [JsonSubtypes.KnownSubType(typeof(TotalPBC), "TOTAL_PRESSURE")]
    public interface OneOfPressureOutletBCPressure
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
