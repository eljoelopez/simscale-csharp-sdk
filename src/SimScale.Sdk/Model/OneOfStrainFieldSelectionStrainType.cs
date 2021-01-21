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
    /// OneOfStrainFieldSelectionStrainType
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(TotalLinearStrainType), "TOTAL_LINEAR")]
    [JsonSubtypes.KnownSubType(typeof(TotalNonLinearStrainType), "TOTAL_NONLINEAR")]
    [JsonSubtypes.KnownSubType(typeof(TotalEquivalentPlasticStrainType), "TOTAL_EQUI_PLASTIC")]
    [JsonSubtypes.KnownSubType(typeof(UnelasticStrainType), "UNELASTIC")]
    [JsonSubtypes.KnownSubType(typeof(PrincipalStrainType), "PRINCIPAL")]
    public interface OneOfStrainFieldSelectionStrainType
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
