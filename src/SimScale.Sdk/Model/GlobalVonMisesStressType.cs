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
    /// GlobalVonMisesStressType
    /// </summary>
    [DataContract]
    public partial class GlobalVonMisesStressType : OneOfStressResultControlItemStressType, IEquatable<GlobalVonMisesStressType>
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
            REALANDIMAGINARY = 1

        }

        /// <summary>
        /// Gets or Sets ComplexNumber
        /// </summary>
        [DataMember(Name="complexNumber", EmitDefaultValue=false)]
        public ComplexNumberEnum? ComplexNumber { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalVonMisesStressType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GlobalVonMisesStressType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalVonMisesStressType" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;VON_MISES&quot;).</param>
        /// <param name="complexNumber">complexNumber (default to ComplexNumberEnum.REALANDIMAGINARY).</param>
        public GlobalVonMisesStressType(string type = "VON_MISES", ComplexNumberEnum? complexNumber = default(ComplexNumberEnum?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for GlobalVonMisesStressType and cannot be null");
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
            sb.Append("class GlobalVonMisesStressType {\n");
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
            return this.Equals(input as GlobalVonMisesStressType);
        }

        /// <summary>
        /// Returns true if GlobalVonMisesStressType instances are equal
        /// </summary>
        /// <param name="input">Instance of GlobalVonMisesStressType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlobalVonMisesStressType input)
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
