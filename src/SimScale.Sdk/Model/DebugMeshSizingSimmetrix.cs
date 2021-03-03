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
    /// DebugMeshSizingSimmetrix
    /// </summary>
    [DataContract]
    public partial class DebugMeshSizingSimmetrix : OneOfSimmetrixMeshingFluidSizing, OneOfSimmetrixMeshingSolidSizing, IEquatable<DebugMeshSizingSimmetrix>
    {
        /// <summary>
        /// Defines LayerAdjustmentBehaviour
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LayerAdjustmentBehaviourEnum
        {
            /// <summary>
            /// Enum SHRINKING for value: SHRINKING
            /// </summary>
            [EnumMember(Value = "SHRINKING")]
            SHRINKING = 1,

            /// <summary>
            /// Enum TRIMMING for value: TRIMMING
            /// </summary>
            [EnumMember(Value = "TRIMMING")]
            TRIMMING = 2

        }

        /// <summary>
        /// Gets or Sets LayerAdjustmentBehaviour
        /// </summary>
        [DataMember(Name="layerAdjustmentBehaviour", EmitDefaultValue=false)]
        public LayerAdjustmentBehaviourEnum? LayerAdjustmentBehaviour { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DebugMeshSizingSimmetrix" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DebugMeshSizingSimmetrix() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DebugMeshSizingSimmetrix" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;DEBUG&quot;).</param>
        /// <param name="maximumEdgeLength">maximumEdgeLength.</param>
        /// <param name="minimumEdgeLength">minimumEdgeLength.</param>
        /// <param name="chordalError">chordalError (default to 0.4M).</param>
        /// <param name="minCurvRef">minCurvRef (default to 0M).</param>
        /// <param name="gradationRate">gradationRate (default to 0.66M).</param>
        /// <param name="proxRefFactor">proxRefFactor (default to 0M).</param>
        /// <param name="minProxSize">minProxSize.</param>
        /// <param name="smallFeatureTol">smallFeatureTol (default to 0M).</param>
        /// <param name="layerAdjustmentBehaviour">layerAdjustmentBehaviour (default to LayerAdjustmentBehaviourEnum.SHRINKING).</param>
        /// <param name="layerHeightGradationRate">layerHeightGradationRate (default to 0.66M).</param>
        /// <param name="surfSkewness">surfSkewness (default to 0.7M).</param>
        /// <param name="volLenRatio">volLenRatio (default to 0.15M).</param>
        public DebugMeshSizingSimmetrix(string type = "DEBUG", DimensionalLength maximumEdgeLength = default(DimensionalLength), DimensionalLength minimumEdgeLength = default(DimensionalLength), decimal? chordalError = default(decimal?), decimal? minCurvRef = default(decimal?), decimal? gradationRate = default(decimal?), decimal? proxRefFactor = default(decimal?), DimensionalLength minProxSize = default(DimensionalLength), decimal? smallFeatureTol = default(decimal?), LayerAdjustmentBehaviourEnum? layerAdjustmentBehaviour = default(LayerAdjustmentBehaviourEnum?), decimal? layerHeightGradationRate = default(decimal?), decimal? surfSkewness = default(decimal?), decimal? volLenRatio = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for DebugMeshSizingSimmetrix and cannot be null");
            this.MaximumEdgeLength = maximumEdgeLength;
            this.MinimumEdgeLength = minimumEdgeLength;
            this.ChordalError = chordalError;
            this.MinCurvRef = minCurvRef;
            this.GradationRate = gradationRate;
            this.ProxRefFactor = proxRefFactor;
            this.MinProxSize = minProxSize;
            this.SmallFeatureTol = smallFeatureTol;
            this.LayerAdjustmentBehaviour = layerAdjustmentBehaviour;
            this.LayerHeightGradationRate = layerHeightGradationRate;
            this.SurfSkewness = surfSkewness;
            this.VolLenRatio = volLenRatio;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets MaximumEdgeLength
        /// </summary>
        [DataMember(Name="maximumEdgeLength", EmitDefaultValue=false)]
        public DimensionalLength MaximumEdgeLength { get; set; }

        /// <summary>
        /// Gets or Sets MinimumEdgeLength
        /// </summary>
        [DataMember(Name="minimumEdgeLength", EmitDefaultValue=false)]
        public DimensionalLength MinimumEdgeLength { get; set; }

        /// <summary>
        /// Gets or Sets ChordalError
        /// </summary>
        [DataMember(Name="chordalError", EmitDefaultValue=false)]
        public decimal? ChordalError { get; set; }

        /// <summary>
        /// Gets or Sets MinCurvRef
        /// </summary>
        [DataMember(Name="minCurvRef", EmitDefaultValue=false)]
        public decimal? MinCurvRef { get; set; }

        /// <summary>
        /// Gets or Sets GradationRate
        /// </summary>
        [DataMember(Name="gradationRate", EmitDefaultValue=false)]
        public decimal? GradationRate { get; set; }

        /// <summary>
        /// Gets or Sets ProxRefFactor
        /// </summary>
        [DataMember(Name="proxRefFactor", EmitDefaultValue=false)]
        public decimal? ProxRefFactor { get; set; }

        /// <summary>
        /// Gets or Sets MinProxSize
        /// </summary>
        [DataMember(Name="minProxSize", EmitDefaultValue=false)]
        public DimensionalLength MinProxSize { get; set; }

        /// <summary>
        /// Gets or Sets SmallFeatureTol
        /// </summary>
        [DataMember(Name="smallFeatureTol", EmitDefaultValue=false)]
        public decimal? SmallFeatureTol { get; set; }

        /// <summary>
        /// Gets or Sets LayerHeightGradationRate
        /// </summary>
        [DataMember(Name="layerHeightGradationRate", EmitDefaultValue=false)]
        public decimal? LayerHeightGradationRate { get; set; }

        /// <summary>
        /// Gets or Sets SurfSkewness
        /// </summary>
        [DataMember(Name="surfSkewness", EmitDefaultValue=false)]
        public decimal? SurfSkewness { get; set; }

        /// <summary>
        /// Gets or Sets VolLenRatio
        /// </summary>
        [DataMember(Name="volLenRatio", EmitDefaultValue=false)]
        public decimal? VolLenRatio { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DebugMeshSizingSimmetrix {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MaximumEdgeLength: ").Append(MaximumEdgeLength).Append("\n");
            sb.Append("  MinimumEdgeLength: ").Append(MinimumEdgeLength).Append("\n");
            sb.Append("  ChordalError: ").Append(ChordalError).Append("\n");
            sb.Append("  MinCurvRef: ").Append(MinCurvRef).Append("\n");
            sb.Append("  GradationRate: ").Append(GradationRate).Append("\n");
            sb.Append("  ProxRefFactor: ").Append(ProxRefFactor).Append("\n");
            sb.Append("  MinProxSize: ").Append(MinProxSize).Append("\n");
            sb.Append("  SmallFeatureTol: ").Append(SmallFeatureTol).Append("\n");
            sb.Append("  LayerAdjustmentBehaviour: ").Append(LayerAdjustmentBehaviour).Append("\n");
            sb.Append("  LayerHeightGradationRate: ").Append(LayerHeightGradationRate).Append("\n");
            sb.Append("  SurfSkewness: ").Append(SurfSkewness).Append("\n");
            sb.Append("  VolLenRatio: ").Append(VolLenRatio).Append("\n");
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
            return this.Equals(input as DebugMeshSizingSimmetrix);
        }

        /// <summary>
        /// Returns true if DebugMeshSizingSimmetrix instances are equal
        /// </summary>
        /// <param name="input">Instance of DebugMeshSizingSimmetrix to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DebugMeshSizingSimmetrix input)
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
                    this.MaximumEdgeLength == input.MaximumEdgeLength ||
                    (this.MaximumEdgeLength != null &&
                    this.MaximumEdgeLength.Equals(input.MaximumEdgeLength))
                ) && 
                (
                    this.MinimumEdgeLength == input.MinimumEdgeLength ||
                    (this.MinimumEdgeLength != null &&
                    this.MinimumEdgeLength.Equals(input.MinimumEdgeLength))
                ) && 
                (
                    this.ChordalError == input.ChordalError ||
                    (this.ChordalError != null &&
                    this.ChordalError.Equals(input.ChordalError))
                ) && 
                (
                    this.MinCurvRef == input.MinCurvRef ||
                    (this.MinCurvRef != null &&
                    this.MinCurvRef.Equals(input.MinCurvRef))
                ) && 
                (
                    this.GradationRate == input.GradationRate ||
                    (this.GradationRate != null &&
                    this.GradationRate.Equals(input.GradationRate))
                ) && 
                (
                    this.ProxRefFactor == input.ProxRefFactor ||
                    (this.ProxRefFactor != null &&
                    this.ProxRefFactor.Equals(input.ProxRefFactor))
                ) && 
                (
                    this.MinProxSize == input.MinProxSize ||
                    (this.MinProxSize != null &&
                    this.MinProxSize.Equals(input.MinProxSize))
                ) && 
                (
                    this.SmallFeatureTol == input.SmallFeatureTol ||
                    (this.SmallFeatureTol != null &&
                    this.SmallFeatureTol.Equals(input.SmallFeatureTol))
                ) && 
                (
                    this.LayerAdjustmentBehaviour == input.LayerAdjustmentBehaviour ||
                    this.LayerAdjustmentBehaviour.Equals(input.LayerAdjustmentBehaviour)
                ) && 
                (
                    this.LayerHeightGradationRate == input.LayerHeightGradationRate ||
                    (this.LayerHeightGradationRate != null &&
                    this.LayerHeightGradationRate.Equals(input.LayerHeightGradationRate))
                ) && 
                (
                    this.SurfSkewness == input.SurfSkewness ||
                    (this.SurfSkewness != null &&
                    this.SurfSkewness.Equals(input.SurfSkewness))
                ) && 
                (
                    this.VolLenRatio == input.VolLenRatio ||
                    (this.VolLenRatio != null &&
                    this.VolLenRatio.Equals(input.VolLenRatio))
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
                if (this.MaximumEdgeLength != null)
                    hashCode = hashCode * 59 + this.MaximumEdgeLength.GetHashCode();
                if (this.MinimumEdgeLength != null)
                    hashCode = hashCode * 59 + this.MinimumEdgeLength.GetHashCode();
                if (this.ChordalError != null)
                    hashCode = hashCode * 59 + this.ChordalError.GetHashCode();
                if (this.MinCurvRef != null)
                    hashCode = hashCode * 59 + this.MinCurvRef.GetHashCode();
                if (this.GradationRate != null)
                    hashCode = hashCode * 59 + this.GradationRate.GetHashCode();
                if (this.ProxRefFactor != null)
                    hashCode = hashCode * 59 + this.ProxRefFactor.GetHashCode();
                if (this.MinProxSize != null)
                    hashCode = hashCode * 59 + this.MinProxSize.GetHashCode();
                if (this.SmallFeatureTol != null)
                    hashCode = hashCode * 59 + this.SmallFeatureTol.GetHashCode();
                hashCode = hashCode * 59 + this.LayerAdjustmentBehaviour.GetHashCode();
                if (this.LayerHeightGradationRate != null)
                    hashCode = hashCode * 59 + this.LayerHeightGradationRate.GetHashCode();
                if (this.SurfSkewness != null)
                    hashCode = hashCode * 59 + this.SurfSkewness.GetHashCode();
                if (this.VolLenRatio != null)
                    hashCode = hashCode * 59 + this.VolLenRatio.GetHashCode();
                return hashCode;
            }
        }

    }

}
