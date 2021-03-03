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
    /// Refine specific faces of interest or complex geometrical shapes by defining a local element size. This will ensure a relatively uniform mesh.
    /// </summary>
    [DataContract]
    public partial class SimmetrixLocalSizingRefinement : OneOfSimmetrixMeshingFluidRefinements, OneOfSimmetrixMeshingSolidRefinements, IEquatable<SimmetrixLocalSizingRefinement>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimmetrixLocalSizingRefinement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SimmetrixLocalSizingRefinement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimmetrixLocalSizingRefinement" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;SIMMETRIX_LOCAL_SIZING_V10&quot;).</param>
        /// <param name="name">name (default to &quot;Local element size&quot;).</param>
        /// <param name="maxElementSize">maxElementSize.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        public SimmetrixLocalSizingRefinement(string type = "SIMMETRIX_LOCAL_SIZING_V10", string name = default(string), DimensionalLength maxElementSize = default(DimensionalLength), TopologicalReference topologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for SimmetrixLocalSizingRefinement and cannot be null");
            this.Name = name;
            this.MaxElementSize = maxElementSize;
            this.TopologicalReference = topologicalReference;
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
        /// Gets or Sets MaxElementSize
        /// </summary>
        [DataMember(Name="maxElementSize", EmitDefaultValue=false)]
        public DimensionalLength MaxElementSize { get; set; }

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
            sb.Append("class SimmetrixLocalSizingRefinement {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MaxElementSize: ").Append(MaxElementSize).Append("\n");
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
            return this.Equals(input as SimmetrixLocalSizingRefinement);
        }

        /// <summary>
        /// Returns true if SimmetrixLocalSizingRefinement instances are equal
        /// </summary>
        /// <param name="input">Instance of SimmetrixLocalSizingRefinement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimmetrixLocalSizingRefinement input)
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
                    this.MaxElementSize == input.MaxElementSize ||
                    (this.MaxElementSize != null &&
                    this.MaxElementSize.Equals(input.MaxElementSize))
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
                if (this.MaxElementSize != null)
                    hashCode = hashCode * 59 + this.MaxElementSize.GetHashCode();
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                return hashCode;
            }
        }

    }

}
