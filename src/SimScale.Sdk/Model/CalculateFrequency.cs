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
    /// CalculateFrequency
    /// </summary>
    [DataContract]
    public partial class CalculateFrequency : IEquatable<CalculateFrequency>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateFrequency" /> class.
        /// </summary>
        /// <param name="precShift">precShift (default to 0.05M).</param>
        /// <param name="maxIterShift">maxIterShift (default to 3).</param>
        /// <param name="thresholdFrequency">thresholdFrequency (default to 0.01M).</param>
        public CalculateFrequency(decimal? precShift = default(decimal?), int? maxIterShift = default(int?), decimal? thresholdFrequency = default(decimal?))
        {
            this.PrecShift = precShift;
            this.MaxIterShift = maxIterShift;
            this.ThresholdFrequency = thresholdFrequency;
        }
        
        /// <summary>
        /// Gets or Sets PrecShift
        /// </summary>
        [DataMember(Name="precShift", EmitDefaultValue=false)]
        public decimal? PrecShift { get; set; }

        /// <summary>
        /// Gets or Sets MaxIterShift
        /// </summary>
        [DataMember(Name="maxIterShift", EmitDefaultValue=false)]
        public int? MaxIterShift { get; set; }

        /// <summary>
        /// Gets or Sets ThresholdFrequency
        /// </summary>
        [DataMember(Name="thresholdFrequency", EmitDefaultValue=false)]
        public decimal? ThresholdFrequency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CalculateFrequency {\n");
            sb.Append("  PrecShift: ").Append(PrecShift).Append("\n");
            sb.Append("  MaxIterShift: ").Append(MaxIterShift).Append("\n");
            sb.Append("  ThresholdFrequency: ").Append(ThresholdFrequency).Append("\n");
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
            return this.Equals(input as CalculateFrequency);
        }

        /// <summary>
        /// Returns true if CalculateFrequency instances are equal
        /// </summary>
        /// <param name="input">Instance of CalculateFrequency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalculateFrequency input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrecShift == input.PrecShift ||
                    (this.PrecShift != null &&
                    this.PrecShift.Equals(input.PrecShift))
                ) && 
                (
                    this.MaxIterShift == input.MaxIterShift ||
                    (this.MaxIterShift != null &&
                    this.MaxIterShift.Equals(input.MaxIterShift))
                ) && 
                (
                    this.ThresholdFrequency == input.ThresholdFrequency ||
                    (this.ThresholdFrequency != null &&
                    this.ThresholdFrequency.Equals(input.ThresholdFrequency))
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
                if (this.PrecShift != null)
                    hashCode = hashCode * 59 + this.PrecShift.GetHashCode();
                if (this.MaxIterShift != null)
                    hashCode = hashCode * 59 + this.MaxIterShift.GetHashCode();
                if (this.ThresholdFrequency != null)
                    hashCode = hashCode * 59 + this.ThresholdFrequency.GetHashCode();
                return hashCode;
            }
        }

    }

}
