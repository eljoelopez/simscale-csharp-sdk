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
    /// IncompressiblePacefish
    /// </summary>
    [DataContract]
    public partial class IncompressiblePacefish : Analysis, IEquatable<IncompressiblePacefish>
    {
        /// <summary>
        /// Choose between RANS, LES, or DES turbulence models. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/incompressible-lbm-lattice-boltzmann-advanced/#turbulence-models-in-incompressible-lbm&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.
        /// </summary>
        /// <value>Choose between RANS, LES, or DES turbulence models. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/incompressible-lbm-lattice-boltzmann-advanced/#turbulence-models-in-incompressible-lbm&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TurbulenceModelEnum
        {
            /// <summary>
            /// Enum SMAGORINSKY for value: SMAGORINSKY
            /// </summary>
            [EnumMember(Value = "SMAGORINSKY")]
            SMAGORINSKY = 1,

            /// <summary>
            /// Enum SMAGORINSKYDIRECT for value: SMAGORINSKY_DIRECT
            /// </summary>
            [EnumMember(Value = "SMAGORINSKY_DIRECT")]
            SMAGORINSKYDIRECT = 2,

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 3,

            /// <summary>
            /// Enum KOMEGASST for value: KOMEGASST
            /// </summary>
            [EnumMember(Value = "KOMEGASST")]
            KOMEGASST = 4,

            /// <summary>
            /// Enum KOMEGASSTDDES for value: KOMEGASST_DDES
            /// </summary>
            [EnumMember(Value = "KOMEGASST_DDES")]
            KOMEGASSTDDES = 5,

            /// <summary>
            /// Enum KOMEGASSTIDDES for value: KOMEGASST_IDDES
            /// </summary>
            [EnumMember(Value = "KOMEGASST_IDDES")]
            KOMEGASSTIDDES = 6

        }

        /// <summary>
        /// Choose between RANS, LES, or DES turbulence models. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/incompressible-lbm-lattice-boltzmann-advanced/#turbulence-models-in-incompressible-lbm&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.
        /// </summary>
        /// <value>Choose between RANS, LES, or DES turbulence models. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/incompressible-lbm-lattice-boltzmann-advanced/#turbulence-models-in-incompressible-lbm&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.</value>
        [DataMember(Name="turbulenceModel", EmitDefaultValue=false)]
        public TurbulenceModelEnum? TurbulenceModel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IncompressiblePacefish" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IncompressiblePacefish() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IncompressiblePacefish" /> class.
        /// </summary>
        /// <param name="type">Schema name: IncompressiblePacefish (required) (default to &quot;INCOMPRESSIBLE_PACEFISH&quot;).</param>
        /// <param name="boundingBoxUuid">boundingBoxUuid.</param>
        /// <param name="turbulenceModel">Choose between RANS, LES, or DES turbulence models. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/incompressible-lbm-lattice-boltzmann-advanced/#turbulence-models-in-incompressible-lbm&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;. (default to TurbulenceModelEnum.KOMEGASSTDDES).</param>
        /// <param name="material">material.</param>
        /// <param name="flowDomainBoundaries">flowDomainBoundaries.</param>
        /// <param name="simulationControl">simulationControl.</param>
        /// <param name="advancedModelling">advancedModelling.</param>
        /// <param name="resultControl">resultControl.</param>
        /// <param name="meshSettingsNew">meshSettingsNew.</param>
        public IncompressiblePacefish(string type = "INCOMPRESSIBLE_PACEFISH", Guid? boundingBoxUuid = default(Guid?), TurbulenceModelEnum? turbulenceModel = default(TurbulenceModelEnum?), IncompressibleMaterial material = default(IncompressibleMaterial), FlowDomainBoundaries flowDomainBoundaries = default(FlowDomainBoundaries), FluidSimulationControl simulationControl = default(FluidSimulationControl), AdvancedModelling advancedModelling = default(AdvancedModelling), FluidResultControls resultControl = default(FluidResultControls), OneOfIncompressiblePacefishMeshSettingsNew meshSettingsNew = default(OneOfIncompressiblePacefishMeshSettingsNew))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for IncompressiblePacefish and cannot be null");
            this.BoundingBoxUuid = boundingBoxUuid;
            this.TurbulenceModel = turbulenceModel;
            this.Material = material;
            this.FlowDomainBoundaries = flowDomainBoundaries;
            this.SimulationControl = simulationControl;
            this.AdvancedModelling = advancedModelling;
            this.ResultControl = resultControl;
            this.MeshSettingsNew = meshSettingsNew;
        }
        
        /// <summary>
        /// Schema name: IncompressiblePacefish
        /// </summary>
        /// <value>Schema name: IncompressiblePacefish</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets BoundingBoxUuid
        /// </summary>
        [DataMember(Name="boundingBoxUuid", EmitDefaultValue=false)]
        public Guid? BoundingBoxUuid { get; set; }

        /// <summary>
        /// Gets or Sets Material
        /// </summary>
        [DataMember(Name="material", EmitDefaultValue=false)]
        public IncompressibleMaterial Material { get; set; }

        /// <summary>
        /// Gets or Sets FlowDomainBoundaries
        /// </summary>
        [DataMember(Name="flowDomainBoundaries", EmitDefaultValue=false)]
        public FlowDomainBoundaries FlowDomainBoundaries { get; set; }

        /// <summary>
        /// Gets or Sets SimulationControl
        /// </summary>
        [DataMember(Name="simulationControl", EmitDefaultValue=false)]
        public FluidSimulationControl SimulationControl { get; set; }

        /// <summary>
        /// Gets or Sets AdvancedModelling
        /// </summary>
        [DataMember(Name="advancedModelling", EmitDefaultValue=false)]
        public AdvancedModelling AdvancedModelling { get; set; }

        /// <summary>
        /// Gets or Sets ResultControl
        /// </summary>
        [DataMember(Name="resultControl", EmitDefaultValue=false)]
        public FluidResultControls ResultControl { get; set; }

        /// <summary>
        /// Gets or Sets MeshSettingsNew
        /// </summary>
        [DataMember(Name="meshSettingsNew", EmitDefaultValue=false)]
        public OneOfIncompressiblePacefishMeshSettingsNew MeshSettingsNew { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IncompressiblePacefish {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  BoundingBoxUuid: ").Append(BoundingBoxUuid).Append("\n");
            sb.Append("  TurbulenceModel: ").Append(TurbulenceModel).Append("\n");
            sb.Append("  Material: ").Append(Material).Append("\n");
            sb.Append("  FlowDomainBoundaries: ").Append(FlowDomainBoundaries).Append("\n");
            sb.Append("  SimulationControl: ").Append(SimulationControl).Append("\n");
            sb.Append("  AdvancedModelling: ").Append(AdvancedModelling).Append("\n");
            sb.Append("  ResultControl: ").Append(ResultControl).Append("\n");
            sb.Append("  MeshSettingsNew: ").Append(MeshSettingsNew).Append("\n");
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
            return this.Equals(input as IncompressiblePacefish);
        }

        /// <summary>
        /// Returns true if IncompressiblePacefish instances are equal
        /// </summary>
        /// <param name="input">Instance of IncompressiblePacefish to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IncompressiblePacefish input)
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
                    this.BoundingBoxUuid == input.BoundingBoxUuid ||
                    (this.BoundingBoxUuid != null &&
                    this.BoundingBoxUuid.Equals(input.BoundingBoxUuid))
                ) && 
                (
                    this.TurbulenceModel == input.TurbulenceModel ||
                    this.TurbulenceModel.Equals(input.TurbulenceModel)
                ) && 
                (
                    this.Material == input.Material ||
                    (this.Material != null &&
                    this.Material.Equals(input.Material))
                ) && 
                (
                    this.FlowDomainBoundaries == input.FlowDomainBoundaries ||
                    (this.FlowDomainBoundaries != null &&
                    this.FlowDomainBoundaries.Equals(input.FlowDomainBoundaries))
                ) && 
                (
                    this.SimulationControl == input.SimulationControl ||
                    (this.SimulationControl != null &&
                    this.SimulationControl.Equals(input.SimulationControl))
                ) && 
                (
                    this.AdvancedModelling == input.AdvancedModelling ||
                    (this.AdvancedModelling != null &&
                    this.AdvancedModelling.Equals(input.AdvancedModelling))
                ) && 
                (
                    this.ResultControl == input.ResultControl ||
                    (this.ResultControl != null &&
                    this.ResultControl.Equals(input.ResultControl))
                ) && 
                (
                    this.MeshSettingsNew == input.MeshSettingsNew ||
                    (this.MeshSettingsNew != null &&
                    this.MeshSettingsNew.Equals(input.MeshSettingsNew))
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
                if (this.BoundingBoxUuid != null)
                    hashCode = hashCode * 59 + this.BoundingBoxUuid.GetHashCode();
                hashCode = hashCode * 59 + this.TurbulenceModel.GetHashCode();
                if (this.Material != null)
                    hashCode = hashCode * 59 + this.Material.GetHashCode();
                if (this.FlowDomainBoundaries != null)
                    hashCode = hashCode * 59 + this.FlowDomainBoundaries.GetHashCode();
                if (this.SimulationControl != null)
                    hashCode = hashCode * 59 + this.SimulationControl.GetHashCode();
                if (this.AdvancedModelling != null)
                    hashCode = hashCode * 59 + this.AdvancedModelling.GetHashCode();
                if (this.ResultControl != null)
                    hashCode = hashCode * 59 + this.ResultControl.GetHashCode();
                if (this.MeshSettingsNew != null)
                    hashCode = hashCode * 59 + this.MeshSettingsNew.GetHashCode();
                return hashCode;
            }
        }

    }

}
