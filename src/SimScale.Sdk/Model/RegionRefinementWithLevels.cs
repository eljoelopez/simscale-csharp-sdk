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
    /// A &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/meshing/hex-dominant/#region-refinement&#39; target&#x3D;&#39;_blank&#39;&gt;&lt;b&gt;region refinement&lt;/b&gt;&lt;/a&gt; can be used to refine the mesh in a given area. The refinement area needs to be defined either via a geometry primitive or an existing solid (Hex-dominant only).
    /// </summary>
    [DataContract]
    public partial class RegionRefinementWithLevels : IEquatable<RegionRefinementWithLevels>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionRefinementWithLevels" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RegionRefinementWithLevels() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionRefinementWithLevels" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;REGION_LEVELS&quot;).</param>
        /// <param name="name">name (default to &quot;Region refinement&quot;).</param>
        /// <param name="refinement">refinement.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        /// <param name="geometryPrimitiveUuids">geometryPrimitiveUuids.</param>
        public RegionRefinementWithLevels(string type = "REGION_LEVELS", string name = default(string), OneOfRegionRefinementWithLevelsRefinement refinement = default(OneOfRegionRefinementWithLevelsRefinement), TopologicalReference topologicalReference = default(TopologicalReference), List<Guid?> geometryPrimitiveUuids = default(List<Guid?>))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for RegionRefinementWithLevels and cannot be null");
            this.Name = name;
            this.Refinement = refinement;
            this.TopologicalReference = topologicalReference;
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
        /// Gets or Sets Refinement
        /// </summary>
        [DataMember(Name="refinement", EmitDefaultValue=false)]
        public OneOfRegionRefinementWithLevelsRefinement Refinement { get; set; }

        /// <summary>
        /// Gets or Sets TopologicalReference
        /// </summary>
        [DataMember(Name="topologicalReference", EmitDefaultValue=false)]
        public TopologicalReference TopologicalReference { get; set; }

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
            sb.Append("class RegionRefinementWithLevels {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Refinement: ").Append(Refinement).Append("\n");
            sb.Append("  TopologicalReference: ").Append(TopologicalReference).Append("\n");
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
            return this.Equals(input as RegionRefinementWithLevels);
        }

        /// <summary>
        /// Returns true if RegionRefinementWithLevels instances are equal
        /// </summary>
        /// <param name="input">Instance of RegionRefinementWithLevels to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegionRefinementWithLevels input)
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
                    this.Refinement == input.Refinement ||
                    (this.Refinement != null &&
                    this.Refinement.Equals(input.Refinement))
                ) && 
                (
                    this.TopologicalReference == input.TopologicalReference ||
                    (this.TopologicalReference != null &&
                    this.TopologicalReference.Equals(input.TopologicalReference))
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
                if (this.Refinement != null)
                    hashCode = hashCode * 59 + this.Refinement.GetHashCode();
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                if (this.GeometryPrimitiveUuids != null)
                    hashCode = hashCode * 59 + this.GeometryPrimitiveUuids.GetHashCode();
                return hashCode;
            }
        }

    }

}
