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
    /// &lt;p&gt;With this option, you can choose your desired gradient scheme:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;If you are unsure, try &lt;b&gt;Gauss linear&lt;/b&gt; first.&lt;/p&gt;&lt;li&gt;&lt;p&gt;If you require a higher-order scheme you can use &lt;b&gt;leastSquares&lt;/b&gt;.&lt;/p&gt;&lt;/ul&gt;
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(GaussLinearGradientScheme), "GAUSS_LINEAR")]
    [JsonSubtypes.KnownSubType(typeof(CelllimitedGaussLinearGradientScheme), "CELLLIMITED_GAUSS_LINEAR")]
    [JsonSubtypes.KnownSubType(typeof(CelllimitedLeastSquaresGradientScheme), "CELLLIMITED_LEASTSQUARES")]
    [JsonSubtypes.KnownSubType(typeof(FourthGradientScheme), "FOURTH")]
    [JsonSubtypes.KnownSubType(typeof(LeastsquaresGradientScheme), "LEASTSQUARES")]
    public interface OneOfGradientSchemesGradNuTilda
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
