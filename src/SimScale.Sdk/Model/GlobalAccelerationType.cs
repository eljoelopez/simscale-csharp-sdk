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
    /// GlobalAccelerationType
    /// </summary>
    [DataContract]
    public partial class GlobalAccelerationType : IEquatable<GlobalAccelerationType>
    {
        /// <summary>
        /// Defines ComplexNumber
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ComplexNumberEnum
        {
            /// <summary>
            /// Enum REALANDIMAGINARY for value: REAL_AND_IMAGINARY
            /// </summary>
            [EnumMember(Value = "REAL_AND_IMAGINARY")]
            REALANDIMAGINARY = 1,

            /// <summary>
            /// Enum MAGNITUDEANDPHASE for value: MAGNITUDE_AND_PHASE
            /// </summary>
            [EnumMember(Value = "MAGNITUDE_AND_PHASE")]
            MAGNITUDEANDPHASE = 2

        }

        /// <summary>
        /// Gets or Sets ComplexNumber
        /// </summary>
        [DataMember(Name="complexNumber", EmitDefaultValue=false)]
        public ComplexNumberEnum? ComplexNumber { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalAccelerationType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GlobalAccelerationType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalAccelerationType" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;GLOBAL&quot;).</param>
        /// <param name="complexNumber">complexNumber (default to ComplexNumberEnum.REALANDIMAGINARY).</param>
        public GlobalAccelerationType(string type = "GLOBAL", ComplexNumberEnum? complexNumber = default(ComplexNumberEnum?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for GlobalAccelerationType and cannot be null");
            this.ComplexNumber = complexNumber;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlobalAccelerationType {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ComplexNumber: ").Append(ComplexNumber).Append("\n");
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
            return this.Equals(input as GlobalAccelerationType);
        }

        /// <summary>
        /// Returns true if GlobalAccelerationType instances are equal
        /// </summary>
        /// <param name="input">Instance of GlobalAccelerationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlobalAccelerationType input)
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
                    this.ComplexNumber == input.ComplexNumber ||
                    this.ComplexNumber.Equals(input.ComplexNumber)
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
                hashCode = hashCode * 59 + this.ComplexNumber.GetHashCode();
                return hashCode;
            }
        }

    }

}
