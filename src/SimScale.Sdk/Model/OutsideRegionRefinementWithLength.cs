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
    /// OutsideRegionRefinementWithLength
    /// </summary>
    [DataContract]
    public partial class OutsideRegionRefinementWithLength : OneOfRegionRefinementWithLengthRefinement, IEquatable<OutsideRegionRefinementWithLength>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutsideRegionRefinementWithLength" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OutsideRegionRefinementWithLength() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutsideRegionRefinementWithLength" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;OUTSIDE&quot;).</param>
        /// <param name="length">length.</param>
        public OutsideRegionRefinementWithLength(string type = "OUTSIDE", DimensionalLength length = default(DimensionalLength))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for OutsideRegionRefinementWithLength and cannot be null");
            this.Length = length;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public DimensionalLength Length { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutsideRegionRefinementWithLength {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
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
            return this.Equals(input as OutsideRegionRefinementWithLength);
        }

        /// <summary>
        /// Returns true if OutsideRegionRefinementWithLength instances are equal
        /// </summary>
        /// <param name="input">Instance of OutsideRegionRefinementWithLength to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutsideRegionRefinementWithLength input)
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
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
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
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                return hashCode;
            }
        }

    }

}
