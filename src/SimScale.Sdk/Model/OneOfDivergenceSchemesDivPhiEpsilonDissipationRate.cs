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
    /// &lt;p&gt;With this option, you can choose your desired divergence scheme.&lt;/p&gt;
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(GaussLinearDivergenceScheme), "GAUSS_LINEAR")]
    [JsonSubtypes.KnownSubType(typeof(GaussLinearUpwindUnlimitedDivergenceScheme), "GAUSS_LINEARUPWIND_UNLIMITED")]
    [JsonSubtypes.KnownSubType(typeof(GaussLinearUpwindLimitedGradDivergenceScheme), "GAUSS_LINEARUPWIND_LIMITEDGRAD")]
    [JsonSubtypes.KnownSubType(typeof(GaussLimitedLinear1DivergenceScheme), "GAUSS_LIMITEDLINEAR_1")]
    [JsonSubtypes.KnownSubType(typeof(BoundedGaussUpwindDivergenceScheme), "BOUNDED_GAUSS_UPWIND")]
    [JsonSubtypes.KnownSubType(typeof(GaussUpwindDivergenceScheme), "GAUSS_UPWIND")]
    [JsonSubtypes.KnownSubType(typeof(GaussVanleerDivergenceScheme), "GAUSS_VANLEER")]
    public interface OneOfDivergenceSchemesDivPhiEpsilonDissipationRate
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
