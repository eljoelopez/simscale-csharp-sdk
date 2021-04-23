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
    /// FixedPointFrictionNonLinearityResolution
    /// </summary>
    [DataContract]
    public partial class FixedPointFrictionNonLinearityResolution : OneOfCoulombFrictionNonlinearityResolution, IEquatable<FixedPointFrictionNonLinearityResolution>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedPointFrictionNonLinearityResolution" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FixedPointFrictionNonLinearityResolution() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedPointFrictionNonLinearityResolution" /> class.
        /// </summary>
        /// <param name="type">Schema name: FixedPointFrictionNonLinearityResolution (required) (default to &quot;FIXED_POINT&quot;).</param>
        /// <param name="maxNumIteration">maxNumIteration (default to 10).</param>
        /// <param name="iterationCriterion">iterationCriterion (default to 0.00010M).</param>
        public FixedPointFrictionNonLinearityResolution(string type = "FIXED_POINT", int? maxNumIteration = default(int?), decimal? iterationCriterion = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for FixedPointFrictionNonLinearityResolution and cannot be null");
            this.MaxNumIteration = maxNumIteration;
            this.IterationCriterion = iterationCriterion;
        }
        
        /// <summary>
        /// Schema name: FixedPointFrictionNonLinearityResolution
        /// </summary>
        /// <value>Schema name: FixedPointFrictionNonLinearityResolution</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets MaxNumIteration
        /// </summary>
        [DataMember(Name="maxNumIteration", EmitDefaultValue=false)]
        public int? MaxNumIteration { get; set; }

        /// <summary>
        /// Gets or Sets IterationCriterion
        /// </summary>
        [DataMember(Name="iterationCriterion", EmitDefaultValue=false)]
        public decimal? IterationCriterion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FixedPointFrictionNonLinearityResolution {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MaxNumIteration: ").Append(MaxNumIteration).Append("\n");
            sb.Append("  IterationCriterion: ").Append(IterationCriterion).Append("\n");
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
            return this.Equals(input as FixedPointFrictionNonLinearityResolution);
        }

        /// <summary>
        /// Returns true if FixedPointFrictionNonLinearityResolution instances are equal
        /// </summary>
        /// <param name="input">Instance of FixedPointFrictionNonLinearityResolution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FixedPointFrictionNonLinearityResolution input)
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
                ) && 
                (
                    this.IterationCriterion == input.IterationCriterion ||
                    (this.IterationCriterion != null &&
                    this.IterationCriterion.Equals(input.IterationCriterion))
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
                if (this.IterationCriterion != null)
                    hashCode = hashCode * 59 + this.IterationCriterion.GetHashCode();
                return hashCode;
            }
        }

    }

}
