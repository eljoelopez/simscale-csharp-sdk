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
    /// FixedGradientPFBC
    /// </summary>
    [DataContract]
    public partial class FixedGradientPFBC : OneOfCustomFluidBCPhaseFraction, IEquatable<FixedGradientPFBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedGradientPFBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FixedGradientPFBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedGradientPFBC" /> class.
        /// </summary>
        /// <param name="type">Schema name: FixedGradientPFBC (required) (default to &quot;FIXED_GRADIENT&quot;).</param>
        /// <param name="gradient">gradient.</param>
        public FixedGradientPFBC(string type = "FIXED_GRADIENT", DimensionalPhaseFractionGradient gradient = default(DimensionalPhaseFractionGradient))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for FixedGradientPFBC and cannot be null");
            this.Gradient = gradient;
        }
        
        /// <summary>
        /// Schema name: FixedGradientPFBC
        /// </summary>
        /// <value>Schema name: FixedGradientPFBC</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Gradient
        /// </summary>
        [DataMember(Name="gradient", EmitDefaultValue=false)]
        public DimensionalPhaseFractionGradient Gradient { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FixedGradientPFBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Gradient: ").Append(Gradient).Append("\n");
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
            return this.Equals(input as FixedGradientPFBC);
        }

        /// <summary>
        /// Returns true if FixedGradientPFBC instances are equal
        /// </summary>
        /// <param name="input">Instance of FixedGradientPFBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FixedGradientPFBC input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Gradient == input.Gradient ||
                    (this.Gradient != null &&
                    this.Gradient.Equals(input.Gradient))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Gradient != null)
                    hashCode = hashCode * 59 + this.Gradient.GetHashCode();
                return hashCode;
            }
        }

    }

}
