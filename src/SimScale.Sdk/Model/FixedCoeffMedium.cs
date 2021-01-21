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
    /// FixedCoeffMedium
    /// </summary>
    [DataContract]
    public partial class FixedCoeffMedium : OneOfAdvancedConceptsPorousMediums, IEquatable<FixedCoeffMedium>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedCoeffMedium" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FixedCoeffMedium() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedCoeffMedium" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;FIXED_COEFFICIENTS&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="alpha">alpha.</param>
        /// <param name="beta">beta.</param>
        /// <param name="referenceDensity">referenceDensity.</param>
        /// <param name="orientation">orientation.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        /// <param name="geometryPrimitiveUuids">geometryPrimitiveUuids.</param>
        public FixedCoeffMedium(string type = "FIXED_COEFFICIENTS", string name = default(string), DimensionalVectorSpecificTurbulenceDissipationRate alpha = default(DimensionalVectorSpecificTurbulenceDissipationRate), DimensionalVectorAbsorptivity beta = default(DimensionalVectorAbsorptivity), DimensionalDensity referenceDensity = default(DimensionalDensity), OneOfFixedCoeffMediumOrientation orientation = default(OneOfFixedCoeffMediumOrientation), TopologicalReference topologicalReference = default(TopologicalReference), List<Guid?> geometryPrimitiveUuids = default(List<Guid?>))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for FixedCoeffMedium and cannot be null");
            this.Name = name;
            this.Alpha = alpha;
            this.Beta = beta;
            this.ReferenceDensity = referenceDensity;
            this.Orientation = orientation;
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
        /// Gets or Sets Alpha
        /// </summary>
        [DataMember(Name="alpha", EmitDefaultValue=false)]
        public DimensionalVectorSpecificTurbulenceDissipationRate Alpha { get; set; }

        /// <summary>
        /// Gets or Sets Beta
        /// </summary>
        [DataMember(Name="beta", EmitDefaultValue=false)]
        public DimensionalVectorAbsorptivity Beta { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceDensity
        /// </summary>
        [DataMember(Name="referenceDensity", EmitDefaultValue=false)]
        public DimensionalDensity ReferenceDensity { get; set; }

        /// <summary>
        /// Gets or Sets Orientation
        /// </summary>
        [DataMember(Name="orientation", EmitDefaultValue=false)]
        public OneOfFixedCoeffMediumOrientation Orientation { get; set; }

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
            sb.Append("class FixedCoeffMedium {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Alpha: ").Append(Alpha).Append("\n");
            sb.Append("  Beta: ").Append(Beta).Append("\n");
            sb.Append("  ReferenceDensity: ").Append(ReferenceDensity).Append("\n");
            sb.Append("  Orientation: ").Append(Orientation).Append("\n");
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
            return this.Equals(input as FixedCoeffMedium);
        }

        /// <summary>
        /// Returns true if FixedCoeffMedium instances are equal
        /// </summary>
        /// <param name="input">Instance of FixedCoeffMedium to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FixedCoeffMedium input)
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
                    this.Alpha == input.Alpha ||
                    (this.Alpha != null &&
                    this.Alpha.Equals(input.Alpha))
                ) && 
                (
                    this.Beta == input.Beta ||
                    (this.Beta != null &&
                    this.Beta.Equals(input.Beta))
                ) && 
                (
                    this.ReferenceDensity == input.ReferenceDensity ||
                    (this.ReferenceDensity != null &&
                    this.ReferenceDensity.Equals(input.ReferenceDensity))
                ) && 
                (
                    this.Orientation == input.Orientation ||
                    (this.Orientation != null &&
                    this.Orientation.Equals(input.Orientation))
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
                if (this.Alpha != null)
                    hashCode = hashCode * 59 + this.Alpha.GetHashCode();
                if (this.Beta != null)
                    hashCode = hashCode * 59 + this.Beta.GetHashCode();
                if (this.ReferenceDensity != null)
                    hashCode = hashCode * 59 + this.ReferenceDensity.GetHashCode();
                if (this.Orientation != null)
                    hashCode = hashCode * 59 + this.Orientation.GetHashCode();
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                if (this.GeometryPrimitiveUuids != null)
                    hashCode = hashCode * 59 + this.GeometryPrimitiveUuids.GetHashCode();
                return hashCode;
            }
        }

    }

}
