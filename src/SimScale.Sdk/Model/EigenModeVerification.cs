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
    /// EigenModeVerification
    /// </summary>
    [DataContract]
    public partial class EigenModeVerification : IEquatable<EigenModeVerification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EigenModeVerification" /> class.
        /// </summary>
        /// <param name="stopError">stopError (default to false).</param>
        /// <param name="threshold">threshold (default to 0.0000010M).</param>
        /// <param name="precisionShift">precisionShift (default to 0.05M).</param>
        public EigenModeVerification(bool? stopError = default(bool?), decimal? threshold = default(decimal?), decimal? precisionShift = default(decimal?))
        {
            this.StopError = stopError;
            this.Threshold = threshold;
            this.PrecisionShift = precisionShift;
        }
        
        /// <summary>
        /// Gets or Sets StopError
        /// </summary>
        [DataMember(Name="stopError", EmitDefaultValue=false)]
        public bool? StopError { get; set; }

        /// <summary>
        /// Gets or Sets Threshold
        /// </summary>
        [DataMember(Name="threshold", EmitDefaultValue=false)]
        public decimal? Threshold { get; set; }

        /// <summary>
        /// Gets or Sets PrecisionShift
        /// </summary>
        [DataMember(Name="precisionShift", EmitDefaultValue=false)]
        public decimal? PrecisionShift { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EigenModeVerification {\n");
            sb.Append("  StopError: ").Append(StopError).Append("\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
            sb.Append("  PrecisionShift: ").Append(PrecisionShift).Append("\n");
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
            return this.Equals(input as EigenModeVerification);
        }

        /// <summary>
        /// Returns true if EigenModeVerification instances are equal
        /// </summary>
        /// <param name="input">Instance of EigenModeVerification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EigenModeVerification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StopError == input.StopError ||
                    (this.StopError != null &&
                    this.StopError.Equals(input.StopError))
                ) && 
                (
                    this.Threshold == input.Threshold ||
                    (this.Threshold != null &&
                    this.Threshold.Equals(input.Threshold))
                ) && 
                (
                    this.PrecisionShift == input.PrecisionShift ||
                    (this.PrecisionShift != null &&
                    this.PrecisionShift.Equals(input.PrecisionShift))
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
                if (this.StopError != null)
                    hashCode = hashCode * 59 + this.StopError.GetHashCode();
                if (this.Threshold != null)
                    hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.PrecisionShift != null)
                    hashCode = hashCode * 59 + this.PrecisionShift.GetHashCode();
                return hashCode;
            }
        }

    }

}
