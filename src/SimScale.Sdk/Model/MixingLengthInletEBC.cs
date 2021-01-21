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
    /// MixingLengthInletEBC
    /// </summary>
    [DataContract]
    public partial class MixingLengthInletEBC : OneOfCustomFluidBCEpsilonDissipationRate, IEquatable<MixingLengthInletEBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MixingLengthInletEBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MixingLengthInletEBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MixingLengthInletEBC" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;TURBULENCE_MIXING_LENGTH_DISSIPATION_RATE_INLET&quot;).</param>
        /// <param name="mixingLength">mixingLength.</param>
        public MixingLengthInletEBC(string type = "TURBULENCE_MIXING_LENGTH_DISSIPATION_RATE_INLET", DimensionalLength mixingLength = default(DimensionalLength))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for MixingLengthInletEBC and cannot be null");
            this.MixingLength = mixingLength;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets MixingLength
        /// </summary>
        [DataMember(Name="mixingLength", EmitDefaultValue=false)]
        public DimensionalLength MixingLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MixingLengthInletEBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MixingLength: ").Append(MixingLength).Append("\n");
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
            return this.Equals(input as MixingLengthInletEBC);
        }

        /// <summary>
        /// Returns true if MixingLengthInletEBC instances are equal
        /// </summary>
        /// <param name="input">Instance of MixingLengthInletEBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MixingLengthInletEBC input)
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
                    this.MixingLength == input.MixingLength ||
                    (this.MixingLength != null &&
                    this.MixingLength.Equals(input.MixingLength))
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
                if (this.MixingLength != null)
                    hashCode = hashCode * 59 + this.MixingLength.GetHashCode();
                return hashCode;
            }
        }

    }

}
