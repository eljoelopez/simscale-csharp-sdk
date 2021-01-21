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
    /// SpecificPassiveScalarSource
    /// </summary>
    [DataContract]
    public partial class SpecificPassiveScalarSource : OneOfAdvancedConceptsPassiveScalarSources, IEquatable<SpecificPassiveScalarSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecificPassiveScalarSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SpecificPassiveScalarSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecificPassiveScalarSource" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;SPECIFIC&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="passiveScalarVariable">passiveScalarVariable.</param>
        /// <param name="flux">flux.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        /// <param name="geometryPrimitiveUuids">geometryPrimitiveUuids.</param>
        public SpecificPassiveScalarSource(string type = "SPECIFIC", string name = default(string), string passiveScalarVariable = default(string), DimensionalVolumetricPassiveScalarSourceRate flux = default(DimensionalVolumetricPassiveScalarSourceRate), TopologicalReference topologicalReference = default(TopologicalReference), List<Guid?> geometryPrimitiveUuids = default(List<Guid?>))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for SpecificPassiveScalarSource and cannot be null");
            this.Name = name;
            this.PassiveScalarVariable = passiveScalarVariable;
            this.Flux = flux;
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
        /// Gets or Sets PassiveScalarVariable
        /// </summary>
        [DataMember(Name="passiveScalarVariable", EmitDefaultValue=false)]
        public string PassiveScalarVariable { get; set; }

        /// <summary>
        /// Gets or Sets Flux
        /// </summary>
        [DataMember(Name="flux", EmitDefaultValue=false)]
        public DimensionalVolumetricPassiveScalarSourceRate Flux { get; set; }

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
            sb.Append("class SpecificPassiveScalarSource {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PassiveScalarVariable: ").Append(PassiveScalarVariable).Append("\n");
            sb.Append("  Flux: ").Append(Flux).Append("\n");
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
            return this.Equals(input as SpecificPassiveScalarSource);
        }

        /// <summary>
        /// Returns true if SpecificPassiveScalarSource instances are equal
        /// </summary>
        /// <param name="input">Instance of SpecificPassiveScalarSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpecificPassiveScalarSource input)
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
                    this.PassiveScalarVariable == input.PassiveScalarVariable ||
                    (this.PassiveScalarVariable != null &&
                    this.PassiveScalarVariable.Equals(input.PassiveScalarVariable))
                ) && 
                (
                    this.Flux == input.Flux ||
                    (this.Flux != null &&
                    this.Flux.Equals(input.Flux))
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
                if (this.PassiveScalarVariable != null)
                    hashCode = hashCode * 59 + this.PassiveScalarVariable.GetHashCode();
                if (this.Flux != null)
                    hashCode = hashCode * 59 + this.Flux.GetHashCode();
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                if (this.GeometryPrimitiveUuids != null)
                    hashCode = hashCode * 59 + this.GeometryPrimitiveUuids.GetHashCode();
                return hashCode;
            }
        }

    }

}
