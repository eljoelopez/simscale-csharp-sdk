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
    /// TotalIsotropicStiffnessDefinition
    /// </summary>
    [DataContract]
    public partial class TotalIsotropicStiffnessDefinition : OneOfIsotropicSpringStiffnessStiffnessDefinition, IEquatable<TotalIsotropicStiffnessDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TotalIsotropicStiffnessDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TotalIsotropicStiffnessDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TotalIsotropicStiffnessDefinition" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;TOTAL_ISOTROPIC&quot;).</param>
        /// <param name="total">total.</param>
        public TotalIsotropicStiffnessDefinition(string type = "TOTAL_ISOTROPIC", DimensionalSurfaceTension total = default(DimensionalSurfaceTension))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for TotalIsotropicStiffnessDefinition and cannot be null");
            this.Total = total;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public DimensionalSurfaceTension Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TotalIsotropicStiffnessDefinition {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as TotalIsotropicStiffnessDefinition);
        }

        /// <summary>
        /// Returns true if TotalIsotropicStiffnessDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of TotalIsotropicStiffnessDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TotalIsotropicStiffnessDefinition input)
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
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }

    }

}
