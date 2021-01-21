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
    /// TotalPressurePressureType
    /// </summary>
    [DataContract]
    public partial class TotalPressurePressureType : OneOfFieldCalculationsPressureResultControlPressureType, IEquatable<TotalPressurePressureType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TotalPressurePressureType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TotalPressurePressureType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TotalPressurePressureType" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;TOTAL_PRESSURE&quot;).</param>
        /// <param name="pressureValue">pressureValue.</param>
        public TotalPressurePressureType(string type = "TOTAL_PRESSURE", DimensionalPressure pressureValue = default(DimensionalPressure))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for TotalPressurePressureType and cannot be null");
            this.PressureValue = pressureValue;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets PressureValue
        /// </summary>
        [DataMember(Name="pressureValue", EmitDefaultValue=false)]
        public DimensionalPressure PressureValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TotalPressurePressureType {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  PressureValue: ").Append(PressureValue).Append("\n");
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
            return this.Equals(input as TotalPressurePressureType);
        }

        /// <summary>
        /// Returns true if TotalPressurePressureType instances are equal
        /// </summary>
        /// <param name="input">Instance of TotalPressurePressureType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TotalPressurePressureType input)
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
                    this.PressureValue == input.PressureValue ||
                    (this.PressureValue != null &&
                    this.PressureValue.Equals(input.PressureValue))
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
                if (this.PressureValue != null)
                    hashCode = hashCode * 59 + this.PressureValue.GetHashCode();
                return hashCode;
            }
        }

    }

}
