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
    /// FanPBC
    /// </summary>
    [DataContract]
    public partial class FanPBC : OneOfCustomFluidBCGaugePressure, OneOfCustomFluidBCGaugePressureRgh, OneOfCustomFluidBCPressure, OneOfCustomFluidBCPressureRgh, IEquatable<FanPBC>
    {
        /// <summary>
        /// Defines Direction
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            /// <summary>
            /// Enum IN for value: IN
            /// </summary>
            [EnumMember(Value = "IN")]
            IN = 1,

            /// <summary>
            /// Enum OUT for value: OUT
            /// </summary>
            [EnumMember(Value = "OUT")]
            OUT = 2

        }

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FanPBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FanPBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FanPBC" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;FAN_PRESSURE&quot;).</param>
        /// <param name="fanPressure">fanPressure.</param>
        /// <param name="direction">direction (default to DirectionEnum.IN).</param>
        /// <param name="environmentalTotalPressure">environmentalTotalPressure.</param>
        public FanPBC(string type = "FAN_PRESSURE", DimensionalFunctionPressure fanPressure = default(DimensionalFunctionPressure), DirectionEnum? direction = default(DirectionEnum?), DimensionalPressure environmentalTotalPressure = default(DimensionalPressure))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for FanPBC and cannot be null");
            this.FanPressure = fanPressure;
            this.Direction = direction;
            this.EnvironmentalTotalPressure = environmentalTotalPressure;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets FanPressure
        /// </summary>
        [DataMember(Name="fanPressure", EmitDefaultValue=false)]
        public DimensionalFunctionPressure FanPressure { get; set; }

        /// <summary>
        /// Gets or Sets EnvironmentalTotalPressure
        /// </summary>
        [DataMember(Name="environmentalTotalPressure", EmitDefaultValue=false)]
        public DimensionalPressure EnvironmentalTotalPressure { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FanPBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FanPressure: ").Append(FanPressure).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  EnvironmentalTotalPressure: ").Append(EnvironmentalTotalPressure).Append("\n");
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
            return this.Equals(input as FanPBC);
        }

        /// <summary>
        /// Returns true if FanPBC instances are equal
        /// </summary>
        /// <param name="input">Instance of FanPBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FanPBC input)
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
                    this.FanPressure == input.FanPressure ||
                    (this.FanPressure != null &&
                    this.FanPressure.Equals(input.FanPressure))
                ) && 
                (
                    this.Direction == input.Direction ||
                    this.Direction.Equals(input.Direction)
                ) && 
                (
                    this.EnvironmentalTotalPressure == input.EnvironmentalTotalPressure ||
                    (this.EnvironmentalTotalPressure != null &&
                    this.EnvironmentalTotalPressure.Equals(input.EnvironmentalTotalPressure))
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
                if (this.FanPressure != null)
                    hashCode = hashCode * 59 + this.FanPressure.GetHashCode();
                hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.EnvironmentalTotalPressure != null)
                    hashCode = hashCode * 59 + this.EnvironmentalTotalPressure.GetHashCode();
                return hashCode;
            }
        }

    }

}
