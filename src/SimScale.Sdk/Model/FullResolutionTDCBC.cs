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
    /// FullResolutionTDCBC
    /// </summary>
    [DataContract]
    public partial class FullResolutionTDCBC : OneOfCustomFluidBCTurbulentThermalDiffusivityCompressible, IEquatable<FullResolutionTDCBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FullResolutionTDCBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FullResolutionTDCBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FullResolutionTDCBC" /> class.
        /// </summary>
        /// <param name="type">Schema name: FullResolutionTDCBC (required) (default to &quot;FULL_RESOLUTION&quot;).</param>
        /// <param name="prandtlNumber">prandtlNumber (default to 0.85M).</param>
        public FullResolutionTDCBC(string type = "FULL_RESOLUTION", decimal? prandtlNumber = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for FullResolutionTDCBC and cannot be null");
            this.PrandtlNumber = prandtlNumber;
        }
        
        /// <summary>
        /// Schema name: FullResolutionTDCBC
        /// </summary>
        /// <value>Schema name: FullResolutionTDCBC</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets PrandtlNumber
        /// </summary>
        [DataMember(Name="prandtlNumber", EmitDefaultValue=false)]
        public decimal? PrandtlNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullResolutionTDCBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  PrandtlNumber: ").Append(PrandtlNumber).Append("\n");
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
            return this.Equals(input as FullResolutionTDCBC);
        }

        /// <summary>
        /// Returns true if FullResolutionTDCBC instances are equal
        /// </summary>
        /// <param name="input">Instance of FullResolutionTDCBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FullResolutionTDCBC input)
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
                    this.PrandtlNumber == input.PrandtlNumber ||
                    (this.PrandtlNumber != null &&
                    this.PrandtlNumber.Equals(input.PrandtlNumber))
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
                if (this.PrandtlNumber != null)
                    hashCode = hashCode * 59 + this.PrandtlNumber.GetHashCode();
                return hashCode;
            }
        }

    }

}
