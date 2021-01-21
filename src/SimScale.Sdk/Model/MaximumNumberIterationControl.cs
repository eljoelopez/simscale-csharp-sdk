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
    /// MaximumNumberIterationControl
    /// </summary>
    [DataContract]
    public partial class MaximumNumberIterationControl : OneOfFixedPointContactNonLinearityResolutionIterationControl, IEquatable<MaximumNumberIterationControl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaximumNumberIterationControl" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MaximumNumberIterationControl() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MaximumNumberIterationControl" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;MAXIMUM_NUMBER&quot;).</param>
        /// <param name="maxNumIteration">maxNumIteration (default to 30).</param>
        public MaximumNumberIterationControl(string type = "MAXIMUM_NUMBER", int? maxNumIteration = default(int?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for MaximumNumberIterationControl and cannot be null");
            this.MaxNumIteration = maxNumIteration;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets MaxNumIteration
        /// </summary>
        [DataMember(Name="maxNumIteration", EmitDefaultValue=false)]
        public int? MaxNumIteration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaximumNumberIterationControl {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MaxNumIteration: ").Append(MaxNumIteration).Append("\n");
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
            return this.Equals(input as MaximumNumberIterationControl);
        }

        /// <summary>
        /// Returns true if MaximumNumberIterationControl instances are equal
        /// </summary>
        /// <param name="input">Instance of MaximumNumberIterationControl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaximumNumberIterationControl input)
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
                    this.MaxNumIteration == input.MaxNumIteration ||
                    (this.MaxNumIteration != null &&
                    this.MaxNumIteration.Equals(input.MaxNumIteration))
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
                if (this.MaxNumIteration != null)
                    hashCode = hashCode * 59 + this.MaxNumIteration.GetHashCode();
                return hashCode;
            }
        }

    }

}
