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
using OpenAPIDateConverter = SimScale.Sdk.Client.OpenAPIDateConverter;

namespace SimScale.Sdk.Model
{
    /// <summary>
    /// DimensionalInitialConditionDomainsTemperature
    /// </summary>
    [DataContract]
    public partial class DimensionalInitialConditionDomainsTemperature : IEquatable<DimensionalInitialConditionDomainsTemperature>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DimensionalInitialConditionDomainsTemperature" /> class.
        /// </summary>
        /// <param name="global">global.</param>
        /// <param name="subdomains">subdomains.</param>
        public DimensionalInitialConditionDomainsTemperature(DimensionalTemperature global = default(DimensionalTemperature), List<SubdomainDimensionalInitialConditionTemperature> subdomains = default(List<SubdomainDimensionalInitialConditionTemperature>))
        {
            this.Global = global;
            this.Subdomains = subdomains;
        }
        
        /// <summary>
        /// Gets or Sets Global
        /// </summary>
        [DataMember(Name="global", EmitDefaultValue=false)]
        public DimensionalTemperature Global { get; set; }

        /// <summary>
        /// Gets or Sets Subdomains
        /// </summary>
        [DataMember(Name="subdomains", EmitDefaultValue=false)]
        public List<SubdomainDimensionalInitialConditionTemperature> Subdomains { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DimensionalInitialConditionDomainsTemperature {\n");
            sb.Append("  Global: ").Append(Global).Append("\n");
            sb.Append("  Subdomains: ").Append(Subdomains).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DimensionalInitialConditionDomainsTemperature);
        }

        /// <summary>
        /// Returns true if DimensionalInitialConditionDomainsTemperature instances are equal
        /// </summary>
        /// <param name="input">Instance of DimensionalInitialConditionDomainsTemperature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DimensionalInitialConditionDomainsTemperature input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Global == input.Global ||
                    (this.Global != null &&
                    this.Global.Equals(input.Global))
                ) && 
                (
                    this.Subdomains == input.Subdomains ||
                    this.Subdomains != null &&
                    input.Subdomains != null &&
                    this.Subdomains.SequenceEqual(input.Subdomains)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Global != null)
                    hashCode = hashCode * 59 + this.Global.GetHashCode();
                if (this.Subdomains != null)
                    hashCode = hashCode * 59 + this.Subdomains.GetHashCode();
                return hashCode;
            }
        }

    }

}
