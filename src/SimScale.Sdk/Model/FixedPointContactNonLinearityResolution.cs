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
    /// FixedPointContactNonLinearityResolution
    /// </summary>
    [DataContract]
    public partial class FixedPointContactNonLinearityResolution : OneOfConnectionSettingsV36ContactNonLinearityResolution, IEquatable<FixedPointContactNonLinearityResolution>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedPointContactNonLinearityResolution" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FixedPointContactNonLinearityResolution() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedPointContactNonLinearityResolution" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;FIXED_POINT&quot;).</param>
        /// <param name="iterationControl">iterationControl.</param>
        public FixedPointContactNonLinearityResolution(string type = "FIXED_POINT", OneOfFixedPointContactNonLinearityResolutionIterationControl iterationControl = default(OneOfFixedPointContactNonLinearityResolutionIterationControl))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for FixedPointContactNonLinearityResolution and cannot be null");
            this.IterationControl = iterationControl;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets IterationControl
        /// </summary>
        [DataMember(Name="iterationControl", EmitDefaultValue=false)]
        public OneOfFixedPointContactNonLinearityResolutionIterationControl IterationControl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FixedPointContactNonLinearityResolution {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IterationControl: ").Append(IterationControl).Append("\n");
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
            return this.Equals(input as FixedPointContactNonLinearityResolution);
        }

        /// <summary>
        /// Returns true if FixedPointContactNonLinearityResolution instances are equal
        /// </summary>
        /// <param name="input">Instance of FixedPointContactNonLinearityResolution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FixedPointContactNonLinearityResolution input)
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
                    this.IterationControl == input.IterationControl ||
                    (this.IterationControl != null &&
                    this.IterationControl.Equals(input.IterationControl))
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
                if (this.IterationControl != null)
                    hashCode = hashCode * 59 + this.IterationControl.GetHashCode();
                return hashCode;
            }
        }

    }

}
