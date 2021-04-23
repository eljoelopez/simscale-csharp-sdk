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
    /// ManualMeshSizingHexDominantSnappy
    /// </summary>
    [DataContract]
    public partial class ManualMeshSizingHexDominantSnappy : IEquatable<ManualMeshSizingHexDominantSnappy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualMeshSizingHexDominantSnappy" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ManualMeshSizingHexDominantSnappy() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualMeshSizingHexDominantSnappy" /> class.
        /// </summary>
        /// <param name="type">Schema name: ManualMeshSizingHexDominantSnappy (required) (default to &quot;MANUAL&quot;).</param>
        /// <param name="minimumEdgeLength">minimumEdgeLength.</param>
        /// <param name="maximumEdgeLength">maximumEdgeLength.</param>
        public ManualMeshSizingHexDominantSnappy(string type = "MANUAL", DimensionalLength minimumEdgeLength = default(DimensionalLength), DimensionalLength maximumEdgeLength = default(DimensionalLength))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ManualMeshSizingHexDominantSnappy and cannot be null");
            this.MinimumEdgeLength = minimumEdgeLength;
            this.MaximumEdgeLength = maximumEdgeLength;
        }
        
        /// <summary>
        /// Schema name: ManualMeshSizingHexDominantSnappy
        /// </summary>
        /// <value>Schema name: ManualMeshSizingHexDominantSnappy</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets MinimumEdgeLength
        /// </summary>
        [DataMember(Name="minimumEdgeLength", EmitDefaultValue=false)]
        public DimensionalLength MinimumEdgeLength { get; set; }

        /// <summary>
        /// Gets or Sets MaximumEdgeLength
        /// </summary>
        [DataMember(Name="maximumEdgeLength", EmitDefaultValue=false)]
        public DimensionalLength MaximumEdgeLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManualMeshSizingHexDominantSnappy {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MinimumEdgeLength: ").Append(MinimumEdgeLength).Append("\n");
            sb.Append("  MaximumEdgeLength: ").Append(MaximumEdgeLength).Append("\n");
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
            return this.Equals(input as ManualMeshSizingHexDominantSnappy);
        }

        /// <summary>
        /// Returns true if ManualMeshSizingHexDominantSnappy instances are equal
        /// </summary>
        /// <param name="input">Instance of ManualMeshSizingHexDominantSnappy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManualMeshSizingHexDominantSnappy input)
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
                    this.MinimumEdgeLength == input.MinimumEdgeLength ||
                    (this.MinimumEdgeLength != null &&
                    this.MinimumEdgeLength.Equals(input.MinimumEdgeLength))
                ) && 
                (
                    this.MaximumEdgeLength == input.MaximumEdgeLength ||
                    (this.MaximumEdgeLength != null &&
                    this.MaximumEdgeLength.Equals(input.MaximumEdgeLength))
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
                if (this.MinimumEdgeLength != null)
                    hashCode = hashCode * 59 + this.MinimumEdgeLength.GetHashCode();
                if (this.MaximumEdgeLength != null)
                    hashCode = hashCode * 59 + this.MaximumEdgeLength.GetHashCode();
                return hashCode;
            }
        }

    }

}
