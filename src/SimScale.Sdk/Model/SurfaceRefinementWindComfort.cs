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
    /// SurfaceRefinementWindComfort
    /// </summary>
    [DataContract]
    public partial class SurfaceRefinementWindComfort : OneOfWindComfortMeshRefinements, IEquatable<SurfaceRefinementWindComfort>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceRefinementWindComfort" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SurfaceRefinementWindComfort() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceRefinementWindComfort" /> class.
        /// </summary>
        /// <param name="type">Schema name: SurfaceRefinementWindComfort (required) (default to &quot;SURFACE_REFINEMENT_WIND_COMFORT&quot;).</param>
        /// <param name="name">name (default to &quot;Surface refinement&quot;).</param>
        /// <param name="newFineness">newFineness.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        public SurfaceRefinementWindComfort(string type = "SURFACE_REFINEMENT_WIND_COMFORT", string name = default(string), OneOfSurfaceRefinementWindComfortNewFineness newFineness = default(OneOfSurfaceRefinementWindComfortNewFineness), TopologicalReference topologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for SurfaceRefinementWindComfort and cannot be null");
            this.Name = name;
            this.NewFineness = newFineness;
            this.TopologicalReference = topologicalReference;
        }
        
        /// <summary>
        /// Schema name: SurfaceRefinementWindComfort
        /// </summary>
        /// <value>Schema name: SurfaceRefinementWindComfort</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NewFineness
        /// </summary>
        [DataMember(Name="newFineness", EmitDefaultValue=false)]
        public OneOfSurfaceRefinementWindComfortNewFineness NewFineness { get; set; }

        /// <summary>
        /// Gets or Sets TopologicalReference
        /// </summary>
        [DataMember(Name="topologicalReference", EmitDefaultValue=false)]
        public TopologicalReference TopologicalReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SurfaceRefinementWindComfort {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NewFineness: ").Append(NewFineness).Append("\n");
            sb.Append("  TopologicalReference: ").Append(TopologicalReference).Append("\n");
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
            return this.Equals(input as SurfaceRefinementWindComfort);
        }

        /// <summary>
        /// Returns true if SurfaceRefinementWindComfort instances are equal
        /// </summary>
        /// <param name="input">Instance of SurfaceRefinementWindComfort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SurfaceRefinementWindComfort input)
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
                    this.NewFineness == input.NewFineness ||
                    (this.NewFineness != null &&
                    this.NewFineness.Equals(input.NewFineness))
                ) && 
                (
                    this.TopologicalReference == input.TopologicalReference ||
                    (this.TopologicalReference != null &&
                    this.TopologicalReference.Equals(input.TopologicalReference))
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
                if (this.NewFineness != null)
                    hashCode = hashCode * 59 + this.NewFineness.GetHashCode();
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                return hashCode;
            }
        }

    }

}
