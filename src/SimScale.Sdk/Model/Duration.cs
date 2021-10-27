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
    /// An interval with the estimated duration for a simulation run or a mesh operation.
    /// </summary>
    [DataContract]
    public partial class Duration : IEquatable<Duration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Duration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Duration()
        {
        }
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; private set; }

        /// <summary>
        /// Gets or Sets IntervalMin
        /// </summary>
        [DataMember(Name="intervalMin", EmitDefaultValue=false)]
        public string IntervalMin { get; private set; }

        /// <summary>
        /// Gets or Sets IntervalMax
        /// </summary>
        [DataMember(Name="intervalMax", EmitDefaultValue=false)]
        public string IntervalMax { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Duration {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  IntervalMin: ").Append(IntervalMin).Append("\n");
            sb.Append("  IntervalMax: ").Append(IntervalMax).Append("\n");
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
            return this.Equals(input as Duration);
        }

        /// <summary>
        /// Returns true if Duration instances are equal
        /// </summary>
        /// <param name="input">Instance of Duration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Duration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.IntervalMin == input.IntervalMin ||
                    (this.IntervalMin != null &&
                    this.IntervalMin.Equals(input.IntervalMin))
                ) && 
                (
                    this.IntervalMax == input.IntervalMax ||
                    (this.IntervalMax != null &&
                    this.IntervalMax.Equals(input.IntervalMax))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.IntervalMin != null)
                    hashCode = hashCode * 59 + this.IntervalMin.GetHashCode();
                if (this.IntervalMax != null)
                    hashCode = hashCode * 59 + this.IntervalMax.GetHashCode();
                return hashCode;
            }
        }

    }

}
