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
    /// FieldCalculationsThermalComfortResultControl
    /// </summary>
    [DataContract]
    public partial class FieldCalculationsThermalComfortResultControl : OneOfFluidResultControlsFieldCalculations, IEquatable<FieldCalculationsThermalComfortResultControl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldCalculationsThermalComfortResultControl" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FieldCalculationsThermalComfortResultControl() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldCalculationsThermalComfortResultControl" /> class.
        /// </summary>
        /// <param name="type">Schema name: FieldCalculationsThermalComfortResultControl (required) (default to &quot;THERMAL_COMFORT&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="clothingCoefficientFactor">clothingCoefficientFactor (default to 1M).</param>
        /// <param name="metabolicRateFactor">metabolicRateFactor (default to 1M).</param>
        /// <param name="relativeHumidityFactor">relativeHumidityFactor (default to 50M).</param>
        public FieldCalculationsThermalComfortResultControl(string type = "THERMAL_COMFORT", string name = default(string), decimal? clothingCoefficientFactor = default(decimal?), decimal? metabolicRateFactor = default(decimal?), decimal? relativeHumidityFactor = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for FieldCalculationsThermalComfortResultControl and cannot be null");
            this.Name = name;
            this.ClothingCoefficientFactor = clothingCoefficientFactor;
            this.MetabolicRateFactor = metabolicRateFactor;
            this.RelativeHumidityFactor = relativeHumidityFactor;
        }
        
        /// <summary>
        /// Schema name: FieldCalculationsThermalComfortResultControl
        /// </summary>
        /// <value>Schema name: FieldCalculationsThermalComfortResultControl</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ClothingCoefficientFactor
        /// </summary>
        [DataMember(Name="clothingCoefficientFactor", EmitDefaultValue=false)]
        public decimal? ClothingCoefficientFactor { get; set; }

        /// <summary>
        /// Gets or Sets MetabolicRateFactor
        /// </summary>
        [DataMember(Name="metabolicRateFactor", EmitDefaultValue=false)]
        public decimal? MetabolicRateFactor { get; set; }

        /// <summary>
        /// Gets or Sets RelativeHumidityFactor
        /// </summary>
        [DataMember(Name="relativeHumidityFactor", EmitDefaultValue=false)]
        public decimal? RelativeHumidityFactor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldCalculationsThermalComfortResultControl {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ClothingCoefficientFactor: ").Append(ClothingCoefficientFactor).Append("\n");
            sb.Append("  MetabolicRateFactor: ").Append(MetabolicRateFactor).Append("\n");
            sb.Append("  RelativeHumidityFactor: ").Append(RelativeHumidityFactor).Append("\n");
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
            return this.Equals(input as FieldCalculationsThermalComfortResultControl);
        }

        /// <summary>
        /// Returns true if FieldCalculationsThermalComfortResultControl instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldCalculationsThermalComfortResultControl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldCalculationsThermalComfortResultControl input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ClothingCoefficientFactor == input.ClothingCoefficientFactor ||
                    (this.ClothingCoefficientFactor != null &&
                    this.ClothingCoefficientFactor.Equals(input.ClothingCoefficientFactor))
                ) && 
                (
                    this.MetabolicRateFactor == input.MetabolicRateFactor ||
                    (this.MetabolicRateFactor != null &&
                    this.MetabolicRateFactor.Equals(input.MetabolicRateFactor))
                ) && 
                (
                    this.RelativeHumidityFactor == input.RelativeHumidityFactor ||
                    (this.RelativeHumidityFactor != null &&
                    this.RelativeHumidityFactor.Equals(input.RelativeHumidityFactor))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ClothingCoefficientFactor != null)
                    hashCode = hashCode * 59 + this.ClothingCoefficientFactor.GetHashCode();
                if (this.MetabolicRateFactor != null)
                    hashCode = hashCode * 59 + this.MetabolicRateFactor.GetHashCode();
                if (this.RelativeHumidityFactor != null)
                    hashCode = hashCode * 59 + this.RelativeHumidityFactor.GetHashCode();
                return hashCode;
            }
        }

    }

}
