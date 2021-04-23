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
    /// PacefishMeshV38
    /// </summary>
    [DataContract]
    public partial class PacefishMeshV38 : OneOfIncompressiblePacefishMeshSettingsNew, IEquatable<PacefishMeshV38>
    {
        /// <summary>
        /// Defines Fineness
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FinenessEnum
        {
            /// <summary>
            /// Enum VERYCOARSE for value: VERY_COARSE
            /// </summary>
            [EnumMember(Value = "VERY_COARSE")]
            VERYCOARSE = 1,

            /// <summary>
            /// Enum COARSE for value: COARSE
            /// </summary>
            [EnumMember(Value = "COARSE")]
            COARSE = 2,

            /// <summary>
            /// Enum MODERATE for value: MODERATE
            /// </summary>
            [EnumMember(Value = "MODERATE")]
            MODERATE = 3,

            /// <summary>
            /// Enum FINE for value: FINE
            /// </summary>
            [EnumMember(Value = "FINE")]
            FINE = 4,

            /// <summary>
            /// Enum VERYFINE for value: VERY_FINE
            /// </summary>
            [EnumMember(Value = "VERY_FINE")]
            VERYFINE = 5

        }

        /// <summary>
        /// Gets or Sets Fineness
        /// </summary>
        [DataMember(Name="fineness", EmitDefaultValue=false)]
        public FinenessEnum? Fineness { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PacefishMeshV38" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PacefishMeshV38() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PacefishMeshV38" /> class.
        /// </summary>
        /// <param name="type">Schema name: PacefishMeshV38 (required) (default to &quot;PACEFISH_MESH_V38&quot;).</param>
        /// <param name="fineness">fineness (default to FinenessEnum.COARSE).</param>
        /// <param name="referenceLength">referenceLength.</param>
        /// <param name="primaryTopology">primaryTopology.</param>
        /// <param name="refinements">refinements.</param>
        public PacefishMeshV38(string type = "PACEFISH_MESH_V38", FinenessEnum? fineness = default(FinenessEnum?), DimensionalLength referenceLength = default(DimensionalLength), OneOfPacefishMeshV38PrimaryTopology primaryTopology = default(OneOfPacefishMeshV38PrimaryTopology), List<OneOfPacefishMeshV38Refinements> refinements = default(List<OneOfPacefishMeshV38Refinements>))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for PacefishMeshV38 and cannot be null");
            this.Fineness = fineness;
            this.ReferenceLength = referenceLength;
            this.PrimaryTopology = primaryTopology;
            this.Refinements = refinements;
        }
        
        /// <summary>
        /// Schema name: PacefishMeshV38
        /// </summary>
        /// <value>Schema name: PacefishMeshV38</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceLength
        /// </summary>
        [DataMember(Name="referenceLength", EmitDefaultValue=false)]
        public DimensionalLength ReferenceLength { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryTopology
        /// </summary>
        [DataMember(Name="primaryTopology", EmitDefaultValue=false)]
        public OneOfPacefishMeshV38PrimaryTopology PrimaryTopology { get; set; }

        /// <summary>
        /// Gets or Sets Refinements
        /// </summary>
        [DataMember(Name="refinements", EmitDefaultValue=false)]
        public List<OneOfPacefishMeshV38Refinements> Refinements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PacefishMeshV38 {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Fineness: ").Append(Fineness).Append("\n");
            sb.Append("  ReferenceLength: ").Append(ReferenceLength).Append("\n");
            sb.Append("  PrimaryTopology: ").Append(PrimaryTopology).Append("\n");
            sb.Append("  Refinements: ").Append(Refinements).Append("\n");
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
            return this.Equals(input as PacefishMeshV38);
        }

        /// <summary>
        /// Returns true if PacefishMeshV38 instances are equal
        /// </summary>
        /// <param name="input">Instance of PacefishMeshV38 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PacefishMeshV38 input)
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
                    this.Fineness == input.Fineness ||
                    this.Fineness.Equals(input.Fineness)
                ) && 
                (
                    this.ReferenceLength == input.ReferenceLength ||
                    (this.ReferenceLength != null &&
                    this.ReferenceLength.Equals(input.ReferenceLength))
                ) && 
                (
                    this.PrimaryTopology == input.PrimaryTopology ||
                    (this.PrimaryTopology != null &&
                    this.PrimaryTopology.Equals(input.PrimaryTopology))
                ) && 
                (
                    this.Refinements == input.Refinements ||
                    this.Refinements != null &&
                    input.Refinements != null &&
                    this.Refinements.SequenceEqual(input.Refinements)
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
                hashCode = hashCode * 59 + this.Fineness.GetHashCode();
                if (this.ReferenceLength != null)
                    hashCode = hashCode * 59 + this.ReferenceLength.GetHashCode();
                if (this.PrimaryTopology != null)
                    hashCode = hashCode * 59 + this.PrimaryTopology.GetHashCode();
                if (this.Refinements != null)
                    hashCode = hashCode * 59 + this.Refinements.GetHashCode();
                return hashCode;
            }
        }

    }

}
