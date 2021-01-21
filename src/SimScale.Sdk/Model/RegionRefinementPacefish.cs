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
    /// RegionRefinementPacefish
    /// </summary>
    [DataContract]
    public partial class RegionRefinementPacefish : OneOfPacefishMeshLegacyRefinements, IEquatable<RegionRefinementPacefish>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionRefinementPacefish" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RegionRefinementPacefish() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionRefinementPacefish" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;REGION_PACEFISH&quot;).</param>
        /// <param name="name">name (default to &quot;Region refinement&quot;).</param>
        /// <param name="targetResolution">targetResolution.</param>
        /// <param name="geometryPrimitiveUuids">geometryPrimitiveUuids.</param>
        public RegionRefinementPacefish(string type = "REGION_PACEFISH", string name = default(string), DimensionalLength targetResolution = default(DimensionalLength), List<Guid?> geometryPrimitiveUuids = default(List<Guid?>))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for RegionRefinementPacefish and cannot be null");
            this.Name = name;
            this.TargetResolution = targetResolution;
            this.GeometryPrimitiveUuids = geometryPrimitiveUuids;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TargetResolution
        /// </summary>
        [DataMember(Name="targetResolution", EmitDefaultValue=false)]
        public DimensionalLength TargetResolution { get; set; }

        /// <summary>
        /// Gets or Sets GeometryPrimitiveUuids
        /// </summary>
        [DataMember(Name="geometryPrimitiveUuids", EmitDefaultValue=false)]
        public List<Guid?> GeometryPrimitiveUuids { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegionRefinementPacefish {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TargetResolution: ").Append(TargetResolution).Append("\n");
            sb.Append("  GeometryPrimitiveUuids: ").Append(GeometryPrimitiveUuids).Append("\n");
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
            return this.Equals(input as RegionRefinementPacefish);
        }

        /// <summary>
        /// Returns true if RegionRefinementPacefish instances are equal
        /// </summary>
        /// <param name="input">Instance of RegionRefinementPacefish to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegionRefinementPacefish input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TargetResolution == input.TargetResolution ||
                    (this.TargetResolution != null &&
                    this.TargetResolution.Equals(input.TargetResolution))
                ) && 
                (
                    this.GeometryPrimitiveUuids == input.GeometryPrimitiveUuids ||
                    this.GeometryPrimitiveUuids != null &&
                    input.GeometryPrimitiveUuids != null &&
                    this.GeometryPrimitiveUuids.SequenceEqual(input.GeometryPrimitiveUuids)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TargetResolution != null)
                    hashCode = hashCode * 59 + this.TargetResolution.GetHashCode();
                if (this.GeometryPrimitiveUuids != null)
                    hashCode = hashCode * 59 + this.GeometryPrimitiveUuids.GetHashCode();
                return hashCode;
            }
        }

    }

}
