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
    /// FixedValueOBC
    /// </summary>
    [DataContract]
    public partial class FixedValueOBC : OneOfCustomFluidBCOmegaDissipationRate, IEquatable<FixedValueOBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedValueOBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FixedValueOBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedValueOBC" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;FIXED_VALUE&quot;).</param>
        /// <param name="value">value.</param>
        public FixedValueOBC(string type = "FIXED_VALUE", DimensionalFunctionSpecificTurbulenceDissipationRate value = default(DimensionalFunctionSpecificTurbulenceDissipationRate))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for FixedValueOBC and cannot be null");
            this.Value = value;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public DimensionalFunctionSpecificTurbulenceDissipationRate Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FixedValueOBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as FixedValueOBC);
        }

        /// <summary>
        /// Returns true if FixedValueOBC instances are equal
        /// </summary>
        /// <param name="input">Instance of FixedValueOBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FixedValueOBC input)
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
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }

}
