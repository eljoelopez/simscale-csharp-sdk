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
    /// SimericsAnalysis
    /// </summary>
    [DataContract]
    public partial class SimericsAnalysis : Analysis, IEquatable<SimericsAnalysis>
    {
        /// <summary>
        /// Defines TurbulenceModel
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TurbulenceModelEnum
        {
            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 1,

            /// <summary>
            /// Enum KEPSILON for value: KEPSILON
            /// </summary>
            [EnumMember(Value = "KEPSILON")]
            KEPSILON = 2

        }

        /// <summary>
        /// Gets or Sets TurbulenceModel
        /// </summary>
        [DataMember(Name="turbulenceModel", EmitDefaultValue=false)]
        public TurbulenceModelEnum? TurbulenceModel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimericsAnalysis" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SimericsAnalysis() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimericsAnalysis" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;SIMERICS_ANALYSIS&quot;).</param>
        /// <param name="materials">materials.</param>
        /// <param name="isCompressible">isCompressible (default to false).</param>
        /// <param name="boundaryConditions">boundaryConditions.</param>
        /// <param name="simulationControl">simulationControl.</param>
        /// <param name="resultControl">resultControl.</param>
        /// <param name="turbulenceModel">turbulenceModel (default to TurbulenceModelEnum.NONE).</param>
        /// <param name="meshSettings">meshSettings.</param>
        public SimericsAnalysis(string type = "SIMERICS_ANALYSIS", SimericsFluidMaterials materials = default(SimericsFluidMaterials), bool? isCompressible = default(bool?), List<OneOfSimericsAnalysisBoundaryConditions> boundaryConditions = default(List<OneOfSimericsAnalysisBoundaryConditions>), FluidSimulationControl simulationControl = default(FluidSimulationControl), FluidResultControls resultControl = default(FluidResultControls), TurbulenceModelEnum? turbulenceModel = default(TurbulenceModelEnum?), ManualSimericsMeshSettings meshSettings = default(ManualSimericsMeshSettings))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for SimericsAnalysis and cannot be null");
            this.Materials = materials;
            this.IsCompressible = isCompressible;
            this.BoundaryConditions = boundaryConditions;
            this.SimulationControl = simulationControl;
            this.ResultControl = resultControl;
            this.TurbulenceModel = turbulenceModel;
            this.MeshSettings = meshSettings;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Materials
        /// </summary>
        [DataMember(Name="materials", EmitDefaultValue=false)]
        public SimericsFluidMaterials Materials { get; set; }

        /// <summary>
        /// Gets or Sets IsCompressible
        /// </summary>
        [DataMember(Name="isCompressible", EmitDefaultValue=false)]
        public bool? IsCompressible { get; set; }

        /// <summary>
        /// Gets or Sets BoundaryConditions
        /// </summary>
        [DataMember(Name="boundaryConditions", EmitDefaultValue=false)]
        public List<OneOfSimericsAnalysisBoundaryConditions> BoundaryConditions { get; set; }

        /// <summary>
        /// Gets or Sets SimulationControl
        /// </summary>
        [DataMember(Name="simulationControl", EmitDefaultValue=false)]
        public FluidSimulationControl SimulationControl { get; set; }

        /// <summary>
        /// Gets or Sets ResultControl
        /// </summary>
        [DataMember(Name="resultControl", EmitDefaultValue=false)]
        public FluidResultControls ResultControl { get; set; }

        /// <summary>
        /// Gets or Sets MeshSettings
        /// </summary>
        [DataMember(Name="meshSettings", EmitDefaultValue=false)]
        public ManualSimericsMeshSettings MeshSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimericsAnalysis {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Materials: ").Append(Materials).Append("\n");
            sb.Append("  IsCompressible: ").Append(IsCompressible).Append("\n");
            sb.Append("  BoundaryConditions: ").Append(BoundaryConditions).Append("\n");
            sb.Append("  SimulationControl: ").Append(SimulationControl).Append("\n");
            sb.Append("  ResultControl: ").Append(ResultControl).Append("\n");
            sb.Append("  TurbulenceModel: ").Append(TurbulenceModel).Append("\n");
            sb.Append("  MeshSettings: ").Append(MeshSettings).Append("\n");
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
            return this.Equals(input as SimericsAnalysis);
        }

        /// <summary>
        /// Returns true if SimericsAnalysis instances are equal
        /// </summary>
        /// <param name="input">Instance of SimericsAnalysis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimericsAnalysis input)
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
                    this.Materials == input.Materials ||
                    (this.Materials != null &&
                    this.Materials.Equals(input.Materials))
                ) && 
                (
                    this.IsCompressible == input.IsCompressible ||
                    (this.IsCompressible != null &&
                    this.IsCompressible.Equals(input.IsCompressible))
                ) && 
                (
                    this.BoundaryConditions == input.BoundaryConditions ||
                    this.BoundaryConditions != null &&
                    input.BoundaryConditions != null &&
                    this.BoundaryConditions.SequenceEqual(input.BoundaryConditions)
                ) && 
                (
                    this.SimulationControl == input.SimulationControl ||
                    (this.SimulationControl != null &&
                    this.SimulationControl.Equals(input.SimulationControl))
                ) && 
                (
                    this.ResultControl == input.ResultControl ||
                    (this.ResultControl != null &&
                    this.ResultControl.Equals(input.ResultControl))
                ) && 
                (
                    this.TurbulenceModel == input.TurbulenceModel ||
                    this.TurbulenceModel.Equals(input.TurbulenceModel)
                ) && 
                (
                    this.MeshSettings == input.MeshSettings ||
                    (this.MeshSettings != null &&
                    this.MeshSettings.Equals(input.MeshSettings))
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
                if (this.Materials != null)
                    hashCode = hashCode * 59 + this.Materials.GetHashCode();
                if (this.IsCompressible != null)
                    hashCode = hashCode * 59 + this.IsCompressible.GetHashCode();
                if (this.BoundaryConditions != null)
                    hashCode = hashCode * 59 + this.BoundaryConditions.GetHashCode();
                if (this.SimulationControl != null)
                    hashCode = hashCode * 59 + this.SimulationControl.GetHashCode();
                if (this.ResultControl != null)
                    hashCode = hashCode * 59 + this.ResultControl.GetHashCode();
                hashCode = hashCode * 59 + this.TurbulenceModel.GetHashCode();
                if (this.MeshSettings != null)
                    hashCode = hashCode * 59 + this.MeshSettings.GetHashCode();
                return hashCode;
            }
        }

    }

}
